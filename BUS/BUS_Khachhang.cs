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
    public class BUS_Khachhang
    {
        DAL_Khachhang dal_kh = new DAL_Khachhang();
        public DataTable getData()
        {
            return dal_kh.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_kh.kiemtramatrung(ma);
        }
        public bool Themkh(Khachhang kh)
        {
            return dal_kh.Themkh(kh);
        }

        public bool Suakh(Khachhang kh)
        {
            return dal_kh.Suakh(kh);
        }

        public bool Xoakh(Khachhang kh)
        {
            return dal_kh.Xoakh(kh);
        }

        public DataTable Timkiem(Khachhang kh)
        {
            return dal_kh.Timkiem(kh);
        }
        //public bool Kiemtratontai(string ma)
        //{
        //    return dal_kh.Kiemtratontai(ma);
        //}
    }
}
