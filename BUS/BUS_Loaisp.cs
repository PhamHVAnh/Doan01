using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Loaisp
    {
        DAL_Loaisp dal_lsp = new DAL_Loaisp();

        public DataTable getData()
        {
            return dal_lsp.getData();
        }

        public int kiemtramatrung(string ma)
        {
            return dal_lsp.kiemtramatrung(ma);
        }
        public bool Themlh(Loaihang lh)
        {
            return dal_lsp.Themlh(lh);
        }
        public bool Sualh(Loaihang lh)
        {
            return dal_lsp.Sualh(lh);
        }
        public bool Xoalh(Loaihang lh)
        {
            return dal_lsp.Xoalh(lh);
        }
        public DataTable Timkiem(Loaihang lh)
        {
            return dal_lsp.Timkiem(lh);
        }
        //public bool Kiemtratontai(string ma)
        //{
        //    return dal_lsp.Kiemtratontai(ma);
        //}
    }
}
