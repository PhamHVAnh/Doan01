using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Hoadonban : DbConnect

    {
        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "SELECT * FROM HoaDonBan";
            return base.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = $"SELECT COUNT(*) FROM HoaDonBan WHERE MaHDB = '{ma}'";
            return base.kiemtramatrung(ma, sql);
        }
        public bool Themhdb(Hoadonban hdb)
        {
            string sql = string.Format("INSERT INTO HoaDonBan (MaHDB, Manv, Makh, Ngayban, Tongtien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", hdb.MaHDB, hdb.Manv, hdb.Makh, hdb.Ngayban, hdb.Tongtien);
            thucthisql(sql);
            return true;
        }


        public bool Suahdb(Hoadonban hdb)
        {
            string sql = string.Format("UPDATE HoaDonBan SET Manv = '{0}', Makh = '{1}', Ngayban = '{2}', Tongtien = '{3}' WHERE MaHDB = '{4}'", hdb.Manv, hdb.Makh, hdb.Ngayban, hdb.Tongtien, hdb.MaHDB);
            thucthisql(sql);
            return true;
        }

        public bool Xoahdb(Hoadonban hdb)
        {
            string sql = string.Format("DELETE FROM HoaDonBan WHERE MaHDB = '{0}'", hdb.MaHDB);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(Hoadonban hdb)
        {
            string sql = string.Format("SELECT * FROM HoaDonBan WHERE MaHDB  LIKE '%{0}%'", hdb.MaHDB);
            return base.getData(sql);
        }
        public string Gettennv(string maNV)
        {
            string sql = $"SELECT Tennv FROM NhanVien WHERE Manv = '{maNV}'";
            DataTable dt = Connect.getData(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Tennv"].ToString();
            }
            return null;
        }

        public string Gettenkh(string maKH)
        {
            string sql = $"SELECT Tenkh FROM KhachHang WHERE Makh = '{maKH}'";
            DataTable dt = Connect.getData(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Tenkh"].ToString();
            }
            return null;
        }
    }
}
