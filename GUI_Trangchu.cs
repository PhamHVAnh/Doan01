using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Doan01
{
    public partial class GUI_Trangchu : Form
    {

        BUS_Taikhoan bus_tk=new BUS_Taikhoan();
        public GUI_Trangchu(string Chucvu)
        {

            InitializeComponent();
            customizeDesing();
            this.Size = new System.Drawing.Size(1100, 650);
           if (Chucvu != "Quản lý")
            {
                button1.Enabled = false;
                button6.Enabled = false;
                btn_Ql3.Enabled = false;
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void customizeDesing()
        {
            panelQl1.Visible = false;
            panelQl2.Visible = false;
        }
        private void hidemenu()
        {
            if (panelQl1.Visible == true)
                panelQl1.Visible = false;
            if (panelQl2.Visible == true)
                panelQl2.Visible = false;

        }
        private void showmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidemenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void GUI_Trangchu_Load(object sender, EventArgs e)
        {

        }
        private void btnQL1_Click(object sender, EventArgs e)
        {
            showmenu(panelQl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Loaisp());
            //hidemenu();
            lbhienthi.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbhienthi.Text = "     QUẢN LÝ SẢN PHẨM";
            openChildForm(new GUI_Sanpham());
            //hidemenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Khachhang());
            //hidemenu();
            lbhienthi.Text = "     QUẢN LÝ KHÁCH HÀNG";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Nhacungcap());
            //hidemenu();
            lbhienthi.Text = "     QUẢN LÝ NHÀ CUNG CẤP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Nhanvien());
            //hidemenu();
            lbhienthi.Text = "      QUẢN LÝ NHÂN VIÊN";
            

            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Taikhoan());
            //hidemenu();
            lbhienthi.Text = "    QUẢN LÝ TÀI KHOẢN";
        }

        private void btnQl2_Click_1(object sender, EventArgs e)
        {
            showmenu(panelQl2);
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            lbhienthi.Text = "   QUẢN LÝ HOÁ ĐƠN NHẬP";
            openChildForm(new GUI_Hoadonnhap());
            //hidemenu();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            lbhienthi.Text = "   QUẢN LÝ HOÁ ĐƠN BÁN";
            openChildForm(new GUI_Hoadonban());
            //hidemenu();
        }
        private void btn_Ql3_Click(object sender, EventArgs e)
        {
            lbhienthi.Text = "                THỐNG KÊ";
            openChildForm(new GUI_Thongke());
        }
        private void button12_Click(object sender, EventArgs e)
        {
            lbhienthi.Text = "Trợ giúp quản lý cửa hàng.";
            openChildForm(new GUI_Trogiup());
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void RestoreInitialView()
        {
            hidemenu();
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            lbhienthi.Text = "CHÀO MỪNG BẠN ĐẾN VỚI CỬA HÀNG"; 
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            RestoreInitialView();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                GUI_Dangnhap Form = new GUI_Dangnhap();
                Form.Show();
                this.Hide();
            }    
                
        }


    }
}
