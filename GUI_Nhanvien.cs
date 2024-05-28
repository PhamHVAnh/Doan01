using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Doan01
{
    public partial class GUI_Nhanvien : Form
    {
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        Nhanvien nv = new Nhanvien();
        public GUI_Nhanvien()
        {
            InitializeComponent();
            dgvNv.CellClick += dgvNv_CellClick;
        }
        void loaddgv()
        {
            DataTable dataTable = bus_nv.getData();
            dgvNv.DataSource = dataTable;
            dgvNv.Columns[0].HeaderText = "Mã nhân viên";
            dgvNv.Columns[1].HeaderText = "Tên nhân viên";
            dgvNv.Columns[2].HeaderText = "Giới tính";
            dgvNv.Columns[3].HeaderText = "Ngày sinh";
            dgvNv.Columns[4].HeaderText = "Địa chỉ";
            dgvNv.Columns[5].HeaderText = "Số điện thoại";
        }

        private void GUI_Nhanvien_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
        private void dgvNv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow =dgvNv.Rows[e.RowIndex];
                txtMnv.Text = selectedRow.Cells["Manv"].Value.ToString();
                txtTnv.Text = selectedRow.Cells["Tennv"].Value.ToString();
                cbGt.Text = selectedRow.Cells["Gioitinhnv"].Value.ToString();
                dtpNs.Value = Convert.ToDateTime(selectedRow.Cells["Ngaysinhnv"].Value);
                txtDc.Text = selectedRow.Cells["Dchinv"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["Sdtnv"].Value.ToString();
                txtMnv.Enabled=false;
            }
        }

        private void ClearTextbox()
        {
            txtMnv.Enabled = true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                else if (c is DateTimePicker)
                {
                    (c as DateTimePicker).Value = DateTime.Now;
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
            if (string.IsNullOrEmpty(txtMnv.Text) || string.IsNullOrEmpty(txtTnv.Text) || string.IsNullOrEmpty(cbGt.Text) || string.IsNullOrEmpty(txtDc.Text) ||string.IsNullOrEmpty(dtpNs.Text)|| string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Sdtnv = txtSdt.Text;
            if (Sdtnv.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nv.Manv = txtMnv.Text;
            nv.Tennv = txtTnv.Text;
            nv.Gioitinhnv = cbGt.Text;
            nv.Ngaysinhnv = dtpNs.Value.ToString("yyyy-MM-dd"); 
            nv.Dchinv = txtDc.Text;
            nv.Sdtnv = txtSdt.Text;

            if (bus_nv.kiemtramatrung(txtMnv.Text) == 1)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_nv.Themnv(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtMnv.Text) || string.IsNullOrEmpty(txtTnv.Text) || string.IsNullOrEmpty(cbGt.Text) || string.IsNullOrEmpty(txtDc.Text) || string.IsNullOrEmpty(dtpNs.Text) || string.IsNullOrEmpty(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string Sdtnv = txtSdt.Text;
            if (Sdtnv.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nv.Manv = txtMnv.Text;
            nv.Tennv = txtTnv.Text;
            nv.Gioitinhnv = cbGt.Text;
            nv.Ngaysinhnv = dtpNs.Value.ToString("yyyy-MM-dd");
            nv.Dchinv = txtDc.Text;
            nv.Sdtnv = txtSdt.Text;

            if (bus_nv.Suanv(nv))
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgv();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv.Manv = txtMnv.Text;
            if (string.IsNullOrEmpty(nv.Manv))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (bus_nv.Xoanv(nv))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                    ClearTextbox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần xóa hoặc nhân viên này đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            nv.Manv = txtTk.Text;
            nv.Tennv = txtTk.Text;

            DataTable result = bus_nv.Timkiem(nv);
            dgvNv.DataSource = result;
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
