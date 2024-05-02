using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {

        private NhanVienAccess nhanVienAccess;

        public NhanVienBUS(string connectionString, string databaseName, string collectionName)
        {
            // Sử dụng tham số truyền vào để thiết lập kết nối cơ sở dữ liệu
            nhanVienAccess = new NhanVienAccess(connectionString, databaseName, collectionName);
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return nhanVienAccess.LayDanhSachNhanVien();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            nhanVienAccess.ThemNhanVien(nhanVien);
        }
        public void CapNhatMatKhauNhanVien(string hoTen, string matKhauMoi)
        {
            nhanVienAccess.CapNhatMatKhauNhanVien(hoTen, matKhauMoi);
        }
    }
}
