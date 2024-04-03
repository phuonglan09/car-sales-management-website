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
    public partial class Client : Form
    {
        BLL_Client bLL_Client = new BLL_Client();
        public bool coAdd = false;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loaddata();
            txtMaKH.Enabled = false;
        }
        private void loaddata()
        {
            setNull();
            dgvDSKH.DataSource = bLL_Client.getLoai("");
            dgvDSKH.Columns[0].HeaderText = "Mã KH";
            dgvDSKH.Columns[1].HeaderText = "Tên KH";
            dgvDSKH.Columns[2].HeaderText = "Giới tính";
            dgvDSKH.Columns[3].HeaderText = "Mail";
            dgvDSKH.Columns[4].HeaderText = "SDT";
            dgvDSKH.Columns[5].HeaderText = "Địa chỉ";
            dgvDSKH.Columns[6].HeaderText = "Ngày thêm";

            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;
            btHuy.Enabled = false;
        }
        private void setNull()
        {
            txtMaKH.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtPhone.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            coAdd = true;
            setNull();
            int count = dgvDSKH.Rows.Count + 1;
            if (count > 9)
            {
                txtMaKH.Text = "KH" + count++ + "";
            }
            else
            {
                txtMaKH.Text = "KH" + "0" + count++ + "";
            }
            txtMaKH.Enabled = true;

            btLuu.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int index = dgvDSKH.CurrentCell.RowIndex;
            string productCode = dgvDSKH.Rows[index].Cells[0].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bLL_Client.DeleteKhachHang(productCode))
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
            btLuu.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            txtMaKH.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //true : mở    false : tắt
            btLuu.Enabled = true;
            btHuy.Enabled = true;

            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;

            txtMaKH.Enabled = false;
            txtTen.Focus();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text.Trim();
            string TenKH = txtTen.Text.Trim();
            string Mail = txtEmail.Text.Trim();
            string DC = txtDiaChi.Text.Trim();
            string SDT = txtPhone.Text.Trim();
            DateTime NgayThem = DateTime.Now;
            string GT = "";
            if (rdNam.Checked == true)
            {
                GT = rdNam.Text.ToString();
            }
            else if (rdNu.Checked == true)
            {
                GT = rdNu.Text.ToString();
            }
         
            if (coAdd == true)
            {
                if (bLL_Client.AddKhachHang( MaKH,  TenKH,  GT,  Mail,  SDT,  DC,  NgayThem))
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
                if (bLL_Client.UpdateKhachHang(MaKH, TenKH, GT, Mail, SDT, DC, NgayThem))
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

        private void btHuy_Click(object sender, EventArgs e)
        {
            //true : mở    false : tắt
            btLuu.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;

            txtMaKH.Enabled = false;
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvDSKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = dgvDSKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                if (dgvDSKH.Rows[e.RowIndex].Cells[2].Value.ToString() == rdNam.Text.ToString())
                {
                    rdNam.Checked = true;
                }
                else if (dgvDSKH.Rows[e.RowIndex].Cells[2].Value.ToString() == rdNu.Text.ToString())
                {
                    rdNu.Checked = true;
                }

                txtEmail.Text = dgvDSKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvDSKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDSKH.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = txtFind.Text.Trim();
            if (name == "")
            {
                loaddata();
            }
            else
            {
                dgvDSKH.DataSource = bLL_Client.getLoai(" where MaKH like '%" + name + "%' or TenKH like N'%" + name + "%' or GT like '%" + name + "%' or Mail like '%" + name + "%' or SDT like '%" + name + "%'  or DC like N'%" + name + "%'  or NgayThem like '%" + name + "%'  ");
            }
        }
    }
}
