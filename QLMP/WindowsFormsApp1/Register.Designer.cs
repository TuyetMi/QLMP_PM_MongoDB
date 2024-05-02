namespace WindowsFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(353, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 318);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(265, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(36, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 76);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 22);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ Tên không hợp lệ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_hoten);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 41);
            this.panel5.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.ForeColor = System.Drawing.Color.Gray;
            this.txt_hoten.Location = new System.Drawing.Point(7, 8);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(224, 22);
            this.txt_hoten.TabIndex = 4;
            this.txt_hoten.Text = "Họ Tên";
            this.txt_hoten.Click += new System.EventHandler(this.taikhoan_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(7, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 1);
            this.panel6.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Location = new System.Drawing.Point(36, 230);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(249, 76);
            this.panel10.TabIndex = 22;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label4);
            this.panel11.Location = new System.Drawing.Point(0, 46);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(242, 22);
            this.panel11.TabIndex = 7;
            this.panel11.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật Khẩu không hợp lệ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txt_matkhau);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(0, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(242, 41);
            this.panel12.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.Gray;
            this.txt_matkhau.Location = new System.Drawing.Point(7, 8);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(224, 22);
            this.txt_matkhau.TabIndex = 4;
            this.txt_matkhau.Text = "Mật Khẩu";
            this.txt_matkhau.UseSystemPasswordChar = true;
            this.txt_matkhau.Click += new System.EventHandler(this.matkhau_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(7, 32);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(224, 1);
            this.panel13.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(36, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 76);
            this.panel2.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(0, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 22);
            this.panel7.TabIndex = 7;
            this.panel7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tài Khoản không hợp lệ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_taikhoan);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(0, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 41);
            this.panel8.TabIndex = 2;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.ForeColor = System.Drawing.Color.Gray;
            this.txt_taikhoan.Location = new System.Drawing.Point(7, 8);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(224, 22);
            this.txt_taikhoan.TabIndex = 4;
            this.txt_taikhoan.Text = "Tài Khoản";
            this.txt_taikhoan.Click += new System.EventHandler(this.gmail_Click);
            this.txt_taikhoan.TextChanged += new System.EventHandler(this.txt_taikhoan_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(7, 32);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(224, 1);
            this.panel9.TabIndex = 3;
            // 
            // btn_dangki
            // 
            this.btn_dangki.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangki.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangki.Location = new System.Drawing.Point(111, 395);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(88, 33);
            this.btn_dangki.TabIndex = 31;
            this.btn_dangki.Text = "Đăng ký";
            this.btn_dangki.UseVisualStyleBackColor = true;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giới Tính:";
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gioitinh.Location = new System.Drawing.Point(99, 334);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(174, 21);
            this.cbb_gioitinh.TabIndex = 32;
            // 
            // btn_huy
            // 
            this.btn_huy.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huy.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_huy.Location = new System.Drawing.Point(219, 395);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(88, 33);
            this.btn_huy.TabIndex = 33;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(706, 529);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.cbb_gioitinh);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.Button btn_huy;
    }
}