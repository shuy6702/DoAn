using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get => instance == null ? instance = new AccountDAO() : instance;
            private set => instance = value;
        }

        private AccountDAO() { }

        public bool login(string userName, string password)
        {
            string query = "USP_login @userName , @passWord ";
            DataTable result = Connection.Instance.ExecuteQuery(query, new object[] { userName, password });
            //DataTable result = Modify.Instance.Table(query);
            return result.Rows.Count > 0;
        }
        public Account GetAccountcsByUserName(string userName)
        {
            DataTable data = Connection.Instance.ExecuteQuery("select * from account where Username = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = Connection.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @passWord , @newPassword", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }
        public void InsertAccount(string userName, string displayname, string passWord, int type)
        {
            Connection.Instance.ExecuteQuery("exec USP_insertaccount @userName , @displayname , @passWord , @type", new object[] { userName, displayname, passWord, type });
        }
        public void SuaAccount(string userName, string displayname, string passWord, int type)
        {
            Connection.Instance.ExecuteQuery("exec USP_updateaccountinfo @userName , @displayname , @passWord , @type", new object[] { userName, displayname, passWord, type });
        }
        public void DeleteAccount(string userName)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteAccount @userName", new object[] { userName });
        }
    }
}
