using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPT
{
    public partial class frmGiaiPT : Form
    {
        public frmGiaiPT()
        {
            InitializeComponent();
            rbBac1.Checked = true;
        }

        private void rbBac1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBac1.Checked)
            {
                txtC.ReadOnly = true;
            }
        }

        private void rbBac2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBac2.Checked)
            {
                txtC.ReadOnly = false;
            }
        }

        public string GiaiPTBac1()
        {
            if (txtA.Text == string.Empty || txtB.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return "";
            }
            try
            {
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                string result = "";

                if (a == 0 && b == 0)
                {
                    result = "PT có vô số nghiệm";
                }
                else if (a == 0 && b != 0)
                {
                    result = "PT vô nghiệm";
                }
                else if (a != 0)
                {
                    double rs = -b / a;
                    result = "PT có nghiệm duy nhất: x = " + rs;
                }

                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return "";
            }
        }
        public string GiaiPTBac2()
        {
            if
            (
            txtA.Text == string.Empty ||
            txtB.Text == string.Empty ||
            txtC.Text == string.Empty
            )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return "";
            }
            try
            {
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                double c = Double.Parse(txtC.Text);
                string result = "";
                double delta = b * b - 4 * a * c;
                if (a == 0)
                {
                    result = GiaiPTBac1();
                }
                if (a != 0)
                {
                    if (delta < 0)
                    {
                        result = "PT vô nghiệm";
                    }
                    else if (delta == 0)
                    {
                        double rs = -b / (2 * a);
                        result = "Phương trình có nghiệm kép x1 = x2 = " + rs;
                    }
                    else if (delta > 0)
                    {
                        double rs1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        double rs2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        result = String.Format("x1 = {0}, \n x2 = {1}", rs1, rs2);
                    }
                }

                return result.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return "";
            }


        }

        private void btnGiai_Click(object sender, EventArgs e)
        {

            if (rbBac1.Checked)
            {
                txtKQ.Text = GiaiPTBac1();
            }
            if (rbBac2.Checked)
            {
                txtKQ.Text = GiaiPTBac2();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show
                (
                "Bạn có chắc muốn thoát?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
