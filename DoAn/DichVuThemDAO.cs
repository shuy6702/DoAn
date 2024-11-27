using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class DichVuThemDAO
    {
        private static DichVuThemDAO instance;

        public static DichVuThemDAO Instance
        {
            get => instance == null ? instance = new DichVuThemDAO() : instance;
            private set => instance = value;
        }

        private DichVuThemDAO() { }
        public List<DichVuThem> GetListDV()
        {
            List<DichVuThem> list = new List<DichVuThem>();
            string query = "select * from DichVuThem";
            DataTable dt = Connection.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DichVuThem dichVuThem = new DichVuThem(item);
                list.Add(dichVuThem);
            }
            return list;
        }
        public void InsertDVThem(string TenDV, float DonGia, string DonViTinh)
        {
            Connection.Instance.ExecuteQuery("exec USP_InsertDVThem @TenDV , @DonGia , @DonViTinh", new object[] { TenDV, DonGia, DonViTinh });
        }
        public void UpdateDVThem(string TenDV, float DonGia, string DonViTinh)
        {
            Connection.Instance.ExecuteQuery("exec USP_updateaccountinfo @TenDV , @DonGia , @DonViTinh", new object[] { TenDV, DonGia, DonViTinh });
        }
        public void DeleteDVThem(string TenDV)
        {
            Connection.Instance.ExecuteQuery("exec USP_DeleteAccount @TenDV", new object[] { TenDV });
        }
    }
}
