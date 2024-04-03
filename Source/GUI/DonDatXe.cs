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
    public partial class DonDatXe : Form
    {
        public DonDatXe()
        {
            InitializeComponent();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            Form form = new TaoMoiDon();
            form.Show();
        }
        public DataGridView dgvDSDX;
        BLL_DonHang bLL_DonHang = new BLL_DonHang();
        private void loaddata()
        {
            dgvDSDX.DataSource = bLL_DonHang.getDonDatXe("");
        }
        private void DonDatXe_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string name = txtFind.Text.Trim();
            if (name == "")
            {
                loaddata();
            }
            else
            {
                dgvDSDX.DataSource = bLL_DonHang.getDonDatXe(" where Client.TenKH like N'%" + name + "%' or Vehicle.Mau like N'%" + name + "%' or Staff.Ten like N'%" + name + "%' ");
            }
        }
        public static string savemadh;
        public static string savemakh;
        public static string savemaxe;
        private void dgvDSDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào ô hợp lệ (không phải header)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy dữ liệu của cột đầu tiên của dòng được click
                savemadh = dgvDSDX.Rows[e.RowIndex].Cells[0].Value.ToString();
                savemakh = dgvDSDX.Rows[e.RowIndex].Cells[1].Value.ToString();
                savemaxe = dgvDSDX.Rows[e.RowIndex].Cells[4].Value.ToString();



            }

            Form a = new ChiTietDatXe();
            a.Show();
        }
    }
}
