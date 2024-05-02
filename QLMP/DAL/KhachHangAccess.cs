using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace DAL
{
    public class KhachHangAccess 
    {
        //public bool ThemKhachHang(KhachHang kh)
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "INSERT INTO KHACHHANG (SDT, HOTEN_KH, NGAYSINH, PHAI) VALUES (:SDT, :TenKhachHang, @NgaySinh, @GioiTinh)";
        //    command.Connection = conn;
        //    command.Parameters.Add(":SDT", kh.SDT);
        //    command.Parameters.Add(":TenKhachHang", kh.tenKhachHang);
        //    command.Parameters.Add(":NgaySinh", kh.ngaySinh);
        //    command.Parameters.Add(":GioiTinh", kh.gioiTinh);
        //    int kq = command.ExecuteNonQuery();
        //    return kq > 0;

        //}
    }
}
