using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Menu
    {
        private string tenDV;
        private int soLuong;
        private float donGia;
        private int tongTien;

        public Menu(DataRow row)
        {
            this.tenDV = row["TenDV"].ToString();
            this.soLuong = (int)row["SoLuong"];
            this.donGia = (int)row["DonGia"];
            this.tongTien = (int)row["tongtien"];
            //this.tongTien = (float)Convert.ToDouble(row["tongtien"].ToString());
        }

        public Menu(string tenDV, int soLuong, float donGia, int tongTien)
        {
            this.tenDV = tenDV;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.tongTien = tongTien;
        }

        public string TenDV { get => tenDV; set => tenDV = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
