using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan01
{
    public partial class GUI_Nhacungcap : Form
    {
        BUS_Nhacungcap bus_ncc = new BUS_Nhacungcap();
        Nhacungcap ncc = new Nhacungcap();
        public GUI_Nhacungcap()
        {
            InitializeComponent();
            dgvNcc.CellClick += dgvNcc_CellClick;
        }
        void loaddgv()
        {
            DataTable dataTable = bus_ncc.getData();
            dgvNcc.DataSource = dataTable;
            dgvNcc.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNcc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNcc.Columns[2].HeaderText = "Số điện thoại";
            dgvNcc.Columns[3].HeaderText = "Địa chỉ";
        }

        private void GUI_Nhacungcap_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
        private void dgvNcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNcc.Rows[e.RowIndex];
                txtMncc.Text = selectedRow.Cells["Mancc"].Value.ToString();
                txtTncc.Text = selectedRow.Cells["Tenncc"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["Sdtncc"].Value.ToString();
                txtDchi.Text = selectedRow.Cells["Dchincc"].Value.ToString();
                txtMncc.Enabled = false;
            }
        }
        private void ClearTextbox()
        {
            txtMncc.Enabled = true;
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
            loaddgv();
            ClearTextbox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMncc.Text) || string.IsNullOrEmpty(txtTncc.Text) || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDchi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Sdtncc = txtSdt.Text;
            if (Sdtncc.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ncc.Mancc = txtMncc.Text;
            ncc.Tenncc = txtTncc.Text;
            ncc.Sdtncc = txtSdt.Text;
            ncc.Dchincc = txtDchi.Text;

            if (bus_ncc.kiemtramatrung(txtMncc.Text) == 1)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bus_ncc.Themncc(ncc))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMncc.Text) || string.IsNullOrEmpty(txtTncc.Text) || string.IsNullOrEmpty(txtSdt.Text) || string.IsNullOrEmpty(txtDchi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string Sdtncc = txtSdt.Text;
            if (Sdtncc.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ncc.Mancc = txtMncc.Text;
            ncc.Tenncc = txtTncc.Text;
            ncc.Sdtncc = txtSdt.Text;
            ncc.Dchincc = txtDchi.Text;

            if (bus_ncc.Suancc(ncc))
            {
                MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgv();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ncc.Mancc = txtMncc.Text;
            if (string.IsNullOrEmpty(ncc.Mancc))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (bus_ncc.Xoancc(ncc))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loaddgv();
                    ClearTextbox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp cần xóa hoặc nhà cung cấp này đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ncc.Mancc = txtTk.Text;
            ncc.Tenncc = txtTk.Text;

            DataTable result = bus_ncc.Timkiem(ncc);
            dgvNcc.DataSource = result;
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
