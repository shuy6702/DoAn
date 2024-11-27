using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Account
    {
        private string userName;
        private string displayName;
        private int type;
        private string password;

        public Account() { }



        public Account(DataRow row)
        {
            this.userName = row["userName"].ToString();
            this.password = row["Password"].ToString();
            this.displayName = row["DisplayName"].ToString();
            this.type = (int)row["Type"];

        }

        public Account(string userName, string displayName, int type, string password)
        {
            this.userName = userName;
            this.displayName = displayName;
            this.type = type;
            this.password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
        public string Password { get => password; set => password = value; }
    }
}
