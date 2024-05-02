using Amazon.Runtime.Documents;
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

namespace WindowsFormsApp1
{
    public partial class GioHang : UserControl
    {
        private IMongoCollection<BsonDocument> gioHangCollection;
        private IMongoCollection<BsonDocument> hoaDonCollection;
        private IMongoCollection<BsonDocument> sanPhamCollection;
        public GioHang()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "GioHang"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            string collectionNameHD = "HoaDon";
            string collectionNameSP = "SanPham";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            gioHangCollection = database.GetCollection<BsonDocument>(collectionName);
            hoaDonCollection = database.GetCollection<BsonDocument>(collectionNameHD);
            sanPhamCollection = database.GetCollection<BsonDocument>(collectionNameSP);
            LoadData();
            dataGridView1.Refresh();
        }
        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            var pipeline = new List<BsonDocument>
{
    new BsonDocument("$match", new BsonDocument
    {
        { "TENKH", ShareData.HoTen } // Replace "desired_name" with the name you want to filter by
    }),
    new BsonDocument("$unwind", "$CTGH"),
    new BsonDocument("$group", new BsonDocument
    {
        { "_id", new BsonDocument
            {
                { "TENKH", "$TENKH" },
                { "TENSP", "$CTGH.TENSP" }
            }
        },
        { "SOLUONG_TONG", new BsonDocument("$sum", "$CTGH.SOLUONG") },
        { "GIA_TONG", new BsonDocument("$sum", new BsonDocument("$multiply", new BsonArray { "$CTGH.GIA", "$CTGH.SOLUONG" })) },
        { "ANH", new BsonDocument("$first", "$CTGH.ANH") }
    }),
    new BsonDocument("$group", new BsonDocument
    {
        { "_id", "$_id.TENKH" },
        { "SANPHAM", new BsonDocument("$push", new BsonDocument
            {
                { "TENSP", "$_id.TENSP" },
                { "SOLUONG_TONG", "$SOLUONG_TONG" },
                { "GIA_TONG", "$GIA_TONG" },
                { "ANH", "$ANH" }
            })
        }
    }),
    new BsonDocument("$project", new BsonDocument
    {
        { "TENKH", "$_id" },
        { "SANPHAM", 1 },
        { "_id", 0 }
    })
};

            var aggregation = gioHangCollection.Aggregate<BsonDocument>(pipeline);

            foreach (var document in aggregation.ToEnumerable())
            {
                string tenKhachHang = document["TENKH"].AsString;
                BsonArray sanPhamArray = document["SANPHAM"].AsBsonArray;
                double totalCost = 0;

                foreach (BsonDocument sanPham in sanPhamArray)
                {
                    string tenSanPham = sanPham["TENSP"].AsString;
                    int soLuong = sanPham["SOLUONG_TONG"].AsInt32;
                    int gia = sanPham["GIA_TONG"].AsInt32;
                    string imageUrl = sanPham["ANH"].AsString;

                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["TENKH_COL"].Value = tenKhachHang;
                    dataGridView1.Rows[rowIndex].Cells["TENSP_COL"].Value = tenSanPham;
                    dataGridView1.Rows[rowIndex].Cells["SOLUONG_COL"].Value = soLuong;
                    dataGridView1.Rows[rowIndex].Cells["GIA_COL"].Value = gia;

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        try
                        {
                            using (var webClient = new System.Net.WebClient())
                            {
                                byte[] imageBytes = webClient.DownloadData(imageUrl);
                                using (var ms = new System.IO.MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);
                                    dataGridView1.Rows[rowIndex].Cells["ANH_COL"].Value = image;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Lỗi tải hình ảnh: " + ex.Message);
                        }
                    }

                    double productCost = gia;
                    totalCost += productCost;
                }

                labelTotalCost.Text = "Tổng tiền:   " + totalCost.ToString("N0") + " VNĐ";
            }
        }


        private string GenerateMAPN(IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter.Exists("MAHD");
            var sort = Builders<BsonDocument>.Sort.Descending("MAHD");
            var lastDocument = collection.Find(filter).Sort(sort).FirstOrDefault();

            if (lastDocument != null && lastDocument.Contains("MAHD"))
            {
                string lastMAHD = lastDocument["MAHD"].AsString;
                string newMAHD = IncrementMAHD(lastMAHD);
                return newMAHD;
            }

            return "HD01"; // Nếu không có bản ghi nào trong bộ sưu tập
        }

        private string IncrementMAHD(string lastMAHD)
        {
            int number;
            if (int.TryParse(lastMAHD.Substring(2), out number))
            {
                return "HD" + (number + 1).ToString("D2");
            }

            return "HD01";
        }

        private void InsertDocument(IMongoCollection<BsonDocument> collection, BsonDocument document)
        {
            collection.InsertOne(document);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                // Kiểm tra xem nút xóa đã được nhấn và không phải là hàng tiêu đề
                if (e.ColumnIndex == dataGridView1.Columns["DELETE_COL"].Index && e.RowIndex >= 0)
                {
                    // Lấy tên sản phẩm từ cột "TENSP_COL" trong dòng được chọn
                    string tenSanPham = dataGridView1.Rows[e.RowIndex].Cells["TENSP_COL"].Value.ToString();

                    // Xóa giỏ hàng dựa trên tên sản phẩm
                    var filter = Builders<BsonDocument>.Filter.Eq("TENKH", ShareData.HoTen) & Builders<BsonDocument>.Filter.Eq("CTGH.TENSP", tenSanPham);
                    gioHangCollection.DeleteOne(filter);

                    // Cập nhật DataGridView bằng cách tải lại dữ liệu
                    LoadData();

                    // Hiển thị thông báo xóa thành công (tuỳ chọn)
                    MessageBox.Show("Sản phẩm đã được xóa khỏi giỏ hàng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy tên sản phẩm từ dòng được chọn
                string tenSanPham = dataGridView1.SelectedRows[0].Cells["TENSP_COL"].Value.ToString();

                // Xóa sản phẩm khỏi collection "gioHangCollection" dựa trên tên sản phẩm và tên khách hàng
                var filter = Builders<BsonDocument>.Filter.Eq("TENKH", ShareData.HoTen) & Builders<BsonDocument>.Filter.Eq("CTGH.TENSP", tenSanPham);
                gioHangCollection.DeleteOne(filter);

                // Cập nhật DataGridView bằng cách tải lại dữ liệu
                LoadData();

                // Hiển thị thông báo xóa thành công (tuỳ chọn)
                MessageBox.Show("Sản phẩm đã được xóa khỏi giỏ hàng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (gioHangCollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("TENKH", ShareData.HoTen)) == 0)
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chọn 1 sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string newMAHD = GenerateMAPN(hoaDonCollection);
            // Kiểm tra xem có dữ liệu trong giỏ hàng không
            var countInCart = gioHangCollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("TENKH", ShareData.HoTen));

            if (countInCart == 0)
            {
                MessageBox.Show("Thêm sản phẩm vào giỏ hàng để thanh toán.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Lấy ngày hiện tại cho trường NGAYLAP.
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
           
            // Duyệt qua DataGridView để xử lý từng mặt hàng trong giỏ hàng.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (!row.IsNewRow)
                {
                    string tenSanPham = row.Cells["TENSP_COL"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["SOLUONG_COL"].Value);
                    int gia = Convert.ToInt32(row.Cells["GIA_COL"].Value);
                    string imageUrl = row.Cells["ANH_COL"].Value.ToString();
                    
                    // Tạo một tài liệu HoaDon mới cho từng mặt hàng.
                    var hoaDon = new BsonDocument
            {
                { "MAHD", newMAHD},
                { "NGAYLAP", currentDate },
                { "CHITIETHOADON", new BsonArray
                    {
                        new BsonDocument
                        {
                            { "TENSP", tenSanPham },
                            { "SOLUONG", soLuong },
                            { "DONGIA", gia }
                        }
                    }
                },
                { "NhanVien", new BsonDocument { { "HOTEN", ShareData.HoTen } } }
            };

                    // Chèn tài liệu HoaDon vào bộ sưu tập "hoaDonCollection."
                    InsertDocument(hoaDonCollection, hoaDon);

                    // Cập nhật số lượng sản phẩm trong collection "SanPham"
                    var filter = Builders<BsonDocument>.Filter.Eq("TENSP", tenSanPham);
                    var update = Builders<BsonDocument>.Update.Inc("SOLUONGTON", -soLuong); // Giảm số lượng tồn đi
                    sanPhamCollection.UpdateOne(filter, update);
                }
            }

            // Xóa collection "gioHangCollection" sau khi hoàn tất thanh toán.
            gioHangCollection.DeleteMany(Builders<BsonDocument>.Filter.Eq("TENKH", ShareData.HoTen));

            // Xóa DataGridView.
            dataGridView1.Rows.Clear();

            // Xóa nhãn tổng tiền.
            labelTotalCost.Text = "Tổng tiền:   0 VNĐ";
            MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       

    }

}


