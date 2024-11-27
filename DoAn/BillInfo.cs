using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class BillInfo
    {
        private int maCTHD;
        private int maHD;
        private int maDV;
        private int soLuong;
        

        public BillInfo(int maCTHD, int maHD, int maDV, int soLuong)
        {
            this.maCTHD = maCTHD;
            this.maHD = maHD;
            this.maDV = maDV;
            this.soLuong = soLuong;
            
        }
        public BillInfo(DataRow row)
        {
            this.maCTHD = (int)row["MaCTHD"];
            this.maHD = (int)row["MaHD"];
            this.maDV = (int)row["MaDV"];
            this.soLuong = (int)row["SoLuong"];
            

        }
        public int MaCTHD { get => maCTHD; set => maCTHD = value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaDV { get => maDV; set => maDV = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        
    }
}
