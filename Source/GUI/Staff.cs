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
    public partial class Staff : Form
    {
        BLL_Staff bLL_Staff = new BLL_Staff();
        public bool coAdd = false;
        public Staff()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            setNull();
            dgvDSNV.DataSource = bLL_Staff.getLoai("");
            dgvDSNV.Columns[0].HeaderText = "Mã NV";
            dgvDSNV.Columns[1].HeaderText = "Tên NV";
            dgvDSNV.Columns[2].HeaderText = "Giới tính";
            dgvDSNV.Columns[3].HeaderText = "Email";
            dgvDSNV.Columns[4].HeaderText = "Phone";
            dgvDSNV.Columns[5].HeaderText = "Địa chỉ";


            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void setNull()
        {
            txtMaNV.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDiaChi.Clear();

            rdNam.Checked = false;
            rdNu.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            coAdd = true;
            setNull();
            int count = dgvDSNV.Rows.Count + 1;
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

        private void Staff_Load(object sender, EventArgs e)
        {
            loaddata();
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvDSNV.CurrentCell.RowIndex;
            string productCode = dgvDSNV.Rows[index].Cells[0].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bLL_Staff.DeleteNhanVien(productCode))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            //true : mở    false : tắt
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaNV.Enabled = false;
            txtTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            string ten = txtTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();

            string gioitinh = "";
            if (rdNam.Checked == true)
            {
                gioitinh = rdNam.Text.ToString();
            }
            else if (rdNu.Checked == true)
            {
                gioitinh = rdNu.Text.ToString();
            }
            else
            {
                gioitinh = "";
            }
            if (coAdd == true)
            {
                if (bLL_Staff.AddNhanVien( manv,  ten,  gioitinh,  email,  phone,  diachi))
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
                if (bLL_Staff.UpdateNhanVien(manv, ten, gioitinh, email, phone, diachi))
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

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // khi click vào 1 dòng trong datagridview, truyền dữ liệu vào textbox
            try
            {
                txtMaNV.Text = dgvDSNV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = dgvDSNV.Rows[e.RowIndex].Cells[1].Value.ToString();
     
                if (dgvDSNV.Rows[e.RowIndex].Cells[2].Value.ToString() == rdNam.Text.ToString())
                {
                    rdNam.Checked = true;
                }
                else if (dgvDSNV.Rows[e.RowIndex].Cells[2].Value.ToString() == rdNu.Text.ToString())
                {
                    rdNu.Checked = true;
                }

                txtEmail.Text = dgvDSNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvDSNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDSNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
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
                dgvDSNV.DataSource = bLL_Staff.getLoai(" where MaNV like '%" + name + "%' or Ten like N'%" + name + "%' or GioiTinh like N'%" + name + "%' or Phone like '%" + name + "%' or Email like '%" + name + "%' or DiaChi like N'%" + name + "%'  ");
            }
        }
    }
}
