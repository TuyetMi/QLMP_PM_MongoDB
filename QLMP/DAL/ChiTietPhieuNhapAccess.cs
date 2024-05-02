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
    public class ChiTietPhieuNhapAccess
    { 
        
        //public List<ChiTietPhieuNhap> laytoanbosanpham()
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = "SELECT CTPN.ID_PN, NHACUNGCAP.TEN_NCC, SANPHAM.TEN_SP, PHIEUNHAP.NGAYLAP, CTPN.DONGIA, CTPN.SOLUONG, PHIEUNHAP.TongTien " +
        //               "FROM CTPN " +
        //               "INNER JOIN NHACUNGCAP ON CTPN.ID_NCC = NHACUNGCAP.ID_NCC " +
        //               "INNER JOIN SANPHAM ON CTPN.ID_SP = SANPHAM.ID_SP " +
        //               "INNER JOIN PHIEUNHAP ON CTPN.ID_PN = PHIEUNHAP.ID_PN";

        //    command.Connection = conn;
        //    OracleDataReader reader = command.ExecuteReader();
        //    List<ChiTietPhieuNhap> dsCTPN = new List<ChiTietPhieuNhap>();

        //    while (reader.Read())
        //    {
        //        string IdPhieuNhap = reader.GetString(0); // Lấy ID_PN
        //        string TenNCC = reader.GetString(1); // Lấy TEN_NCC
        //        string TenSanPham = reader.GetString(2); // Lấy TEN_SP
        //        DateTime NgayLap = reader.GetDateTime(3); // Lấy NGAYLAP
        //        decimal Dongia = reader.GetDecimal(4); // Lấy DONGIA
        //        int Soluong = reader.GetInt32(5); // Lấy SOLUONG
        //        decimal TongTien = reader.GetDecimal(6); // Lấy TONGTIEN 

        //        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
        //        ctpn.IdPhieuNhap = IdPhieuNhap;
        //        ctpn.TenNhaCungCap = TenNCC;
        //        ctpn.TenSanPham = TenSanPham;
        //        ctpn.NgayLap = NgayLap;
        //        ctpn.DonGia = Dongia;
        //        ctpn.SoLuong = Soluong;
        //        ctpn.TongTien = TongTien;
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
        //    command.CommandText = "delete from CTPN where ID_PN =:ID_PN";
        //    command.Connection = conn;
        //    command.Parameters.Add(":ID_PN", OracleDbType.NVarchar2).Value = CTphieunhapid;
        //    int kq = command.ExecuteNonQuery();
        //    return kq > 0;
        //}
        //public bool ThemCTPhieunhap(ChiTietPhieuNhap CTPN)
        //{
        //    Moketnoi();
        //    // Tạo đối tượng OracleCommand
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "THEM_CHITIET_PHIEUNHAP";
        //    command.Connection = conn;
        //    // Thêm tham số cho stored procedure
        //    command.Parameters.Add("p_ID_PN", OracleDbType.Varchar2, 10).Value = CTPN.IdPhieuNhap;
        //    command.Parameters.Add("p_TenSP", OracleDbType.NVarchar2, 30).Value = CTPN.TenSanPham;
        //    command.Parameters.Add("p_TenNCC", OracleDbType.NVarchar2, 30).Value = CTPN.TenNhaCungCap;
        //    command.Parameters.Add("p_SOLUONG", OracleDbType.Int32).Value = CTPN.SoLuong;
        //    command.Parameters.Add("p_DONGIA", OracleDbType.Decimal).Value = Convert.ToDecimal(CTPN.DonGia);


        //    // Thực thi stored procedure
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
