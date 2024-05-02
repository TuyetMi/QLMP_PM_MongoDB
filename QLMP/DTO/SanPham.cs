using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public ObjectId _id { get; set; }
        public string MASP { get; set; }
        public DanhMuc DanhMuc { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public string TENSP { get; set; }
        public int SOLUONGTON { get; set; }
        public int GIA { get; set; }
        public string THUONGHIEU { get; set; }
        public string ANH { get; set; }
        public SanPham() {
            
        
        }
    }
}
