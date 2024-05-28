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
    public class BUS_Nhanvien
    {
        DAL_Nhanvien dal_nv = new DAL_Nhanvien();

        public DataTable getData()
        {
            return dal_nv.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_nv.kiemtramatrung(ma);
        }

        public bool Themnv(Nhanvien nv)
        {
            return dal_nv.Themnv(nv);
        }

        public bool Suanv(Nhanvien nv)
        {
            return dal_nv.Suanv(nv);
        }

        public bool Xoanv(Nhanvien nv)
        {
            return dal_nv.Xoanv(nv);
        }

        public DataTable Timkiem(Nhanvien nv)
        {
            return dal_nv.Timkiem(nv);
        }
    }
}
