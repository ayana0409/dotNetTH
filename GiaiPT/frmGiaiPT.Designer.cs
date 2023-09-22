namespace GiaiPT
{
    partial class frmGiaiPT
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbBac2 = new RadioButton();
            rbBac1 = new RadioButton();
            label2 = new Label();
            btnGiai = new Button();
            label3 = new Label();
            btnXoa = new Button();
            label4 = new Label();
            btnThoat = new Button();
            label5 = new Label();
            txtKQ = new TextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 41);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 1, 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBac2);
            groupBox1.Controls.Add(rbBac1);
            groupBox1.Location = new Point(8, 63);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(402, 103);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn bậc phương trình";
            // 
            // rbBac2
            // 
            rbBac2.AutoSize = true;
            rbBac2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbBac2.Location = new Point(13, 62);
            rbBac2.Margin = new Padding(2);
            rbBac2.Name = "rbBac2";
            rbBac2.Size = new Size(300, 25);
            rbBac2.TabIndex = 0;
            rbBac2.TabStop = true;
            rbBac2.Text = "Phương trình bậc 2 (ax^2 + by + c = 0)";
            rbBac2.UseVisualStyleBackColor = true;
            rbBac2.CheckedChanged += rbBac2_CheckedChanged;
            // 
            // rbBac1
            // 
            rbBac1.AutoSize = true;
            rbBac1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbBac1.Location = new Point(13, 25);
            rbBac1.Margin = new Padding(2);
            rbBac1.Name = "rbBac1";
            rbBac1.Size = new Size(246, 25);
            rbBac1.TabIndex = 0;
            rbBac1.TabStop = true;
            rbBac1.Text = "Phương trình bậc 1 (ax + b = 0)";
            rbBac1.UseVisualStyleBackColor = true;
            rbBac1.CheckedChanged += rbBac1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 188);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Nhập a:";
            // 
            // btnGiai
            // 
            btnGiai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiai.Location = new Point(327, 184);
            btnGiai.Margin = new Padding(2);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(78, 32);
            btnGiai.TabIndex = 4;
            btnGiai.Text = "Giải PT";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 230);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 2;
            label3.Text = "Nhập b:";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(327, 225);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(78, 32);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 271);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 2;
            label4.Text = "Nhập c:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(327, 266);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(78, 32);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 312);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 2;
            label5.Text = "Kết quả:";
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKQ.Location = new Point(81, 310);
            txtKQ.Margin = new Padding(2);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(324, 78);
            txtKQ.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(81, 187);
            txtA.Margin = new Padding(2);
            txtA.Name = "txtA";
            txtA.Size = new Size(229, 29);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(81, 228);
            txtB.Margin = new Padding(2);
            txtB.Name = "txtB";
            txtB.Size = new Size(229, 29);
            txtB.TabIndex = 5;
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(81, 269);
            txtC.Margin = new Padding(2);
            txtC.Name = "txtC";
            txtC.Size = new Size(229, 29);
            txtC.TabIndex = 5;
            // 
            // frmGiaiPT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 407);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnGiai);
            Controls.Add(txtKQ);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmGiaiPT";
            Text = "frmGiaiPT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbBac2;
        private RadioButton rbBac1;
        private Label label2;
        private Button btnGiai;
        private Label label3;
        private Button btnXoa;
        private Label label4;
        private Button btnThoat;
        private Label label5;
        private TextBox txtKQ;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
    }
}