using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Sanpham : DbConnect
    {
        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "Select * from SanPham";
            return Connect.getData(sql);
        }
        public int kiemtramatrung(string ma)
        {
            string sql = $" Select count(*) from SanPham where Masp='" + ma+ "'";
            return Connect.kiemtramatrung(ma, sql);
        }
        public bool Themsp(Sanpham sp)
        {
            string sql = string.Format("INSERT INTO SanPham (Masp, Tensp, Soluong, Malh, Ghichu, Dongia) VALUES ('{0}', N'{1}', {2}, '{3}', N'{4}', {5})", sp.Masp, sp.Tensp, sp.Soluong, sp.Malh, sp.Ghichu, sp.Dongia);

            thucthisql(sql);
            return true;
        }
        public bool Suasp(Sanpham sp)
        {
            string sql = string.Format("UPDATE SanPham SET Tensp = N'{0}', Soluong = {1}, Malh = '{2}', Ghichu = N'{3}', Dongia = {4} WHERE Masp = '{5}'", sp.Tensp, sp.Soluong, sp.Malh, sp.Ghichu, sp.Dongia, sp.Masp);
            thucthisql(sql);
            return true;
        }
        public bool Xoasp(Sanpham sp)
        {
            string sql = string.Format("DELETE FROM SanPham WHERE Masp = '{0}'", sp.Masp);

            thucthisql(sql);
            return true;
        }
        public DataTable Timkiem(Sanpham sp)
        {
            string sql = string.Format("SELECT * FROM SanPham WHERE Masp LIKE '%{0}%' OR Tensp LIKE N'%{1}%'", sp.Masp, sp.Tensp);
            return Connect.getData(sql);

        }
        //public int Laysoluong(string ma)
        //{
        //    string sql = $"SELECT Soluong FROM SanPham WHERE Masp = '{ma}'";
        //    DataTable result = Connect.getData(sql);

        //    if (result != null && result.Rows.Count > 0)
        //    {
        //        int soLuong = Convert.ToInt32(result.Rows[0]["Soluong"]);
        //        return soLuong;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        //public bool Capnhatsl(string maSP, float slThayDoi)
        //{
        //    string query = "UPDATE Sanpham SET Soluong = Soluong + @slThayDoi WHERE Masp = @maSP";
        //    SqlParameter[] sqlParameters = new SqlParameter[]
        //    {
        //new SqlParameter("@slThayDoi", slThayDoi),
        //new SqlParameter("@maSP", maSP)
        //    };
        //    Connect.ExecuteNonQuery(query, sqlParameters);
        //    return true;
        //}




    }
}
