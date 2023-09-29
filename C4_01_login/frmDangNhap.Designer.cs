namespace _01_login
{
    partial class frmDangNhap
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
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            label2 = new Label();
            txtTenNguoiDung = new TextBox();
            label1 = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenNguoiDung);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(252, 118);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(397, 29);
            txtMatKhau.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 121);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txtTenNguoiDung
            // 
            txtTenNguoiDung.Location = new Point(252, 63);
            txtTenNguoiDung.Name = "txtTenNguoiDung";
            txtTenNguoiDung.Size = new Size(397, 29);
            txtTenNguoiDung.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 66);
            label1.Name = "label1";
            label1.Size = new Size(143, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên người dùng:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(52, 289);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(164, 71);
            btnDangNhap.TabIndex = 1;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += button1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(547, 289);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(164, 71);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(800, 396);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmDangNhap";
            Text = "Đăng nhập hệ thống";
            FormClosing += frmDangNhap_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtTenNguoiDung;
        private Label label1;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}