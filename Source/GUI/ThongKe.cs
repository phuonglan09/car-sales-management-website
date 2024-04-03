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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        BLL_DonHang BLL_DonHang = new BLL_DonHang();

        private void ThongKe_Load(object sender, EventArgs e)
        {
            dgvDSTK.DataSource =  BLL_DonHang.getThongKe("");
        }
    }
}
