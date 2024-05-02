namespace WindowsFormsApp1
{
    partial class GioHang
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
            this.TENKH_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH_COL = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENKH_COL,
            this.TENSP_COL,
            this.GIA_COL,
            this.SOLUONG_COL,
            this.ANH_COL});
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 200;
            this.dataGridView1.Size = new System.Drawing.Size(936, 506);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TENKH_COL
            // 
            this.TENKH_COL.HeaderText = "Tên Khách Hàng";
            this.TENKH_COL.Name = "TENKH_COL";
            this.TENKH_COL.Width = 200;
            // 
            // TENSP_COL
            // 
            this.TENSP_COL.HeaderText = "Tên Sản Phẩm";
            this.TENSP_COL.Name = "TENSP_COL";
            this.TENSP_COL.Width = 200;
            // 
            // GIA_COL
            // 
            this.GIA_COL.HeaderText = "Giá";
            this.GIA_COL.Name = "GIA_COL";
            this.GIA_COL.Width = 200;
            // 
            // SOLUONG_COL
            // 
            this.SOLUONG_COL.HeaderText = "Số Lượng";
            this.SOLUONG_COL.Name = "SOLUONG_COL";
            // 
            // ANH_COL
            // 
            this.ANH_COL.FillWeight = 200F;
            this.ANH_COL.HeaderText = "ẢNH";
            this.ANH_COL.Name = "ANH_COL";
            this.ANH_COL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ANH_COL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ANH_COL.Width = 200;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.labelTotalCost.Location = new System.Drawing.Point(942, 363);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(83, 20);
            this.labelTotalCost.TabIndex = 22;
            this.labelTotalCost.Text = "Tổng Tiền:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(952, 501);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 33);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xoá Sản Phẩm";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(1062, 501);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(108, 33);
            this.btn_ThanhToan.TabIndex = 24;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GioHang";
            this.Size = new System.Drawing.Size(1173, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG_COL;
        private System.Windows.Forms.DataGridViewImageColumn ANH_COL;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_ThanhToan;
    }
}
