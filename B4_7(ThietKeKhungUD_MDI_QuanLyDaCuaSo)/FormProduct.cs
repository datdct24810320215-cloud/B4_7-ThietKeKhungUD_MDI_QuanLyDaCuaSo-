#nullable disable
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace B4_7_MDI_QuanLyDaCuaSo
{
    public partial class FormProduct : Form, IStatusReporter
    {
        public event EventHandler<string> StatusChanged;

        private BindingList<Product> _products = new BindingList<Product>();

        public FormProduct()
        {
            InitializeComponent();

            this.Load += FormProduct_Load;
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            cmsDelete.Click += (s, e) => BtnDelete_Click(s, e);
            cmsRefresh.Click += (s, e) =>
            {
                LoadData();
                NotifyParent("Đã làm mới dữ liệu sản phẩm");
            };
            cmsDetail.Click += CmsDetail_Click;
        }

        private void NotifyParent(string message)
        {
            StatusChanged?.Invoke(this, message);
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            NotifyParent("Form Sản phẩm đã sẵn sàng");
        }

        private void LoadData()
        {
            _products.Clear();
            _products.Add(new Product { ProductId = "SP001", 
                ProductName = "Laptop Dell", UnitPrice = 15000000m, Quantity = 5 });
            _products.Add(new Product { ProductId = "SP002", 
                ProductName = "Nồi cơm điện", UnitPrice = 850000m, Quantity = 12 });
            _products.Add(new Product { ProductId = "SP003", 
                ProductName = "Sữa Vinamilk", UnitPrice = 25000m, Quantity = 100 });

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _products;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Nhập tên sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newId = "SP" + (_products.Count + 1).ToString("D3");
            Product p = new Product
            {
                ProductId = newId,
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = 100000m,
                Quantity = 1
            };
            _products.Add(p);
            txtProductName.Clear();
            NotifyParent($"Đã thêm sản phẩm: {p.ProductName}");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Chọn 1 dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Product p = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (p == null) return;

            if (MessageBox.Show($"Xóa sản phẩm \"{p.ProductName}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _products.Remove(p);
                NotifyParent($"Đã xóa sản phẩm: {p.ProductName}");
            }
        }

        private void CmsDetail_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            Product p = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (p == null) return;
            MessageBox.Show(
                $"Mã SP: {p.ProductId}\n" +
                $"Tên SP: {p.ProductName}\n" +
                $"Đơn giá: {p.UnitPrice:N0} VNĐ\n" +
                $"Số lượng: {p.Quantity}",
                "Chi tiết sản phẩm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            NotifyParent($"Đã xem chi tiết: {p.ProductName}");
        }
    }
}
