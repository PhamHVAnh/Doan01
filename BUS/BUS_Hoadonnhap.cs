using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Hoadonnhap
    {
        DAL_Hoadonnhap dal_hdn = new DAL_Hoadonnhap();
        public DataTable getData()
        {
            return dal_hdn.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_hdn.kiemtramatrung(ma);
        }
        public bool Themhdn(Hoadonnhap hdn)
        {
            return dal_hdn.Themhdn(hdn);
        }

        public bool Suahdn(Hoadonnhap hdn)
        {
            return dal_hdn.Suahdn(hdn);
        }

        public bool Xoahdn(Hoadonnhap hdn)
        {
            return dal_hdn.Xoahdn(hdn);
        }

        public DataTable Timkiem(Hoadonnhap hdn)
        {
            return dal_hdn.Timkiem(hdn);
        }
        public string GetTenNCC(string maNCC)
        {
            return dal_hdn.GetTenNhaCungCap(maNCC);
        }
        public string GetTenNV(string maNV)
        {
            return dal_hdn.GetTenNhanVien(maNV);
        }
    }
}
