using BUS;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Frm_ThemSanPham : Form
    {
        private IMongoCollection<BsonDocument> sanPhamCollection;
        public Frm_ThemSanPham()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "SanPham"; // Thay collectionName bằng tên của collection SanPham trong CSDL

            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionName);
        }
        private string imageFilePath;
        private void btn_Brown_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp; *.gif)|*.jpg; *.png; *.bmp; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imageFilePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maSanPham = txt_MaSP.Text;
                string tenSanPham = txt_TenSP.Text;
                int soLuongTon = int.Parse(txt_SoLuong.Text);
                int gia = int.Parse(txt_Gia.Text);
                string thuongHieu = txt_ThuongHieu.Text;

                string tenDanhMuc = txt_TenDanhMuc.Text;
                string tenNhaCungCap = txt_NhaCungCap.Text;
                // Kiểm tra xem bạn đã chọn hình ảnh chưa
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh trước khi thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                var danhMuc = new BsonDocument
                {
                    { "TENDM", tenDanhMuc }
                };

                // Tạo đối tượng NhaCungCap
                var nhaCungCap = new BsonDocument
                {
                    { "TENNCC", tenNhaCungCap }
                };
                var productDoc = new BsonDocument
                {
                    { "MASP", maSanPham },
                    { "TENSP", tenSanPham },
                    { "SOLUONGTON", soLuongTon },
                    { "GIA", gia },
                    { "THUONGHIEU", thuongHieu },
                    { "ANH", imageFilePath }, // Đường dẫn đến hình ảnh
                    { "DanhMuc", danhMuc }, // Thêm đối tượng DanhMuc
                    { "NhaCungCap", nhaCungCap } // Thêm đối tượng NhaCungCap
                };

                // Thêm đối tượng BsonDocument vào cơ sở dữ liệu MongoDB
                sanPhamCollection.InsertOne(productDoc);

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
