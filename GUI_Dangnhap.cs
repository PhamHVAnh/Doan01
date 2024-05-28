using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan01
{
    public partial class GUI_Dangnhap : Form
    {
        BUS_Taikhoan bus_tk= new BUS_Taikhoan();
        Taikhoan tk=new Taikhoan();
       
        
        public GUI_Dangnhap()
        {
            InitializeComponent();




        }
        string[] arr = new string[2];


        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string Tentk = txtDn.Text;
            string Matkhau = txtMkhau.Text;
            if (string.IsNullOrWhiteSpace(Tentk) || string.IsNullOrWhiteSpace(Matkhau)||txtDn.Text == "Tên đăng nhập"||txtMkhau.Text=="Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bus_tk.Login(Tentk, Matkhau))
            {
                //MessageBox.Show("Đăng nhập thành công!");
                string ChucVu = bus_tk.Laychucvu(Tentk);

                // Tạo một thể hiện mới của form GUI_Trangchu và truyền chức vụ vào đó
                this.Hide();
                GUI_Trangchu Form = new GUI_Trangchu(ChucVu);
                Form.Show();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDn.Text = "";
                txtMkhau.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMkhau.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtMkhau.PasswordChar = '*';
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMkhau.PasswordChar == '*')
            {
                button2.BringToFront();
                txtMkhau.PasswordChar = '\0';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_Matkhaumoi Form = new GUI_Matkhaumoi();
            Form.Show();
            this.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void GUI_Dangnhap_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void txtDn_Enter_1(object sender, EventArgs e)
        {
            if (txtDn.Text == "Tên đăng nhập")
            {
                txtDn.Text = "";
                txtDn.ForeColor = Color.Black;
            }
        }
        private void txtDn_Leave(object sender, EventArgs e)
        {
            if (txtDn.Text == "")
            {
                txtDn.Text = "Tên đăng nhập";
                txtDn.ForeColor = Color.DimGray;
            }
        }
        private void txtMkhau_Enter(object sender, EventArgs e)
        {
            if (txtMkhau.Text == "Mật khẩu")
            {
                txtMkhau.Text = "";
                txtMkhau.ForeColor = Color.Black;
            }
        }

        private void txtMkhau_Leave(object sender, EventArgs e)
        {
            if (txtMkhau.Text == "")
            {
                txtMkhau.Text = "Mật khẩu";
                txtMkhau.ForeColor = Color.DimGray;
            }
            if (string.IsNullOrEmpty(txtMkhau.Text))
            {
                txtMkhau.PasswordChar = '\0'; // Hiển thị chữ khi không có ký tự nào được nhập
            }
        }

        private void txtMkhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txtMkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMkhau.PasswordChar = '*';
        }
    }
}
