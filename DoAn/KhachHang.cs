using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class KhachHang
    {
        private string hoTenKH;
        private string sDT;
        private string cCCD;
        private int diem;
        

        public KhachHang() { }



        public KhachHang(DataRow row)
        {
            this.hoTenKH = row["HoTenKH"].ToString();
            this.sDT = row["SDT"].ToString();
            this.cCCD = row["CCCD"].ToString();
            this.diem = (int)row["Diem"];
            
        }

        public KhachHang(string hoTenKH, string sDT, string cCCD, int diem)
        {
            this.hoTenKH = hoTenKH;
            this.sDT = sDT;
            this.cCCD = cCCD;
            this.diem = diem;
        }

        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}
