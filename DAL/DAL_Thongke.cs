using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Thongke:DbConnect
    {
        public DataTable Topbanchay(DateTime fromDate, DateTime toDate)
        {
            string sql = @"
                SELECT TOP 5 HD.Ngayban, SP.Tensp, SUM(CTHD.Slban) AS SoLuongBan, SUM(CTHD.Slban * CTHD.DGban) AS DoanhThu
                FROM SanPham SP
                JOIN ChiTietHDB CTHD ON SP.Masp = CTHD.Masp
                JOIN HoaDonBan HD ON CTHD.MaHDB = HD.MaHDB
                WHERE HD.Ngayban BETWEEN @FromDate AND @ToDate
                GROUP BY HD.Ngayban, SP.Tensp
                ORDER BY DoanhThu DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            };

            return Getdata(sql, parameters);
        }
        public DataRow Tensanpham(string tenSanPham)
        {
            string sql = "SELECT * FROM SanPham WHERE Tensp = @TenSanPham";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenSanPham", tenSanPham)
            };

            DataTable dt = Getdata(sql, parameters);

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }
    }
}
