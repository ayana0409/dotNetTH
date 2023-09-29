namespace _01_login
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text == "student")
            {
                if (txtMatKhau.Text == "123")
                    MessageBox.Show("Bạn đã đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn thoát!",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}