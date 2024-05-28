using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTHoadonban : DbConnect
    {
        DbConnect connect = new DbConnect();

        public DataTable getData()
        {
            string sql = "SELECT * FROM ChiTietHDB";
            return base.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = $"SELECT COUNT(*) FROM ChiTietHDB WHERE MaHDB = '{ma}'";
            return base.kiemtramatrung(ma, sql);
        }
        private bool KiemTraTonTai(string maHDB, string maSP)
        {
            string sql = $"SELECT COUNT(*) FROM ChiTietHDB WHERE maHDB = '{maHDB}' AND maSP = '{maSP}'";
            int count = connect.kiemtramatrung(maHDB, sql);
            return count > 0;
        }
        public bool ThemCThdb(ChiTietHDB cthdb)
        {
            if (KiemTraTonTai(cthdb.MaHDB, cthdb.Masp))
            {
                // Bản ghi đã tồn tại, cập nhật số lượng
                return (CapNhatSoLuong(cthdb.MaHDB, cthdb.Masp, cthdb.Slban) && TinhLaiThanhTien(cthdb.MaHDB, cthdb.Masp));
            }
            else
            {
                // Bản ghi chưa tồn tại, thêm mới
                string sql = "INSERT INTO ChiTietHDB (MaHDB, Masp, Slban, DGban, Giamgia, ThanhTien) VALUES (@MaHDB, @Masp, @Slban, @DGban, @Giamgia, @ThanhTien)";
                SqlParameter[] parameters =
                {

                new SqlParameter("@MaHDB", SqlDbType.VarChar) { Value = cthdb.MaHDB },
                new SqlParameter("@Masp", SqlDbType.VarChar) { Value = cthdb.Masp },
                new SqlParameter("@Slban", SqlDbType.Int) { Value = cthdb.Slban },
                new SqlParameter("@DGban", SqlDbType.Float) { Value = cthdb.DGban },
                new SqlParameter("@Giamgia", SqlDbType.Float) { Value = cthdb.Giamgia },
                new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = cthdb.ThanhTien }
            };
                connect.ExecuteNonQuery(sql, parameters);
                //Tinhtiennhap();
                return true;
            }
            //string sql = "INSERT INTO ChiTietHDB (MaHDB, Masp, Slban, DGban, Giamgia, ThanhTien) VALUES (@MaHDB, @Masp, @Slban, @DGban, @Giamgia, @ThanhTien)";
            //SqlParameter[] parameters =
            //{

            //    new SqlParameter("@MaHDB", SqlDbType.VarChar) { Value = cthdb.MaHDB },
            //    new SqlParameter("@Masp", SqlDbType.VarChar) { Value = cthdb.Masp },
            //    new SqlParameter("@Slban", SqlDbType.Int) { Value = cthdb.Slban },
            //    new SqlParameter("@DGban", SqlDbType.Float) { Value = cthdb.DGban },
            //    new SqlParameter("@Giamgia", SqlDbType.Float) { Value = cthdb.Giamgia },
            //    new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = cthdb.ThanhTien }
            //};
            //connect.ExecuteNonQuery(sql, parameters);
            ////Tinhtiennhap();
            //return true;

        }


        public bool SuaCThdb(ChiTietHDB cthdb)
        {
            //Tinhtiennhap();
            string sql = "UPDATE ChiTietHDB SET Slban = @Slban, DGban = @DGban, Giamgia = @Giamgia, ThanhTien = @ThanhTien WHERE MaHDB = @MaHDB AND Masp = @Masp";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Masp", SqlDbType.VarChar) { Value = cthdb.Masp },
                new SqlParameter("@Slban", SqlDbType.Int) { Value = cthdb.Slban },
                new SqlParameter("@DGban", SqlDbType.Float) { Value = cthdb.DGban },
                new SqlParameter("@Giamgia", SqlDbType.Float) { Value = cthdb.Giamgia },
                new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = cthdb.ThanhTien },
                new SqlParameter("@MaHDB", SqlDbType.VarChar) { Value = cthdb.MaHDB }
            };

            connect.ExecuteNonQuery(sql, parameters);
            return true;
        }

        public bool XoaCThdb(string maHDB, string maSP)
        {
            string sql = string.Format("DELETE FROM ChiTietHDB WHERE MaHDB = '{0}' AND Masp = '{1}'", maHDB, maSP);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(ChiTietHDB cthdb)
        {
            string sql = string.Format("SELECT * FROM ChiTietHDB WHERE MaHDB  LIKE '%{0}%'", cthdb.MaHDB);
            return base.getData(sql);
        }
        public DataTable GetCThdb(string maHDB)
        {
            string sql = $"SELECT * FROM ChiTietHDB WHERE MaHDB = '{maHDB}'";
            return base.getData(sql);

        }
        public bool CapNhatSoLuong(string maHDB, string maSP, float slThayDoi)
        {
            string query = "UPDATE ChiTietHDB SET Slban = Slban + @slThayDoi WHERE MaHDB = @maHDB AND Masp = @maSP";

            SqlParameter[] parameters =
            {
        new SqlParameter("@slThayDoi", SqlDbType.Int) { Value = slThayDoi },
        new SqlParameter("@maHDB", SqlDbType.VarChar) { Value = maHDB },
        new SqlParameter("@maSP", SqlDbType.VarChar) { Value = maSP }
    };
            connect.ExecuteNonQuery(query, parameters);
            return true;
        }
        public bool TinhLaiThanhTien(string maHDB, string maSP)
        {
            string sql = "UPDATE ChiTietHDB SET ThanhTien = Slban * DGban * (1 - Giamgia / 100) WHERE MaHDB = @MaHDB AND Masp = @Masp";
            SqlParameter[] parameters =
            {
        new SqlParameter("@MaHDB", SqlDbType.VarChar) { Value = maHDB },
        new SqlParameter("@Masp", SqlDbType.VarChar) { Value = maSP }
    };
            connect.ExecuteNonQuery(sql, parameters);
            return true;
        }
        public int Laysoluong(string ma)
        {
            string sql = "SELECT Soluong FROM SanPham WHERE Masp = @maSP";
            SqlParameter[] parameters =
            {
                new SqlParameter("@maSP", SqlDbType.VarChar) { Value = ma }
            };
            DataTable result = connect.Getdata(sql, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["Soluong"]);
            }
            else
            {
                return 0;
            }
        }
        public bool Capnhatsl(string maSP, float slThayDoi)
        {
            string query = "UPDATE Sanpham SET Soluong = Soluong - @slThayDoi WHERE Masp = @maSP";

            SqlParameter[] parameters =
            {
                new SqlParameter("@slThayDoi", SqlDbType.Float) { Value = slThayDoi },
                new SqlParameter("@maSP", SqlDbType.VarChar) { Value = maSP }
            };
            connect.ExecuteNonQuery(query, parameters);
            return true;
        }
        public float Laydongia(string ma)
        {
            string sql = "SELECT Dongia FROM SanPham WHERE Masp = @maSP";
            SqlParameter[] parameters =
            {
        new SqlParameter("@maSP", SqlDbType.VarChar) { Value = ma }
    };
            DataTable result = connect.Getdata(sql, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                return Convert.ToSingle(result.Rows[0]["Dongia"]);
            }
            else
            {
                return 0; // Trả về 0 khi không tìm thấy
            }
            
        }
        public string Gettensp(string maSP)
        {
            string sql = $"SELECT Tensp FROM SanPham WHERE maSP = '{maSP}'";
            DataTable dt = connect.getData(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Tensp"].ToString();
            }
            return null;
        }

    }
}
