namespace DVKhamBenh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtQueQuan = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            txtDienThoai = new TextBox();
            txtHoTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lbChonDichVu = new ListBox();
            groupBox3 = new GroupBox();
            lbDichVuDaChon = new ListBox();
            btnSelect = new Button();
            btnSelectAll = new Button();
            btnDeselect = new Button();
            btnDeselectAll = new Button();
            groupBox4 = new GroupBox();
            rtxtKetQua = new RichTextBox();
            btnXacNhan = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 45);
            label1.TabIndex = 0;
            label1.Text = "DỊCH VỤ KHÁM BỆNH";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQueQuan);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 155);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(90, 114);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(521, 29);
            txtQueQuan.TabIndex = 4;
            txtQueQuan.TextChanged += txtHoTen_TextChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(93, 75);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 29);
            dtpNgaySinh.TabIndex = 3;
            dtpNgaySinh.ValueChanged += txtHoTen_TextChanged;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(411, 37);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(200, 29);
            cboGioiTinh.TabIndex = 2;
            cboGioiTinh.SelectedIndexChanged += txtHoTen_TextChanged;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(411, 75);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(200, 29);
            txtDienThoai.TabIndex = 1;
            txtDienThoai.TextChanged += txtHoTen_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(93, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 29);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 40);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 0;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 81);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 0;
            label3.Text = "Điện thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 117);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 0;
            label6.Text = "Quê quán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbChonDichVu);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 183);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mời chọn dịch vụ";
            // 
            // lbChonDichVu
            // 
            lbChonDichVu.Dock = DockStyle.Fill;
            lbChonDichVu.FormattingEnabled = true;
            lbChonDichVu.ItemHeight = 21;
            lbChonDichVu.Items.AddRange(new object[] { "Siêu âm", "Thử máu", "Nội soi", "X-Quang", "Khám ấy" });
            lbChonDichVu.Location = new Point(3, 25);
            lbChonDichVu.Name = "lbChonDichVu";
            lbChonDichVu.Size = new Size(250, 155);
            lbChonDichVu.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbDichVuDaChon);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(377, 218);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(256, 183);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dịch vụ đã chọn";
            // 
            // lbDichVuDaChon
            // 
            lbDichVuDaChon.Dock = DockStyle.Fill;
            lbDichVuDaChon.FormattingEnabled = true;
            lbDichVuDaChon.ItemHeight = 21;
            lbDichVuDaChon.Location = new Point(3, 25);
            lbDichVuDaChon.Name = "lbDichVuDaChon";
            lbDichVuDaChon.Size = new Size(250, 155);
            lbDichVuDaChon.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelect.Location = new Point(274, 243);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(97, 35);
            btnSelect.TabIndex = 4;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectAll.Location = new Point(274, 283);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(97, 35);
            btnSelectAll.TabIndex = 4;
            btnSelectAll.Text = ">>";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // btnDeselect
            // 
            btnDeselect.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeselect.Location = new Point(274, 324);
            btnDeselect.Name = "btnDeselect";
            btnDeselect.Size = new Size(97, 35);
            btnDeselect.TabIndex = 4;
            btnDeselect.Text = "<";
            btnDeselect.UseVisualStyleBackColor = true;
            btnDeselect.Click += btnDeselect_Click;
            // 
            // btnDeselectAll
            // 
            btnDeselectAll.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeselectAll.Location = new Point(274, 363);
            btnDeselectAll.Name = "btnDeselectAll";
            btnDeselectAll.Size = new Size(97, 35);
            btnDeselectAll.TabIndex = 4;
            btnDeselectAll.Text = "<<";
            btnDeselectAll.UseVisualStyleBackColor = true;
            btnDeselectAll.Click += btnDeselectAll_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rtxtKetQua);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(16, 407);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(499, 152);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kết quả";
            // 
            // rtxtKetQua
            // 
            rtxtKetQua.Dock = DockStyle.Fill;
            rtxtKetQua.Location = new Point(3, 23);
            rtxtKetQua.Name = "rtxtKetQua";
            rtxtKetQua.ReadOnly = true;
            rtxtKetQua.Size = new Size(493, 126);
            rtxtKetQua.TabIndex = 0;
            rtxtKetQua.Text = "Họ và tên bệnh nhân:\nGiới tính:\nNgày sinh:\nQuê quán:\nĐiện thoại:\nDịch vụ đã chọn:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXacNhan.Location = new Point(521, 415);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(110, 43);
            btnXacNhan.TabIndex = 6;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(521, 464);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 43);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(521, 513);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 43);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 568);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnXacNhan);
            Controls.Add(groupBox4);
            Controls.Add(btnDeselectAll);
            Controls.Add(btnDeselect);
            Controls.Add(btnSelectAll);
            Controls.Add(btnSelect);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtQueQuan;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private TextBox txtDienThoai;
        private TextBox txtHoTen;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private GroupBox groupBox2;
        private ListBox lbChonDichVu;
        private GroupBox groupBox3;
        private ListBox lbDichVuDaChon;
        private Button btnSelect;
        private Button btnSelectAll;
        private Button btnDeselect;
        private Button btnDeselectAll;
        private GroupBox groupBox4;
        private Button btnXacNhan;
        private Button btnXoa;
        private Button btnThoat;
        private RichTextBox rtxtKetQua;
    }
}