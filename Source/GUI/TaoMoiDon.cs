using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class TaoMoiDon : Form
    {
        BLL_Vehicle bLL_Vehicle = new BLL_Vehicle();
        BLL_Client BLL_Client = new BLL_Client();
        BLL_Staff BLL_Staff = new BLL_Staff();
        BLL_DonHang BLL_DonHang = new BLL_DonHang();
        bLL_Info bLL_Info = new bLL_Info();

        public TaoMoiDon()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            dgvDSXe.DataSource = bLL_Vehicle.getTen(" where TinhTrang like N'Trống' ");
            dgvDSXe.Columns[0].HeaderText = "Mã xe";
            dgvDSXe.Columns[1].HeaderText = "Mẫu";
            dgvDSXe.Columns[2].HeaderText = "Loại xe";
            dgvDSXe.Columns[3].HeaderText = "Nhiên liệu";
            dgvDSXe.Columns[4].HeaderText = "Màu sắc";
            dgvDSXe.Columns[5].HeaderText = "Giá thuê";
            dgvDSXe.Columns[6].HeaderText = "Tình trạng";
           
            dgvKH.DataSource = BLL_Client.getTen("");
            dgvKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKH.Columns[2].HeaderText = "Số điện thoại";

            dgvNV.DataSource = BLL_Staff.getTen("");
            dgvNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvNV.Columns[1].HeaderText = "Tên nhân viên";

            setNull();

        }
        private void setNull()
        {
            cmbMaxe.Items.Clear();
            cmbNV.Items.Clear();
            cmbKH.Items.Clear();
            //cmbNgayThue.Value = DateTime.Now;
            //cmbNgayTra.Value = DateTime.Now;
            cmbTinhTrangXeTrc.Items.Clear();
            txtTien.Clear();
        }
        private DateTime NgayThue;
        private DateTime NgayTra; 
        //moi luu ddc ngay tra
        private void cmbNgayTra_ValueChanged(object sender, EventArgs e)
        {
            NgayThue = cmbNgayThue.Value;
            NgayTra = cmbNgayTra.Value;
            TinhVaHienThiGiaTien();
        }
        private void cmbNgayThue_ValueChanged(object sender, EventArgs e)
        {
            
        }
        public void TinhVaHienThiGiaTien()
        {
            
            if (cmbNgayTra.Value > cmbNgayThue.Value)
            {
                string maxe = cmbMaxe.Text.Trim();
                TimeSpan chenhLechNgay = cmbNgayTra.Value - cmbNgayThue.Value;
                double gia = bLL_Vehicle.GetGia(maxe);
                double giaTien = chenhLechNgay.TotalDays * gia;

                // Hiển thị giá tiền trong TextBox
                txtTien.Text = giaTien.ToString();
            }
            else
            {
                txtTien.Text = "Ngày trả phải sau ngày thuê";
            }
        }
        private void btnDatXe_Click(object sender, EventArgs e)  // Thêm đơn hàng
        {

            int count = BLL_DonHang.getLoai("").Rows.Count + 1;
            int count1 = bLL_Info.getLoai("").Rows.Count + 1;
            //Form form = new DatXe();
            // form.Show();
            setNull();
            string MaDH = "";
            if (count > 9)
            {
                MaDH = "DH" + count++ + "";
            }
            else
            {
                MaDH = "DH" + "0" + count++ + "";
            }

            string MaInfo = "";
            if (count > 9)
            {
                MaInfo = "INFO" + count1++ + "";
            }
            else
            {
                MaInfo = "INFO" + "0" + count1++ + "";
            }

            string MaNV = cmbNV.Text.Trim();
            string MaKH = cmbKH.Text.Trim();
            string MaXe = cmbMaxe.Text.Trim();
            //NgayThue = cmbNgayThue.Value;
            //NgayTra = cmbNgayTra.Value;
            string TinhTrangTruoc = cmbTinhTrangXeTrc.Text.Trim();
            DateTime NgayThemDH = DateTime.Now;

            string CheckReturn = "0";
            string GhiChu = "";

            DateTime? Pay = null;
            if (BLL_DonHang.AddDH(MaDH, MaKH,  MaNV,  MaXe, NgayThue,  NgayTra,  TinhTrangTruoc,  NgayThemDH,  CheckReturn,  GhiChu))
            {
                bLL_Info.AddInfo(MaInfo, MaDH, Pay, "", "", "");
                bLL_Info.UpdateSLInfo(MaDH);
                bLL_Info.UpdateToltal(MaDH);
                bLL_Vehicle.UpdateTinhTrang(MaXe, "Đang cho thuê");
                MessageBox.Show("Thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            loaddata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaoMoiDon_Load(object sender, EventArgs e)
        {
            loaddata();
            cmbTinhTrangXeTrc.Items.AddRange(new object[] { "New", "Old", "Good", "Bad", "Same"});
            // dữ liệu cmb Mã xe
            cmbMaxe.Items.Clear();
            // Lặp qua tất cả các dòng trong DataGridView và thêm giá trị vào ComboBox
            foreach (DataGridViewRow row in dgvDSXe.Rows)
            {
                if (!row.IsNewRow) // Loại bỏ dòng mới nếu có
                {
                    // Lấy giá trị từ cột đã chọn
                    object cellValue = row.Cells[0].Value;

                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        cmbMaxe.Items.Add(cellValue.ToString());
                    }
                }
            }
            // dữ liệu cmb Mã khách hàng
            cmbKH.Items.Clear();
            // Lặp qua tất cả các dòng trong DataGridView và thêm giá trị vào ComboBox
            foreach (DataGridViewRow row in dgvKH.Rows)
            {
                if (!row.IsNewRow) // Loại bỏ dòng mới nếu có
                {
                    // Lấy giá trị từ cột đã chọn
                    object cellValue = row.Cells[0].Value;

                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        cmbKH.Items.Add(cellValue.ToString());
                    }
                }
            }

            // dữ liệu cmb Mã nv
            cmbNV.Items.Clear();
            // Lặp qua tất cả các dòng trong DataGridView và thêm giá trị vào ComboBox
            foreach (DataGridViewRow row in dgvNV.Rows)
            {
                if (!row.IsNewRow) // Loại bỏ dòng mới nếu có
                {
                    // Lấy giá trị từ cột đã chọn
                    object cellValue = row.Cells[0].Value;

                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        cmbNV.Items.Add(cellValue.ToString());
                    }
                }
            }
        }

        
    }
}
