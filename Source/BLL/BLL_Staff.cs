using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Staff
    {
        ConnectDB connectDB;

        public BLL_Staff()
        {
            connectDB = new ConnectDB();
        }

        public DataTable getStaff()
        {
            return connectDB.getDataTable("Staff");
        }

        public DataTable getLoai(string dk)
        {
            return connectDB.LayDTable("select * from Staff" + dk);
        }
        public DataTable getTen(string dk)
        {
            return connectDB.LayDTable("select MaNV, Ten from Staff" + dk);
        }


        public bool AddNhanVien(string manv, string ten, string gioitinh, string email, string phone, string diachi)
        {
            string query =
                "INSERT INTO Staff VALUES('" + manv + "', N'" + ten + "', '" + gioitinh + "' , '" + email + "' , '" + phone + "', N'" + diachi + "')";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool UpdateNhanVien(string manv, string ten, string gioitinh, string email, string phone, string diachi)
        {
            string query =
                "UPDATE Staff set Ten = N'" + ten + "',  GioiTinh = '" + gioitinh + "',  Email = '" + email + "',  Phone = '" + phone + "' ,  DiaChi = N'" + diachi + "'where MaNV = '" + manv + "'   ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool DeleteNhanVien(string manv)
        {
            string query =
                "DELETE From Staff where MaNV = '" + manv + "'";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
    }
}

