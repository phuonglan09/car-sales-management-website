using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bLL_Info
    {
        ConnectDB connectDB;

        public bLL_Info()
        {
            connectDB = new ConnectDB();
        }

        public DataTable getAccount()
        {
            return connectDB.getDataTable("DonHangInfo");
        }

        public DataTable getLoai(string dk)
        {
            return connectDB.LayDTable("select * from DonHangInfo" + dk);
        }


        public bool AddInfo(string MaInfo, string MaDH, DateTime? DateOfPayment, string TongSoLuong, string TotalPrice, string TinhTrangSau)
        {
            string query =
                "INSERT INTO DonHangInfo VALUES('" + MaInfo + "', '" + MaDH + "', '" + DateOfPayment + "' , '" + TongSoLuong + "', '" + TotalPrice + "' , '" + TinhTrangSau + "')";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
        public bool UpdateSLInfo(string MaDH)
        {
            string query =
                 "UPDATE DonHangInfo SET TongSoLuong = DATEDIFF(day, (SELECT NgayThue FROM DonHang WHERE DonHangInfo.MaDH = DonHang.MaDH), (SELECT NgayTra FROM DonHang WHERE DonHangInfo.MaDH = DonHang.MaDH)) where MaDH =  '" + MaDH + "' ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool UpdateToltal(string MaDH)
        {
            string query =
                 "UPDATE DonHangInfo SET TotalPrice = DonHangInfo.TongSoLuong * Vehicle.GiaThue FROM DonHangInfo JOIN DonHang ON DonHangInfo.MaDH = DonHang.MaDH JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe where DonHangInfo.MaDH =  '" + MaDH + "' ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

    }
}
