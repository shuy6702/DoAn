using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Table
    {
        public Table(DataRow row)
        {
            this.MaB = (int)row["MaB"];
            this.tenB = row["TenB"].ToString();
            this.Status = row["status"].ToString();
        }
        
        private int maB;
        private string tenB;
        private string status;

        public Table(int maB, string status)
        {
            this.maB = maB;
            this.status = status;
        }

        public Table(string tenB)
        {
            this.tenB = tenB;
        }

        public int MaB { get => maB; set => maB = value; }
        public string Status { get => status; set => status = value; }
        public string TenB { get => tenB; set => tenB = value; }
    }
}
