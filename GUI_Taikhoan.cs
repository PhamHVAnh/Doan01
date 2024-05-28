using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan01
{
    public partial class GUI_Taikhoan : Form
    {
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        BUS_Taikhoan bus_tk = new BUS_Taikhoan();
        Taikhoan tk = new Taikhoan();

        public GUI_Taikhoan()
        {
            InitializeComponent();
            dgvTk.CellClick += dgvTk_CellClick;
        }

        void loaddgv()
        {
            DataTable dataTable = bus_tk.getData();
            dgvTk.DataSource = dataTable;
            dgvTk.Columns[0].HeaderText = "Mã nhân viên";
            dgvTk.Columns[1].HeaderText = "Tên tài khoản";
            dgvTk.Columns[2].HeaderText = "Mật khẩu";
            dgvTk.Columns[3].HeaderText = "Email";
            dgvTk.Columns[4].HeaderText = "Chức vụ";
        }

        void loadcb()
        {
            cbMnv.DataSource = bus_nv.getData();
            cbMnv.DisplayMember = "Tennv";
            cbMnv.ValueMember = "Manv";
        }

        private void GUI_Taikhoan_Load(object sender, EventArgs e)
        {
            loaddgv();
            loadcb();
        }

        private void dgvTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTk.Rows[e.RowIndex];
                cbMnv.Text = selectedRow.Cells["Manv"].Value.ToString();
                txtTtk.Text = selectedRow.Cells["Tentk"].Value.ToString();
                txtMk.Text = selectedRow.Cells["Matkhau"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                cbCv.Text = selectedRow.Cells["Chucvu"].Value.ToString();
                //txtTtk.Enabled = false;
            }
        }

        private void ClearTextbox()
        {
            txtTtk.Enabled = true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    (c as System.Windows.Forms.TextBox).Text = "";
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).Text = "";
                }
            }
        }

        private void btnLm_Click(object sender, EventArgs e)
        {
            txtTk.Text = "";
            ClearTextbox();
            loaddgv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tk.Manv = cbMnv.SelectedValue.ToString(); 
            tk.Tentk = txtTtk.Text;
            tk.Matkhau = txtMk.Text;
            tk.Email = txtEmail.Text;
            tk.Chucvu = cbCv.Text;

            if (string.IsNullOrEmpty(tk.Manv) || string.IsNullOrEmpty(tk.Tentk) || string.IsNullOrEmpty(tk.Matkhau) || string.IsNullOrEmpty(tk.Email) || string.IsNullOrEmpty(tk.Chucvu))   
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bus_tk.kiemtramatrung(tk.Tentk) == 1)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_tk.Themtk(tk))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextbox();
                    loaddgv();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tk.Manv = cbMnv.SelectedValue.ToString();
            tk.Tentk = txtTtk.Text;
            tk.Matkhau = txtMk.Text;
            tk.Email = txtEmail.Text;
            tk.Chucvu = cbCv.Text;

            if (string.IsNullOrEmpty(tk.Manv) || string.IsNullOrEmpty(tk.Tentk) || string.IsNullOrEmpty(tk.Matkhau) || string.IsNullOrEmpty(tk.Email) || string.IsNullOrEmpty(tk.Chucvu))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bus_tk.Suatk(tk))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                ClearTextbox();
                loaddgv();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tk.Tentk = txtTtk.Text;

            if (string.IsNullOrEmpty(tk.Tentk))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bus_tk.Xoatk(tk))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddgv();
                        ClearTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản cần xóa hoặc tài khoản này đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnTkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTk.Text) || txtTk.Text == "Nhập tên hoặc mã")
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            tk.Tentk = txtTk.Text;
            tk.Email = txtTk.Text;

            DataTable result = bus_tk.Timkiem(tk);
            dgvTk.DataSource = result;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is GUI_Trangchu)
                    {
                        ((GUI_Trangchu)form).RestoreInitialView();
                        break;
                    }
                }
            }
        }

        private void txtTk_Enter(object sender, EventArgs e)
        {
            if (txtTk.Text == "Nhập tên hoặc mã")
            {
                txtTk.Text = "";
                txtTk.ForeColor = Color.Black;
            }
        }

        private void txtTk_Leave(object sender, EventArgs e)
        {
            if (txtTk.Text == "")
            {
                txtTk.Text = "Nhập tên hoặc mã";
                txtTk.ForeColor = Color.DimGray;
            }
        }
    }
}
