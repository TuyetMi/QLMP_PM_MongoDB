using BUS;
using DTO;
using System;
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
    public partial class Main : Form
    {
        public Label ChucVu;
        
        public Main()
        {
            InitializeComponent();
            lbName.Text = ShareData.HoTen;
            lb_ChucVu.Text = ShareData.CV;
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            panel_Main.Controls.Add(new UC_Home());
            if(lb_ChucVu.Text != "Quản Lí")
            { 
                btn_kho.Enabled = false;
            }
            if (lb_ChucVu.Text == "Khách Hàng")
            {
                btn_hoadon.Enabled = false;
                
            }
            if (lb_ChucVu.Text == "Quản Lí")
            {
                btn_GioHang.Enabled = false;
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public string cv;
        private void button1_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            cv = lb_ChucVu.Text;
            
            
            panel_Main.Controls.Add(new UC_SanPham());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new UC_Home());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new UC_HoaDon());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Kho frm = new Frm_Kho();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            string hoTen;
            hoTen = lbName.Text;
            Frm_ThongTin frm = new Frm_ThongTin(hoTen);
            frm.Show();
        }

        private void btn_GioHang_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new GioHang());
        }
    }
}
