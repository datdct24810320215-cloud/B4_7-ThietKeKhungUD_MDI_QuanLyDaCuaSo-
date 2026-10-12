#nullable disable
using System;
using System.Linq;
using System.Windows.Forms;

namespace B4_7_MDI_QuanLyDaCuaSo
{
    public partial class FormMain : Form
    {
        private string _currentUser = "admin";

        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
            this.FormClosing += FormMain_FormClosing;

            // Menu events
            mnuLogout.Click   += MnuLogout_Click;
            mnuExit.Click     += MnuExit_Click;
            mnuStudent.Click  += (s, e) => OpenChildForm(typeof(FormStudent));
            mnuProduct.Click  += (s, e) => OpenChildForm(typeof(FormProduct));
            mnuCascade.Click  += (s, e) => LayoutMdi(MdiLayout.Cascade);
            mnuTileH.Click    += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            mnuTileV.Click    += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            mnuCloseAll.Click += MnuCloseAll_Click;
            mnuAbout.Click    += MnuAbout_Click;

            // ToolStrip events
            tsbStudent.Click += (s, e) => OpenChildForm(typeof(FormStudent));
            tsbProduct.Click += (s, e) => OpenChildForm(typeof(FormProduct));
            tsbCascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            tsbTileH.Click   += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            tsbTileV.Click   += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            tsbExit.Click    += MnuExit_Click;

            // ContextMenu events
            cmsCascade.Click  += (s, e) => LayoutMdi(MdiLayout.Cascade);
            cmsTileH.Click    += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            cmsTileV.Click    += (s, e) => LayoutMdi(MdiLayout.TileVertical);
            cmsCloseAll.Click += MnuCloseAll_Click;

            // Timer
            timer1.Tick += Timer1_Tick;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUser.Text = $"👤 Người dùng: {_currentUser}";
            lblMessage.Text = "Chào mừng đến với hệ thống!";
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
        }

        // ★ KEY REQUIREMENT: DO NOT open duplicate child forms
        private void OpenChildForm(Type formType)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == formType)
                {
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;
                    child.Activate();
                    child.BringToFront();
                    lblMessage.Text = $"Đã kích hoạt: {child.Text}";
                    return;
                }
            }

            Form newForm = (Form)Activator.CreateInstance(formType);
            newForm.MdiParent = this;
            newForm.WindowState = FormWindowState.Normal;

            if (newForm is IStatusReporter reporter)
                reporter.StatusChanged += ChildForm_StatusChanged;

            newForm.FormClosed += (s, e) =>
            {
                if (newForm is IStatusReporter r2)
                    r2.StatusChanged -= ChildForm_StatusChanged;
                lblMessage.Text = $"Đã đóng: {newForm.Text}";
            };

            newForm.Show();
            lblMessage.Text = $"Đã mở: {newForm.Text}";
        }

        // ★ Parent-child communication: child sends message here
        private void ChildForm_StatusChanged(object sender, string message)
        {
            lblMessage.Text = $"[{DateTime.Now:HH:mm:ss}] {message}";
        }

        private void MnuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (Form child in this.MdiChildren.ToArray())
                child.Close();

            _currentUser = "";
            lblUser.Text = "👤 Người dùng: (chưa đăng nhập)";
            lblMessage.Text = "Đã đăng xuất. Vui lòng đăng nhập lại.";
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void MnuCloseAll_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show("Không có cửa sổ nào đang mở!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Đóng tất cả {this.MdiChildren.Length} cửa sổ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form child in this.MdiChildren.ToArray())
                    child.Close();
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ứng dụng MDI - Bài 4.7\n" +
                "Quản lý đa cửa sổ\n\n" +
                "Sinh viên thực hiện: [Tên của bạn]\n" +
                "MSSV: [MSSV của bạn]",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1 != null) timer1.Stop();
        }
    }
}
