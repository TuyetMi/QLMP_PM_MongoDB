using BUS;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        private IMongoCollection<BsonDocument> nhanVienCollection;
        public Register()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "NhanVien"; // Thay collectionName bằng tên của collection SanPham trong CSDL

            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            nhanVienCollection = database.GetCollection<BsonDocument>(collectionName);
        }







        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_dangki.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_dangki.ForeColor = Color.PaleVioletRed;
        }

        private void taikhoan_Click(object sender, EventArgs e)
        {
            txt_hoten.SelectAll();
            
        }









        private void matkhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_matkhau.Text == "")
                {
                    txt_matkhau.Text = "Mật Khẩu";
                    return;
                }
                txt_matkhau.ForeColor = Color.White;
                panel11.Visible = false;
            }
            catch
            {

            }
        }

        private void gmail_Click(object sender, EventArgs e)
        {
            txt_taikhoan.SelectAll();
        }

        private void matkhau_Click(object sender, EventArgs e)
        {
            txt_matkhau.SelectAll();
        }



        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_hoten.Text == "")
                {
                    txt_hoten.Text = "Tài Khoản";
                    return;
                }
                txt_taikhoan.ForeColor = Color.White;
                panel7.Visible = false;

            }
            catch
            {
            }
        }

        //private void txt_NgaySinh_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txt_VaiTro.Text == "")
        //        {
        //            txt_VaiTro.Text = "Ngày Sinh";
        //            return;
        //        }
        //        txt_VaiTro.ForeColor = Color.White;
        //        panel15.Visible = false;

        //    }
        //    catch
        //    {
        //    }
        //}

        private void Register_Load(object sender, EventArgs e)
        {


        }
        public string encryption(string password)
        {

            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các TextBox

                string hoTen = txt_hoten.Text;
                string gioiTinh = cbb_gioitinh.Text;
                string tenTaiKhoan = txt_taikhoan.Text;
                string matKhau = txt_matkhau.Text;
                string vaitro = "Khách Hàng";

                // Tạo đối tượng TaiKhoan
                var taiKhoan = new BsonDocument
                {
                    { "TENTK", tenTaiKhoan },
                    { "MATKHAU", matKhau },
                    { "VAITRO", vaitro }
                };

                // Tạo đối tượng NhanVien
                var nhanVien = new BsonDocument
                {

                    { "HOTEN", hoTen },
                    { "GIOITINH", gioiTinh },
                    { "TaiKhoan", taiKhoan } // Đưa đối tượng TaiKhoan vào đối tượng NhanVien
                };

                // Thêm đối tượng NhanVien vào cơ sở dữ liệu

                nhanVienCollection.InsertOne(nhanVien);
                DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            }

            catch (Exception ex)
            {
                if (txt_hoten.Text == "Họ Tên" && txt_taikhoan.Text == "Tài Khoản" && txt_matkhau.Text == "Mật Khẩu")
                {

                    panel4.Visible = true;
                    panel7.Visible = true;
                    panel11.Visible = true;
                    //panel15.Visible = true;
                    txt_hoten.Focus();
                    txt_taikhoan.Focus();
                    txt_matkhau.Focus();
                    return;
                }

            }
        }

        private void txt_NgaySinh_Click(object sender, EventArgs e)
        {
            //txt_VaiTro.SelectAll();
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}