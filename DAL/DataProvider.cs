using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DataProvider
    {
        private string StringConnect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_Cafe;User ID=sa;Password=123";
        SqlConnection Conn;

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        public void Open_cn()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
        }

        public void Close_cn()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
        }
        public DataTable ExcuteQuery(string sql, object[] parameter = null)
        {
            DataTable table = new DataTable();
            using (Conn = new SqlConnection(StringConnect))
            {
                Open_cn();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                if (parameter != null)
                {
                    string[] lst_para = sql.Split(' ');
                    int i = 0;
                    foreach (string item in lst_para)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(table);
                Close_cn();
            }
            return table;
        }

        public int ExcuteNonQuery(string sql, object[] parameter = null)
        {
            int ketqua = 0;
            using (Conn = new SqlConnection(StringConnect))
            {
                Open_cn();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                if (parameter != null)
                {
                    string[] lst_para = sql.Split(' ');
                    int i = 0;
                    foreach (string item in lst_para)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                ketqua = cmd.ExecuteNonQuery();
                Close_cn();
            }
            return ketqua;
        }
        public object ExcuteScalar(string sql, object[] parameter = null)
        {
            object ketqua = 0;
            using (Conn = new SqlConnection(StringConnect))
            {
                Open_cn();
                SqlCommand cmd = new SqlCommand(sql, Conn);
                if (parameter != null)
                {
                    string[] lst_para = sql.Split(' ');
                    int i = 0;
                    foreach (string item in lst_para)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                ketqua = cmd.ExecuteScalar();
                Close_cn();
            }
            return ketqua;
        }
    }
}

