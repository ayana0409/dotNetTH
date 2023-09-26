namespace _02_calculator
{
    public partial class frmMayTinhDonGian : Form
    {
        private bool kiemtra;
        private string pheptoan, value;
        public frmMayTinhDonGian()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (kiemtra)
                txtKetQua.Clear();
            Button btnNumber = sender as Button;
            txtKetQua.Text += btnNumber.Text;

            txtKetQua.Text = Convert.ToDouble(txtKetQua.Text).ToString();

            kiemtra = false;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            value = txtKetQua.Text;
            kiemtra = true;
            pheptoan = "+";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            value = txtKetQua.Text;
            kiemtra = true;
            pheptoan = "-";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            value = txtKetQua.Text;
            kiemtra = true;
            pheptoan = "*";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            value = txtKetQua.Text;
            kiemtra = true;
            pheptoan = "/";
        }
        private void btnBang_Click(object sendern, EventArgs e)
        {
            Double v1, v2;

            v1 = Convert.ToDouble(value);
            v2 = Convert.ToDouble(txtKetQua.Text);
            if (pheptoan == "+")
            {
                txtKetQua.Text = Convert.ToString(v1 + v2);

                pheptoan = "";
                kiemtra = true;

            }
            else if (pheptoan == "-")
            {
                txtKetQua.Text = Convert.ToString(v1 - v2);
                pheptoan = "";
                kiemtra = true;
            }
            else if (pheptoan == "*")

            {
                txtKetQua.Text = Convert.ToString(v1 * v2);
                pheptoan = "";
                kiemtra = true;

            }
            else if (pheptoan == "/")
            {

                if (v2 != 0)
                {

                    txtKetQua.Text = Convert.ToString(v1 / v2);

                    pheptoan = "";
                    kiemtra = true;
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
        }
    }
}