namespace C5_01_connection
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
            dtgvChuDe = new DataGridView();
            MaChuDe = new DataGridViewTextBoxColumn();
            TenChuDe = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgvChuDe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvChuDe
            // 
            dtgvChuDe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvChuDe.Columns.AddRange(new DataGridViewColumn[] { MaChuDe, TenChuDe });
            dtgvChuDe.Location = new Point(16, 249);
            dtgvChuDe.Margin = new Padding(4);
            dtgvChuDe.Name = "dtgvChuDe";
            dtgvChuDe.RowHeadersWidth = 62;
            dtgvChuDe.RowTemplate.Height = 33;
            dtgvChuDe.Size = new Size(1011, 323);
            dtgvChuDe.TabIndex = 0;
            dtgvChuDe.CellClick += dtgvChuDe_CellContentClick;
            // 
            // MaChuDe
            // 
            MaChuDe.DataPropertyName = "MaChuDe";
            MaChuDe.HeaderText = "Mã Chủ Đề";
            MaChuDe.MinimumWidth = 8;
            MaChuDe.Name = "MaChuDe";
            MaChuDe.Width = 150;
            // 
            // TenChuDe
            // 
            TenChuDe.DataPropertyName = "TenChuDe";
            TenChuDe.HeaderText = "Tên Chủ Đề";
            TenChuDe.MinimumWidth = 8;
            TenChuDe.Name = "TenChuDe";
            TenChuDe.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "Mã chủ đề:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(181, 60);
            txtMa.Margin = new Padding(4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(373, 29);
            txtMa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên chủ đề:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(181, 151);
            txtTen.Margin = new Padding(4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(373, 29);
            txtTen.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(673, 29);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(308, 50);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(673, 106);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(308, 50);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(673, 180);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(308, 50);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 219);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(groupBox1);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(dtgvChuDe);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvChuDe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvChuDe;
        private DataGridViewTextBoxColumn MaChuDe;
        private DataGridViewTextBoxColumn TenChuDe;
        private Label label1;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtTen;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private GroupBox groupBox1;
    }
}