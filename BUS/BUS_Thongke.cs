using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Thongke
    {
        private DAL_Thongke dal_tk = new DAL_Thongke();

        public DataTable Topbanchay(DateTime fromDate, DateTime toDate)
        {
            return dal_tk.Topbanchay(fromDate, toDate);
        }

        public DataRow Tensanpham(string tenSanPham)
        {
            return dal_tk.Tensanpham(tenSanPham);
        }
    }
}
