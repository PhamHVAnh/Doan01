using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Taikhoan : DbConnect
    {

        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "SELECT * FROM TaiKhoan";
            return Connect.getData(sql);
        }

        public int kiemtramatrung(string ten)
        {
            string sql = $"SELECT COUNT(*) FROM TaiKhoan WHERE Tentk = '{ten}'";
            return Connect.kiemtramatrung(ten, sql);
        }
        public bool Themtk(Taikhoan tk)
        {
            string sql = string.Format("INSERT INTO TaiKhoan (Manv, Tentk, Matkhau, Email, Chucvu) VALUES ('{0}', N'{1}', '{2}', '{3}', N'{4}')", tk.Manv, tk.Tentk, tk.Matkhau, tk.Email, tk.Chucvu);
            thucthisql(sql);
            return true;
        }

        public bool Suatk(Taikhoan tk)
        {
            string sql = string.Format("UPDATE TaiKhoan SET Manv = N'{0}', Matkhau= '{1}', Email = '{2}', Chucvu = N'{3}' WHERE Tentk = '{4}'", tk.Manv, tk.Matkhau, tk.Email, tk.Chucvu, tk.Tentk);
            thucthisql(sql);
            return true;
        }

        public bool Xoatk(Taikhoan tk)
        {
            string sql = string.Format("DELETE FROM TaiKhoan WHERE Tentk = '{0}'", tk.Tentk);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(Taikhoan tk)
        {
            string sql = string.Format("SELECT * FROM TaiKhoan WHERE Tentk LIKE '%{0}%' OR Email LIKE N'%{1}%'", tk.Tentk, tk.Email);
            return base.getData(sql);
        }

        public bool Login(string Tentk, string Matkhau)
        {

            string sql = string.Format($"SELECT * FROM TaiKhoan WHERE Tentk = N'{Tentk}' AND Matkhau = N'{Matkhau}'");
            DataTable result = Connect.getData(sql); 
            return result.Rows.Count > 0; 
        }
        public bool Xacnhantk(string Tentk, string Email)
        {
            string sql = $"SELECT * FROM TaiKhoan WHERE Tentk = N'{Tentk}' AND Email = N'{Email}'";
            DataTable result = Connect.getData(sql);
            return result.Rows.Count > 0;

        }
        public bool Doimatkhau(string Tentk, string MatKhauMoi)
        {
            string sql = $"UPDATE TaiKhoan SET Matkhau = '{MatKhauMoi}' WHERE Tentk = N'{Tentk}'";
            thucthisql(sql);
            return true;
        }

        public string Laychucvu(string Tentk)
        {
            string sql = $"SELECT Chucvu FROM TaiKhoan WHERE Tentk = N'{Tentk}'";
            DataTable result = Connect.getData(sql);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["Chucvu"].ToString();
            }
            else
            {
                return null;
            }
        }

    }
}

