using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using BUS;
using DTO;
using MetroFramework.Drawing.Html;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1.GUI
{
    public partial class UC_SanPham : UserControl
    {
        private IMongoCollection<BsonDocument> sanPhamCollection;
        private SanPhamBUS sanPhamBUS;
        
        public UC_SanPham()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "SanPham"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            sanPhamBUS = new SanPhamBUS(connectionString, databaseName, collectionName);
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionName);
            LoadSanPhamToFlowLayoutPanel();

            
            kiemtra(ShareData.CV);
        }

       public void kiemtra(string cv)
        {
            if(cv == "Khách Hàng")
            {
                btn_HienThi.Visible = false;
                btn_them.Visible = false;
            }    
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_ThemSanPham frm = new Frm_ThemSanPham();
            frm.Show();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LoadSanPhamToFlowLayoutPanel();


        }
        
        private void LoadSanPhamToFlowLayoutPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            var sanPhamList = sanPhamCollection.Find(new BsonDocument()).ToList();

            foreach (var sanPham in sanPhamList)
            {
                // Đọc thông tin sản phẩm từ BsonDocument
                string masp = sanPham["MASP"].AsString;
                string tenSP = sanPham["TENSP"].AsString;
                int soLuongTon = sanPham["SOLUONGTON"].AsInt32;
                int gia = sanPham["GIA"].AsInt32;
                string thuongHieu = sanPham["THUONGHIEU"].AsString;
                string anh = sanPham["ANH"].AsString; // Đường dẫn ảnh

                // Tạo một UserControl để hiển thị thông tin sản phẩm
                var productControl = new ProductControl(masp,tenSP, gia, anh);



                
                flowLayoutPanel1.Controls.Add(productControl);
            }
            
        }
       
        private void TimKiemSanPhamTheoTen(string keyword)
        {
            // Xóa tất cả các Control trước
            flowLayoutPanel1.Controls.Clear();
            var filter = Builders<BsonDocument>.Filter.Empty; // Đây là một bộ lọc trống, bạn có thể tùy chỉnh nếu cần thiết
            var sanPhamList = sanPhamCollection.Find(filter).ToList();
            // Lặp qua danh sách BsonDocument để tìm kiếm sản phẩm theo tên
            foreach (var sanPham in sanPhamList)
            {
                string tenSP = sanPham["TENSP"].AsString;

                // Kiểm tra nếu tên sản phẩm chứa từ khóa tìm kiếm
                if (tenSP.Contains(keyword))
                {
                    // Nếu tìm thấy sản phẩm, đọc thông tin khác
                    string masp = sanPham["MASP"].AsString;
                    int gia = sanPham["GIA"].AsInt32;
                    string anh = sanPham["ANH"].AsString;

                    // Tạo UserControl để hiển thị sản phẩm
                    var productControl = new ProductControl(masp, tenSP, gia, anh);

                    // Thêm UserControl vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(productControl);
                }
            }
        }
        private void TimKiemSanPhamTheoDanhMuc(string danhMuc)
        {
            // Xóa tất cả các Control trước
            flowLayoutPanel1.Controls.Clear();

            var filter = Builders<BsonDocument>.Filter.Eq("DanhMuc.TENDM", danhMuc);
            // Tìm sản phẩm có TENDM bằng danhMuc
            var sanPhamList = sanPhamCollection.Find(filter).ToList();

            // Lặp qua danh sách BsonDocument để tìm kiếm sản phẩm theo danh mục
            foreach (var sanPham in sanPhamList)
            {
                string masp = sanPham["MASP"].AsString;
                string tenSP = sanPham["TENSP"].AsString;
                int gia = sanPham["GIA"].AsInt32;
                string anh = sanPham["ANH"].AsString;

                // Tạo UserControl để hiển thị sản phẩm
                var productControl = new ProductControl(masp, tenSP, gia, anh);

                // Thêm UserControl vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            TimKiemSanPhamTheoTen(keyword);
            comboBox1.ResetText();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDanhMuc = comboBox1.SelectedItem.ToString();

            // Thực hiện tìm kiếm dựa trên danh mục
            TimKiemSanPhamTheoDanhMuc(selectedDanhMuc);
        }
    }
}

