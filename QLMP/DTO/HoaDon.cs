using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public string MAHD {  get; set; }
        public DateTime NGAYLAP { get; set; }
        public ChiTietHoaDon chiTietHoaDon { get; set; }
        public NhanVien NhanVien { get; set; }

        public HoaDon() { }
    }
}

