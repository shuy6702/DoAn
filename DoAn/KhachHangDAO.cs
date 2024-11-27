using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get => instance == null ? instance = new KhachHangDAO() : instance;
            private set => instance = value;
        }
        public void InsertKH(string HoTenKH, string SDT, string CCCD, int Diem)
        {
            Connection.Instance.ExecuteQuery("exec USP_insertKH @HoTenKH , @SoDT , @CCCD , @Diem", new object[] { HoTenKH, SDT, CCCD, Diem});
        }

        public void UpdateKH(string HoTenKH, string SDT, string CCCD, int Diem)
        {
            Connection.Instance.ExecuteQuery("exec USP_UpdateKH @HoTenKH , @SoDT , @CCCD , @Diem", new object[] { HoTenKH, SDT, CCCD, Diem });
        }

        public void DeleteKH(string HoTenKH)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteKH @HoTenKH ", new object[] { HoTenKH });
        }
    }
}
