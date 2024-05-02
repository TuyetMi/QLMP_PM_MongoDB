using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    public class HoaDonAccess : DBConnection
    {
        private IMongoCollection<HoaDon> _hoadonCollection;

        public HoaDonAccess(string connectionString, string databaseName, string collectionName)
            : base(connectionString, databaseName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _hoadonCollection = database.GetCollection<HoaDon>(collectionName);
        }

        public List<HoaDon> LayToanBoHoaDon()
        {
            return _hoadonCollection.Find(_ => true).ToList();
        }

        public void ThemHoaDon(HoaDon hoaDon)
        {
            _hoadonCollection.InsertOne(hoaDon);
        }
    }
}
