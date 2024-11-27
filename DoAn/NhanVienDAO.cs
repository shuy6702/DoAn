using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get => instance == null ? instance = new NhanVienDAO() : instance;
            private set => instance = value;
        }
        public void InsertNV(string HoTenNV, string DiaChiNV, float Luong, float Thuong, int ViPham, float Cong)
        {
            Connection.Instance.ExecuteQuery("exec USP_insertNV @HoTenNV , @DiachiNV , @Luong , @Thuong , @ViPham , @Cong", new object[] { HoTenNV, DiaChiNV, Luong, Thuong, ViPham, Cong });
        }

        public void UpdateNV(string HoTenNV, string DiaChiNV, float Luong, float Thuong, int ViPham, float Cong)
        {
            Connection.Instance.ExecuteQuery("exec USP_UpdateNV @HoTenNV , @DiachiNV , @Luong , @Thuong , @ViPham , @Cong", new object[] { HoTenNV, DiaChiNV, Luong, Thuong, ViPham, Cong });
        }

        public void DeleteNV(string HoTenNV)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteNV @HoTenNV ", new object[] { HoTenNV });
        }
    }
}
