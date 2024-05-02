using BUS;
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

namespace WindowsFormsApp1.GUI
{
    public partial class UC_HoaDon : UserControl
    {
        private IMongoCollection<BsonDocument> hoadonCollection;
        private HoaDonBUS hoadonBUS;
        private string selectedMaHoaDon;
        public UC_HoaDon()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "HoaDon"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            hoadonBUS = new HoaDonBUS(connectionString, databaseName, collectionName);
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            hoadonCollection = database.GetCollection<BsonDocument>(collectionName);
            loaddata();
        }

        public void loaddata()
        {
            dataGridView1.Rows.Clear();
            // Tạo truy vấn MongoDB
            var pipeline = new List<BsonDocument>
{
    BsonDocument.Parse("{ $unwind: '$CHITIETHOADON' }"),
    BsonDocument.Parse("{ $group: { _id: { MAHD: '$MAHD', TENSP: '$CHITIETHOADON.TENSP', NGAYLAP: '$NGAYLAP', TENNV: '$NhanVien.HOTEN' }, SoLuong: { $sum: '$CHITIETHOADON.SOLUONG' }, DonGia: { $first: '$CHITIETHOADON.DONGIA' }, TongTien: { $sum: { $multiply: ['$CHITIETHOADON.SOLUONG', '$CHITIETHOADON.DONGIA'] } } } }"),
    BsonDocument.Parse("{ $project: { _id: 0, MAHD: '$_id.MAHD',NGAYLAP: '$_id.NGAYLAP', TENNV: '$_id.TENNV', TenSanPham: '$_id.TENSP', SoLuong: 1, DonGia: 1, TongTien: 1,  } }")
};

            var aggregateOptions = new AggregateOptions();
            var result = hoadonCollection.Aggregate<BsonDocument>(pipeline, aggregateOptions).ToList();

            // Đặt kết quả vào DataGridView
            foreach (var doc in result)
            {
                string maHD = doc["MAHD"].AsString;
                string ngayLap = doc["NGAYLAP"].AsString;
                string tenNhanVien = doc["TENNV"].AsString;
                string tenSanPham = doc["TenSanPham"].AsString;
                int soLuong = doc["SoLuong"].AsInt32;
                int donGia = doc["DonGia"].AsInt32;
                double tongTien = doc["TongTien"].AsInt32;
                

                // Thêm dòng mới vào DataGridView
                dataGridView1.Rows.Add(maHD, ngayLap, tenNhanVien, tenSanPham, soLuong, donGia, tongTien);
            }

        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Có ít nhất một dòng dữ liệu được chọn
                // Lấy mã hóa đơn từ dòng được chọn
                string maHoaDon = dataGridView1.SelectedRows[0].Cells["ID_HD_COL"].Value.ToString(); // Thay MaHoaDonColumnName bằng tên cột chứa mã hóa đơn
                // Lưu mã hóa đơn vào một biến toàn cục hoặc một biến khác để sử dụng sau này
                selectedMaHoaDon = maHoaDon;
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có mã hóa đơn nào được chọn chưa
            if (!string.IsNullOrEmpty(selectedMaHoaDon))
            {
                // Thực hiện xóa hóa đơn dựa trên mã hóa đơn
                XoaHoaDon(selectedMaHoaDon);
                // Sau khi xóa, cập nhật lại DataGridView hoặc thực hiện các thao tác cần thiết khác
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.");
            }
        }
        private void XoaHoaDon(string maHoaDon)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MAHD", maHoaDon);

            hoadonCollection.DeleteOne(filter);

            // Sau khi xóa, cập nhật lại DataGridView hoặc thực hiện các thao tác cần thiết khác
            loaddata();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            dataGridView1.Controls.Clear();
            loaddata();
        }

        

        private void btn_tim_Click(object sender, EventArgs e)
        {
            // Lấy mã hóa đơn từ TextBox
            string maHoaDon = txt_timmahd.Text;

            // Thực hiện tìm kiếm hoặc lọc dữ liệu trong DataGridView dựa trên mã hóa đơn
            if (!string.IsNullOrEmpty(maHoaDon))
            {
                // Gọi hàm tìm kiếm dữ liệu dựa trên mã hóa đơn và cập nhật DataGridView
                TimHoaDonTheoMa(maHoaDon);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để tìm kiếm.");
            }
        }
        private void TimHoaDonTheoMa(string maHoaDon)
        {
            // Thực hiện tìm kiếm dữ liệu trong DataGridView dựa trên mã hóa đơn
            // Ví dụ, bạn có thể duyệt qua các dòng của DataGridView và ẩn hoặc hiển thị dòng tương ứng dựa trên mã hóa đơn
            // Ví dụ:
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maHD = row.Cells["ID_HD_COL"].Value.ToString(); // Thay MaHoaDonColumnName bằng tên cột chứa mã hóa đơn
                if (maHD == maHoaDon)
                {
                    row.Visible = true; // Hiển thị dòng nếu mã hóa đơn trùng khớp
                }
                else
                {
                    row.Visible = false; // Ẩn dòng nếu mã hóa đơn không khớp
                }
            }
        }
    }
}
            

