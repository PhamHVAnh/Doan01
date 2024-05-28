using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Taikhoan
    {
        DAL_Taikhoan dal_tk = new DAL_Taikhoan();
        public DataTable getData()
        {
            return dal_tk.getData();
        }

        public int kiemtramatrung(string ten)
        {
            return dal_tk.kiemtramatrung(ten);
        }
        public bool Themtk(Taikhoan tk)
        {
            return dal_tk.Themtk(tk);
        }

        public bool Suatk(Taikhoan tk)
        {
            return dal_tk.Suatk(tk);
        }

        public bool Xoatk(Taikhoan tk)
        {
            return dal_tk.Xoatk(tk);
        }

        public DataTable Timkiem(Taikhoan tk)
        {
            return dal_tk.Timkiem(tk);
        }
        public bool Login(string Tentk, string Matkhau)
        {
            return dal_tk.Login(Tentk, Matkhau);
        }
        public bool Xacnhantk(string Tentk, string Email)
        {
            return dal_tk.Xacnhantk(Tentk, Email);
        }
        public bool Doimatkhau(string Tentk, string Email)
        {
            return dal_tk.Doimatkhau(Tentk, Email);
        }

        public string Laychucvu(string Tentk)
        {
            return dal_tk.Laychucvu(Tentk);
        }
    }
}
