namespace C5_01_connection
{
    partial class ChuDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvChuDe = new DataGridView();
            label1 = new Label();
            txtMa = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvChuDe).BeginInit();
            SuspendLayout();
            // 
            // dtgvChuDe
            // 
            dtgvChuDe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvChuDe.Location = new Point(12, 159);
            dtgvChuDe.Name = "dtgvChuDe";
            dtgvChuDe.RowHeadersWidth = 62;
            dtgvChuDe.RowTemplate.Height = 33;
            dtgvChuDe.Size = new Size(830, 397);
            dtgvChuDe.TabIndex = 0;
            dtgvChuDe.CellContentClick += dtgvChuDe_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã chủ đề:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(181, 32);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(507, 31);
            txtMa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 93);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên chủ đề:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(181, 93);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(507, 31);
            txtTen.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 583);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(158, 69);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(181, 583);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(158, 69);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(345, 583);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(158, 69);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // ChuDe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 679);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(txtMa);
            Controls.Add(label1);
            Controls.Add(dtgvChuDe);
            Name = "ChuDe";
            Text = "ChuDe";
            Load += ChuDe_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvChuDe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvChuDe;
        private Label label1;
        private TextBox txtMa;
        private Label label2;
        private TextBox txtTen;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}