using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Sanpham
    {
        DAL_Sanpham dal_sp = new DAL_Sanpham();
        public DataTable getData()
        {
            return dal_sp.getData();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_sp.kiemtramatrung(ma);
        }
        public bool Themsp(Sanpham sp)
        {
            return dal_sp.Themsp(sp);
        }
        public bool Suasp(Sanpham sp)
        {
            return dal_sp.Suasp(sp);
        }

        public bool Xoasp(Sanpham sp)
        {
            return dal_sp.Xoasp(sp);
        }

        public DataTable Timkiem(Sanpham sp)
        {
            return dal_sp.Timkiem(sp);
        }
        //public int Laysoluong(string ma)
        //{
        //    return dal_sp.Laysoluong(ma);
        //}
        //public bool Capnhatsl(string maSP, float slThayDoi)
        //{
        //    return dal_sp.Capnhatsl(maSP, slThayDoi);
        //}

    }
}
