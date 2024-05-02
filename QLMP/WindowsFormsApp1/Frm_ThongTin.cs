using BUS;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_ThongTin : Form
    {
        private IMongoCollection<BsonDocument> nhanVienCollection;
        private NhanVienBUS nhanVienBUS;
        public Frm_ThongTin(string hoTen)
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "NhanVien"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            nhanVienBUS = new NhanVienBUS(connectionString, databaseName, collectionName);
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            nhanVienCollection = database.GetCollection<BsonDocument>(collectionName);
            loadmain(hoTen);
        }
        public void loadmain(string hoTen)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("HOTEN", hoTen);
                var result = nhanVienCollection.Find(filter).FirstOrDefault();
                // Kiểm tra xem danh sách có ít nhất một tài khoản không
                if (result != null)
                {
                    // Bạn có thể truy cập thông tin của nhân viên ở đây
                    txt_hoten.Text = result["HOTEN"].AsString;
                    txt_GioiTinh.Text = result["GIOITINH"].AsString;
                    txt_TaiKhoan.Text = result["TaiKhoan"]["TENTK"].AsString; // Truy cập TENTK trong TaiKhoan

                    // Sau đó, hiển thị thông tin hoặc thực hiện các thao tác khác tùy ý
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có tên: " + hoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string encryption(string password)
        {

            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin tên nhân viên và mật khẩu mới từ các TextBox hoặc các điều khiển tương ứng
                string hoTenNhanVien = txt_hoten.Text;
                string matKhauMoi = txtMatkhauMoi.Text;

                // Gọi phương thức cập nhật mật khẩu từ lớp BUS
                
                nhanVienBUS.CapNhatMatKhauNhanVien(hoTenNhanVien, matKhauMoi);

                // Hiển thị thông báo cho người dùng
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Xử lý các trường hợp lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
