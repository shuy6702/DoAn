using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class NhanVien
    {
        private string hoTenNV;
        private string diaChiNV;
        private float luong;
        private float thuong;
        private int viPham;
        private float cong;

        public NhanVien() { }



        public NhanVien(DataRow row)
        {
            this.hoTenNV = row["HoTenNV"].ToString();
            this.diaChiNV = row["DiaChiNV"].ToString();
            this.luong = (float)row["Luong"];
            this.thuong = (float)row["Thuong"];
            this.viPham = (int)row["ViPham"];
            this.cong = (float)row["Cong"];
        }

        public NhanVien(string hoTenNV, string diaChiNV, float luong, float thuong, int viPham, float cong)
        {
            this.hoTenNV = hoTenNV;
            this.diaChiNV = diaChiNV;
            this.luong = luong;
            this.thuong = thuong;
            this.viPham = viPham;
            this.cong = cong;
        }

        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string DiaChiNV { get => diaChiNV; set => diaChiNV = value; }
        public float Luong { get => luong; set => luong = value; }
        public float Thuong { get => thuong; set => thuong = value; }
        public int ViPham { get => viPham; set => viPham = value; }
        public float Cong { get => cong; set => cong = value; }
    }
}
