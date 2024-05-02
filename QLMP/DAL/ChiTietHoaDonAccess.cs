using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ChiTietHoaDonAccess 
    {
        //List<ChiTietHoaDon> dsCTPN = new List<ChiTietHoaDon>();
        //public List<ChiTietHoaDon> laytoanbosanpham()
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "Select * from CTPhieunhap";
        //    command.Connection = conn;
        //    OracleDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        string IdHoaDon = reader.GetString(0);
        //        string IdSanPham = reader.GetString(1);
        //        int Soluong = reader.GetInt32(2);
        //        ChiTietHoaDon ctpn = new ChiTietHoaDon();
        //        ctpn.IdHoaDon = IdHoaDon;
        //        ctpn.IdSanPham = IdSanPham;
        //        ctpn.soLuong = Soluong;
        //        dsCTPN.Add(ctpn);
        //    }
        //    reader.Close();
        //    return dsCTPN;
        //}
        //public bool xoaCTPhieuNhap(string CTphieunhapid)
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "delete from CTPhieunhap where IDHOADON=:IDHOADON";
        //    command.Connection = conn;
        //    command.Parameters.Add(":IDHOADON", OracleDbType.NVarchar2).Value = CTphieunhapid;
        //    int kq = command.ExecuteNonQuery();
        //    return kq > 0;
        //}
        //public bool ThemCTPhieunhap(ChiTietPhieuNhap CTPN)
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "ThemChiTietPhieuNhap";
        //    command.Connection = conn;
        //    command.Parameters.Add("@idCTphieunhap", CTPN.chiTietPhieuNhapID);
        //    command.Parameters.Add("@idPhieuNhap", CTPN.phieuNhapID);
        //    command.Parameters.Add("@idSanPham", CTPN.sanPhamID);
        //    command.Parameters.Add("@soLuong", CTPN.soLuong);
        //    command.Parameters.Add("@giaNhap", CTPN.giaNhap);

        //    int kq = command.ExecuteNonQuery();
        //    return kq > 0;

        //}
        //public bool SuaCTPhieunhap(ChiTietPhieuNhap CTPN)
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "ChinhSuaChiTietPhieuNhap";
        //    command.Connection = conn;
        //    command.Parameters.Add("@idCTphieunhap", CTPN.chiTietPhieuNhapID);
        //    command.Parameters.Add("@idPhieuNhap", CTPN.phieuNhapID);
        //    command.Parameters.Add("@idSanPham", CTPN.sanPhamID);
        //    command.Parameters.Add("@soLuong", CTPN.soLuong);
        //    command.Parameters.Add("@giaNhap", CTPN.giaNhap);

        //    int kq = command.ExecuteNonQuery();
        //    return kq > 0;

        //}
    }
}
