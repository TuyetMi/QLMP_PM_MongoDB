namespace WindowsFormsApp1
{
    partial class Frm_NhapHang
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nhaphang = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAPN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOINHAP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGNHAP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(146, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_nhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaphang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_nhaphang.Location = new System.Drawing.Point(12, 17);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Size = new System.Drawing.Size(128, 59);
            this.btn_nhaphang.TabIndex = 10;
            this.btn_nhaphang.Text = "Tạo Phiếu Nhập Hàng";
            this.btn_nhaphang.UseVisualStyleBackColor = false;
            this.btn_nhaphang.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN_COL,
            this.NGUOINHAP_COL,
            this.NGAYLAP_COL,
            this.MASP_COL,
            this.SOLUONGNHAP_COL,
            this.GIANHAP_COL});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 352);
            this.dataGridView1.TabIndex = 9;
            // 
            // MAPN_COL
            // 
            this.MAPN_COL.HeaderText = "Mã Phiếu Nhập";
            this.MAPN_COL.Name = "MAPN_COL";
            // 
            // NGUOINHAP_COL
            // 
            this.NGUOINHAP_COL.HeaderText = "Tên Người Nhập";
            this.NGUOINHAP_COL.Name = "NGUOINHAP_COL";
            // 
            // NGAYLAP_COL
            // 
            this.NGAYLAP_COL.HeaderText = "Ngày Lập";
            this.NGAYLAP_COL.Name = "NGAYLAP_COL";
            // 
            // MASP_COL
            // 
            this.MASP_COL.HeaderText = "Mã SP";
            this.MASP_COL.Name = "MASP_COL";
            // 
            // SOLUONGNHAP_COL
            // 
            this.SOLUONGNHAP_COL.HeaderText = "Số Lượng Nhập";
            this.SOLUONGNHAP_COL.Name = "SOLUONGNHAP_COL";
            // 
            // GIANHAP_COL
            // 
            this.GIANHAP_COL.HeaderText = "Giá Nhập";
            this.GIANHAP_COL.Name = "GIANHAP_COL";
            // 
            // Frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nhaphang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_NhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nhaphang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOINHAP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGNHAP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP_COL;
    }
}