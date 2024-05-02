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
    public partial class Frm_SuaSanPham : Form
    {
        private IMongoCollection<BsonDocument> sanPhamCollection;
        public Frm_SuaSanPham(string maSanPham)
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "SanPham"; // Thay collectionName bằng tên của collection SanPham trong CSDL

            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionName);
            LoadDataForEdit(maSanPham);
        }
        private void LoadDataForEdit(string maSanPham)
        {
            // Sử dụng mã sản phẩm để tải dữ liệu sản phẩm từ CSDL
            var filter = Builders<BsonDocument>.Filter.Eq("MASP", maSanPham);
            var result = sanPhamCollection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                // Gán dữ liệu sản phẩm vào các thành phần giao diện của Frm_SuaSanPham
                txt_MaSP.Text = result["MASP"].AsString;
                txt_TenSP.Text = result["TENSP"].AsString;
                txt_SoLuong.Text = result["SOLUONGTON"].AsInt32.ToString();
                txt_linksanh.Text = result["ANH"].AsString;

                // Lấy tên danh mục
                string tenDanhMuc = result["DanhMuc"]["TENDM"].AsString;
                // Gán tên danh mục vào một TextBox hoặc nơi bạn muốn hiển thị
                txt_TenDanhMuc.Text = tenDanhMuc;

                // Lấy tên nhà cung cấp
                string tenNhaCungCap = result["NhaCungCap"]["TENNCC"].AsString;
                // Gán tên nhà cung cấp vào một TextBox hoặc nơi bạn muốn hiển thị
                txt_NhaCungCap.Text = tenNhaCungCap;

                txt_ThuongHieu.Text = result["THUONGHIEU"].AsString;
                txt_Gia.Text = result["GIA"].AsInt32.ToString();

                // Tải đường dẫn ảnh từ MongoDB
                string imageUrl = result["ANH"].AsString;

                // Hiển thị ảnh từ đường dẫn web lên PictureBox
                pictureBox1.Load(imageUrl);
            }
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp hình ảnh|*.jpg;*.png;*.jpeg;*.gif|Tất cả tệp|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trên PictureBox
                pictureBox1.ImageLocation = selectedImagePath;

                // Lưu đường dẫn hình ảnh vào biến hoặc TextBox tùy bạn
               txt_linksanh.Text = selectedImagePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox và PictureBox
            string maSanPham = txt_MaSP.Text;
            string tenSanPham = txt_TenSP.Text;
            int soLuongTon = int.Parse(txt_SoLuong.Text);
            string imagePath = txt_linksanh.Text;

            // Cập nhật thông tin sản phẩm vào collection "SanPham"
            var filter = Builders<BsonDocument>.Filter.Eq("MASP", maSanPham);
            var update = Builders<BsonDocument>.Update
                .Set("TENSP", tenSanPham)
                .Set("SOLUONGTON", soLuongTon)
                .Set("ANH", imagePath); // Cập nhật đường dẫn hình ảnh
            var updateResult = sanPhamCollection.UpdateOne(filter, update);

            if (updateResult.ModifiedCount > 0)
            {
                MessageBox.Show("Sản phẩm đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm có mã " + maSanPham, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
