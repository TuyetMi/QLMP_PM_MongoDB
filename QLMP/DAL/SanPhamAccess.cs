using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.ComponentModel;
using System.Globalization;
using MongoDB.Driver;
using System.Collections;

namespace DAL
{
    public class SanPhamAccess : DBConnection
    {
        private IMongoCollection<SanPham> _sanPhamCollection;

        public SanPhamAccess(string connectionString, string databaseName, string collectionName)
            : base(connectionString, databaseName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _sanPhamCollection = database.GetCollection<SanPham>(collectionName);
        }

        public List<SanPham> LayToanBoSanPham()
        {
            return _sanPhamCollection.Find(_ => true).ToList();
        }

        public void ThemSanPham(SanPham sanPham)
        {
            _sanPhamCollection.InsertOne(sanPham);
        }
        public SanPham TimSanPhamTheoMaSP(string maSP)
        {
            var filter = Builders<SanPham>.Filter.Eq(x => x.MASP, maSP);
            return _sanPhamCollection.Find(filter).FirstOrDefault();
        }
        public List<SanPham> TimKiemSanPhamTheoDanhMuc(string tenDanhMuc)
        {
            var filter = Builders<SanPham>.Filter.Eq("DanhMuc.TENDM", tenDanhMuc);
            var result = _sanPhamCollection.Find(filter).ToList();

            return result;
        }
        public List<SanPham> TimKiemSanPhamTheoTenSanPham(string tenSP)
        {
            var filter = Builders<SanPham>.Filter.Eq("TENSP", tenSP);
            var result = _sanPhamCollection.Find(filter).ToList();

            return result;
        }


    }
}
