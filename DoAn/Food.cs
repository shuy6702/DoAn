using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Food
    {
        private int id;
        private string tenDV;
        private float donGia;
        private string donViTinh;

        public Food(DataRow row)
        {
            this.id = (int)row["MaDV"];
            this.tenDV = row["TenDV"].ToString();
            this.donGia = (int)row["DonGia"];
            this.donViTinh = row["DonViTinh"].ToString();


        }
        public Food(int id, string tenDV, float donGia, string donViTinh)
        {
            this.id = id;
            this.tenDV = tenDV;
            this.donGia = donGia;
            this.donViTinh = donViTinh;
        }

        public int Id { get => id; set => id = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
