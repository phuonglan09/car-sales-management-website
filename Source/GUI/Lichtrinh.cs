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

namespace GUI
{
    public partial class Lichtrinh : Form
    {
        public string savemaxe;
        public DateTime saveNgayThue;
        public Lichtrinh()
        {
            InitializeComponent();
        }
        BLL_DonHang BLL_DonHang = new BLL_DonHang();
        BLL_Vehicle BLL_Vehicle = new BLL_Vehicle();
        private void Lichtrinh_Load(object sender, EventArgs e)
        {
            dgvDSLT.DataSource = BLL_DonHang.getLichTrinh(" where Vehicle.TinhTrang like N'Đang cho thuê'");
            cmbTTSau.Items.AddRange(new object[] { "New", "Old", "Good", "Bad", "Same" });
        
            
        }
       
        private void dgvDSLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDH.Text = dgvDSLT.Rows[e.RowIndex].Cells[0].Value.ToString();
                // Kiểm tra nếu người dùng click vào ô hợp lệ (không phải header)
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Lấy dữ liệu của cột đầu tiên của dòng được click
                    savemaxe = dgvDSLT.Rows[e.RowIndex].Cells[4].Value.ToString();
                    saveNgayThue =(DateTime) dgvDSLT.Rows[e.RowIndex].Cells[2].Value;

                }
                dtNgayThue.Value = saveNgayThue;
            }
            catch { }
        }
        private void btnTra_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trả xe không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string MaDH = txtMaDH.Text;
                DateTime NgayTra = dtNgayTra.Value;
                string CheckReturn = "1";
                string TinhTrangSau = cmbTTSau.Text.Trim();
                DateTime DateOfPayment = DateTime.Now;
                BLL_DonHang.UpdateTraXe_DonHang(MaDH, NgayTra, CheckReturn);
                BLL_DonHang.UpdateTraXe_Info(MaDH, DateOfPayment, TinhTrangSau);
                BLL_Vehicle.UpdateTinhTrang(savemaxe, "Trống");
            }
            


        }
        public void TinhVaHienThiGiaTien()
        {

            if (dtNgayTra.Value > dtNgayThue.Value)
            {
                string maxe = savemaxe;
                TimeSpan chenhLechNgay = dtNgayTra.Value - dtNgayThue.Value;
                double gia = BLL_Vehicle.GetGia(maxe);
                double giaTien = chenhLechNgay.TotalDays * gia;

                // Hiển thị giá tiền trong TextBox
                txtTien.Text = giaTien.ToString();
            }
            else
            {
                txtTien.Text = "Ngày trả phải sau ngày thuê";
            }
        }

        private void cmbTTSau_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            TinhVaHienThiGiaTien();
        }
    }
}
