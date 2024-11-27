using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get => instance == null ? instance = new MenuDAO() : instance;
            private set => instance = value;
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id) 
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select dv.TenDV as TenDV, bi.SoLuong as SoLuong, dv.DonGia as DonGia, dv.DonGia*bi.SoLuong as tongtien from ChiTietHD as bi, HD as b, DichVuThem as dv where bi.MaHD = b.MaHD and bi.MaDV = dv.MaDV and b.status = 0 and MaB = " + id;
            DataTable dt = Connection.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }


    }
}
