using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Client
    {
        ConnectDB connectDB;

        public BLL_Client()
        {
            connectDB = new ConnectDB();
        }

        public DataTable getAccount()
        {
            return connectDB.getDataTable("Client");
        }

        public DataTable getLoai(string dk)
        {
            return connectDB.LayDTable("select * from Client" + dk);
        }
        public DataTable getTen(string dk)
        {
            return connectDB.LayDTable("select MaKH, TenKH, SDT from Client" + dk);
        }

        public bool AddKhachHang(string MaKH, string TenKH, string GT, string Mail, string SDT, string DC, DateTime NgayThem)
        {
            string query =
                "INSERT INTO Client VALUES('" + MaKH + "', N'" + TenKH + "', N'" + GT + "' , '" + Mail + "', '" + SDT + "', N'" + DC + "', '" + NgayThem + "')";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool UpdateKhachHang(string MaKH, string TenKH, string GT, string Mail, string SDT, string DC, DateTime NgayThem)
        {
            string query =
                "UPDATE Client set TenKH = N'" + TenKH + "',  GT = N'" + GT + "',  Mail = '" + Mail + "',  SDT = '" + SDT + "',  DC = N'" + DC + "',  NgayThem = '" + NgayThem + "' where MaKH = '" + MaKH + "'   ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool DeleteKhachHang(string makh)
        {
            string query =
                "DELETE From Client where MaKH = '" + makh + "'";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
    }
}
