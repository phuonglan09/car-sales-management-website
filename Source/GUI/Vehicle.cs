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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Vehicle : Form
    {
        BLL_Vehicle bLL_Vehicle = new BLL_Vehicle();
        public bool coAdd = false;
        public Vehicle()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            setNull();
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

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void setNull()
        {
            txtMaxe.Clear();
            txtModal.Clear();
            cmbLoai.Items.Clear();
            txtHang.Clear();
            txtDT.Clear();
            txtDK.Clear();
            txtMau.Clear();
            txtGia.Clear();
            cbTinhTrang.Items.Clear();
            txtNote.Clear();

            rdXang.Checked = false;
            rdDau.Checked = false;
            rdDien.Checked = false;

            cbBanDo.Checked = false;
            cbCamera.Checked = false;
            cbCamBien.Checked = false;
            cbCuaSo.Checked = false;
            cbUSB.Checked = false;
            cbBT.Checked = false;
            cbCamHT.Checked = false;
            cbCBVC.Checked = false;
            cbGPS.Checked = false;
            cb360.Checked = false;
            cbCamLui.Checked = false;
            cbTocDo.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            coAdd = true;
            setNull();
            int count = dgvDSXe.Rows.Count + 1;
            if (count > 9)
            {
                txtMaxe.Text = "XE" + count++ + "";
            }
            else
            {
                txtMaxe.Text = "XE" + "0" + count++ + "";
            }
            txtMaxe.Enabled = true;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            cmbLoai.Items.AddRange(new object[] { "4 chỗ (Mini)", "4 chỗ (Hatchback)", "5 chỗ (CUV Gầm cao)", "7 chỗ (CUV Gầm cao)", "7 chỗ (MPV Gầm thấp)", "Bán tải" });
            cbTinhTrang.Items.AddRange(new object[] { "Đang cho thuê", "Trống" });
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvDSXe.CurrentCell.RowIndex;
            string productCode = dgvDSXe.Rows[index].Cells[0].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bLL_Vehicle.DeleteXe(productCode))
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
            txtMaxe.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //true : mở    false : tắt
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaxe.Enabled = false;
            txtHang.Focus();

          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaXe = txtMaxe.Text.Trim();
            string Mau = txtModal.Text.Trim();
            string LoaiXe = cmbLoai.Text.Trim();
            string Hang = txtHang.Text.Trim();

            string DungTich = txtDT.Text.Trim();
            string Registration = txtDK.Text.Trim();
            string MauSac = txtMau.Text.Trim();

            string GiaThue = txtGia.Text.Trim();
            string TinhTrang = cbTinhTrang.Text.Trim();
            string Note = txtNote.Text.Trim();

            string TinhNang = "";
            if (cbBanDo.Checked == true)
            {
                TinhNang += cbBanDo.Text.ToString() + ", " ;
            }
            if (cbCamera.Checked == true)
            {
                TinhNang += cbCamera.Text.ToString() + ", ";
            }
            if (cbCamBien.Checked == true)
            {
                TinhNang += cbCamBien.Text.ToString() + ", ";
            }
            if (cbBT.Checked == true)
            {
                TinhNang += cbBT.Text.ToString() + ", ";
            }
            if (cbUSB.Checked == true)
            {
                TinhNang += cbUSB.Text.ToString() + ", ";
            }
            if (cbCuaSo.Checked == true)
            {
                TinhNang += cbCuaSo.Text.ToString() + ", ";
            }
            if (cbCamHT.Checked == true)
            {
                TinhNang += cbCamHT.Text.ToString() + ", ";
            }
            if (cbCBVC.Checked == true)
            {
                TinhNang += cbCBVC.Text.ToString() + ", ";
            }
            if (cbGPS.Checked == true)
            {
                TinhNang += cbGPS.Text.ToString() + ", ";
            }
            if (cb360.Checked == true)
            {
                TinhNang += cb360.Text.ToString() + ", ";
            }
            if (cbCamLui.Checked == true)
            {
                TinhNang += cbCamLui.Text.ToString() + ", ";
            }
            if (cbTocDo.Checked == true)
            {
                TinhNang += cbTocDo.Text.ToString() + ", ";
            }



            string LoaiNhienLieu = "";
            if (rdXang.Checked == true)
            {
                LoaiNhienLieu = rdXang.Text.ToString();
            }
            else if (rdDau.Checked == true)
            {
                LoaiNhienLieu = rdDau.Text.ToString();
            }
            else if (rdDien.Checked == true)
            {
                LoaiNhienLieu = rdDien.Text.ToString();
            }
         
            if (coAdd == true)
            {
                if (bLL_Vehicle.AddXe( MaXe, Mau,  LoaiXe,  Hang,  LoaiNhienLieu,  DungTich,  Registration,  MauSac,  TinhNang,  GiaThue,  TinhTrang,  Note))
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
                if (bLL_Vehicle.UpdateXe(MaXe, Mau, LoaiXe, Hang, LoaiNhienLieu, DungTich, Registration, MauSac, TinhNang, GiaThue, TinhTrang, Note))
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

            txtMaxe.Enabled = false;
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            loaddata();
            txtMaxe.Enabled = false;
            // thêm dữ liệu vào combobox Loại xe và combobox tình trạng xe
            cmbLoai.Items.AddRange(new object[] { "4 chỗ (Mini)", "4 chỗ (Hatchback)", "5 chỗ (CUV Gầm cao)", "7 chỗ (CUV Gầm cao)", "7 chỗ (MPV Gầm thấp)", "Bán tải" });
            cbTinhTrang.Items.AddRange(new object[] { "Đang cho thuê", "Trống" });
        }

        private void dgvDSXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // khi click vào 1 dòng trong datagridview, truyền dữ liệu vào textbox
            try
            {
                txtMaxe.Text = dgvDSXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtModal.Text = dgvDSXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbLoai.Text = dgvDSXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHang.Text = dgvDSXe.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (dgvDSXe.Rows[e.RowIndex].Cells[4].Value.ToString() == rdXang.Text.ToString())
                {
                    rdXang.Checked = true;
                }
                else if (dgvDSXe.Rows[e.RowIndex].Cells[4].Value.ToString() == rdDau.Text.ToString())
                {
                    rdDau.Checked = true;
                }
                else if (dgvDSXe.Rows[e.RowIndex].Cells[4].Value.ToString() == rdDien.Text.ToString())
                {
                    rdDien.Checked = true;
                }

                txtDT.Text = dgvDSXe.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDK.Text = dgvDSXe.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMau.Text = dgvDSXe.Rows[e.RowIndex].Cells[7].Value.ToString();

                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbBanDo.Text.ToString()))
                {
                    cbBanDo.Checked = true;
                }
                else
                {
                    cbBanDo.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbCamera.Text.ToString()))
                {
                    cbCamera.Checked = true;
                }
                else { cbCamera.Checked = false; }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbCamBien.Text.ToString()))
                {
                    cbCamBien.Checked = true;
                }
                else
                {
                    cbCamBien.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbCuaSo.Text.ToString()))
                {
                    cbCuaSo.Checked = true;
                }
                else
                {
                    cbCuaSo.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbUSB.Text.ToString()))
                {
                    cbUSB.Checked = true;
                }
                else
                {
                    cbUSB.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbBT.Text.ToString()))
                {
                    cbBT.Checked = true;
                }
                else
                {
                    cbBT.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbCamHT.Text.ToString()))
                {
                    cbCamHT.Checked = true;
                }
                else
                {
                    cbCamHT.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbCBVC.Text.ToString()))
                {
                    cbCBVC.Checked = true;
                }
                else
                {
                    cbCBVC.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbGPS.Text.ToString()))
                {
                    cbGPS.Checked = true;
                }
                else
                {
                    cbGPS.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cb360.Text.ToString()))
                {
                    cb360.Checked = true;
                }
                else
                {
                    cb360.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbCamLui.Text.ToString()))
                {
                    cbCamLui.Checked = true;
                }
                else
                {
                    cbCamLui.Checked = false;
                }
                if (dgvDSXe.Rows[e.RowIndex].Cells[8].Value.ToString().Contains(cbTocDo.Text.ToString()))
                {
                    cbTocDo.Checked = true;
                }
                else
                {
                    cbTocDo.Checked = false;
                }
                

                txtGia.Text = dgvDSXe.Rows[e.RowIndex].Cells[9].Value.ToString();
                cbTinhTrang.Text = dgvDSXe.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtNote.Text = dgvDSXe.Rows[e.RowIndex].Cells[11].Value.ToString();
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
                dgvDSXe.DataSource = bLL_Vehicle.getLoai(" where Mau like N'%" + name + "%' or Hang like N'%" + name + "%' or LoaiXe like N'%" + name + "%' or TinhNang like N'%" + name + "%' or TinhTrang like N'%" + name + "%'  or LoaiNhienLieu like N'%" + name + "%'  ");
            }
        }
    }
}
