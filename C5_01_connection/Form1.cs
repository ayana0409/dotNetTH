using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Drawing.Text;

namespace C5_01_connection
{
    public partial class Form1 : Form
    {
        readonly string connStr = "Data Source=THUANDUONG\\THUANDATA;Initial Catalog=Sach;Integrated Security=True; TrustServerCertificate = True";
        SqlConnection? conn = null;
        public Form1()
        { 
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == String.Empty || txtTen.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            try
            {
                string ma = txtMa.Text;
                string ten = txtTen.Text;

                SqlConnection connection = new(connStr);
                string commandText = "INSERT INTO ChuDe (MaChuDe, TenChuDe) VALUES (@ma, @ten)";
                SqlCommand sqlCommand = new SqlCommand(commandText, connection);

                SqlParameter pr1 = new("@ma", SqlDbType.Char);
                pr1.Value = ma;
                SqlParameter pr2 = new("@ten", SqlDbType.NVarChar);
                pr2.Value = ten;

                sqlCommand.Parameters.Add(pr1);
                sqlCommand.Parameters.Add(pr2);

                connection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                connection.Close(); 



                /*
                string commandText = "Select * from ChuDe";
                SqlDataAdapter dataAdapter = new(commandText, connection);

                DataSet dataSet = new();
                dataAdapter.Fill(dataSet);

                // Thêm dòng cho dữ liệu nguồn
                DataTable dataTable = dataSet.Tables[0];
                DataRow newRow = dataTable.NewRow();
                newRow["MaChuDe"] = ma;
                newRow["TenChuDe"] = ten;
                dataTable.Rows.Add(newRow);

                // Chỉ định câu lệnh insert
                dataAdapter.InsertCommand = new SqlCommand(
                    @"INSERT INTO ChuDe (MaChuDe, TenChuDe) VALUES (@ma, @ten)",
                    connection);
                SqlParameter pr1 = new("@ma", SqlDbType.Char);
                pr1.Value = ma;
                SqlParameter pr2 = new("@ten", SqlDbType.NVarChar);
                pr2.Value = ten;
                dataAdapter.InsertCommand.Parameters.Add(pr1);
                dataAdapter.InsertCommand.Parameters.Add(pr2);
                // Cập nhật cho dữ liệu nguồn
                dataAdapter.Update(dataSet);
                */
                LoadData();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại thông tin");
            }
        }
        private void LoadData()
        {
            conn = new SqlConnection(connStr);

            string query = "select * from ChuDe";
            SqlDataAdapter data = new(query, conn);

            DataTable dataTB = new();
            data.Fill(dataTB);

            dtgvChuDe.DataSource = dataTB;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvChuDe.SelectedCells.Count > 0)
            {
                DataSet dataSet = GetChuDe();

                string commandText = "Select * from ChuDe";
                SqlConnection connection = new(connStr);
                SqlDataAdapter dataAdapter = new(commandText, connection);

                DataTable dataTable = dataSet.Tables[0];
                int rowIndex = dtgvChuDe.CurrentCell.RowIndex;
                string? delMa = dtgvChuDe.Rows[rowIndex].Cells[0].Value.ToString();

                DialogResult rs = MessageBox.Show(
                    "Bạn có muốn xóa chủ đề có mã [" + delMa + "]?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    dataAdapter.DeleteCommand = new SqlCommand(@"delete from ChuDe where MaChuDe = @ma", connection);
                    SqlParameter pr1 = new("@ma", SqlDbType.Char, 4, "MaChuDe");
                    pr1.Value = delMa;
                    dataAdapter.DeleteCommand.Parameters.Add(pr1);

                    dataTable.Rows[rowIndex].Delete();

                    dataAdapter.Update(dataSet);
                    LoadData();
                }
            }
        }
        private DataSet GetChuDe()
        {
            DataSet ds = new();
            string commandText = "Select * from ChuDe";
            SqlConnection connection = new(connStr);
            SqlDataAdapter dataAdapter = new(commandText, connection);
            dataAdapter.Fill(ds);

            return ds;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;

            DataSet dataSet = GetChuDe();

            string commandText = "Select * from ChuDe";
            SqlConnection connection = new(connStr);
            SqlDataAdapter dataAdapter = new(commandText, connection);

            int rowIndex = dtgvChuDe.CurrentCell.RowIndex;
            string? upMa = dtgvChuDe.Rows[rowIndex].Cells[0].Value.ToString();

            dataAdapter.UpdateCommand = new SqlCommand("update ChuDe SET TenChuDe = @ten where MaChuDe = @upma", connection);
            SqlParameter pr1 = new("@upma", SqlDbType.Char, 4);
            pr1.Value = upMa;
            SqlParameter pr2 = new("@ten", SqlDbType.NVarChar, 50);
            pr2.Value = ten;
            dataAdapter.UpdateCommand.Parameters.Add(pr1);
            dataAdapter.UpdateCommand.Parameters.Add(pr2);

            DataTable dataTable = dataSet.Tables[0];
            DataRow upRow = dataTable.Rows[rowIndex];
            upRow["TenChuDe"] = ten;
            dataAdapter.Update(dataSet);

            LoadData();
        }
        private void dtgvChuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtgvChuDe.CurrentCell.RowIndex;
            txtMa.Text = dtgvChuDe.Rows[rowIndex].Cells[0].Value.ToString();
            txtTen.Text = dtgvChuDe.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}