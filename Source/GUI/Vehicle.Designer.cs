namespace GUI
{
    partial class Vehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
            this.txtMaxe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdDau = new System.Windows.Forms.RadioButton();
            this.rdXang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSXe = new System.Windows.Forms.DataGridView();
            this.cbTocDo = new System.Windows.Forms.CheckBox();
            this.cbCamLui = new System.Windows.Forms.CheckBox();
            this.cb360 = new System.Windows.Forms.CheckBox();
            this.cbGPS = new System.Windows.Forms.CheckBox();
            this.cbCBVC = new System.Windows.Forms.CheckBox();
            this.cbCamHT = new System.Windows.Forms.CheckBox();
            this.cbBT = new System.Windows.Forms.CheckBox();
            this.cbUSB = new System.Windows.Forms.CheckBox();
            this.cbCuaSo = new System.Windows.Forms.CheckBox();
            this.cbCamBien = new System.Windows.Forms.CheckBox();
            this.cbCamera = new System.Windows.Forms.CheckBox();
            this.cbBanDo = new System.Windows.Forms.CheckBox();
            this.txtModal = new System.Windows.Forms.TextBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdDien = new System.Windows.Forms.RadioButton();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.btnHuy = new GUI.CustomBtn();
            this.btnLuu = new GUI.CustomBtn();
            this.btnSua = new GUI.CustomBtn();
            this.btnXoa = new GUI.CustomBtn();
            this.btnThem = new GUI.CustomBtn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaxe
            // 
            this.txtMaxe.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxe.Location = new System.Drawing.Point(150, 10);
            this.txtMaxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxe.Multiline = true;
            this.txtMaxe.Name = "txtMaxe";
            this.txtMaxe.Size = new System.Drawing.Size(245, 30);
            this.txtMaxe.TabIndex = 62;
            this.txtMaxe.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 33);
            this.label3.TabIndex = 61;
            this.label3.Text = "Mã xe";
            // 
            // rdDau
            // 
            this.rdDau.AutoSize = true;
            this.rdDau.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.rdDau.Location = new System.Drawing.Point(755, 82);
            this.rdDau.Name = "rdDau";
            this.rdDau.Size = new System.Drawing.Size(165, 37);
            this.rdDau.TabIndex = 60;
            this.rdDau.TabStop = true;
            this.rdDau.Text = "Dầu Diesel";
            this.rdDau.UseVisualStyleBackColor = true;
            // 
            // rdXang
            // 
            this.rdXang.AutoSize = true;
            this.rdXang.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.rdXang.Location = new System.Drawing.Point(677, 82);
            this.rdXang.Name = "rdXang";
            this.rdXang.Size = new System.Drawing.Size(96, 37);
            this.rdXang.TabIndex = 59;
            this.rdXang.TabStop = true;
            this.rdXang.Text = "Xăng";
            this.rdXang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(497, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nhiên liệu";
            // 
            // txtHang
            // 
            this.txtHang.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHang.Location = new System.Drawing.Point(150, 127);
            this.txtHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHang.Multiline = true;
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(245, 30);
            this.txtHang.TabIndex = 56;
            this.txtHang.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 33);
            this.label5.TabIndex = 55;
            this.label5.Text = "Hãng sx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 33);
            this.label6.TabIndex = 53;
            this.label6.Text = "Loại xe";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(677, 1);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(201, 29);
            this.txtFind.TabIndex = 39;
            this.txtFind.WordWrap = false;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // panelHome
            // 
            this.panelHome.AutoSize = true;
            this.panelHome.BackColor = System.Drawing.Color.Honeydew;
            this.panelHome.Controls.Add(this.txtMau);
            this.panelHome.Controls.Add(this.label13);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.dgvDSXe);
            this.panelHome.Controls.Add(this.cbTocDo);
            this.panelHome.Controls.Add(this.cbCamLui);
            this.panelHome.Controls.Add(this.cb360);
            this.panelHome.Controls.Add(this.cbGPS);
            this.panelHome.Controls.Add(this.cbCBVC);
            this.panelHome.Controls.Add(this.cbCamHT);
            this.panelHome.Controls.Add(this.cbBT);
            this.panelHome.Controls.Add(this.cbUSB);
            this.panelHome.Controls.Add(this.cbCuaSo);
            this.panelHome.Controls.Add(this.cbCamBien);
            this.panelHome.Controls.Add(this.cbCamera);
            this.panelHome.Controls.Add(this.cbBanDo);
            this.panelHome.Controls.Add(this.txtModal);
            this.panelHome.Controls.Add(this.cbTinhTrang);
            this.panelHome.Controls.Add(this.txtGia);
            this.panelHome.Controls.Add(this.label10);
            this.panelHome.Controls.Add(this.txtNote);
            this.panelHome.Controls.Add(this.label11);
            this.panelHome.Controls.Add(this.label12);
            this.panelHome.Controls.Add(this.txtDT);
            this.panelHome.Controls.Add(this.label7);
            this.panelHome.Controls.Add(this.txtDK);
            this.panelHome.Controls.Add(this.label8);
            this.panelHome.Controls.Add(this.label9);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.rdDien);
            this.panelHome.Controls.Add(this.cmbLoai);
            this.panelHome.Controls.Add(this.btnHuy);
            this.panelHome.Controls.Add(this.btnLuu);
            this.panelHome.Controls.Add(this.btnSua);
            this.panelHome.Controls.Add(this.btnXoa);
            this.panelHome.Controls.Add(this.btnThem);
            this.panelHome.Controls.Add(this.txtMaxe);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.rdDau);
            this.panelHome.Controls.Add(this.rdXang);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.txtHang);
            this.panelHome.Controls.Add(this.label5);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.txtFind);
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1037, 568);
            this.panelHome.TabIndex = 35;
            // 
            // txtMau
            // 
            this.txtMau.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMau.Location = new System.Drawing.Point(675, 46);
            this.txtMau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMau.Multiline = true;
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(245, 30);
            this.txtMau.TabIndex = 101;
            this.txtMau.WordWrap = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(498, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 33);
            this.label13.TabIndex = 100;
            this.label13.Text = "Màu sắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 99;
            this.label1.Text = "Danh sách xe";
            // 
            // dgvDSXe
            // 
            this.dgvDSXe.AllowUserToAddRows = false;
            this.dgvDSXe.AllowUserToDeleteRows = false;
            this.dgvDSXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSXe.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDSXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSXe.Location = new System.Drawing.Point(-25, 451);
            this.dgvDSXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSXe.Name = "dgvDSXe";
            this.dgvDSXe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSXe.RowHeadersWidth = 51;
            this.dgvDSXe.RowTemplate.Height = 24;
            this.dgvDSXe.Size = new System.Drawing.Size(1030, 115);
            this.dgvDSXe.TabIndex = 98;
            this.dgvDSXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSXe_CellClick);
            // 
            // cbTocDo
            // 
            this.cbTocDo.AutoSize = true;
            this.cbTocDo.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbTocDo.Location = new System.Drawing.Point(778, 342);
            this.cbTocDo.Name = "cbTocDo";
            this.cbTocDo.Size = new System.Drawing.Size(227, 37);
            this.cbTocDo.TabIndex = 97;
            this.cbTocDo.Text = "Cảnh báo tốc độ";
            this.cbTocDo.UseVisualStyleBackColor = true;
            // 
            // cbCamLui
            // 
            this.cbCamLui.AutoSize = true;
            this.cbCamLui.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbCamLui.Location = new System.Drawing.Point(778, 310);
            this.cbCamLui.Name = "cbCamLui";
            this.cbCamLui.Size = new System.Drawing.Size(167, 37);
            this.cbCamLui.TabIndex = 96;
            this.cbCamLui.Text = "Camera lùi";
            this.cbCamLui.UseVisualStyleBackColor = true;
            // 
            // cb360
            // 
            this.cb360.AutoSize = true;
            this.cb360.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cb360.Location = new System.Drawing.Point(778, 277);
            this.cb360.Name = "cb360";
            this.cb360.Size = new System.Drawing.Size(184, 37);
            this.cb360.TabIndex = 95;
            this.cb360.Text = "Camera 360";
            this.cb360.UseVisualStyleBackColor = true;
            // 
            // cbGPS
            // 
            this.cbGPS.AutoSize = true;
            this.cbGPS.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbGPS.Location = new System.Drawing.Point(534, 342);
            this.cbGPS.Name = "cbGPS";
            this.cbGPS.Size = new System.Drawing.Size(176, 37);
            this.cbGPS.TabIndex = 94;
            this.cbGPS.Text = "Định vị GPS";
            this.cbGPS.UseVisualStyleBackColor = true;
            // 
            // cbCBVC
            // 
            this.cbCBVC.AutoSize = true;
            this.cbCBVC.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbCBVC.Location = new System.Drawing.Point(534, 310);
            this.cbCBVC.Name = "cbCBVC";
            this.cbCBVC.Size = new System.Drawing.Size(252, 37);
            this.cbCBVC.TabIndex = 93;
            this.cbCBVC.Text = "Cảm biến va chạm";
            this.cbCBVC.UseVisualStyleBackColor = true;
            // 
            // cbCamHT
            // 
            this.cbCamHT.AutoSize = true;
            this.cbCamHT.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbCamHT.Location = new System.Drawing.Point(534, 277);
            this.cbCamHT.Name = "cbCamHT";
            this.cbCamHT.Size = new System.Drawing.Size(262, 37);
            this.cbCamHT.TabIndex = 92;
            this.cbCamHT.Text = "Camera hành trình";
            this.cbCamHT.UseVisualStyleBackColor = true;
            // 
            // cbBT
            // 
            this.cbBT.AutoSize = true;
            this.cbBT.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbBT.Location = new System.Drawing.Point(284, 342);
            this.cbBT.Name = "cbBT";
            this.cbBT.Size = new System.Drawing.Size(154, 37);
            this.cbBT.TabIndex = 91;
            this.cbBT.Text = "Bluetooth";
            this.cbBT.UseVisualStyleBackColor = true;
            // 
            // cbUSB
            // 
            this.cbUSB.AutoSize = true;
            this.cbUSB.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbUSB.Location = new System.Drawing.Point(284, 310);
            this.cbUSB.Name = "cbUSB";
            this.cbUSB.Size = new System.Drawing.Size(194, 37);
            this.cbUSB.TabIndex = 90;
            this.cbUSB.Text = "Khe cắm USB";
            this.cbUSB.UseVisualStyleBackColor = true;
            // 
            // cbCuaSo
            // 
            this.cbCuaSo.AutoSize = true;
            this.cbCuaSo.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbCuaSo.Location = new System.Drawing.Point(284, 277);
            this.cbCuaSo.Name = "cbCuaSo";
            this.cbCuaSo.Size = new System.Drawing.Size(169, 37);
            this.cbCuaSo.TabIndex = 89;
            this.cbCuaSo.Text = "Cửa sổ trời";
            this.cbCuaSo.UseVisualStyleBackColor = true;
            // 
            // cbCamBien
            // 
            this.cbCamBien.AutoSize = true;
            this.cbCamBien.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbCamBien.Location = new System.Drawing.Point(46, 342);
            this.cbCamBien.Name = "cbCamBien";
            this.cbCamBien.Size = new System.Drawing.Size(194, 37);
            this.cbCamBien.TabIndex = 88;
            this.cbCamBien.Text = "Cảm biến lốp";
            this.cbCamBien.UseVisualStyleBackColor = true;
            // 
            // cbCamera
            // 
            this.cbCamera.AutoSize = true;
            this.cbCamera.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbCamera.Location = new System.Drawing.Point(46, 310);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(206, 37);
            this.cbCamera.TabIndex = 87;
            this.cbCamera.Text = "Camera cập lề";
            this.cbCamera.UseVisualStyleBackColor = true;
            // 
            // cbBanDo
            // 
            this.cbBanDo.AutoSize = true;
            this.cbBanDo.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.cbBanDo.Location = new System.Drawing.Point(46, 277);
            this.cbBanDo.Name = "cbBanDo";
            this.cbBanDo.Size = new System.Drawing.Size(121, 37);
            this.cbBanDo.TabIndex = 86;
            this.cbBanDo.Text = "Bản đồ";
            this.cbBanDo.UseVisualStyleBackColor = true;
            // 
            // txtModal
            // 
            this.txtModal.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModal.Location = new System.Drawing.Point(150, 51);
            this.txtModal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModal.Multiline = true;
            this.txtModal.Name = "txtModal";
            this.txtModal.Size = new System.Drawing.Size(245, 30);
            this.txtModal.TabIndex = 85;
            this.txtModal.WordWrap = false;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đang cho thuê",
            "Trống"});
            this.cbTinhTrang.Location = new System.Drawing.Point(675, 174);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(245, 24);
            this.cbTinhTrang.TabIndex = 84;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(675, 129);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(245, 30);
            this.txtGia.TabIndex = 83;
            this.txtGia.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(495, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 33);
            this.label10.TabIndex = 82;
            this.label10.Text = "Giá thuê";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(675, 208);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(245, 30);
            this.txtNote.TabIndex = 81;
            this.txtNote.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(497, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 33);
            this.label11.TabIndex = 80;
            this.label11.Text = "Note";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(497, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 33);
            this.label12.TabIndex = 79;
            this.label12.Text = "Tình trạng";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(151, 165);
            this.txtDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDT.Multiline = true;
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(245, 30);
            this.txtDT.TabIndex = 77;
            this.txtDT.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 33);
            this.label7.TabIndex = 76;
            this.label7.Text = "Dung tích";
            // 
            // txtDK
            // 
            this.txtDK.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDK.Location = new System.Drawing.Point(151, 203);
            this.txtDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDK.Multiline = true;
            this.txtDK.Name = "txtDK";
            this.txtDK.Size = new System.Drawing.Size(245, 30);
            this.txtDK.TabIndex = 75;
            this.txtDK.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 33);
            this.label8.TabIndex = 74;
            this.label8.Text = "Mẫu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 33);
            this.label9.TabIndex = 73;
            this.label9.Text = "Số đăng kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(16, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 33);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tính năng";
            // 
            // rdDien
            // 
            this.rdDien.AutoSize = true;
            this.rdDien.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.rdDien.Location = new System.Drawing.Point(868, 84);
            this.rdDien.Name = "rdDien";
            this.rdDien.Size = new System.Drawing.Size(93, 37);
            this.rdDien.TabIndex = 70;
            this.rdDien.TabStop = true;
            this.rdDien.Text = "Điện";
            this.rdDien.UseVisualStyleBackColor = true;
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "4 chỗ (Mini)",
            "4 chỗ (Sedan)",
            "4 chỗ (Hatchback)",
            "5 chỗ (CUV Gầm cao)",
            "7 chỗ (CUV Gầm cao)",
            "7 chỗ (MPV Gầm thấp)",
            "Bán tải"});
            this.cmbLoai.Location = new System.Drawing.Point(150, 88);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(245, 24);
            this.cmbLoai.TabIndex = 68;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHuy.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(777, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(127, 40);
            this.btnHuy.TabIndex = 67;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.Black;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 0;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(597, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 40);
            this.btnLuu.TabIndex = 66;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.Black;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(413, 380);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 40);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(221, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 40);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(46, 380);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 40);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.find;
            this.pictureBox2.Location = new System.Drawing.Point(884, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 568);
            this.Controls.Add(this.panelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBtn btnHuy;
        private CustomBtn btnLuu;
        private CustomBtn btnSua;
        private CustomBtn btnXoa;
        private CustomBtn btnThem;
        private System.Windows.Forms.TextBox txtMaxe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdDau;
        private System.Windows.Forms.RadioButton rdXang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.RadioButton rdDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbCamBien;
        private System.Windows.Forms.CheckBox cbCamera;
        private System.Windows.Forms.CheckBox cbBanDo;
        private System.Windows.Forms.TextBox txtModal;
        private System.Windows.Forms.CheckBox cbTocDo;
        private System.Windows.Forms.CheckBox cbCamLui;
        private System.Windows.Forms.CheckBox cb360;
        private System.Windows.Forms.CheckBox cbGPS;
        private System.Windows.Forms.CheckBox cbCBVC;
        private System.Windows.Forms.CheckBox cbCamHT;
        private System.Windows.Forms.CheckBox cbBT;
        private System.Windows.Forms.CheckBox cbUSB;
        private System.Windows.Forms.CheckBox cbCuaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSXe;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Label label13;
    }
}