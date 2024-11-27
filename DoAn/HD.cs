using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class HD
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int MaB { get; set; }
        public DateTime TGBD { get; set; }
        public DateTime? TGKT { get; set; }
        public int KM { get; set; }
        public int Status { get; set; }

        public HD(DataRow row)
        {
            MaHD = (int)row["MaHD"];
            MaKH = (int)row["MaKH"];
            MaB = (int)row["MaB"];
            TGBD = (DateTime)row["TGBD"];
            TGKT = row["TGKT"] == DBNull.Value ? (DateTime?)null : (DateTime)row["TGKT"];
            KM = (int)row["KM"];
            Status = (int)row["status"];
        }
    }
}
