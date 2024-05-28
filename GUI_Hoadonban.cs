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
    public partial class GUI_Hoadonban : Form
    {
        BUS_Sanpham bus_sp = new BUS_Sanpham();
        BUS_Khachhang bus_kh = new BUS_Khachhang();
        BUS_Nhanvien bus_nv = new BUS_Nhanvien();
        BUS_Hoadonban bus_hdb = new BUS_Hoadonban();
        BUS_CTHoadonban bus_cthdb = new BUS_CTHoadonban();

        Hoadonban hdb = new Hoadonban();
        ChiTietHDB cthdb = new ChiTietHDB();

        private float Soluongcu;
        public GUI_Hoadonban()
        {
            InitializeComponent();
            dgvHDB.CellClick += dgvHDB_CellClick;
            dgvCTHDB.CellClick += dgvCTHDB_CellClick;
        }
        private void GUI_Hoadonban_Load(object sender, EventArgs e)
        {
            loadcbkh();
            loadcbnv();
            loadcbsp();
            loaddgv();
            txtDg.ReadOnly = true;

        }
        void loaddgv()
        {
            DataTable dataTable = bus_hdb.getData();
            dgvHDB.DataSource = dataTable;
            dgvHDB.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHDB.Columns[1].HeaderText = "Mã nhân viên";
            dgvHDB.Columns[2].HeaderText = "Mã khách hàng";
            dgvHDB.Columns[3].HeaderText = "Ngày bán";
            dgvHDB.Columns[4].HeaderText = "Tổng tiền";


        }
        void loadcbsp()
        {
            cbMsp.DataSource = bus_sp.getData();
            cbMsp.DisplayMember = "Tensp";
            cbMsp.ValueMember = "Masp";
            cbMsp.SelectedIndexChanged += cbMsp_Laysoluong;
        }
        private void UpdateComboBoxData()
        {
            // Lấy dữ liệu mã sản phẩm từ dòng được chọn trong DataGridView dgvCTHDN
            string maSP = dgvCTHDB.CurrentRow.Cells["Masp"].Value.ToString();

            // Cập nhật dữ liệu cho ComboBox cbMsp
            DataTable dt = bus_sp.getData();
            cbMsp.DataSource = dt;
            cbMsp.DisplayMember = "Tensp";
            cbMsp.ValueMember = "Masp";

            // Chọn lại giá trị mã sản phẩm tương ứng trong ComboBox
            cbMsp.SelectedValue = maSP;
        }
        private void cbMsp_Laysoluong(object sender, EventArgs e)
        {
            string ma = cbMsp.SelectedValue?.ToString(); // Kiểm tra giá trị null trước khi chuyển đổi thành chuỗi
            if (!string.IsNullOrEmpty(ma))
            {
                int soluong = bus_cthdb.Laysoluong(ma);
                lblSL.Text = "Số lượng kho: " + soluong.ToString();
                float dongia = bus_cthdb.Laydongia(ma);
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
        void loadcbkh()
        {
            cbMkh.DataSource = bus_kh.getData();
            cbMkh.DisplayMember = "Tenkh";
            cbMkh.ValueMember = "Makh";
        }


        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHDB.Rows[e.RowIndex];
                txtMhdb.Text = selectedRow.Cells["MaHDB"].Value.ToString();
                cbMnv.Text = selectedRow.Cells["Manv"].Value.ToString();
                cbMkh.Text = selectedRow.Cells["Makh"].Value.ToString();
                dtpNB.Text = selectedRow.Cells["Ngayban"].Value.ToString();
                lblTongtien.Text = "Tổng tiền: " + string.Format("{0:#,##0} VND", selectedRow.Cells["Tongtien"].Value);

                txtMhdb.Enabled = false;
                string maHDB = selectedRow.Cells[0].Value.ToString();
                DataTable dtChiTietHDB = bus_cthdb.GetCThdb(maHDB);
                dgvCTHDB.DataSource = dtChiTietHDB;

                dgvCTHDB.Columns[0].HeaderText = "Mã hóa đơn";
                dgvCTHDB.Columns[1].HeaderText = "Mã sản phẩm";
                dgvCTHDB.Columns[2].HeaderText = "Số lượng bán";
                dgvCTHDB.Columns[3].HeaderText = "Đơn giá bán";
                dgvCTHDB.Columns[4].HeaderText = "Giảm giá %";
                dgvCTHDB.Columns[5].HeaderText = "Thành tiền";
            }
        }
        private void dgvCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCTHDB.Rows[e.RowIndex];
                txtMhdb.Text = selectedRow.Cells["MaHDB"].Value.ToString();
                cbMsp.Text = selectedRow.Cells["Masp"].Value.ToString();
                txtSl.Text = selectedRow.Cells["Slban"].Value.ToString();
                txtDg.Text = selectedRow.Cells["DGban"].Value.ToString();
                nudGg.Text = selectedRow.Cells["Giamgia"].Value.ToString();
                lbthanhtien.Text = "Thành tiền: " + string.Format("{0:#,##0} VND", selectedRow.Cells["ThanhTien"].Value);
                TinhTongTienHoaDon();
                int soLuong = bus_cthdb.Laysoluong(cbMsp.Text);
                lblSL.Text = "Số lượng kho: " + soLuong.ToString();
                UpdateComboBoxData();
                if (float.TryParse(selectedRow.Cells["Slban"].Value.ToString(), out float Slban))
                {
                    Soluongcu = Slban;
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
            if (dgvCTHDB != null && dgvCTHDB.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCTHDB.Rows)
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
            txtMhdb.Enabled = true;
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
           
            if (string.IsNullOrEmpty(txtMhdb.Text) || string.IsNullOrEmpty(cbMnv.Text) || string.IsNullOrEmpty(dtpNB.Text) || string.IsNullOrEmpty(cbMkh.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            hdb.MaHDB = txtMhdb.Text;
            hdb.Manv = cbMnv.SelectedValue.ToString();
            hdb.Makh = cbMkh.SelectedValue.ToString();
            hdb.Ngayban = string.Format("{0}/{1}/{2}", dtpNB.Value.Year, dtpNB.Value.Month, dtpNB.Value.Day);
            hdb.Tongtien = 0;

            if (bus_hdb.kiemtramatrung(txtMhdb.Text) == 1)
            {
                MessageBox.Show("Mã đã hoá đơn đã tồn tại, vui lòng nhập lại mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (bus_hdb.Themhdb(hdb) == true)
                {

                    MessageBox.Show("Thêm hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhdb.Text) || string.IsNullOrEmpty(cbMnv.Text) || string.IsNullOrEmpty(dtpNB.Text) || string.IsNullOrEmpty(cbMkh.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            hdb.MaHDB = txtMhdb.Text;
            hdb.Manv = cbMnv.SelectedValue.ToString();
            hdb.Makh = cbMkh.SelectedValue.ToString();
            hdb.Ngayban = string.Format("{0}/{1}/{2}", dtpNB.Value.Year, dtpNB.Value.Month, dtpNB.Value.Day);
            hdb.Tongtien = 0;
            if (bus_hdb.Suahdb(hdb) == true)
            {
                MessageBox.Show("Hoá đơn đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgv();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hdb.MaHDB = txtMhdb.Text;
            if (string.IsNullOrEmpty(hdb.MaHDB))
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult x = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    if (bus_hdb.Xoahdb(hdb))
                    {
                        MessageBox.Show("Hoá đơn đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCTHDB.DataSource = null;
                        dgvCTHDB.Rows.Clear();
                        dgvCTHDB.Columns.Clear();
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
            if (string.IsNullOrEmpty(txtMhdb.Text) || (string.IsNullOrEmpty(cbMsp.Text) || string.IsNullOrEmpty(txtSl.Text) || string.IsNullOrEmpty(txtDg.Text) || string.IsNullOrEmpty(nudGg.Text) || string.IsNullOrEmpty(lbthanhtien.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHDB = txtMhdb.Text;
            cthdb.MaHDB = maHDB;
            cthdb.Masp = cbMsp.SelectedValue.ToString();
            cthdb.Slban = float.Parse(txtSl.Text);
            cthdb.DGban = float.Parse(txtDg.Text);
            cthdb.Giamgia = float.Parse(nudGg.Text);
            cthdb.ThanhTien = cthdb.Slban * cthdb.DGban * (1 - cthdb.Giamgia / 100);

            int soLuongKho = bus_cthdb.Laysoluong(cbMsp.SelectedValue.ToString());
            int soLuongBan = int.Parse(txtSl.Text);
            if (soLuongBan > soLuongKho)
            {
                MessageBox.Show("Số lượng kho không đủ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bus_cthdb.ThemCThdb(cthdb))
            {
               
                bus_cthdb.Capnhatsl(cthdb.Masp, cthdb.Slban); 
                MessageBox.Show("Thêm chi tiết thông tin hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dtChiTietHDB = bus_cthdb.GetCThdb(maHDB);
                dgvCTHDB.DataSource = dtChiTietHDB;
                TinhTongTienHoaDon();
                loaddgv();
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhdb.Text) || (string.IsNullOrEmpty(cbMsp.Text) || string.IsNullOrEmpty(txtSl.Text) || string.IsNullOrEmpty(txtDg.Text) || string.IsNullOrEmpty(nudGg.Text) || string.IsNullOrEmpty(lbthanhtien.Text)))
            {
                MessageBox.Show("Vui chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soLuongKho = bus_cthdb.Laysoluong(cbMsp.SelectedValue.ToString());
            int soLuongBan = int.Parse(txtSl.Text);
            if (soLuongBan > soLuongKho)
            {
                MessageBox.Show("Số lượng kho không đủ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maHDB = txtMhdb.Text;
            cthdb.MaHDB = maHDB;
            cthdb.Masp = cbMsp.SelectedValue.ToString();
            float soLuongMoi = float.Parse(txtSl.Text);
            cthdb.Slban = soLuongMoi;
            cthdb.DGban = float.Parse(txtDg.Text);
            cthdb.Giamgia = float.Parse(nudGg.Text);
            cthdb.ThanhTien = cthdb.Slban * cthdb.DGban * (1 - cthdb.Giamgia / 100);

            if (bus_cthdb.SuaCThdb(cthdb))
            {
                float soLuongCapNhat = soLuongMoi - Soluongcu;
                bus_cthdb.Capnhatsl(cthdb.Masp, soLuongCapNhat);

                MessageBox.Show("Cập nhật chi tiết hoá đơn thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable dtChiTietHDB = bus_cthdb.GetCThdb(maHDB);
                dgvCTHDB.DataSource = dtChiTietHDB;
                TinhTongTienHoaDon();
                loaddgv();

            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string maHDB = txtMhdb.Text;
            cthdb.MaHDB = maHDB;
            string maSP=cbMsp.SelectedValue.ToString();
            hdb.MaHDB = txtMhdb.Text;
            if (string.IsNullOrEmpty(hdb.MaHDB))
            {
                MessageBox.Show("Vui lòng chọn thông tin muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult x = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    if (bus_cthdb.XoaCThdb(maHDB,maSP))
                    {
                        float soLuongBan = float.Parse(txtSl.Text);
                        bus_cthdb.Capnhatsl(maSP, -soLuongBan);

                        MessageBox.Show("Chi tiết hoá đơn đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dtChiTietHDB = bus_cthdb.GetCThdb(maHDB);
                        dgvCTHDB.DataSource = dtChiTietHDB;
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
            hdb.MaHDB = txtTk.Text;
            DataTable result = bus_hdb.Timkiem(hdb);
            dgvHDB.DataSource = result;
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMhdb.Text))
            {
                XuatHDB formHDB = new XuatHDB(txtMhdb.Text);
                formHDB.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
