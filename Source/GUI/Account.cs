using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace GUI   
{
    public partial class Account : Form
    {
        BLL_Account bLL_Account = new BLL_Account();
        public bool coAdd = false;
        public Account()
        {
            InitializeComponent();
        }
        
        private void Account_Load(object sender, EventArgs e)
        {
            loaddata();
            txtMaNV.Enabled = false;
        }
        private void loaddata()
        {
            setNull();
            dgvDSTK.DataSource = bLL_Account.getLoai("");
            dgvDSTK.Columns[0].HeaderText = "Mã NV";
            dgvDSTK.Columns[1].HeaderText = "Tên đăng nhập";
            dgvDSTK.Columns[2].HeaderText = "Password";
            dgvDSTK.Columns[3].HeaderText = "Quyền";

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void setNull()
        {
            txtMaNV.Clear();
            txtUser.Clear();
            txtPass.Clear();
            rdQL.Checked = false;   
            rdNV.Checked = false;   
            rdKT.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            coAdd = true;
            setNull();
            int count = dgvDSTK.Rows.Count +1;
            if (count > 9)
            {
                txtMaNV.Text = "NV" + count++ + "";
            }
            else
            {
                txtMaNV.Text = "NV" + "0" + count++ + "";
            }
            txtMaNV.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = dgvDSTK.CurrentCell.RowIndex;
            string productCode = dgvDSTK.Rows[index].Cells[0].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bLL_Account.DeleteTaiKhoan(productCode))
                {
                    loaddata();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            //true : mở    false : tắt
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNV.Enabled = false;
        }

        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvDSTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUser.Text = dgvDSTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPass.Text = dgvDSTK.Rows[e.RowIndex].Cells[2].Value.ToString();

                /*
                string loainv = "";
                if (rdNV.Checked == true)
                {
                    loainv = rdNV.Text.ToString();
                }
                else if (rdKT.Checked == true)
                {
                    loainv = rdKT.Text.ToString();
                }
                else if (rdQL.Checked == true)
                {
                    loainv = rdQL.Text.ToString();
                }
                else { 
                    loainv = "";
                }
                */
                /// --------
                if (dgvDSTK.Rows[e.RowIndex].Cells[3].Value.ToString() == rdNV.Text.ToString())
                {
                    rdNV.Checked = true;
                }
                else if (dgvDSTK.Rows[e.RowIndex].Cells[3].Value.ToString() == rdKT.Text.ToString())
                {
                    rdKT.Checked= true;
                }
                else if (dgvDSTK.Rows[e.RowIndex].Cells[3].Value.ToString() == rdQL.Text.ToString())
                {
                    rdQL.Checked = true;
                }
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //true : mở    false : tắt
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaNV.Enabled = false;
            txtUser.Focus();
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
                dgvDSTK.DataSource = bLL_Account.getLoai(" where MaNV like '%" + name + "%' or Quyen like N'%" + name + "%' or TenDN like '%" + name + "%'  ");
            }
        }
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            string use = txtUser.Text.Trim();
            string pas = txtPass.Text.Trim();
            string hashedData = GetSHA256Hash(pas);

            string loainv = "";
            if (rdNV.Checked == true)
            {
                loainv = "Staff";
            }
            else if (rdKT.Checked == true)
            {
                loainv = "Accountant";
            }
            else
            {
                loainv = "Manager";
            }
            if (coAdd == true)
            {
                if (bLL_Account.AddTaiKhoan( txtMaNV.Text, use, hashedData, loainv))
                {
                    loaddata();
                    MessageBox.Show("Thêm thành công");
                    coAdd = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                if (bLL_Account.UpdateTaiKhoan(txtMaNV.Text, use, hashedData, loainv))
                {
                    loaddata();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //true : mở    false : tắt
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaNV.Enabled = false;
        }
    }
   
}
