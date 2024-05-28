using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Doan01
{
    public partial class GUI_Hoadonnhap : Form
    {
        BUS_Sanpham bus_sp = new BUS_Sanpham();
        BUS_Nhacungcap bus_ncc = new BUS_Nhacungcap();
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        BUS_Hoadonnhap bus_hdn = new BUS_Hoadonnhap();
        BUS_CTHoadonnhap bus_cthdn = new BUS_CTHoadonnhap();

        Hoadonnhap hdn = new Hoadonnhap();
        ChiTietHDN cthdn = new ChiTietHDN();

        private float Soluongcu;
        public GUI_Hoadonnhap()
        {
            InitializeComponent();
            dgvHDN.CellClick += dgvHDN_CellClick;
            dgvCTHDN.CellClick += dgvCTHDN_CellClick;
        }
        private void GUI_Hoadonnhap_Load(object sender, EventArgs e)
        {
            loadcbncc();
            loadcbnv();
            loadcbsp();
            loaddgv();
            txtDg.ReadOnly = true;

        }
        void loaddgv()
        {
            DataTable dataTable = bus_hdn.getData();
            dgvHDN.DataSource = dataTable;
            dgvHDN.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDN.Columns[1].HeaderText = "Mã nhân viên";
            dgvHDN.Columns[2].HeaderText = "Mã nhà cung cấp";
            dgvHDN.Columns[3].HeaderText = "Ngày nhập";
            dgvHDN.Columns[4].HeaderText = "Tổng tiền";
        }
        private void UpdateComboBoxData()
        {
            // Lấy dữ liệu mã sản phẩm từ dòng được chọn trong DataGridView dgvCTHDN
            string maSP = dgvCTHDN.CurrentRow.Cells["Masp"].Value.ToString();

            // Cập nhật dữ liệu cho ComboBox cbMsp
            DataTable dt = bus_sp.getData();
            cbMsp.DataSource = dt;
            cbMsp.DisplayMember = "Tensp";
            cbMsp.ValueMember = "Masp";

            // Chọn lại giá trị mã sản phẩm tương ứng trong ComboBox
            cbMsp.SelectedValue = maSP;
        }

        void loadcbsp()
        {
            cbMsp.DataSource = bus_sp.getData();
            cbMsp.DisplayMember = "Tensp";
            cbMsp.ValueMember = "Masp";
            cbMsp.SelectedIndexChanged += cbMsp_Laysoluong;
        }
        private void cbMsp_Laysoluong(object sender, EventArgs e)
        {
            string ma = cbMsp.SelectedValue?.ToString(); // Kiểm tra giá trị null trước khi chuyển đổi thành chuỗi
            if (!string.IsNullOrEmpty(ma))
            {
                int soluong = bus_cthdn.Laysoluong(ma);
                lblSL.Text = "Số lượng kho: " + soluong.ToString();
                float dongia = bus_cthdn.Laydongia(ma);
                txtDg.Text = dongia.ToString();
            }
            else
            {
                lblSL.Text = "Số lượng kho: 0";
                txtDg.Text = "";
            }
        }


        void loadcbnv()
        {
            cbMnv.DataSource = bus_nv.getData();
            cbMnv.DisplayMember = "Tennv";
            cbMnv.ValueMember = "Manv";
        }
        void loadcbncc()
        {
            cbMncc.DataSource = bus_ncc.getData();
            cbMncc.DisplayMember = "Tenncc";
            cbMncc.ValueMember = "Mancc";
        }


        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHDN.Rows[e.RowIndex];
                txtMhdn.Text = selectedRow.Cells["MaHDN"].Value.ToString();
                cbMnv.Text = selectedRow.Cells["Manv"].Value.ToString();
                cbMncc.Text = selectedRow.Cells["Mancc"].Value.ToString();
                dtpNN.Text = selectedRow.Cells["Ngaynhap"].Value.ToString();
                lblTongtien.Text = "Tổng tiền: " + string.Format("{0:#,##0} VND", selectedRow.Cells["Tongtien"].Value);

                txtMhdn.Enabled = false;
                string maHDN = selectedRow.Cells[0].Value.ToString();
                DataTable dtChiTietHDN = bus_cthdn.GetCThdn(maHDN);

                dgvCTHDN.DataSource = dtChiTietHDN;

                dgvCTHDN.Columns["MaHDN"].HeaderText = "Mã hóa đơn";
                dgvCTHDN.Columns["Masp"].HeaderText = "Mã sản phẩm";
                dgvCTHDN.Columns["Slnhap"].HeaderText = "Số lượng nhập";
                dgvCTHDN.Columns["DGnhap"].HeaderText = "Đơn giá nhập";
                dgvCTHDN.Columns["Giamgia"].HeaderText = "Giảm giá %";
                dgvCTHDN.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }
        }
        private void dgvCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCTHDN.Rows[e.RowIndex];
                txtMhdn.Text = selectedRow.Cells["MaHDN"].Value.ToString();
                cbMsp.Text = selectedRow.Cells["Masp"].Value.ToString();
                txtSl.Text = selectedRow.Cells["Slnhap"].Value.ToString();
                txtDg.Text = selectedRow.Cells["DGnhap"].Value.ToString();
                nudGg.Text = selectedRow.Cells["Giamgia"].Value.ToString();
                lbthanhtien.Text = "Thành tiền: " + string.Format("{0:#,##0} VND", selectedRow.Cells["ThanhTien"].Value);
                TinhTongTienHoaDon();
                int soLuong = bus_cthdn.Laysoluong(cbMsp.Text);
                lblSL.Text = "Số lượng kho: " + soLuong.ToString();
                UpdateComboBoxData();
                if (float.TryParse(selectedRow.Cells["Slnhap"].Value.ToString(), out float slNhap))
                {
                    Soluongcu = slNhap;
                }
                else
                {
                    Soluongcu = 0;
                }
            }
        }
        private void TinhTongTienHoaDon()
        {
            float Tongtien = 0;
            if (dgvCTHDN != null && dgvCTHDN.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCTHDN.Rows)
                {
                    if (row.Cells[5] != null && row.Cells[5].Value != null)
                    {
                        float Thanhtien;
                        if (float.TryParse(row.Cells[5].Value.ToString(), out Thanhtien))
                        {
                            Tongtien += Thanhtien;
                        }
                    }
                }
            }
            lblTongtien.Text = "Tổng tiền: " + string.Format("{0:#,##0} VND", Tongtien);
        }
        private void ClearTextbox()
        {
            txtMhdn.Enabled = true;
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
            foreach (Control c in groupBox2.Controls)
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
        private void txtDg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void nudGg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhdn.Text) || string.IsNullOrEmpty(cbMnv.Text) || string.IsNullOrEmpty(dtpNN.Text) || string.IsNullOrEmpty(cbMncc.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hdn.MaHDN = txtMhdn.Text;
            hdn.Manv = cbMnv.SelectedValue.ToString();
            hdn.Mancc = cbMncc.SelectedValue.ToString();
            hdn.Ngaynhap = string.Format("{0}/{1}/{2}", dtpNN.Value.Year, dtpNN.Value.Month, dtpNN.Value.Day);
            hdn.Tongtien = 0;

            if (bus_hdn.kiemtramatrung(txtMhdn.Text) == 1)
            {
                MessageBox.Show("Mã đã hoá đơn đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bus_hdn.Themhdn(hdn) == true)
                {

                    MessageBox.Show("Thêm hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhdn.Text) || string.IsNullOrEmpty(cbMnv.Text) || string.IsNullOrEmpty(dtpNN.Text) || string.IsNullOrEmpty(cbMncc.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hdn.MaHDN = txtMhdn.Text;
            hdn.Manv = cbMnv.SelectedValue.ToString();
            hdn.Mancc = cbMncc.SelectedValue.ToString();
            hdn.Ngaynhap = string.Format("{0}/{1}/{2}", dtpNN.Value.Year, dtpNN.Value.Month, dtpNN.Value.Day);
            hdn.Tongtien = 0;
            if (bus_hdn.Suahdn(hdn) == true)
            {
                MessageBox.Show("Hoá đơn đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgv();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hdn.MaHDN = txtMhdn.Text;
            if (string.IsNullOrEmpty(hdn.MaHDN))
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult x = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    if (bus_hdn.Xoahdn(hdn))
                    {
                        MessageBox.Show("Hoá đơn đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCTHDN.DataSource = null;
                        dgvCTHDN.Rows.Clear();
                        dgvCTHDN.Columns.Clear();
                        loaddgv();
                        ClearTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Hoá đơn không tồn tại hoặc đã bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng xóa thông tin chi tiết hóa đơn! .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLm_Click(object sender, EventArgs e)
        {
            txtTk.Text = "";
            ClearTextbox();
            loaddgv();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhdn.Text) || (string.IsNullOrEmpty(cbMsp.Text) || string.IsNullOrEmpty(txtSl.Text) || string.IsNullOrEmpty(txtDg.Text) || string.IsNullOrEmpty(nudGg.Text) || string.IsNullOrEmpty(lbthanhtien.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHDN = txtMhdn.Text;
            cthdn.MaHDN = maHDN;
            cthdn.Masp = cbMsp.SelectedValue.ToString();
            cthdn.Slnhap = float.Parse(txtSl.Text);
            cthdn.DGnhap = float.Parse(txtDg.Text);
            cthdn.Giamgia = float.Parse(nudGg.Text);
            cthdn.ThanhTien = cthdn.Slnhap * cthdn.DGnhap * (1 - cthdn.Giamgia / 100);

            if (bus_cthdn.ThemCThdn(cthdn))
            {
                
                bus_cthdn.Capnhatsl(cthdn.Masp, cthdn.Slnhap); // Update stock
                MessageBox.Show("Thêm chi tiết thông tin hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dtChiTietHDN = bus_cthdn.GetCThdn(maHDN);
                dgvCTHDN.DataSource = dtChiTietHDN;
                TinhTongTienHoaDon();
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhdn.Text) || (string.IsNullOrEmpty(cbMsp.Text) || string.IsNullOrEmpty(txtSl.Text) || string.IsNullOrEmpty(nudGg.Text) || string.IsNullOrEmpty(lbthanhtien.Text)))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHDN = txtMhdn.Text;
            cthdn.MaHDN = maHDN;
            cthdn.Masp = cbMsp.SelectedValue.ToString();
            float soLuongMoi = float.Parse(txtSl.Text);
            cthdn.DGnhap = float.Parse(txtDg.Text);
            cthdn.Slnhap = soLuongMoi;
            cthdn.Giamgia = float.Parse(nudGg.Text);
            cthdn.ThanhTien = cthdn.Slnhap * cthdn.DGnhap * (1 - cthdn.Giamgia / 100);

            if (bus_cthdn.SuaCThdn(cthdn))
            {
                // Tính toán lại số lượng kho
                float soLuongCapNhat = soLuongMoi - Soluongcu;
                bus_cthdn.Capnhatsl(cthdn.Masp, soLuongCapNhat);

                MessageBox.Show("Cập nhật chi tiết hoá đơn thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dtChiTietHDN = bus_cthdn.GetCThdn(maHDN);
                dgvCTHDN.DataSource = dtChiTietHDN;
                TinhTongTienHoaDon();
            }
        }


        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string maHDN = txtMhdn.Text;
            cthdn.MaHDN = maHDN;
            string maSP = cbMsp.SelectedValue.ToString();
            hdn.MaHDN = txtMhdn.Text;
            if (string.IsNullOrEmpty(hdn.MaHDN))
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult x = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    if (bus_cthdn.XoaCThdn(maHDN,maSP))
                    {
                        float soLuongcu = float.Parse(txtSl.Text);
                        bus_cthdn.Capnhatsl(maSP, -soLuongcu);

                        MessageBox.Show("Chi tiết hoá đơn đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dtChiTietHDN = bus_cthdn.GetCThdn(maHDN);
                        dgvCTHDN.DataSource = dtChiTietHDN;
                        ClearTextbox();
                        loaddgv();
                    }
                    else
                    {
                        MessageBox.Show("Chi tiết hoá đơn không tồn tại hoặc đã bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
        private void btnTkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTk.Text) || txtTk.Text == "Nhập mã hoá đơn")
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            hdn.MaHDN = txtTk.Text;
            DataTable result = bus_hdn.Timkiem(hdn);
            dgvHDN.DataSource = result;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            if (txtTk.Text == "Nhập mã hoá đơn")
            {
                txtTk.Text = "";
                txtTk.ForeColor = Color.Black;
            }
        }

        private void txtTk_Leave(object sender, EventArgs e)
        {
            if (txtTk.Text == "")
            {
                txtTk.Text = "Nhập mã hoá đơn";
                txtTk.ForeColor = Color.DimGray;
            }
        }

        private void btnXhd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMhdn.Text))
            {
                 XuatHDN formHDN = new XuatHDN(txtMhdn.Text);
                formHDN.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

