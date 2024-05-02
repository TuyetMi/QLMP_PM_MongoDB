using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonAccess hoadonAccess;

        public HoaDonBUS(string connectionString, string databaseName, string collectionName)
        {
            hoadonAccess = new HoaDonAccess(connectionString, databaseName, collectionName);
        }
    }
}
