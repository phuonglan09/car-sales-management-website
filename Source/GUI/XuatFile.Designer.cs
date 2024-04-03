namespace GUI
{
    partial class XuatFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatFile));
            this.panelHome = new System.Windows.Forms.Panel();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.Import = new GUI.CustomBtn();
            this.btnExport = new GUI.CustomBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSXe = new System.Windows.Forms.DataGridView();
            this.btnExXe = new GUI.CustomBtn();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.AutoSize = true;
            this.panelHome.BackColor = System.Drawing.Color.Honeydew;
            this.panelHome.Controls.Add(this.btnExXe);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.dgvDSXe);
            this.panelHome.Controls.Add(this.Import);
            this.panelHome.Controls.Add(this.txt_FilePath);
            this.panelHome.Controls.Add(this.btnExport);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.dgvDSKH);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1924, 911);
            this.panelHome.TabIndex = 37;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(3, 426);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(10, 22);
            this.txt_FilePath.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.AllowUserToAddRows = false;
            this.dgvDSKH.AllowUserToDeleteRows = false;
            this.dgvDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKH.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDSKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKH.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSKH.Location = new System.Drawing.Point(45, 68);
            this.dgvDSKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSKH.RowHeadersWidth = 51;
            this.dgvDSKH.RowTemplate.Height = 24;
            this.dgvDSKH.Size = new System.Drawing.Size(1787, 321);
            this.dgvDSKH.TabIndex = 44;
            // 
            // Import
            // 
            this.Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Import.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Import.BorderColor = System.Drawing.Color.YellowGreen;
            this.Import.BorderRadius = 20;
            this.Import.BorderSize = 0;
            this.Import.FlatAppearance.BorderSize = 0;
            this.Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Import.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.Import.ForeColor = System.Drawing.Color.Black;
            this.Import.Location = new System.Drawing.Point(292, 833);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(205, 46);
            this.Import.TabIndex = 79;
            this.Import.Text = "Import xe";
            this.Import.TextColor = System.Drawing.Color.Black;
            this.Import.UseVisualStyleBackColor = false;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExport.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnExport.BorderRadius = 20;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(1110, 833);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(250, 46);
            this.btnExport.TabIndex = 75;
            this.btnExport.Text = "Export Khách hàng";
            this.btnExport.TextColor = System.Drawing.Color.Black;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(39, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 33);
            this.label2.TabIndex = 81;
            this.label2.Text = "Danh sách xe";
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
            this.dgvDSXe.Location = new System.Drawing.Point(45, 463);
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
            this.dgvDSXe.Size = new System.Drawing.Size(1787, 336);
            this.dgvDSXe.TabIndex = 80;
            // 
            // btnExXe
            // 
            this.btnExXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExXe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExXe.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnExXe.BorderRadius = 20;
            this.btnExXe.BorderSize = 0;
            this.btnExXe.FlatAppearance.BorderSize = 0;
            this.btnExXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExXe.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.btnExXe.ForeColor = System.Drawing.Color.Black;
            this.btnExXe.Location = new System.Drawing.Point(603, 833);
            this.btnExXe.Name = "btnExXe";
            this.btnExXe.Size = new System.Drawing.Size(206, 46);
            this.btnExXe.TabIndex = 82;
            this.btnExXe.Text = "Export xe";
            this.btnExXe.TextColor = System.Drawing.Color.Black;
            this.btnExXe.UseVisualStyleBackColor = false;
            this.btnExXe.Click += new System.EventHandler(this.btnExXe_Click);
            // 
            // XuatFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 911);
            this.Controls.Add(this.panelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XuatFile";
            this.Text = "BaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XuatFile_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private CustomBtn btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.TextBox txt_FilePath;
        private CustomBtn Import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSXe;
        private CustomBtn btnExXe;
    }
}