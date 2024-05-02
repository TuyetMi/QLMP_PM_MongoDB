using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public string GIOITINH {  get; set; }
        public string VAITRO {  get; set; }
        public TaiKhoan TaiKhoan { get; set; }

    }
}
