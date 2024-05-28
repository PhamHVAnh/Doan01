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
    public partial class XuatHDB : Form
    {
        private string maHDB;
        BUS_CTHoadonban bus_cthdb = new BUS_CTHoadonban();
        BUS_Hoadonban bus_hdb = new BUS_Hoadonban();
        public XuatHDB(string maHDB)
        {
            InitializeComponent();
            this.maHDB = maHDB;
            this.Size = new System.Drawing.Size(600, 700);
        }

        private void XuatHDB_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "Doan01.HDB.rdlc";

                DataTable hdbData = bus_hdb.getData().AsEnumerable()
                    .Where(row => row.Field<string>("MaHDB") == maHDB)
                    .CopyToDataTable();

                DataTable cthdData = bus_cthdb.getData().AsEnumerable()
                    .Where(row => row.Field<string>("MaHDB") == maHDB)
                    .CopyToDataTable();
                double tongTien = 0;
                foreach (DataRow cthdRow in cthdData.Rows)
                {
                    string maSP = cthdRow.Field<string>("Masp");
                    string tenSP = bus_cthdb.Gettensp(maSP);

                    cthdRow.SetField("Masp", tenSP);
                    tongTien += cthdRow.Field<double>("Thanhtien");
                }

                string tenKH = "";
                string tenNV = "";
                DateTime ngayBan = DateTime.MinValue;


                if (hdbData.Rows.Count > 0)
                {
                    DataRow hdbRow = hdbData.Rows[0];

                    string maKH = hdbRow.Field<string>("Makh");
                    tenKH = bus_hdb.Gettenkh(maKH);
                    hdbRow.SetField("Makh", tenKH);

                    string maNV = hdbRow.Field<string>("Manv");
                    tenNV = bus_hdb.Gettennv(maNV);
                    hdbRow.SetField("Manv", tenNV);

                    ngayBan = hdbRow.Field<DateTime>("Ngayban");

                }

                ReportDataSource reportDataSource1 = new ReportDataSource();
                reportDataSource1.Name = "DSban";
                reportDataSource1.Value = hdbData;

                ReportDataSource reportDataSource2 = new ReportDataSource();
                reportDataSource2.Name = "DSbanCT";
                reportDataSource2.Value = cthdData;

                ReportParameter reportParameter5 = new ReportParameter("MaHDB", maHDB);
                ReportParameter reportParameter1 = new ReportParameter("Khachhang", tenKH);
                ReportParameter reportParameter2 = new ReportParameter("Nhanvien", tenNV);
                ReportParameter reportParameter3 = new ReportParameter("Ngayban", ngayBan.ToString("dd/MM/yyyy"));
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
