using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class BLL_Account
    {
        ConnectDB connectDB;

        public BLL_Account()
        {
            connectDB = new ConnectDB();
        }

        public DataTable getAccount()
        {
            return connectDB.getDataTable("Account");
        }

        public DataTable getLoai(string dk)
        {
            return connectDB.LayDTable("select * from Account" + dk);
        }

      

        public bool AddTaiKhoan(string manv, string tendn, string pass, string quyen)
        {
            string query =
                "INSERT INTO Account VALUES('" + manv + "', '" + tendn + "',   '" + pass + "' , '" + quyen + "')";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool UpdateTaiKhoan(string manv, string tendn, string pass, string quyen)
        {
            string query =
                "UPDATE Account set TenDN = '" + tendn + "',  Pass = '" + pass + "',  Quyen = '" + quyen + "' where MaNV = '" + manv + "'   ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool DeleteTaiKhoan(string manv)
        {
            string query =
                "DELETE From Account where MaNV = '" + manv + "'";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
    }
}
