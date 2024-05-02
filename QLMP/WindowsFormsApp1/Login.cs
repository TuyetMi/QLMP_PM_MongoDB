
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private IMongoCollection<BsonDocument> nhanVienCollection;
        
        
        public Login()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "QLMP"; // Thay TenCSDL bằng tên thật của bạn
            string collectionName = "NhanVien"; // Thay collectionName bằng tên của collection SanPham trong CSDL

            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            nhanVienCollection = database.GetCollection<BsonDocument>(collectionName);
            
            
            
        }
        private void taikhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (taikhoan.Text == "")
                {
                    taikhoan.Text = "Username";
                    return;
                }
                taikhoan.ForeColor = Color.White;
                panel4.Visible = false;

            }
            catch
            {
            }
        }

        private void matkhau_Click(object sender, EventArgs e)
        {
            matkhau.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            dangnhap.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            dangnhap.ForeColor = Color.PaleVioletRed;
        }

       

        private void taikhoan_Click(object sender, EventArgs e)
        {
            taikhoan.SelectAll(); 
        }
        private void matkhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (matkhau.Text == "")
                {
                    matkhau.Text = "Mật Khẩu";
                    return;
                }
                matkhau.ForeColor = Color.White;
                panel8.Visible = false;
            }
            catch
            {

            }
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
        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        

        private void dangky_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            try
            {

                string tk = taikhoan.Text;
                string mk = matkhau.Text;
                string mk_encrypted = encryption(mk);

                var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoan.TENTK", tk) & Builders<BsonDocument>.Filter.Eq("TaiKhoan.MATKHAU", mk);
                var result = nhanVienCollection.Find(filter).ToList();

                if (result.Count > 0)
                {
                    string hoTen = result[0]["HOTEN"].AsString;
                    string cv = result[0]["TaiKhoan"]["VAITRO"].AsString;
                    ShareData.CV = cv;
                    ShareData.HoTen = hoTen;
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main frm = new Main();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (taikhoan.Text == "Tài Khoản" && matkhau.Text == "Mật Khẩu")
                {
                    panel4.Visible = true;
                    taikhoan.Focus();
                    panel8.Visible = true;
                    matkhau.Focus();
                    return;
                }

            }
        }
    }
}