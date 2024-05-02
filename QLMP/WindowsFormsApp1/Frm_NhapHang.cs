using DTO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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
    public partial class Frm_NhapHang : Form
    {
        private IMongoCollection<BsonDocument> phieuNhapCollection;
        private IMongoCollection<BsonDocument> sanPhamCollection;
        public Frm_NhapHang()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay thế bằng tên CSDL của bạn
            string collectionName = "PhieuNhap";
            string collectionNameSP = "SanPham";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            phieuNhapCollection = database.GetCollection<BsonDocument>(collectionName);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionNameSP);

            // Gọi hàm để load dữ liệu vào DataGridView
            LoadPhieuNhapData();
        }

        private void LoadPhieuNhapData()
        {
            dataGridView1.Rows.Clear();
            var phieuNhapList = phieuNhapCollection.Find(new BsonDocument()).ToList();

            foreach (var phieuNhap in phieuNhapList)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["MAPN_COL"].Value = phieuNhap["MAPN"].AsString;  
                dataGridView1.Rows[rowIndex].Cells["NGUOINHAP_COL"].Value = phieuNhap["NGUOINHAP"].AsString;
                dataGridView1.Rows[rowIndex].Cells["NGAYLAP_COL"].Value = phieuNhap["NGAYLAP"].AsDateTime;
                dataGridView1.Rows[rowIndex].Cells["MASP_COL"].Value = phieuNhap["MASP"].AsString;
                dataGridView1.Rows[rowIndex].Cells["SOLUONGNHAP_COL"].Value = phieuNhap["SoLuongNhap"].AsInt32;
                dataGridView1.Rows[rowIndex].Cells["GIANHAP_COL"].Value = phieuNhap["DonGiaNhap"].AsDecimal;
                
            }
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            Frm_PhieuNhap frm_PhieuNhap = new Frm_PhieuNhap();
            frm_PhieuNhap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPhieuNhapData();
        }
    }
}
