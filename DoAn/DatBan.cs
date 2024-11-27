using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class DatBan
    {
        private string hoTenKH;
        private string sDT;
        private DateTime TGDB;
        private string GhiChu;

        public DatBan(DataRow row)
        {
            this.hoTenKH = row["HoTenKH"].ToString();
            this.sDT = row["SDT"].ToString();
            this.TGDB = (DateTime)row["GioDatBan"];
            this.GhiChu = row["GhiChu"].ToString();

        }
        public DatBan(string hoTenKH, string sDT, DateTime tGDB, string ghiChu)
        {
            this.hoTenKH = hoTenKH;
            this.sDT = sDT;
            TGDB = tGDB;
            GhiChu = ghiChu;
        }

        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime TGDB1 { get => TGDB; set => TGDB = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    }
}
