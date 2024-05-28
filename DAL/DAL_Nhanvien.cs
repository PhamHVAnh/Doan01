using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Nhanvien:DbConnect
    {
        DbConnect Connect = new DbConnect();
        public DataTable getData()
        {
            string sql = "Select * from NhanVien";
            return Connect.getData(sql);
        }
        public int kiemtramatrung(string ma)
        {
            string sql = $" Select count(*) from NhanVien where Manv='" + ma + "'";
            return Connect.kiemtramatrung(ma, sql);
        }
        public bool Themnv(Nhanvien nv)
        {
            string sql = string.Format("INSERT INTO NhanVien (Manv, Tennv, Gioitinhnv, Ngaysinhnv, Dchinv, Emailnv, Sdtnv) VALUES ('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}')",nv.Manv, nv.Tennv, nv.Gioitinhnv, nv.Ngaysinhnv, nv.Dchinv, nv.Emailnv, nv.Sdtnv);
            thucthisql(sql);
            return true;
        }

        public bool Suanv(Nhanvien nv)
        {
            string sql = string.Format("UPDATE NhanVien SET Tennv = N'{0}', Gioitinhnv = N'{1}', Ngaysinhnv = '{2}', Dchinv = N'{3}', Emailnv = '{4}', Sdtnv = '{5}' WHERE Manv = '{6}'",nv.Tennv, nv.Gioitinhnv, nv.Ngaysinhnv, nv.Dchinv, nv.Emailnv, nv.Sdtnv, nv.Manv);
            thucthisql(sql);
            return true;
        }

        public bool Xoanv(Nhanvien nv)
        {
            string sql = string.Format("DELETE FROM NhanVien WHERE Manv = '{0}'", nv.Manv);

            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(Nhanvien nv)
        {
            string sql = string.Format("SELECT * FROM NhanVien WHERE Manv LIKE '%{0}%' OR Tennv LIKE N'%{1}%'", nv.Manv, nv.Tennv);
            return base.getData(sql);
        }

    }
}
