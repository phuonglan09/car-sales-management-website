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
    public class BLL_Vehicle
    {
        ConnectDB connectDB;

        public BLL_Vehicle()
        {
            connectDB = new ConnectDB();
        }

        public DataTable getAccount()
        {
            return connectDB.getDataTable("Vehicle");
        }

        public DataTable getLoai(string dk)
        {
            return connectDB.LayDTable("select * from Vehicle" + dk);
        }
        public DataTable getTen(string dk)
        {
            return connectDB.LayDTable("select MaXe, Mau, LoaiXe, LoaiNhienLieu, MauSac,GiaThue,TinhTrang   from Vehicle" + dk);
        }
      

        public float GetGia(string maxe)
        {
            float gia = 0.0f;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = LAN\\SQLEXPRESS01; Initial Catalog = RentCar3; Integrated Security = True"))
                {
                    connection.Open();

                    string query = "SELECT GiaThue FROM Vehicle WHERE MaXe = @MaXe";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaXe", maxe);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            gia = Convert.ToSingle(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
            }

            return gia;
        }

        public bool AddXe(string MaXe, string Mau, string LoaiXe, string Hang, string LoaiNhienLieu, string DungTich, string Registration, string MauSac,string TinhNang, string GiaThue, string TinhTrang, string Note)
        {
            string query =
                "INSERT INTO Vehicle VALUES('" + MaXe + "', N'" + Mau + "', N'" + LoaiXe + "', N'" + Hang + "', N'" + LoaiNhienLieu + "' , '" + DungTich + "', N'" + Registration + "', N'" + MauSac + "', N'" + TinhNang + "', '" + GiaThue + "', N'" + TinhTrang + "', N'" + Note + "')";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }

        public bool UpdateXe(string MaXe, string Mau, string LoaiXe, string Hang, string LoaiNhienLieu, string DungTich, string Registration, string MauSac, string TinhNang, string GiaThue, string TinhTrang, string Note)
        {
            string query =
                "UPDATE Vehicle set Mau = N'" + Mau + "', LoaiXe = N'" + LoaiXe + "', Hang = N'" + Hang + "',  LoaiNhienLieu = N'" + LoaiNhienLieu + "',  DungTich = '" + DungTich + "',  Registration = N'" + Registration + "',  MauSac = N'" + MauSac + "',  TinhNang = N'" + TinhNang + "',   GiaThue = '" + GiaThue + "' ,  TinhTrang = N'" + TinhTrang + "',  Note = N'" + Note + "' where MaXe = '" + MaXe + "'   ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
        public bool UpdateTinhTrang(string MaXe, string TinhTrang)
        {
            string query =
                "UPDATE Vehicle set TinhTrang = N'" + TinhTrang + "' where MaXe = '" + MaXe + "' ";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
        public bool DeleteXe(string maxe)
        {
            string query =
                "DELETE From Vehicle where MaXe = '" + maxe + "'";
            bool temp = connectDB.MyExcuteNonquery(query);
            connectDB.CloseConnection();
            return temp;
        }
    }
}
