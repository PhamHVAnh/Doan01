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
using BUS;
using DTO;

namespace Doan01
{
    public partial class GUI_Matkhaumoi : Form
    {
        BUS_Taikhoan bus_tk = new BUS_Taikhoan();
        Taikhoan tk = new Taikhoan();
        public GUI_Matkhaumoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Tentk = txtTtk.Text;
            string Email = txtEmail.Text;
            bool ktra = bus_tk.Xacnhantk(Tentk, Email);
            if (ktra)
            {
                this.Close();
                GUI_Doimatkhau Form = new GUI_Doimatkhau(Tentk);
                Form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Thông tin vừa nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTtk.Text = "";
                txtEmail.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
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

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
{
                button1.PerformClick();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GUI_Dangnhap Form = new GUI_Dangnhap();
            Form.Show();
            this.Hide();
        }
    }
}
