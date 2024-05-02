namespace WindowsFormsApp1
{
    partial class Frm_Kho
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_nhaphang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MASP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTON_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THUONG_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP_COL,
            this.TENSP_COL,
            this.SOLUONGTON_COL,
            this.GIA_COL,
            this.THUONG_COL});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_nhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaphang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_nhaphang.Location = new System.Drawing.Point(416, 21);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Size = new System.Drawing.Size(138, 37);
            this.btn_nhaphang.TabIndex = 7;
            this.btn_nhaphang.Text = "Nhập Hàng";
            this.btn_nhaphang.UseVisualStyleBackColor = false;
            this.btn_nhaphang.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(272, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MASP_COL
            // 
            this.MASP_COL.HeaderText = "Mã Sản Phẩm";
            this.MASP_COL.Name = "MASP_COL";
            // 
            // TENSP_COL
            // 
            this.TENSP_COL.HeaderText = "Tên Sản Phẩm ";
            this.TENSP_COL.Name = "TENSP_COL";
            // 
            // SOLUONGTON_COL
            // 
            this.SOLUONGTON_COL.HeaderText = "Số Lượng Tồn";
            this.SOLUONGTON_COL.Name = "SOLUONGTON_COL";
            // 
            // GIA_COL
            // 
            this.GIA_COL.HeaderText = "Gía";
            this.GIA_COL.Name = "GIA_COL";
            // 
            // THUONG_COL
            // 
            this.THUONG_COL.HeaderText = "Thương Hiệu";
            this.THUONG_COL.Name = "THUONG_COL";
            // 
            // Frm_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nhaphang);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frm_Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frn_Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nhaphang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTON_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn THUONG_COL;
    }
}