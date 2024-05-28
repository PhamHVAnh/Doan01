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
    public class DAL_Hoadonnhap : DbConnect

    {
        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "SELECT * FROM HoaDonNhap";
            return base.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = $"SELECT COUNT(*) FROM HoaDonNhap WHERE MaHDN = '{ma}'";
            return base.kiemtramatrung(ma, sql);
        }
        public bool Themhdn(Hoadonnhap hdn)
        {
            string sql = string.Format("INSERT INTO HoaDonNhap (MaHDN, Manv, Mancc, Ngaynhap, Tongtien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", hdn.MaHDN, hdn.Manv, hdn.Mancc, hdn.Ngaynhap, hdn.Tongtien);
            thucthisql(sql);
            return true;
        }


        public bool Suahdn(Hoadonnhap hdn)
        {
            string sql = string.Format("UPDATE HoaDonNhap SET Manv = '{0}', Mancc = '{1}', Ngaynhap = '{2}', Tongtien = '{3}' WHERE MaHDN = '{4}'", hdn.Manv, hdn.Mancc, hdn.Ngaynhap, hdn.Tongtien, hdn.MaHDN);
            thucthisql(sql);
            return true;
        }

        public bool Xoahdn(Hoadonnhap hdn)
        {
            string sql = string.Format("DELETE FROM HoaDonNhap WHERE MaHDN = '{0}'", hdn.MaHDN);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(Hoadonnhap hdn)
        {
            string sql = string.Format("SELECT * FROM HoaDonNhap WHERE MaHDN  LIKE '%{0}%'", hdn.MaHDN);
            return base.getData(sql);
        }
        public string GetTenNhanVien(string maNV)
        {
            string sql = $"SELECT Tennv FROM NhanVien WHERE Manv = '{maNV}'";
            DataTable dt = Connect.getData(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Tennv"].ToString();
            }
            return null;
        }

        public string GetTenNhaCungCap(string maNCC)
        {
            string sql = $"SELECT Tenncc FROM NhaCC WHERE Mancc = '{maNCC}'";
            DataTable dt = Connect.getData(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Tenncc"].ToString();
            }
            return null;
        }

    }
}
