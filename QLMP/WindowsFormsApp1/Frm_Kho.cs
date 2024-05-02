using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Kho : Form
    {
        private IMongoCollection<BsonDocument> sanPhamCollection;
        public Frm_Kho()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "SanPham"; // Thay collectionName bằng tên của collection SanPham trong CSDL

            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionName);
            LoadSanPhamData();
        }
        private void LoadSanPhamData()
        {
            dataGridView1.Rows.Clear();
            var sanPhamList = sanPhamCollection.Find(new BsonDocument()).ToList();

            foreach (var sanPham in sanPhamList)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["MASP_COL"].Value = sanPham["MASP"].AsString;
                dataGridView1.Rows[rowIndex].Cells["TENSP_COL"].Value = sanPham["TENSP"].AsString;
                dataGridView1.Rows[rowIndex].Cells["SOLUONGTON_COL"].Value = sanPham["SOLUONGTON"].AsInt32;
                dataGridView1.Rows[rowIndex].Cells["GIA_COL"].Value = sanPham["GIA"].AsInt32;        
            dataGridView1.Rows[rowIndex].Cells["THUONG_COL"].Value = sanPham["THUONGHIEU"].AsString;
                
            }

        }


        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            Frm_NhapHang frm_NhapHang = new Frm_NhapHang();
            frm_NhapHang.Show();
        }

            private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SOLUONGTON_COL"].Index)
            {
                // Kiểm tra nếu giá trị ô hiện tại không là null và không rỗng
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    int soLuongTon;
                    if (int.TryParse(e.Value.ToString(), out soLuongTon))
                    {
                        // Kiểm tra nếu số lượng ít hơn 5, đổi màu nền ô thành màu đỏ
                        if (soLuongTon < 5)
                        {
                            e.CellStyle.ForeColor = Color.White;
                            dataGridView1.Rows[e.RowIndex].Cells["SOLUONGTON_COL"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridView1.Rows[e.RowIndex].Cells["SOLUONGTON_COL"].Style.BackColor = Color.White; // Đặt lại màu nền về mặc định
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSanPhamData();
        }
    }
}
