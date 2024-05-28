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
    public class BUS_Hoadonban
    {
        DAL_Hoadonban dal_hdb = new DAL_Hoadonban();
        public DataTable getData()
        {
            return dal_hdb.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_hdb.kiemtramatrung(ma);
        }
        public bool Themhdb(Hoadonban hdb)
        {
            return dal_hdb.Themhdb(hdb);
        }

        public bool Suahdb(Hoadonban hdb)
        {
            return dal_hdb.Suahdb(hdb);
        }

        public bool Xoahdb(Hoadonban hdb)
        {
            return dal_hdb.Xoahdb(hdb);
        }

        public DataTable Timkiem(Hoadonban hdb)
        {
            return dal_hdb.Timkiem(hdb);
        }
        public string Gettenkh(string maKH)
        {
            return dal_hdb.Gettenkh(maKH);
        }
        public string Gettennv(string maNV)
        {
            return dal_hdb.Gettennv(maNV);
        }
    }
}
