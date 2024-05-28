using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Khachhang : DbConnect
    {
        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "SELECT * FROM KhachHang";
            return Connect.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = $"SELECT COUNT(*) FROM KhachHang WHERE Makh = '{ma}'";
            return Connect.kiemtramatrung(ma, sql);
        }

        public bool Themkh(Khachhang kh)
        {
            string sql = string.Format("INSERT INTO KhachHang (Makh, Tenkh, Sdtkh, Dchikh) VALUES ('{0}', N'{1}', N'{2}', N'{3}')", kh.Makh, kh.Tenkh, kh.Sdtkh, kh.Dchikh);
            thucthisql(sql);
            return true;
        }

        public bool Suakh(Khachhang kh)
        {
            string sql = string.Format("UPDATE KhachHang SET Tenkh = N'{0}', Sdtkh = '{1}', Dchikh = N'{2}' WHERE Makh = '{3}'", kh.Tenkh, kh.Sdtkh, kh.Dchikh, kh.Makh);
            thucthisql(sql);
            return true;
        }

        public bool Xoakh(Khachhang kh)
        {
            string sql = string.Format("DELETE FROM KhachHang WHERE Makh = '{0}'", kh.Makh);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(Khachhang kh)
        {
            string sql = string.Format("SELECT * FROM KhachHang WHERE Makh LIKE '%{0}%' OR Tenkh LIKE N'%{1}%'", kh.Makh, kh.Tenkh);
            return base.getData(sql);
        }
        //public bool Kiemtratontai(string ma)
        //{
        //    string sql = $"SELECT COUNT(*) FROM KhachHang WHERE Makh = '{ma}'";
        //    int count = Connect.kiemtramatrung(ma, sql);
        //    return count > 0;
        //}


    }
}
