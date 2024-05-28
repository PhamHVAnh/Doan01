using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_CTHoadonnhap
    {
        DAL_CTHoadonnhap dal_cthdn=new DAL_CTHoadonnhap();
        public DataTable getData()
        {
            return dal_cthdn.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_cthdn.kiemtramatrung(ma);
        }
        public bool ThemCThdn(ChiTietHDN cthdn)
        {
            return dal_cthdn.ThemCThdn(cthdn);
        }

        public bool SuaCThdn(ChiTietHDN cthdn)
        {
            return dal_cthdn.SuaCThdn(cthdn);
        }

        public bool XoaCThdn(string maHDN, string maSP)
        {
            return dal_cthdn.XoaCThdn(maHDN, maSP);
        }


        public DataTable Timkiem(ChiTietHDN cthdn)
        {
            return dal_cthdn.Timkiem(cthdn);
        }
        public DataTable GetCThdn(string maHDN)
        {
            return dal_cthdn.GetCThdn(maHDN);
        }
        //public float Laysoluongcu(string maHDN, string maSP)
        //{
        //    return dal_cthdn.Laysoluongcu(maHDN, maSP);
        //}
        //public bool Capnhatsl(string maSP, float slThayDoi)
        //{
        //    DAL_Sanpham dalSanpham = new DAL_Sanpham();
        //    return dalSanpham.Capnhatsl(maSP, slThayDoi);
        //}

        public int Laysoluong(string ma)
        {
            return dal_cthdn.Laysoluong(ma);
        }

        public bool Capnhatsl(string maSP, float slThayDoi)
        {
            return dal_cthdn.Capnhatsl(maSP, slThayDoi);
        }

        //public bool Capnhatslsua(string maSP, float oldQuantity, float newQuantity)
        //{
        //    return dal_cthdn.Capnhatslsua(maSP,oldQuantity, newQuantity);
        //}
        public float Laydongia(string ma)
        {
            return dal_cthdn.Laydongia(ma);
        }
        public bool CapNhatSoLuong(string maHDN, string maSP, float slThayDoi)
        {
            return dal_cthdn.CapNhatSoLuong(maHDN, maSP, slThayDoi);
        }
        public string GetTenSP(string maSP)
        {
            return dal_cthdn.GetTenSanPham(maSP);
        }
    }
}
