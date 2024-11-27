using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get => instance == null ? instance = new BillDAO() : instance;
            private set => instance = value;
        }

        private BillDAO() { }

        public int GetUnCheckBillByTable(int ID)
        {
            DataTable dt = Connection.Instance.ExecuteQuery("select * from HD where MaB = " + ID + "AND status = 0");
            if (dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.MaHD;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            Connection.Instance.ExecuteQuery("exec USP_InsertBill @MaB ", new object[] {id});
        }
        public int GetMaxBill()
        {
            try
            {
                return (int)Connection.Instance.ExecuteScalar("select max(MaHD) from HD");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int ID, int KM, float totalPrice) 
        {
            string query = "UPDATE HD set status = 1 , TGKT = GETDATE() , " +" KM = " + KM + " , TongTien =  " + totalPrice + " where MaHD = " + ID;
            Connection.Instance.ExecuteQuery(query);
        }

        public DateTime GetStartTimeByBill(int idBill)
        {
            string query = "SELECT TGBD FROM HD WHERE MaHD = @idBill";
            DataTable dt = Connection.Instance.ExecuteQuery(query, new object[] { idBill });

            if (dt.Rows.Count > 0)
            {
                return Convert.ToDateTime(dt.Rows[0]["TGBD"]);
            }

            throw new Exception("Không tìm thấy thời gian bắt đầu!");
        }

        public void UpdateEndTime(int idBill, DateTime tgkt)
        {
            string query = "UPDATE HD SET TGKT = @tgkt WHERE MaHD = @idBill";
            Connection.Instance.ExecuteNonQuery(query, new object[] { tgkt, idBill });
        }
        public HD GetBillByTable(int idTable)
        {
            string query = "SELECT * FROM HD WHERE MaB = @idTable AND status = 0";
            DataTable dt = Connection.Instance.ExecuteQuery(query, new object[] { idTable });

            if (dt.Rows.Count > 0)
            {
                return new HD(dt.Rows[0]);
            }

            return null; // Không tìm thấy hóa đơn
        }
    }
}
