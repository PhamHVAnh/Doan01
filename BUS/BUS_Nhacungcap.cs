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
    public class BUS_Nhacungcap
    {
        DAL_Nhacungcap dal_ncc=new DAL_Nhacungcap();
        public DataTable getData()
        {
            return dal_ncc.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_ncc.kiemtramatrung(ma);
        }
        public bool Themncc(Nhacungcap ncc)
        {
            return dal_ncc.Themncc(ncc);
        }

        public bool Suancc(Nhacungcap ncc)
        {
            return dal_ncc.Suancc(ncc);
        }

        public bool Xoancc(Nhacungcap ncc)
        {
            return dal_ncc.Xoancc(ncc);
        }

        public DataTable Timkiem(Nhacungcap ncc)
        {
            return dal_ncc.Timkiem(ncc);
        }
    }
}
