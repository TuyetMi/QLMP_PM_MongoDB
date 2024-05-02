using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MongoDB.Driver;

namespace DAL
{
    public class NhanVienAccess : DBConnection
    {
        private IMongoCollection<NhanVien> _nhanVienCollection;
        public NhanVienAccess(string connectionString, string databaseName, string collectionName)
            : base(connectionString, databaseName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _nhanVienCollection = database.GetCollection<NhanVien>(collectionName);
        }
        public List<NhanVien> LayDanhSachNhanVien()
        {
            return _nhanVienCollection.Find(_ => true).ToList();
        }
        public NhanVien LayNhanVienTheoHoTen(string hoTen)
        {
            var filter = Builders<NhanVien>.Filter.Eq("HOTEN", hoTen);
            return _nhanVienCollection.Find(filter).FirstOrDefault();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            _nhanVienCollection.InsertOne(nhanVien);
        }
        public void CapNhatMatKhauNhanVien(string hoTen, string matKhauMoi)
        {
            try
            {
                var filter = Builders<NhanVien>.Filter.Eq("HOTEN", hoTen);
                var update = Builders<NhanVien>.Update.Set("TaiKhoan.MATKHAU", matKhauMoi);

                _nhanVienCollection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cập nhật mật khẩu: " + ex.Message);
            }
        }
    }
}
