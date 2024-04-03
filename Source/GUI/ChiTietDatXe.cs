using BLL;
using OfficeOpenXml.LoadFunctions.Params;
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
    public partial class ChiTietDatXe : Form
    {
        public ChiTietDatXe()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        BLL_Client client = new BLL_Client();   
        BLL_Vehicle BLL_Vehicle = new BLL_Vehicle();
        BLL_DonHang BLL_DonHang = new BLL_DonHang();
        private void loaddata()
        {
            string a = DonDatXe.savemadh;
            string b = DonDatXe.savemakh;
            string c = DonDatXe.savemaxe;


            dgvDSKH.DataSource = client.getLoai("  where MaKH = '" + b + "' ");
            dgvDSXe.DataSource = BLL_Vehicle.getLoai(" where MaXe = '" + c + "' ");
            dgvDSDH.DataSource = BLL_DonHang.getDonChiTiet(" where DonHang.MaDH = '" + a + "' ");



        }
        private void ChiTietDatXe_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
