using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get => instance == null ? instance = new TableDAO() : instance;
            private set => instance = value;
        }
        //Modify modify;
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        public TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            Connection.Instance.ExecuteQuery("exec USP_SwitchTable @idTable1 , @idTabel2", new object[] { id1, id2 });
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable dt = Connection.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<Table> GetBan(int id)
        {
            List<Table> listMenu = new List<Table>();

            DataTable dt = Connection.Instance.ExecuteQuery("select * from Ban where MaB = " + id);

            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                listMenu.Add(table);
            }

            return listMenu;
        }
        public void InsertBan(string TenB, string status)
        {
            Connection.Instance.ExecuteQuery("exec USP_insertBan @TenB , @status", new object[] { TenB, status });
        }

        public void UpdateBan(string TenB, string status)
        {
            Connection.Instance.ExecuteQuery("exec USP_UpdateBan @TenB , @status", new object[] { TenB, status });
        }

        public void DeleteBan(string TenB)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteBan @TenB ", new object[] { TenB });
        }
    }
}
