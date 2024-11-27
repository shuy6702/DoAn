using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class DaatBanDAO
    {
        private static DaatBanDAO instance;

        public static DaatBanDAO Instance
        {
            get => instance == null ? instance = new DaatBanDAO() : instance;
            private set => instance = value;
        }
        public void InsertDB(string HoTenKH, string SDT, DateTime TGDB, string GhiChu)
        {
            Connection.Instance.ExecuteQuery("exec USP_insertDB @HoTenKH , @SDT , @GioDatBan , @GhiChu ", new object[] { HoTenKH, SDT, TGDB, GhiChu });
        }

        public void UpdateDB(string HoTenKH, string SDT, DateTime TGDB, string GhiChu)
        {
            Connection.Instance.ExecuteQuery("exec USP_UpdateDB @HoTenKH , @SDT , @GioDatBan , @GhiChu", new object[] { HoTenKH, SDT, TGDB, GhiChu });
        }

        public void DeleteDB(string HoTenKH)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteDB @HoTenKH ", new object[] { HoTenKH });
        }
    }
}
