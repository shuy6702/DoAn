using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class QuanLyBan
    {
        private string tenB;
        private string loaiBan;
        private string status;

        public QuanLyBan(string tenB, string loaiBan, string status)
        {
            this.tenB = tenB;
            this.loaiBan = loaiBan;
            this.status = status;
        }
        public QuanLyBan(DataRow row)
        {
            this.tenB = row["TenB"].ToString();
            this.loaiBan = row["LoaiBan"].ToString();
            this.status = row["Status"].ToString();
            

        }
        public string TenB { get => tenB; set => tenB = value; }
        public string LoaiBan { get => loaiBan; set => loaiBan = value; }
        public string Status { get => status; set => status = value; }
    }
}
