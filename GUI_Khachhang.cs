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

namespace Doan01
{
    public partial class GUI_Khachhang : Form
    {
        BUS_Khachhang bus_kh=new BUS_Khachhang();
        Khachhang kh=new Khachhang();
        public GUI_Khachhang()
        {
            InitializeComponent();
            dgvKh.CellClick += dgvKh_CellClick;
            
        }
        void loaddgv()
        {
            DataTable dataTable = bus_kh.getData();
            dgvKh.DataSource = dataTable;
            dgvKh.Columns[0].HeaderText = "Mã khách hàng";
            dgvKh.Columns[1].HeaderText = "Tên khách hàng";
            dgvKh.Columns[2].HeaderText = "Số điện thoại";
            dgvKh.Columns[3].HeaderText = "Địa chỉ";
        }

        private void GUI_Khachhang_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
        private void dgvKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvKh.Rows[e.RowIndex];
                txtMkh.Text = selectedRow.Cells["Makh"].Value.ToString();
                txtTkh.Text = selectedRow.Cells["Tenkh"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["Sdtkh"].Value.ToString();
                txtDchi.Text = selectedRow.Cells["Dchikh"].Value.ToString();
                txtMkh.Enabled = false;
            }
        }
        private void ClearTextbox()
        {
            txtMkh.Enabled=true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
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
            if (string.IsNullOrEmpty(txtMkh.Text) || string.IsNullOrEmpty(txtTkh.Text) || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDchi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Sdtkh = txtSdt.Text;
            if (Sdtkh.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            kh.Makh= txtMkh.Text;
            kh.Tenkh = txtTkh.Text;
            kh.Sdtkh = txtSdt.Text;
            kh.Dchikh = txtDchi.Text;

            if (bus_kh.kiemtramatrung(txtMkh.Text) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_kh.Themkh(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextbox();
                    loaddgv();
                }
            }
        }
        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(txtMkh.Text) || string.IsNullOrEmpty(txtTkh.Text) || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDchi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string Sdtkh = txtSdt.Text;
            if (Sdtkh.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            kh.Makh = txtMkh.Text;
            kh.Tenkh = txtTkh.Text;
            kh.Sdtkh = txtSdt.Text;
            kh.Dchikh = txtDchi.Text;
            if (bus_kh.Suakh(kh)==true)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextbox();
                loaddgv();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kh.Makh = txtMkh.Text;
            
            if (string.IsNullOrEmpty(kh.Makh))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (bus_kh.Xoakh(kh))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddgv();
                        ClearTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp cần xóa hoặc nhà cung cấp này đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            kh.Makh = txtTk.Text;
            kh.Tenkh = txtTk.Text;

            DataTable result = bus_kh.Timkiem(kh);
            dgvKh.DataSource = result;
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
