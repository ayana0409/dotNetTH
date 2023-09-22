namespace DVKhamBenh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtxtKetQua.Clear();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            /* Kiểm tra người dùng đã chọn gì chưa
             * Kiểm tra trong DV đã chọn có dịch vụ cần thêm hay chưa
             * Nếu chưa có trong DV đã chọn chưa có thì thêm vào
             * Nếu chưa có thì không làm gì cả 
             */
            if (lbChonDichVu.SelectedIndex != -1)
                if (!lbDichVuDaChon.Items.Contains(lbChonDichVu.SelectedItem))
                    lbDichVuDaChon.Items.Add(lbChonDichVu.SelectedItem);
            UpdateKetQua();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            lbDichVuDaChon.Items.Clear();
            foreach (string item in lbChonDichVu.Items)
            {
                lbDichVuDaChon.Items.Add(item);
                UpdateKetQua();
            }
        }
        private void btnDeselect_Click(object sender, EventArgs e)
        {
            if (lbDichVuDaChon.SelectedIndex != -1)
                lbDichVuDaChon.Items.RemoveAt(lbDichVuDaChon.SelectedIndex);
            UpdateKetQua();
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            lbDichVuDaChon.Items.Clear();
            UpdateKetQua();
        }

        public void UpdateKetQua()
        {
            rtxtKetQua.Clear();
            rtxtKetQua.AppendText("Họ và tên bệnh nhân: " + txtHoTen.Text);
            rtxtKetQua.AppendText(Environment.NewLine + "Giới tính: " + cboGioiTinh.Text);
            rtxtKetQua.AppendText(Environment.NewLine + "Ngày sinh: " + dtpNgaySinh.Value.ToShortDateString());
            rtxtKetQua.AppendText(Environment.NewLine + "Quê quán: " + txtQueQuan.Text);
            rtxtKetQua.AppendText(Environment.NewLine + "Điện thoại: " + txtDienThoai.Text);
            string dvChon = "";
            for (int i = 0; i < lbDichVuDaChon.Items.Count; i++)
            {
                if (i == lbDichVuDaChon.Items.Count - 1)
                {
                    dvChon += lbDichVuDaChon.Items[i] + ".";
                    break;
                }
                dvChon += lbDichVuDaChon.Items[i] + ", ";
            }
            rtxtKetQua.AppendText(Environment.NewLine + "Dịch vụ đã chọn: " + dvChon);
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            UpdateKetQua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rtxtKetQua.Clear();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show
                (
                "Bạn có muốn đóng chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mời đến phòng số ... để khám");
        }
    }
}