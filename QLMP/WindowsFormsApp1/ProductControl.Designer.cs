namespace WindowsFormsApp1
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_Hinh = new System.Windows.Forms.PictureBox();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_masp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Hinh
            // 
            this.ptb_Hinh.Location = new System.Drawing.Point(27, 24);
            this.ptb_Hinh.Name = "ptb_Hinh";
            this.ptb_Hinh.Size = new System.Drawing.Size(200, 204);
            this.ptb_Hinh.TabIndex = 0;
            this.ptb_Hinh.TabStop = false;
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSP.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_TenSP.Location = new System.Drawing.Point(24, 242);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(50, 16);
            this.lbl_TenSP.TabIndex = 1;
            this.lbl_TenSP.Text = "label1";
            this.lbl_TenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.ForeColor = System.Drawing.Color.Pink;
            this.lbl_GiaTien.Location = new System.Drawing.Point(24, 293);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(50, 16);
            this.lbl_GiaTien.TabIndex = 2;
            this.lbl_GiaTien.Text = "label1";
            this.lbl_GiaTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_masp
            // 
            this.lbl_masp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_masp.AutoSize = true;
            this.lbl_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masp.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbl_masp.Location = new System.Drawing.Point(201, 297);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(41, 13);
            this.lbl_masp.TabIndex = 3;
            this.lbl_masp.Text = "label1";
            this.lbl_masp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lbl_masp);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.lbl_TenSP);
            this.Controls.Add(this.ptb_Hinh);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(256, 328);
            this.Click += new System.EventHandler(this.ProductControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Hinh;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label lbl_masp;
    }
}
