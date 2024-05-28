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
    public partial class GUI_Loaisp : Form
    {
        BUS_Loaisp bus_loaisp = new BUS_Loaisp();

        Loaihang lh = new Loaihang();
        public GUI_Loaisp()
        {
            InitializeComponent();
            dgvLsp.CellClick += dgvLsp_CellClick;
        }

        private void GUI_Loaisp_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
        void loaddgv()
        {
            dgvLsp.DataSource = bus_loaisp.getData();
            dgvLsp.Columns[0].HeaderText = "Mã loại SP";
            dgvLsp.Columns[1].HeaderText = "Tên loại SP";
        }
        private void dgvLsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvLsp.Rows[e.RowIndex];

                txtMl.Text = selectedRow.Cells[0].Value.ToString();
                txtTl.Text = selectedRow.Cells[1].Value.ToString();
                txtMl.Enabled = false;
            }
        }

        private void ClearTextbox()
        {
            txtMl.Enabled = true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                if (c is ComboBox)
                {
                    (c as ComboBox).Text = "";
                }
            }
        }





        private void btnLm_Click_1(object sender, EventArgs e)
        {
            txtTk.Text = "";
            ClearTextbox();
            loaddgv();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMl.Text) || string.IsNullOrEmpty(txtTl.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lh.Malh = txtMl.Text;
            lh.Tenlh = txtTl.Text;

            if (bus_loaisp.kiemtramatrung(txtMl.Text) == 1)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_loaisp.Themlh(lh) == true)
                {
                    MessageBox.Show("Thêm bản ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                    ClearTextbox();
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            lh.Malh = txtMl.Text;
            lh.Tenlh = txtTl.Text;
            if (string.IsNullOrEmpty(lh.Malh) || string.IsNullOrEmpty(lh.Tenlh))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bus_loaisp.Sualh(lh) == true)
                {
                    MessageBox.Show("Bản ghi đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                    ClearTextbox();
                }

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            lh.Malh = txtMl.Text;
            if (string.IsNullOrEmpty(lh.Malh))
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult x = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {

                    if (bus_loaisp.Xoalh(lh))
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
        private void btnTkiem_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTk.Text) || txtTk.Text == "Nhập tên hoặc mã")
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            lh.Malh = txtTk.Text;
            lh.Tenlh = txtTk.Text;
            DataTable result = bus_loaisp.Timkiem(lh);
            dgvLsp.DataSource = result;
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
