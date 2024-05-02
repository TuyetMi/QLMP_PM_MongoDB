using BUS;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Frm_ChiTietSanPham : Form
    {
        private IMongoCollection<BsonDocument> sanPhamCollection;
        private IMongoCollection<BsonDocument> gioHangCollection;
        private SanPhamBUS sanPhamBUS;
        private UC_SanPham uc_SanPham;

        UC_SanPham uc = new UC_SanPham();
        public Frm_ChiTietSanPham(string masp)
        {
            InitializeComponent();
            ShareData.masp = masp;
            lbl_ten.Text = masp;
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionSanPham = "SanPham"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            string collectionGioHang = "GioHang"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            sanPhamBUS = new SanPhamBUS(connectionString, databaseName, collectionSanPham);
            MongoClient client = new MongoClient(connectionString);
            ShareData.masp = masp;
            IMongoDatabase database = client.GetDatabase(databaseName);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionSanPham);
            gioHangCollection = database.GetCollection<BsonDocument>(collectionGioHang);
            kiemtra(ShareData.CV);
            loaddata();

        }
        
        public void kiemtra(string cv) 
        {

            if (cv == "Khách Hàng")
            {
                btn_xoasp.Visible = false;
                btn_suasp.Visible = false;
            }
            if (cv == "Quản Lí")
            {
                btn_them.Visible = false;
                
            }
        }
        string imageUrl;
        public void loaddata()
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("MASP", lbl_ten.Text);
                var result = sanPhamCollection.Find(filter).FirstOrDefault();
                // Kiểm tra xem danh sách có ít nhất một tài khoản không
                if (result != null)
                { 
                    lbl_ma.Text = result["MASP"].AsString;
                    lbl_ten.Text = result["TENSP"].AsString;
                    lbl_loaisp.Text = "Loại sản phẩm: " + result["DanhMuc"]["TENDM"].AsString;
                    lbl_Gia.Text = result["GIA"].AsInt32.ToString();

                    // Lấy đường dẫn ảnh từ MongoDB
                    imageUrl = result["ANH"].AsString;

                    // Hiển thị ảnh từ đường dẫn web lên PictureBox
                    pictureBox1.Load(imageUrl);
                    // Sau đó, hiển thị thông tin hoặc thực hiện các thao tác khác tùy ý
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm có mã: " + lbl_ten.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btn_them_Click(object sender, EventArgs e)
        {
            int soluong;

            // Kiểm tra nếu txt_soluong rỗng hoặc không thể chuyển đổi thành số, thì gán mặc định là 1.
            if (string.IsNullOrWhiteSpace(numericUpDown1.Text) || !int.TryParse(numericUpDown1.Text, out soluong))
            {
                soluong = 1;
            }
            int gia = Int32.Parse(lbl_Gia.Text);
            var chiTietGioHang = new BsonDocument
    {
        { "TENSP", lbl_ten.Text },
        { "SOLUONG", soluong },
        { "GIA",  gia},
        { "ANH", imageUrl }
    };

            var gioHang = new BsonDocument
    {
        { "TENKH", ShareData.HoTen },
        { "CTGH", new BsonArray { chiTietGioHang } }
    };

            gioHangCollection.InsertOne(gioHang);

            // Hiển thị thông báo thành công
            MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi thông báo thành công, đóng form hiện tại
            this.Close();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Lấy MASP của sản phẩm cần xóa
            string maSanPham = lbl_ma.Text; // Ở đây, chúng tôi sử dụng lbl_ten để lấy mã sản phẩm, bạn có thể sử dụng thuộc tính hoặc điều kiện phù hợp để lấy mã sản phẩm

            // Hiển thị hộp thoại xác nhận
            string message = "Bạn có chắc chắn muốn xóa sản phẩm \"" + maSanPham + "\" không?";
            DialogResult dialogResult = MessageBox.Show(message, "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Tìm sản phẩm cần xóa trong collection "SanPham"
                var filter = Builders<BsonDocument>.Filter.Eq("MASP", maSanPham);
                var result = sanPhamCollection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Sản phẩm có mã " + maSanPham + " đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Sau khi xóa sản phẩm, có thể thực hiện các thao tác cần thiết khác
                    // Ví dụ: load lại danh sách sản phẩm hoặc cập nhật giao diện người dùng

                    // Hoặc thực hiện bất kỳ hành động nào khác cần thiết
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm có mã " + maSanPham, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            else
            {
                // Hủy việc xóa sản phẩm
            }
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            string maSanPham = lbl_ma.Text; 

            // Tạo một phiên bản của Frm_SuaSanPham
            Frm_SuaSanPham frmSuaSanPham = new Frm_SuaSanPham(maSanPham);

            // Hiển thị Frm_SuaSanPham
            frmSuaSanPham.ShowDialog();
            this.Close();
        }
    }
}
