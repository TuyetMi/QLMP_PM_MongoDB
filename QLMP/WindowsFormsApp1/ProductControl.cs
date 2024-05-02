using BUS;
using DTO;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class ProductControl : UserControl
    {

        private SanPhamBUS sanPhamBUS;
        public ProductControl(string masp,string tenSP,int gia,string anh)
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "SanPham"; // Thay collectionName bằng tên của collection SanPham trong CSDL
            lbl_masp.Text = masp;
            lbl_TenSP.Text = tenSP;
            lbl_GiaTien.Text = "Giá: " + gia.ToString() + " VNĐ";
            // Load ảnh từ đường dẫn
            ptb_Hinh.Image = Image.FromFile(anh);
            sanPhamBUS = new SanPhamBUS(connectionString, databaseName, collectionName);
            
        }

        

        public string masp;
        public string tenSP;
        public int gia;
        public string anh;
        
        public void Productinfo()
        {
           
            Frm_ChiTietSanPham frm = new Frm_ChiTietSanPham(masp);
            frm.ShowDialog();
        }
        
        

       

        private void ProductControl_Click(object sender, EventArgs e)
        {
            masp = lbl_masp.Text;
            
            Frm_ChiTietSanPham frm = new Frm_ChiTietSanPham(masp);
            frm.ShowDialog();
        }
        

    }
}
