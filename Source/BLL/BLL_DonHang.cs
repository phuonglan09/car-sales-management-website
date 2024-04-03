using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DonHang
    {
        ConnectDB connectDB;

        public BLL_DonHang()
        {
            connectDB = new ConnectDB();
        }

        public DataTable getAccount()
        {
            return connectDB.getDataTable("DonHang");
        }

        public DataTable getLoai(string dk)
        {
            return connectDB.LayDTable("select * from DonHang" + dk); 
        }
        public DataTable getThongKe(string dk)
        {
            string query = "SELECT Vehicle.Hang AS HangXe, Vehicle.Mau AS MauXe, COUNT(DonHang.MaDH) AS SoLuong, SUM(DonHangInfo.TotalPrice) AS DoanhThu " +
                   "FROM DonHang " +
                   "JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH " +
                   "JOIN Client ON DonHang.MaKH = Client.MaKH " +
                   "JOIN Staff ON DonHang.MaNV = Staff.MaNV " +
                   "JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe " +
                   "GROUP BY Vehicle.Hang, Vehicle.Mau " +
                   "ORDER BY HangXe, MauXe " +
                   dk;  // Thêm điều kiện vào cuối câu truy vấn

            return connectDB.LayDTable(query);
        }
        public DataTable getDonDatXe(string dk)
        {
            return connectDB.LayDTable(
                "SELECT DonHang.MaDH, Client.MaKH, Client.TenKH, Staff.Ten,Vehicle.MaXe, Vehicle.Mau, DonHang.NgayThemDH, DonHang.CheckReturn, " +
                "DonHangInfo.DateOfPayment, DonHangInfo.TongSoLuong, DonHangInfo.TotalPrice FROM DonHang " +
                "JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH " +
                "JOIN Client ON DonHang.MaKH = Client.MaKH " +
                "JOIN Staff ON DonHang.MaNV = Staff.MaNV " +
                "JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe" + dk);
        }

        public DataTable getDonChiTiet(string dk)
        {
            return connectDB.LayDTable(
                "SELECT DonHang.* FROM DonHang " +
                "JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH " +
                "JOIN Client ON DonHang.MaKH = Client.MaKH " +
                "JOIN Staff ON DonHang.MaNV = Staff.MaNV " +
                "JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe" + dk);
        }
        public DataTable getLichTrinh(string dk)
        {
            return connectDB.LayDTable(
                "SELECT DonHang.MaDH,Client.TenKH, DonHang.NgayThue,DonHang.NgayTra, Vehicle.MaXe, Vehicle.Mau,DonHang.CheckReturn, Vehicle.TinhTrang FROM DonHang " +
                "JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH " +
                "JOIN Client ON DonHang.MaKH = Client.MaKH " +
                "JOIN Staff ON DonHang.MaNV = Staff.MaNV " +
                "JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe" + dk);
        }

        public DataTable getTinhTrang(string dk)
        {
            return connectDB.LayDTable(
                "SELECT DonHang.MaDH,Client.TenKH, DonHang.NgayThue, Vehicle.Mau, DonHang.CheckReturn, DonHang.TinhTrangTruoc, DonHangInfo.TinhTrangSau FROM DonHang " +
                "JOIN DonHangInfo ON DonHang.MaDH = DonHangInfo.MaDH " +
                "JOIN Client ON DonHang.MaKH = Client.MaKH " +
                "JOIN Staff ON DonHang.MaNV = Staff.MaNV " +
                "JOIN Vehicle ON DonHang.MaXe = Vehicle.MaXe" + dk);
        }
        public bool UpdateTraXe_Info(string MaDH, DateTime DateOfPayment, string TinhTrangSau)
        {
            string query =
                "UPDATE DonHangInfo set DateOfPayment = '" + DateOfPayment + "',  TinhTrangSau = N'" + TinhTrangSau + "'  where MaDH = '" + MaDH + "'   ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
        public bool UpdateTraXe_DonHang(string MaDH, DateTime NgayTra, string CheckReturn)
        {
            string query =
                "UPDATE DonHangset NgayTra = '" + NgayTra + "',  CheckReturn = '" + CheckReturn + "'  where MaDH = '" + MaDH + "'   ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        // Place order
        public bool AddDH(string MaDH, string MaKH, string MaNV, string MaXe, DateTime NgayThue, DateTime NgayTra, string TinhTrangTruoc, DateTime NgayThemDH, string CheckReturn, string GhiChu)
        {
            string query =
            "INSERT INTO DonHang VALUES('" + MaDH + "', '" + MaKH + "', '" + MaNV + "', '" + MaXe + "','" + NgayThue + "', '" + NgayTra + "', N'" + TinhTrangTruoc + "', '" + NgayThemDH + "', '" + CheckReturn + "', N'" + GhiChu + "')";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
        
        
   
    }
}
