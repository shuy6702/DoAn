using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class QuanLyBanDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get => instance == null ? instance = new TableDAO() : instance;
            private set => instance = value;
        }
        public void InsertBan(string TenB, string status)
        {
            Connection.Instance.ExecuteQuery("exec USP_insertBan @TenB , @Status", new object[] { TenB, status });
        }

        public void UpdateBan(string TenB, string status)
        {
            Connection.Instance.ExecuteQuery("exec USP_UpdateBan @TenB , @Status", new object[] { TenB, status });
        }

        public void DeleteBan(string TenB)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteBan @TenB ", new object[] { TenB });
        }
    }
}
