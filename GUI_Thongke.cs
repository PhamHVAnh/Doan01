using BUS;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Doan01
{
    public partial class GUI_Thongke : Form
    {
        BUS_Thongke bus_tk = new BUS_Thongke();

        public GUI_Thongke()
        {
            InitializeComponent();
        }

        private void GUI_Thongke_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void LoadData()
        {
            DateTime fromDate = dtpC1.Value;
            DateTime toDate = dtpC2.Value;

            DataTable topBanchay = bus_tk.Topbanchay(fromDate, toDate);

            Hiendulieu(topBanchay);
        }

        private void Hiendulieu(DataTable dt)
        {
            // Clear existing series and points
            chartCot.Series.Clear();
            chartTron.Series.Clear();

            // Create a new series for column chart if it doesn't exist
            Series seriesCot = new Series("Doanh thu") { ChartType = SeriesChartType.Column };
            chartCot.Series.Add(seriesCot);

            // Create a new series for pie chart if it doesn't exist
            Series seriesSPDaBan = new Series("Số sản phẩm đã bán") { ChartType = SeriesChartType.Pie };
            chartTron.Series.Add(seriesSPDaBan);

            decimal tongDoanhThu = 0;
            int tongSoSanPham = 0;

            foreach (DataRow row in dt.Rows)
            {
                string tenSanPham = row["Tensp"].ToString();
                int soLuongBan = Convert.ToInt32(row["SoLuongBan"]);
                DateTime ngayBan = Convert.ToDateTime(row["Ngayban"]);
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);

                // Add points to the column chart series
                seriesCot.Points.AddXY(ngayBan.ToString("dd/MM/yyyy"), doanhThu);

                tongDoanhThu += doanhThu;
                tongSoSanPham += soLuongBan;
            }

            foreach (DataRow row in dt.Rows)
            {
                string tenSanPham = row["Tensp"].ToString();
                int soLuongBan = Convert.ToInt32(row["SoLuongBan"]);

                // Add points to the pie chart series
                DataPoint dp = new DataPoint();
                dp.AxisLabel = soLuongBan.ToString();
                dp.YValues = new double[] { soLuongBan };
                dp.LegendText = tenSanPham;

                // Calculate the percentage
                double percentage = (double)soLuongBan / tongSoSanPham * 100;
                dp.Label = string.Format("{0:0.00}%", percentage);

                seriesSPDaBan.Points.Add(dp);
            }

            lblDoanhThu.Text = string.Format("{0:#,##0} VND", tongDoanhThu);
            lblBanra.Text = tongSoSanPham.ToString();

            LoadThongtin();
        }


        private void LoadThongtin()
        {
            dgvThongke.Columns.Clear();
            dgvThongke.Columns.Add("Masp", "Mã sản phẩm");
            dgvThongke.Columns.Add("Tensp", "Tên sản phẩm");
            dgvThongke.Columns.Add("Soluong", "Số lượng");
            dgvThongke.Columns.Add("Dongia", "Đơn giá");

            foreach (DataPoint dp in chartTron.Series["Số sản phẩm đã bán"].Points)
            {
                string tenSanPham = dp.LegendText;

                DataRow sp = bus_tk.Tensanpham(tenSanPham);

                if (sp != null)
                {
                    string maSP = sp["Masp"].ToString();
                    string tenSP = sp["Tensp"].ToString();
                    int soLuong = Convert.ToInt32(sp["Soluong"]);
                    decimal donGia = Convert.ToDecimal(sp["Dongia"]);

                    dgvThongke.Rows.Add(maSP, tenSP, soLuong, donGia);
                }
            }
        }

        private void btnTke_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpC1.Value;
            DateTime toDate = dtpC2.Value;

            DataTable topBanchay = bus_tk.Topbanchay(fromDate, toDate);
            if (topBanchay != null && topBanchay.Rows.Count > 0)
            {
                Hiendulieu(topBanchay);
            }
            else
            {
                // Nếu không có dữ liệu, hiển thị thông báo
                chartCot.Series.Clear();
                chartTron.Series.Clear();
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblBanra_Click(object sender, EventArgs e)
        {

        }
    }
}
