using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDB              // connect du lieu
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public static SqlConnection connectDB;

        public ConnectDB()
        {
            conn = new SqlConnection("Data Source=LAN\\SQLEXPRESS01;Initial Catalog=RentCar3;Integrated Security=True");

        }
        // Mở kết nối
        public void OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        // Đóng kết nối
        public void CloseConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public DataTable getDataTable(string table)
        {
            DataTable dt = null;
            try
            {
                string query = "SELECT * FROM " + table;
                cmd = new SqlCommand(query, conn);
                OpenConnection();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dt;
        }

        public DataTable LayDTable(string sql) //select
        {
            try
            {
                OpenConnection();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch { return null; }
        }

        public SqlDataReader getDataReader(string tableName)
        {
            SqlDataReader dr;
            try
            {
                string query = "SELECT * FROM " + tableName;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                OpenConnection();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dr;
        }
        // thực thi
        public bool MyExcuteNonquery(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conn);
                OpenConnection();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
