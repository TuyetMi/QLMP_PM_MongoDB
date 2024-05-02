using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class SanPhamBUS
    {

        private SanPhamAccess sanPhamAccess;

        public SanPhamBUS(string connectionString, string databaseName, string collectionName)
        {
            sanPhamAccess = new SanPhamAccess(connectionString, databaseName, collectionName);
        }

        public List<SanPham> LayToanBoSanPham()
        {
            return sanPhamAccess.LayToanBoSanPham();
        }

        public void ThemSanPham(SanPham sanPham)
        {
            sanPhamAccess.ThemSanPham(sanPham);
        }
        public SanPham TimSanPhamTheoMaSP(string masp)
        {
            return sanPhamAccess.TimSanPhamTheoMaSP(masp);
        }
        public List<SanPham> timkiemSanPhamDanhMuc(string tendanhmuc)
        {
            return sanPhamAccess.TimKiemSanPhamTheoDanhMuc(tendanhmuc);
        }
        public List<SanPham> TimKiemSanPhamTheoTenSanPham(string tenSP) 
        {
            return sanPhamAccess.TimKiemSanPhamTheoDanhMuc(tenSP);
        }
    }
}
