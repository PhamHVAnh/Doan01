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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Doan01
{
    public partial class GUI_Sanpham : Form
    {
        BUS_Sanpham bus_sp = new BUS_Sanpham();
        BUS_Loaisp bus_loaisp = new BUS_Loaisp();

        Sanpham sp = new Sanpham();
        public GUI_Sanpham()
        {
            InitializeComponent();
            dgvSp.CellClick += dgvSp_CellClick;
        }
        void loaddgv()
        {
            DataTable dataTable = bus_sp.getData();
            dgvSp.DataSource = dataTable;
            dgvSp.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSp.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSp.Columns[2].HeaderText = "Số lượng";
            dgvSp.Columns[3].HeaderText = "Mã loại hàng";
            dgvSp.Columns[4].HeaderText = "Ghi chú";
            dgvSp.Columns[5].HeaderText = "Đơn giá";
        }
        void loadcb()
        {
            cbMlh.DataSource = bus_loaisp.getData();
            cbMlh.DisplayMember = "Tenlh";
            cbMlh.ValueMember = "Malh";
        }

        private void GUI_Sanpham_Load(object sender, EventArgs e)
        {
            loaddgv();
            loadcb();
        }
        private void dgvSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSp.Rows[e.RowIndex];
                txtMsp.Text = selectedRow.Cells["Masp"].Value.ToString();
                txtTsp.Text = selectedRow.Cells["Tensp"].Value.ToString();
                txtSl.Text = selectedRow.Cells["Soluong"].Value.ToString();
                cbMlh.Text= selectedRow.Cells["Malh"].Value.ToString();
                txtGc.Text = selectedRow.Cells["Ghichu"].Value.ToString();
                txtDg.Text = selectedRow.Cells["Dongia"].Value.ToString();
                txtMsp.Enabled=false;
            }
        }

        private void ClearTextbox()
        {
            txtMsp.Enabled = true;
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
            if (string.IsNullOrEmpty(txtMsp.Text) || string.IsNullOrEmpty(txtTsp.Text) || string.IsNullOrEmpty(txtSl.Text) || string.IsNullOrEmpty(cbMlh.Text) || string.IsNullOrEmpty(txtDg.Text) || string.IsNullOrEmpty(txtGc.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sp.Masp = txtMsp.Text;
            sp.Tensp = txtTsp.Text;
            sp.Soluong = int.Parse(txtSl.Text);
            sp.Malh = cbMlh.SelectedValue.ToString();
            sp.Ghichu = txtGc.Text;
            sp.Dongia = float.Parse(txtDg.Text);

            if (bus_sp.kiemtramatrung(txtMsp.Text) == 1)
            {
                MessageBox.Show("Mã đã sản phẩm đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_sp.Themsp(sp) == true)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                }
            }
        }
        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (char.IsDigit(e.KeyChar) && txtDg.Text.Length == 0)
            {
                if (txtSl.Text.Length == 0 && e.KeyChar == '0')
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng nhập số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtDg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (char.IsDigit(e.KeyChar) && txtDg.Text.Length == 0)
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                    MessageBox.Show("Vui lòng nhập số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMsp.Text) || string.IsNullOrEmpty(txtTsp.Text) || string.IsNullOrEmpty(txtSl.Text) || string.IsNullOrEmpty(cbMlh.Text) || string.IsNullOrEmpty(txtDg.Text) || string.IsNullOrEmpty(txtGc.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sp.Masp = txtMsp.Text;
            sp.Tensp = txtTsp.Text;
            sp.Soluong = int.Parse(txtSl.Text);
            sp.Malh = cbMlh.SelectedValue.ToString();
            sp.Ghichu = txtGc.Text;
            sp.Dongia = float.Parse(txtDg.Text);
            
            {
                if (bus_sp.Suasp(sp) == true)
                {
                    MessageBox.Show("Bản ghi đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sp.Masp = txtMsp.Text;
            if (string.IsNullOrEmpty(sp.Masp))
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult x = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    if (bus_sp.Xoasp(sp))
                    {
                        MessageBox.Show("Bản ghi đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddgv();
                        ClearTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Bản ghi không tồn tại hoặc đã bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            sp.Masp = txtTk.Text;
            sp.Tensp = txtTk.Text;
            DataTable result = bus_sp.Timkiem(sp);
            dgvSp.DataSource = result;
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
