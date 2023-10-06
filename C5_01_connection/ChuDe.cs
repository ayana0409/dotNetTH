using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5_01_connection
{
    public partial class ChuDe : Form
    {
        public ChuDe()
        {
            InitializeComponent();
        }
        readonly string connStr = "Data Source=THUANDUONG\\THUANDATA;Initial Catalog=Sach;Integrated Security=True; TrustServerCertificate = True";
        SqlConnection? conn = null;
        DataTable dataTB = new();
        private void ChuDe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM ChuDe";

            conn = new SqlConnection(connStr);

            SqlDataAdapter data = new(query, conn);

            data.Fill(dataTB);

            dtgvChuDe.DataSource = dataTB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;

            conn = new SqlConnection(connStr);

            string query = "INSERT INTO ChuDe (MaChuDe, TenChuDe) VALUES (@ma, @ten)";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlParameter pr1 = new("@ma", SqlDbType.Char);
            pr1.Value = ma;
            SqlParameter pr2 = new("@ten", SqlDbType.NVarChar);
            pr2.Value = ten;

            sqlCommand.Parameters.Add(pr1);
            sqlCommand.Parameters.Add(pr2);

            conn.Open();
            int result = sqlCommand.ExecuteNonQuery();
            conn.Close();

            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;

            conn = new SqlConnection(connStr);
            string query = "update ChuDe SET TenChuDe = @ten where MaChuDe = @ma";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlParameter pr1 = new("@ma", SqlDbType.Char);
            pr1.Value = ma;
            SqlParameter pr2 = new("@ten", SqlDbType.NVarChar);
            pr2.Value = ten;

            sqlCommand.Parameters.Add(pr1);
            sqlCommand.Parameters.Add(pr2);

            conn.Open();
            int result = sqlCommand.ExecuteNonQuery();
            conn.Close();

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string query = "delete from ChuDe where MaChuDe = @ma";
            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter pr1 = new("@ma", SqlDbType.Char, 4, "MaChuDe");
            pr1.Value = ma;

            cmd.Parameters.Add(pr1);

            if (MessageBox.Show("Bạn có muốn xóa [" + ma + "]",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes
                )
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadData();
        }

        private void dtgvChuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtgvChuDe.CurrentCell.RowIndex;
            DataRow row = dataTB.Rows[rowIndex];
            txtMa.Text = row["MaChuDe"].ToString();
            txtTen.Text = row["TenChuDe"].ToString();
            /*
            txtMa.Text = dtgvChuDe.Rows[rowIndex].Cells[0].Value.ToString();
            txtTen.Text = dtgvChuDe.Rows[rowIndex].Cells[1].Value.ToString();
            */
        }
    }
}
