using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Connection
    {
        private static Connection instance;

        public static Connection Instance
        {
            get => instance == null ? instance = new Connection() : instance;
            private set => instance = value;
        }
        private Connection() { }
        private static string stringConnection = @"Data Source=DESKTOP-P2L7138\SQLEXPRESS;Initial Catalog=QuanLyBillard;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                //MessageBox.Show(query);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                connect.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();

                connect.Close();
            }
            return dt;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteScalar();

                connect.Close();
            }
            return dt;
        }
    }
}

