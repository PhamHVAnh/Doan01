using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Doan01
{
    public partial class XuatHDN : Form
    {
        private string maHDN;
        BUS_CTHoadonnhap bus_cthd = new BUS_CTHoadonnhap();
        BUS_Hoadonnhap bus_hdn = new BUS_Hoadonnhap();
        public XuatHDN(string maHDN)
        {
            InitializeComponent();
            this.maHDN = maHDN;
            this.Size = new System.Drawing.Size(600,700);
        }

        private void XuatHDN_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "Doan01.HDN.rdlc";

                DataTable hdnData = bus_hdn.getData().AsEnumerable()
                    .Where(row => row.Field<string>("MaHDN") == maHDN)
                    .CopyToDataTable();

                DataTable cthdData = bus_cthd.getData().AsEnumerable()
                    .Where(row => row.Field<string>("MaHDN") == maHDN)
                    .CopyToDataTable();

                double tongTien = 0;
                foreach (DataRow cthdRow in cthdData.Rows)
                {
                    string maSP = cthdRow.Field<string>("Masp");
                    string tenSP = bus_cthd.GetTenSP(maSP);

                    cthdRow.SetField("Masp", tenSP);
                    tongTien += cthdRow.Field<double>("Thanhtien");
                }

                string tenNCC = "";
                string tenNV = "";
                DateTime ngayNhap = DateTime.MinValue;


                if (hdnData.Rows.Count > 0)
                {
                    DataRow hdnRow = hdnData.Rows[0];

                    string maNCC = hdnRow.Field<string>("Mancc");
                    tenNCC = bus_hdn.GetTenNCC(maNCC);
                    hdnRow.SetField("Mancc", tenNCC);

                    string maNV = hdnRow.Field<string>("Manv");
                    tenNV = bus_hdn.GetTenNV(maNV);
                    hdnRow.SetField("Manv", tenNV);

                    ngayNhap = hdnRow.Field<DateTime>("Ngaynhap");

                }

                ReportDataSource reportDataSource1 = new ReportDataSource();
                reportDataSource1.Name = "DSnhap";
                reportDataSource1.Value = hdnData;

                ReportDataSource reportDataSource2 = new ReportDataSource();
                reportDataSource2.Name = "DSnhapCT";
                reportDataSource2.Value = cthdData;

                ReportParameter reportParameter5 = new ReportParameter("MaHDN", maHDN);
                ReportParameter reportParameter1 = new ReportParameter("tenNCC", tenNCC);
                ReportParameter reportParameter2 = new ReportParameter("tenNV", tenNV);
                ReportParameter reportParameter3 = new ReportParameter("Ngaynhap", ngayNhap.ToString("dd/MM/yyyy"));
                ReportParameter reportParameter4 = new ReportParameter("Tongtien", tongTien.ToString());

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
            reportParameter1, reportParameter2, reportParameter3, reportParameter4, reportParameter5 });

                reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
