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
    public class DAL_CTHoadonnhap : DbConnect
    {
        DbConnect connect = new DbConnect();

        public DataTable getData()
        {
            string sql = "SELECT * FROM ChiTietHDN";
            return base.getData(sql);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = $"SELECT COUNT(*) FROM ChiTietHDN WHERE MaHDN = '{ma}'";
            return base.kiemtramatrung(ma, sql);
        }

        public bool ThemCThdn(ChiTietHDN cthdn)
        {
            if (KiemTraTonTai(cthdn.MaHDN, cthdn.Masp))
            {
                // Bản ghi đã tồn tại, cập nhật số lượng
                return (CapNhatSoLuong(cthdn.MaHDN, cthdn.Masp, cthdn.Slnhap) && TinhLaiThanhTien(cthdn.MaHDN, cthdn.Masp));
            }
            else
            {
                // Bản ghi chưa tồn tại, thêm mới
                string sql = "INSERT INTO ChiTietHDN (MaHDN, Masp, Slnhap, DGnhap, Giamgia, ThanhTien) VALUES (@MaHDN, @Masp, @Slnhap, @DGnhap, @Giamgia, @ThanhTien)";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaHDN", SqlDbType.VarChar) { Value = cthdn.MaHDN },
                    new SqlParameter("@Masp", SqlDbType.VarChar) { Value = cthdn.Masp },
                    new SqlParameter("@Slnhap", SqlDbType.Int) { Value = cthdn.Slnhap },
                    new SqlParameter("@DGnhap", SqlDbType.Float) { Value = cthdn.DGnhap },
                    new SqlParameter("@Giamgia", SqlDbType.Float) { Value = cthdn.Giamgia },
                    new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = cthdn.ThanhTien }
                };
                connect.ExecuteNonQuery(sql, parameters);
                return true;
            }
        }


        private bool KiemTraTonTai(string maHDN, string maSP)
        {
            string sql = $"SELECT COUNT(*) FROM ChiTietHDN WHERE maHDN = '{maHDN}' AND maSP = '{maSP}'";
            int count = connect.kiemtramatrung(maHDN, sql);
            return count > 0;
        }

        public bool SuaCThdn(ChiTietHDN cthdn)
        {
            //Tinhtiennhap();
            string sql = "UPDATE ChiTietHDN SET Slnhap = @Slnhap, DGnhap = @DGnhap, Giamgia = @Giamgia, ThanhTien = @ThanhTien WHERE MaHDN = @MaHDN AND Masp = @Masp";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Masp", SqlDbType.VarChar) { Value = cthdn.Masp },
                new SqlParameter("@Slnhap", SqlDbType.Int) { Value = cthdn.Slnhap },
                new SqlParameter("@DGnhap", SqlDbType.Float) { Value = cthdn.DGnhap },
                new SqlParameter("@Giamgia", SqlDbType.Float) { Value = cthdn.Giamgia },
                new SqlParameter("@ThanhTien", SqlDbType.Float) { Value = cthdn.ThanhTien },
                new SqlParameter("@MaHDN", SqlDbType.VarChar) { Value = cthdn.MaHDN }
            };

            connect.ExecuteNonQuery(sql, parameters);
            return true;
        }

        public bool XoaCThdn(string maHDN, string maSP)
        {
            string sql = string.Format("DELETE FROM ChiTietHDN WHERE MaHDN = '{0}' AND Masp = '{1}'", maHDN, maSP);
            thucthisql(sql);
            return true;
        }

        public DataTable Timkiem(ChiTietHDN cthdn)
        {
            string sql = string.Format("SELECT * FROM ChiTietHDN WHERE MaHDN  LIKE '%{0}%'", cthdn.MaHDN);
            return base.getData(sql);
        }
        public DataTable GetCThdn(string maHDN)
        {
            string sql = $"SELECT * FROM ChiTietHDN WHERE MaHDN = '{maHDN}'";
            return base.getData(sql);

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
            string query = "UPDATE Sanpham SET Soluong = Soluong + @slThayDoi WHERE Masp = @maSP";

            SqlParameter[] parameters =
            {
                new SqlParameter("@slThayDoi", SqlDbType.Float) { Value = slThayDoi },
                new SqlParameter("@maSP", SqlDbType.VarChar) { Value = maSP }
            };
            connect.ExecuteNonQuery(query, parameters);
            return true;
        }
    //    public bool Capnhatslsua(string maSP, float oldQuantity, float newQuantity)
    //    {
    //        string query = "UPDATE Sanpham SET Soluong = Soluong - @oldQuantity + @newQuantity WHERE Masp = @maSP";

    //        SqlParameter[] parameters =
    //        {
    //    new SqlParameter("@oldQuantity", SqlDbType.Float) { Value = oldQuantity },
    //    new SqlParameter("@newQuantity", SqlDbType.Float) { Value = newQuantity },
    //    new SqlParameter("@maSP", SqlDbType.VarChar) { Value = maSP }
    //};
    //        connect.ExecuteNonQuery(query, parameters);
    //        return true;
    //    }

        public bool CapNhatSoLuong(string maHDN, string maSP, float slThayDoi)
{
    string query = "UPDATE ChiTietHDN SET Slnhap = Slnhap + @slThayDoi WHERE MaHDN = @maHDN AND Masp = @maSP";

    SqlParameter[] parameters =
    {
        new SqlParameter("@slThayDoi", SqlDbType.Int) { Value = slThayDoi },
        new SqlParameter("@maHDN", SqlDbType.VarChar) { Value = maHDN },
        new SqlParameter("@maSP", SqlDbType.VarChar) { Value = maSP }
    };
    connect.ExecuteNonQuery(query, parameters);
    return true;
}
        public bool TinhLaiThanhTien(string maHDN, string maSP)
        {
            string sql = "UPDATE ChiTietHDN SET ThanhTien = Slnhap * DGnhap * (1 - Giamgia / 100) WHERE MaHDN = @MaHDN AND Masp = @Masp";
            SqlParameter[] parameters =
            {
        new SqlParameter("@MaHDN", SqlDbType.VarChar) { Value = maHDN },
        new SqlParameter("@Masp", SqlDbType.VarChar) { Value = maSP }
    };
            connect.ExecuteNonQuery(sql, parameters);
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
        public string GetTenSanPham(string maSP)
        {
            string sql = $"SELECT Tensp FROM SanPham WHERE Masp = '{maSP}'";
            DataTable dt = connect.getData(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Tensp"].ToString();
            }
            return null;
        }
    }
}