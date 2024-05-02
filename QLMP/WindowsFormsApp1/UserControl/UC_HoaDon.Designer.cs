namespace WindowsFormsApp1.GUI
{
    partial class UC_HoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_HD_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHANVIEN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_TON_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_timmahd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HD_COL,
            this.NGAYLAP_COL,
            this.TENNHANVIEN_COL,
            this.TEN_SP_COL,
            this.SL_TON_COL,
            this.GIA_COL,
            this.TONGTIEN_COL});
            this.dataGridView1.Location = new System.Drawing.Point(10, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1348, 431);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_HD_COL
            // 
            this.ID_HD_COL.HeaderText = "Mã Hoá Đơn";
            this.ID_HD_COL.Name = "ID_HD_COL";
            this.ID_HD_COL.Width = 140;
            // 
            // NGAYLAP_COL
            // 
            this.NGAYLAP_COL.HeaderText = "Ngày Lập";
            this.NGAYLAP_COL.Name = "NGAYLAP_COL";
            // 
            // TENNHANVIEN_COL
            // 
            this.TENNHANVIEN_COL.HeaderText = "Tên Nhân Viên";
            this.TENNHANVIEN_COL.Name = "TENNHANVIEN_COL";
            this.TENNHANVIEN_COL.Width = 250;
            // 
            // TEN_SP_COL
            // 
            this.TEN_SP_COL.HeaderText = "Tên Sản Phẩm";
            this.TEN_SP_COL.Name = "TEN_SP_COL";
            this.TEN_SP_COL.Width = 230;
            // 
            // SL_TON_COL
            // 
            this.SL_TON_COL.HeaderText = "Số Lượng";
            this.SL_TON_COL.Name = "SL_TON_COL";
            this.SL_TON_COL.Width = 130;
            // 
            // GIA_COL
            // 
            this.GIA_COL.HeaderText = "Giá";
            this.GIA_COL.Name = "GIA_COL";
            // 
            // TONGTIEN_COL
            // 
            this.TONGTIEN_COL.HeaderText = "Tổng Tiền";
            this.TONGTIEN_COL.Name = "TONGTIEN_COL";
            this.TONGTIEN_COL.Width = 180;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_HienThi.Location = new System.Drawing.Point(498, 29);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(113, 42);
            this.btn_HienThi.TabIndex = 16;
            this.btn_HienThi.Text = "RESET";
            this.btn_HienThi.UseVisualStyleBackColor = false;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(379, 30);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(113, 42);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa Hóa Đơn";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_timmahd
            // 
            this.txt_timmahd.Location = new System.Drawing.Point(20, 51);
            this.txt_timmahd.Name = "txt_timmahd";
            this.txt_timmahd.Size = new System.Drawing.Size(125, 20);
            this.txt_timmahd.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nhập mã hóa đơn:";
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.Pink;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(162, 31);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(82, 41);
            this.btn_tim.TabIndex = 26;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timmahd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.btn_xoa);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(1373, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HD_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHANVIEN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_TON_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN_COL;
        private System.Windows.Forms.TextBox txt_timmahd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tim;
    }
}
