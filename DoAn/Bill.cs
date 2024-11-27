using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Bill
    {
        private int maHD;
        private int maKH;
        private int maB;
        private DateTime? tGBD;
        private DateTime? tGKT;
        private string donViTinh;
        private int kM;
        private int tongTien;
        private int status;

        public Bill()
        {
        }

        
        public Bill(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.MaKH = (int)row["MaKH"];
            this.MaB = (int)row["MaB"];
            this.TGBD = (DateTime?)row["TGBD"];


            var dateCheckOutTemp = row["TGKT"];
            if (dateCheckOutTemp.ToString() != "")
                this.TGKT = (DateTime?)dateCheckOutTemp;

            //this.DonViTinh = row["DonViTinh"].ToString();
            this.KM = (int)row["KM"];
            //this.TongTien = (int)row["TongTien"];
            this.Status = (int)row["status"];
        }

        public Bill(int maHD, int maKH, int maB, DateTime? tGBD, DateTime? tGKT, string donViTinh, int kM, int tongTien, int status)
        {
            this.maHD = maHD;
            this.maKH = maKH;
            this.maB = maB;
            this.tGBD = tGBD;
            this.tGKT = tGKT;
            this.donViTinh = donViTinh;
            this.kM = kM;
            this.tongTien = tongTien;
            this.status = status;
        }

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int MaB { get => maB; set => maB = value; }
        public DateTime? TGBD { get => tGBD; set => tGBD = value; }
        public DateTime? TGKT { get => tGKT; set => tGKT = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int KM { get => kM; set => kM = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int Status { get => status; set => status = value; }
    }
}
