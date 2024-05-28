using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Nhacungcap:DbConnect
    {
        DbConnect Connect=new DbConnect();
        public DataTable getData()
        {
            string sql = "SELECT * FROM NhaCC";
            return Connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = $"SELECT COUNT(*) FROM NhaCC WHERE Mancc = '{ma}'";
            return Connect.kiemtramatrung(ma, sql);
        }

        public bool Themncc(Nhacungcap ncc)
        {
            string sql = string.Format("INSERT INTO NhaCC (Mancc, Tenncc, Sdtncc, Dchincc) VALUES ('{0}', N'{1}', N'{2}', '{3}')", ncc.Mancc, ncc.Tenncc, ncc.Sdtncc, ncc.Dchincc);
            thucthisql(sql);
            return true;
        }

        public bool Suancc(Nhacungcap ncc)
        {
            string sql = string.Format("UPDATE NhaCC SET Tenncc = N'{0}', Sdtncc = '{1}', Dchincc = N'{2}' WHERE Mancc = '{3}'", ncc.Tenncc, ncc.Sdtncc, ncc.Dchincc,ncc.Mancc);
            thucthisql(sql);
            return true;
        }

        public bool Xoancc(Nhacungcap ncc)
        {
            string sql = string.Format("DELETE FROM NhaCC WHERE Mancc = '{0}'",ncc.Mancc);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(Nhacungcap ncc)
        {
            string sql = string.Format("SELECT * FROM NhaCC WHERE Mancc LIKE '%{0}%' OR Tenncc LIKE N'%{1}%'",ncc.Mancc,ncc.Tenncc);
            return base.getData(sql);
        }
    }
}
