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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Doan01
{
    public partial class GUI_Doimatkhau : Form
    {
        private string Tentk;
        BUS_Taikhoan bus_tk = new BUS_Taikhoan();
        Taikhoan tk = new Taikhoan();
        public GUI_Doimatkhau(string Tentk)
        {
            InitializeComponent();
            this.Tentk = Tentk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtXnmk.Text != txtMkm.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận chưa đúng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMkm.Text = "";
                txtXnmk.Text = "";  
                return;
            }
            if (string.IsNullOrEmpty(txtMkm.Text) || string.IsNullOrEmpty(txtXnmk.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;               
            }
            string Matkhau = txtMkm.Text;
            if (bus_tk.Doimatkhau(this.Tentk, Matkhau))
            {
                MessageBox.Show("Thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMkm.Text = "";
                txtXnmk.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_Dangnhap Form = new GUI_Dangnhap();
            Form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMkm.PasswordChar == '*')
            {
                button4.BringToFront();
                txtMkm.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtMkm.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtMkm.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtXnmk.PasswordChar == '*')
            {
                button6.BringToFront();
                txtXnmk.PasswordChar = '\0';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtXnmk.PasswordChar == '\0')
            {
                button5.BringToFront();
                txtXnmk.PasswordChar = '*';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtXnmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
{
                button1.PerformClick();
            }
        }
    }
}
