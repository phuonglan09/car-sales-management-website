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
    public partial class TinhTrangXe : Form
    {
        public TinhTrangXe()
        {
            InitializeComponent();
        }
        BLL_DonHang BLL_DonHang = new BLL_DonHang();

        private void TinhTrangXe_Load(object sender, EventArgs e)
        {
            dgvTinhTrang.DataSource = BLL_DonHang.getTinhTrang("");

        }
    }
}
