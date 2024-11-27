using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get => instance == null ? instance = new BillInfoDAO() : instance;
            private set => instance = value;
        }
        public BillInfoDAO()
        {
        }

        //public List<BillInfo> GetListBillInfo(int id)
        //{
        //    List<BillInfo> listBillInfo = new List<BillInfo>();

        //    DataTable dt = Connection.Instance.ExecuteQuery("SELECT * FROM ChiTietHD WHERE MaHD = @MaHD", new object[] { id });

        //    foreach (DataRow item in dt.Rows)
        //    {
        //        BillInfo info = new BillInfo(item);
        //        listBillInfo.Add(info);
        //    }
        //    return listBillInfo;
        //}
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable dt = Connection.Instance.ExecuteQuery("select * from ChiTietHD where MaHD = " + id);

            foreach (DataRow item in dt.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void InsertBillInfo(int maHD, int maDV, int soLuong)
        {
            Connection.Instance.ExecuteQuery("exec USP_InsertBillInfo @MaHD , @MaDV , @SoLuong ", new object[] { maHD, maDV, soLuong });
        }

        public void UpdateBillInfo(int idBill, int maDV, double soLuong)
        {
            string query = "UPDATE ChiTietHD SET SoLuong = @soLuong WHERE MaHD = @idBill AND MaDV = @maDV";
            Connection.Instance.ExecuteNonQuery(query, new object[] { soLuong, idBill, maDV });
        }
    }
}
