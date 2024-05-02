namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.dangky = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dangnhap = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("iCiel Pony", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(202, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // dangky
            // 
            this.dangky.AutoSize = true;
            this.dangky.ForeColor = System.Drawing.Color.LightPink;
            this.dangky.Location = new System.Drawing.Point(294, 287);
            this.dangky.Name = "dangky";
            this.dangky.Size = new System.Drawing.Size(55, 13);
            this.dangky.TabIndex = 26;
            this.dangky.Text = "Register ?";
            this.dangky.Click += new System.EventHandler(this.dangky_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Thoat.FlatAppearance.BorderSize = 2;
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Thoat.Location = new System.Drawing.Point(332, 236);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 36);
            this.btn_Thoat.TabIndex = 25;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhap.FlatAppearance.BorderSize = 2;
            this.dangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhap.Location = new System.Drawing.Point(207, 236);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(106, 36);
            this.dangnhap.TabIndex = 24;
            this.dangnhap.Text = "Login";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.taikhoan);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 41);
            this.panel5.TabIndex = 2;
            // 
            // taikhoan
            // 
            this.taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.ForeColor = System.Drawing.Color.Cyan;
            this.taikhoan.Location = new System.Drawing.Point(7, 8);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(224, 22);
            this.taikhoan.TabIndex = 4;
            this.taikhoan.Text = "Tài Khoản";
            this.taikhoan.Click += new System.EventHandler(this.taikhoan_Click);
            this.taikhoan.TextChanged += new System.EventHandler(this.taikhoan_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(7, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 1);
            this.panel6.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tài Khoản không hợp lệ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(201, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 76);
            this.panel3.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.matkhau);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(0, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(242, 41);
            this.panel9.TabIndex = 2;
            // 
            // matkhau
            // 
            this.matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.Cyan;
            this.matkhau.Location = new System.Drawing.Point(7, 8);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(224, 22);
            this.matkhau.TabIndex = 4;
            this.matkhau.Text = "Mật Khẩu";
            this.matkhau.UseSystemPasswordChar = true;
            this.matkhau.TextChanged += new System.EventHandler(this.matkhau_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(7, 32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(224, 1);
            this.panel10.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(0, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 22);
            this.panel8.TabIndex = 7;
            this.panel8.Visible = false;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(200, 145);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(249, 72);
            this.panel7.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(513, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dangky);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dangky;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox taikhoan;
        public System.Windows.Forms.TextBox matkhau;
    }
}

