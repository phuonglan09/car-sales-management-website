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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }
        string TenDN, Pass, quen;
        public Home(string TenDN, string pass, string quyen)
        {
            InitializeComponent();
            this.TenDN  = TenDN;
            this.Pass = pass;
            this.quen = quyen;

        }
        private Form currenChild;

        private void OpenChild(Form chil)
        {
            if (currenChild != null)
            {
                currenChild.Close();
            }
            currenChild = chil;
            chil.TopLevel = false;
            chil.FormBorderStyle = FormBorderStyle.None;
            chil.Dock = DockStyle.Fill;
            panel_body.Controls.Add(chil);
            panel_body.Tag = chil;
            chil.BringToFront();
            chil.Show();
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChild(new Account());
            label2.Text = btnTaiKhoan.Text;
        }

        private void btnThongTinNV_Click(object sender, EventArgs e)
        {
            OpenChild(new Staff());
            label2.Text = btnThongTinNV.Text;
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChild(new Client());
            label2.Text = btnKH.Text;
        }

        private void btnThongTinXe_Click(object sender, EventArgs e)
        {
            OpenChild(new ThongTinXe());
            label2.Text = btnThongTinXe.Text;
        }

        private void btnQLXe_Click(object sender, EventArgs e)
        {
            OpenChild(new Vehicle());
            label2.Text = btnQLXe.Text;
        }

        private void btnDonDatXe_Click(object sender, EventArgs e)
        {
            OpenChild(new DonDatXe());
            label2.Text = btnDonDatXe.Text;
        }
        public static string Quyen;

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Form a = new XuatFile();
            a.Show();
            label2.Text = btnBaoCao.Text;
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            OpenChild(new Lichtrinh());
            label2.Text = btnLichTrinh.Text;
        }

        private void btnTinhTrang_Click(object sender, EventArgs e)
        {
            OpenChild(new TinhTrangXe());
            label2.Text = btnTinhTrang.Text;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChild(new ThongKe());
            label2.Text = btnThongKe.Text;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Quyen == "Staff")
            {
                pnlDropThongKe.Enabled = false;
                pnlDropNV.Enabled = false;
             
                this.Text = "Trang chủ Nhân viên";
            }
            else if (Quyen == "Accountant")
            {
                pnlDropKH.Enabled = false;
                pnlDropDH.Enabled = false;
                pnlDropXe.Enabled = false;
                pnlDropNV.Enabled = false;
                pnlLichTrinh.Enabled = false;
                this.Text = "Trang chủ Kế toán";
            }
            else
            {
                this.Text = "Trang chủ Quản lý";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DialogResult.OK == DialogResult)
                {

                    MessageBox.Show("Đăng xuất thất bại");
                }
                else
                {
                    MessageBox.Show("Đăng xuất thành công");
                    Login login = new Login();

                    login.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
