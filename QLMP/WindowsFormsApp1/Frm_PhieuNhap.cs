using BUS;
using DTO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_PhieuNhap : Form
    {
        private IMongoCollection<BsonDocument> phieuNhapCollection;
        private IMongoCollection<BsonDocument> sanPhamCollection;
        //private int currentInvoiceNumber = 0;

        public Frm_PhieuNhap()
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
            txt_tennn.Text = ShareData.HoTen;
        }

        private string GenerateMAPN(IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter.Exists("MAPN");
            var sort = Builders<BsonDocument>.Sort.Descending("MAPN");
            var lastDocument = collection.Find(filter).Sort(sort).FirstOrDefault();

            if (lastDocument != null && lastDocument.Contains("MAPN"))
            {
                string lastMAPN = lastDocument["MAPN"].AsString;
                string newMAPN = IncrementMAPN(lastMAPN);
                return newMAPN;
            }

            return "PN01"; // Nếu không có bản ghi nào trong bộ sưu tập
        }

        private string IncrementMAPN(string lastMAPN)
        {
            int number;
            if (int.TryParse(lastMAPN.Substring(2), out number))
            {
                return "PN" + (number + 1).ToString("D2");
            }

            return "PN01";
        }

        private void InsertDocument(IMongoCollection<BsonDocument> collection, BsonDocument document)
        {
            collection.InsertOne(document);
        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            string newMAPN = GenerateMAPN(phieuNhapCollection);
            string tenNguoiNhap = txt_tennn.Text;
            string maSanPham = txt_masp.Text;
            string tenSanPham = txt_tensp.Text;
            int soLuongNhap = int.Parse(txt_soluong.Text);
            decimal donGiaNhap = decimal.Parse(txt_dongia.Text);


            // Tìm sản phẩm dựa trên mã sản phẩm
            var sanPhamFilter = Builders<BsonDocument>.Filter.Eq("MASP", maSanPham);
            var sanPhamToUpdate = sanPhamCollection.Find(sanPhamFilter).FirstOrDefault();

            if (sanPhamToUpdate != null)
            {
                // Cập nhật số lượng tồn của sản phẩm
                int soLuongTonHienTai = sanPhamToUpdate["SOLUONGTON"].AsInt32;
                int soLuongTonMoi = soLuongTonHienTai + soLuongNhap;
                var updateDefinition = Builders<BsonDocument>.Update.Set("SOLUONGTON", soLuongTonMoi);
                sanPhamCollection.UpdateOne(sanPhamFilter, updateDefinition);

                BsonDocument document = new BsonDocument
            {
                { "MAPN", newMAPN },
                { "MASP", txt_masp.Text },
                { "NGAYLAP", DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc) },
                { "NGUOINHAP", txt_tennn.Text },
                { "SoLuongNhap", int.Parse(txt_soluong.Text) },
                { "DonGiaNhap", BsonDecimal128.Create(decimal.Parse(txt_dongia.Text)) }
            };


            InsertDocument(phieuNhapCollection, document);

            MessageBox.Show("Đã thêm phiếu nhập thành công.");
            this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần nhập hoặc số lượng tồn không đủ.");
            }

            //    string tenNguoiNhap = txt_tennn.Text;
            //    string maSanPham = txt_masp.Text;
            //    string tenSanPham = txt_tensp.Text;
            //    int soLuongNhap = int.Parse(txt_soluong.Text);
            //    decimal donGiaNhap = decimal.Parse(txt_dongia.Text);


            //    Tìm sản phẩm dựa trên mã sản phẩm
            //var sanPhamFilter = Builders<BsonDocument>.Filter.Eq("MASP", maSanPham);
            //    var sanPhamToUpdate = sanPhamCollection.Find(sanPhamFilter).FirstOrDefault();

            //    if (sanPhamToUpdate != null)
            //    {
            //        Cập nhật số lượng tồn của sản phẩm
            //        int soLuongTonHienTai = sanPhamToUpdate["SOLUONGTON"].AsInt32;
            //        int soLuongTonMoi = soLuongTonHienTai + soLuongNhap;
            //        var updateDefinition = Builders<BsonDocument>.Update.Set("SOLUONGTON", soLuongTonMoi);
            //        sanPhamCollection.UpdateOne(sanPhamFilter, updateDefinition);

            //        DateTime currentDate = DateTime.Now;
            //        Thêm phiếu nhập vào bảng PhieuNhap
            //        var phieuNhapDoc = new BsonDocument
            //{
            //    { "MAPN", GenerateUniqueInvoiceNumber()},
            //    {   "MASP", maSanPham},
            //    { "NGAYLAP", currentDate },
            //    { "NGUOINHAP", tenNguoiNhap },
            //    { "SoLuongNhap", soLuongNhap },
            //    { "DonGiaNhap", donGiaNhap }
            //};
            //    phieuNhapCollection.InsertOne(phieuNhapDoc);

            //    MessageBox.Show("Phiếu nhập đã được thêm thành công.");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Không tìm thấy sản phẩm cần nhập hoặc số lượng tồn không đủ.");
            //}
        }
        //public string GenerateUniqueInvoiceNumber()
        //{
        //    // Triển khai logic của bạn để tạo số hóa đơn duy nhất ở đây.
        //    // Ví dụ: Bạn có thể sử dụng kết hợp của ngày và một bộ đếm.
        //    // Trong lúc này, tôi sử dụng một bộ đếm đơn giản.
        //    int nextInvoiceNumber = GetNextInvoiceNumberFromDatabase();
        //    return "PN" + (nextInvoiceNumber + 1).ToString("D2"); // D2 đảm bảo có hai chữ số.
        //}


        //public int GetNextInvoiceNumberFromDatabase()
        //{

        //    var latestInvoice = phieuNhapCollection.Find(new BsonDocument()).SortByDescending(p => p["MAPN"]).FirstOrDefault();

        //    if (latestInvoice != null)
        //    {
        //        string latestInvoiceNumber = latestInvoice["MAPN"].AsString;
        //        int currentInvoiceNumber = int.Parse(latestInvoiceNumber.Substring(2)) + 1;
        //        return currentInvoiceNumber;
        //    }
        //    else
        //    {
        //        return 1; // Bắt đầu từ "PN01" khi không có phiếu nhập nào trong cơ sở dữ liệu.
        //    }
        //}

        private void txt_masp_TextChanged(object sender, EventArgs e)
        {
            string maSanPham = txt_masp.Text;

            if (!string.IsNullOrWhiteSpace(maSanPham))
            {
                var sanPhamFilter = Builders<BsonDocument>.Filter.Eq("MASP", maSanPham);
                var sanPham = sanPhamCollection.Find(sanPhamFilter).FirstOrDefault();

                if (sanPham != null)
                {
                    string tenSanPham = sanPham["TENSP"].AsString;
                    txt_tensp.Text = tenSanPham;
                }
                else
                {
                    txt_tensp.Text = ""; // Đặt ComboBox thành giá trị mặc định nếu không tìm thấy sản phẩm
                }
            }
        }
    }
}
