#nullable disable
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace B4_7_MDI_QuanLyDaCuaSo
{
    public partial class FormStudent : Form, IStatusReporter
    {
        public event EventHandler<string> StatusChanged;

        private BindingList<Student> _students = new BindingList<Student>();

        public FormStudent()
        {
            InitializeComponent();

            this.Load += FormStudent_Load;
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            cmsDelete.Click += (s, e) => BtnDelete_Click(s, e);
            cmsRefresh.Click += (s, e) =>
            {
                LoadData();
                NotifyParent("Đã làm mới dữ liệu sinh viên");
            };
            cmsDetail.Click += CmsDetail_Click;
        }

        private void NotifyParent(string message)
        {
            StatusChanged?.Invoke(this, message);
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            LoadData();
            NotifyParent("Form Sinh viên đã sẵn sàng");
        }

        private void LoadData()
        {
            _students.Clear();
            _students.Add(new Student { StudentId = "SV001", 
                FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" });
            _students.Add(new Student { StudentId = "SV002", 
                FullName = "Trần Thị Bình", Age = 21, Gender = "Nữ" });
            _students.Add(new Student { StudentId = "SV003", 
                FullName = "Lê Hoàng Cường", Age = 19, Gender = "Nam" });

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _students;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Nhập họ tên sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newId = "SV" + (_students.Count + 1).ToString("D3");
            Student s = new Student
            {
                StudentId = newId,
                FullName = txtFullName.Text.Trim(),
                Age = 18,
                Gender = "Nam"
            };
            _students.Add(s);
            txtFullName.Clear();

            NotifyParent($"Đã thêm sinh viên: {s.FullName}");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Chọn 1 dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student s = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (s == null) return;

            if (MessageBox.Show($"Xóa sinh viên \"{s.FullName}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _students.Remove(s);
                NotifyParent($"Đã xóa sinh viên: {s.FullName}");
            }
        }

        private void CmsDetail_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            Student s = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (s == null) return;

            MessageBox.Show(
                $"Mã SV: {s.StudentId}\n" +
                $"Họ tên: {s.FullName}\n" +
                $"Tuổi: {s.Age}\n" +
                $"Giới tính: {s.Gender}",
                "Chi tiết sinh viên",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            NotifyParent($"Đã xem chi tiết: {s.FullName}");
        }
    }
}
