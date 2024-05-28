using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_Loaisp:DbConnect 
    {
        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "Select * from Loaihang";
            return Connect.getData(sql);
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from Loaihang where Malh='" + ma.Trim() + "'";
            return Connect.kiemtramatrung(ma, sql);
        }
        public bool Themlh (Loaihang lh)
        {
            string sql = string.Format("Insert into Loaihang values('{0}',N'{1}')", lh.Malh, lh.Tenlh);

            thucthisql(sql);
            return true;
        }
        public bool Sualh(Loaihang lh)
        {
            string sql = string.Format("UPDATE Loaihang SET Tenlh = N'{0}' WHERE Malh = '{1}'", lh.Tenlh, lh.Malh);

            thucthisql(sql);
            return true;
        }
        public bool Xoalh(Loaihang lh)
        {
            string sql = string.Format("DELETE FROM Loaihang WHERE Malh = '{0}'", lh.Malh);

            thucthisql(sql);
            return true;
        }
        public DataTable Timkiem(Loaihang lh)
        {
            string sql = string.Format("SELECT * FROM Loaihang WHERE Malh LIKE '%{0}%' OR Tenlh LIKE N'%{1}%'", lh.Malh, lh.Tenlh);
            return Connect.getData(sql);

        }
        //public bool Kiemtratontai(string ma)
        //{
        //    string sql = $"SELECT COUNT(*) FROM LoaiHang WHERE Malh = '{0}'";
        //    int count = Connect.kiemtramatrung(ma, sql);
        //    return count > 0;
        //}
    }
}
