using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        BLL_Login BLL_Login = new BLL_Login();
        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Băm dữ liệu đầu vào
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            // check email và password
            string str = "";
            if (rdBtnKeToan.Checked == true)
            {
                str = rdBtnKeToan.Text;
            }
            else if (rdBtnNhanVien.Checked == true)
            {
                str = rdBtnNhanVien.Text;
            }
            else
            {
                str = rdBtnQuanLy.Text;
            }
            string hashedData = GetSHA256Hash(txtPass.Text);
            if (BLL_Login.LoginSuccess(txtTenDn.Text, hashedData, str) == true ) {
                MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                //ThongTinCaNhan.email = txtPass.Text;
                //ThongTinCaNhan.pass = txtTenDn.Text;
                Home.Quyen = str;
                this.Hide();
                //this.Close();
                Home frm = new Home();// 
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
