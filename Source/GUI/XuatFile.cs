using BLL;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class XuatFile : Form
    {
        public XuatFile()
        {
            InitializeComponent();
        }
    
        DataSet dsTest = new DataSet();

        //Function Read data from excel file 
        private DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;

            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                // for below Excel 2007 version
                conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';";
            else
                // for above Excel 2007 version
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=Yes';";

            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    //Read data from sheet 
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con);
                    DataSet ds = new DataSet();
                    // Fill excel data oleAdpt into dataTable 
                    oleAdpt.Fill(ds, "Client");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //Connect to Database TestLuu
                        String Str_connect_DB = "Data Source=LAN\\SQLEXPRESS01;Initial Catalog=RentCar3;Integrated Security=True";
                        SqlConnection conn_DB = new SqlConnection(Str_connect_DB);
                        conn_DB.Open();
                        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                        {
                            //Insert data to a table : Employee_t in Database
                            string SQL_Insert = " INSERT INTO Client(MaKH, TenKH, GT, Mail, SDT, DC, NgayThem) VALUES('" + ds.Tables[0].Rows[i]["MaKH"].ToString().Trim() + "', N'" + ds.Tables[0].Rows[i]["TenKH"].ToString().Trim() + "', N'" + ds.Tables[0].Rows[i]["GT"].ToString().Trim() + "', '" + ds.Tables[0].Rows[i]["Mail"].ToString().Trim() + "' , '" + ds.Tables[0].Rows[i]["SDT"].ToString().Trim() + "' , N'" + ds.Tables[0].Rows[i]["DC"].ToString().Trim() + "', '" + ds.Tables[0].Rows[i]["NgayThem"].ToString().Trim() + "' )";
                            SqlCommand cmd = new SqlCommand(SQL_Insert, conn_DB);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Imported successfully");
                        //Show data in DataGridView
                        String sql_ShowData = "Select * from  Client";
                        SqlDataAdapter da = new SqlDataAdapter(sql_ShowData, conn_DB);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDSKH.DataSource = dt;
                        conn_DB.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return dtexcel;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvDSKH, saveFileDialog1.FileName);
            }
        }

        private void ExportToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "DanhSach";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        BLL_Client bLL_Client = new BLL_Client();
        private void loaddata()
        {
            dgvDSKH.DataSource = bLL_Client.getLoai("");
           dgvDSKH.Columns[0].HeaderText = "Mã KH";
            dgvDSKH.Columns[1].HeaderText = "Tên KH";
            dgvDSKH.Columns[2].HeaderText = "Giới tính";
            dgvDSKH.Columns[3].HeaderText = "Mail";
            dgvDSKH.Columns[4].HeaderText = "SDT";
            dgvDSKH.Columns[5].HeaderText = "Địa chỉ";
            dgvDSKH.Columns[6].HeaderText = "Ngày thêm";

            dgvDSXe.DataSource = bLL_Vehicle.getLoai("");
            dgvDSXe.Columns[0].HeaderText = "Mã xe";
            dgvDSXe.Columns[1].HeaderText = "Mẫu xe";
            dgvDSXe.Columns[2].HeaderText = "Loại xe";
            dgvDSXe.Columns[3].HeaderText = "Hãng sx";
            dgvDSXe.Columns[4].HeaderText = "Nhiên liệu";
            dgvDSXe.Columns[5].HeaderText = "Dung tích";
            dgvDSXe.Columns[6].HeaderText = "Số đăng kí";
            dgvDSXe.Columns[7].HeaderText = "Màu sắc";
            dgvDSXe.Columns[8].HeaderText = "Tính năng";
            dgvDSXe.Columns[9].HeaderText = "Giá thuê";
            dgvDSXe.Columns[10].HeaderText = "Tình trạng";
            dgvDSXe.Columns[11].HeaderText = "Note";
        }
        private void XuatFile_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        BLL_Vehicle bLL_Vehicle = new BLL_Vehicle();
        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*",
                Title = "Select an Excel file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcelData(filePath);
            }
            
            dgvDSXe.Columns[0].HeaderText = "Mã xe";
            dgvDSXe.Columns[1].HeaderText = "Mẫu xe";
            dgvDSXe.Columns[2].HeaderText = "Loại xe";
            dgvDSXe.Columns[3].HeaderText = "Hãng sx";
            dgvDSXe.Columns[4].HeaderText = "Nhiên liệu";
            dgvDSXe.Columns[5].HeaderText = "Dung tích";
            dgvDSXe.Columns[6].HeaderText = "Số đăng kí";
            dgvDSXe.Columns[7].HeaderText = "Màu sắc";
            dgvDSXe.Columns[8].HeaderText = "Tính năng";
            dgvDSXe.Columns[9].HeaderText = "Giá thuê";
            dgvDSXe.Columns[10].HeaderText = "Tình trạng";
            dgvDSXe.Columns[11].HeaderText = "Note";

        }
        private void ImportExcelData(string filePath)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            int rows = worksheet.UsedRange.Rows.Count;
            int columns = worksheet.UsedRange.Columns.Count;

            DataTable dataTable = new DataTable();

            // Tạo cột cho DataTable dựa trên cột trong Excel
            for (int i = 1; i <= columns; i++)
            {
                dataTable.Columns.Add("Column" + i.ToString(), typeof(string));
            }

            // Đổ dữ liệu từ Excel vào DataTable
            for (int i = 1; i <= rows; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int j = 1; j <= columns; j++)
                {
                    dataRow[j - 1] = worksheet.Cells[i, j].Value.ToString();
                }
                dataTable.Rows.Add(dataRow);
            }

            // Hiển thị DataTable trong DataGridView
            dgvDSKH.DataSource = dataTable;

            // Đóng Excel
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void btnsql_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExXe_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dgvDSXe, saveFileDialog1.FileName);
            }
        }
    }
}
