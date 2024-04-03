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
    public partial class ThongTinXe : Form
    {
        BLL_Vehicle bLL_Vehicle = new BLL_Vehicle();
        public ThongTinXe()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
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
        private void ThongTinXe_Load(object sender, EventArgs e)
        {
            loaddata();
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
                dgvDSXe.DataSource = bLL_Vehicle.getLoai(" where Mau like N'%" + name + "%' or Hang like N'%" + name + "%' or LoaiXe like N'%" + name + "%' or TinhNang like N'%" + name + "%' or TinhTrang like N'%" + name + "%'  or LoaiNhienLieu like N'%" + name + "%'  ");
            }
        }
    }
}
