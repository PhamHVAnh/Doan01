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
    public class BUS_CTHoadonban
    {
        DAL_CTHoadonban dal_cthdb = new DAL_CTHoadonban();
        public DataTable getData()
        {
            return dal_cthdb.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_cthdb.kiemtramatrung(ma);
        }
        public bool ThemCThdb(ChiTietHDB CThdb)
        {
            return dal_cthdb.ThemCThdb(CThdb);
        }

        public bool SuaCThdb(ChiTietHDB CThdb)
        {
            return dal_cthdb.SuaCThdb(CThdb);
        }

        public bool XoaCThdb(string maHDB, string maSP)
        {
            return dal_cthdb.XoaCThdb(maHDB,maSP);
        }

        public DataTable Timkiem(ChiTietHDB CThdb)
        {
            return dal_cthdb.Timkiem(CThdb);
        }
        public DataTable GetCThdb(string maHDB)
        {
            return dal_cthdb.GetCThdb(maHDB);
        }
        public int Laysoluong(string ma)
        {
            return dal_cthdb.Laysoluong(ma);
        }

        public bool Capnhatsl(string maSP, float slThayDoi)
        {
            return dal_cthdb.Capnhatsl(maSP, slThayDoi);
        }
        public float Laydongia(string ma)
        {
            return dal_cthdb.Laydongia(ma);
        }
        public string Gettensp(string maSP)
        {
            return dal_cthdb.Gettensp(maSP);
        }
    }
}
