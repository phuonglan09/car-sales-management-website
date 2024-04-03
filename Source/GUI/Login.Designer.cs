namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTenDn = new System.Windows.Forms.TextBox();
            this.rdBtnNhanVien = new System.Windows.Forms.RadioButton();
            this.rdBtnKeToan = new System.Windows.Forms.RadioButton();
            this.rdBtnQuanLy = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new GUI.CustomBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(731, 251);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(381, 38);
            this.txtPass.TabIndex = 36;
            this.txtPass.WordWrap = false;
            // 
            // txtTenDn
            // 
            this.txtTenDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDn.Location = new System.Drawing.Point(731, 178);
            this.txtTenDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDn.Multiline = true;
            this.txtTenDn.Name = "txtTenDn";
            this.txtTenDn.Size = new System.Drawing.Size(381, 42);
            this.txtTenDn.TabIndex = 42;
            this.txtTenDn.WordWrap = false;
            // 
            // rdBtnNhanVien
            // 
            this.rdBtnNhanVien.AutoSize = true;
            this.rdBtnNhanVien.BackColor = System.Drawing.Color.LightCyan;
            this.rdBtnNhanVien.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnNhanVien.Location = new System.Drawing.Point(1057, 345);
            this.rdBtnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnNhanVien.Name = "rdBtnNhanVien";
            this.rdBtnNhanVien.Size = new System.Drawing.Size(94, 40);
            this.rdBtnNhanVien.TabIndex = 38;
            this.rdBtnNhanVien.TabStop = true;
            this.rdBtnNhanVien.Text = "Staff";
            this.rdBtnNhanVien.UseVisualStyleBackColor = false;
            // 
            // rdBtnKeToan
            // 
            this.rdBtnKeToan.AutoSize = true;
            this.rdBtnKeToan.BackColor = System.Drawing.Color.LightCyan;
            this.rdBtnKeToan.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnKeToan.Location = new System.Drawing.Point(642, 345);
            this.rdBtnKeToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnKeToan.Name = "rdBtnKeToan";
            this.rdBtnKeToan.Size = new System.Drawing.Size(183, 40);
            this.rdBtnKeToan.TabIndex = 39;
            this.rdBtnKeToan.TabStop = true;
            this.rdBtnKeToan.Text = "Accountant";
            this.rdBtnKeToan.UseVisualStyleBackColor = false;
            // 
            // rdBtnQuanLy
            // 
            this.rdBtnQuanLy.AutoSize = true;
            this.rdBtnQuanLy.BackColor = System.Drawing.Color.LightCyan;
            this.rdBtnQuanLy.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnQuanLy.Location = new System.Drawing.Point(859, 345);
            this.rdBtnQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnQuanLy.Name = "rdBtnQuanLy";
            this.rdBtnQuanLy.Size = new System.Drawing.Size(149, 40);
            this.rdBtnQuanLy.TabIndex = 40;
            this.rdBtnQuanLy.TabStop = true;
            this.rdBtnQuanLy.Text = "Manager";
            this.rdBtnQuanLy.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Azure;
            this.pictureBox4.Image = global::GUI.Properties.Resources.User;
            this.pictureBox4.Location = new System.Drawing.Point(156, 118);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(342, 338);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Image = global::GUI.Properties.Resources.Lock;
            this.pictureBox2.Location = new System.Drawing.Point(642, 251);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Azure;
            this.pictureBox3.Image = global::GUI.Properties.Resources.ues;
            this.pictureBox3.Location = new System.Drawing.Point(648, 178);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.loginpic11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1308, 889);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGreen;
            this.btnLogin.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnLogin.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(809, 433);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 59);
            this.btnLogin.TabIndex = 43;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.Black;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 889);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtTenDn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rdBtnQuanLy);
            this.Controls.Add(this.rdBtnKeToan);
            this.Controls.Add(this.rdBtnNhanVien);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTenDn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdBtnNhanVien;
        private System.Windows.Forms.RadioButton rdBtnKeToan;
        private System.Windows.Forms.RadioButton rdBtnQuanLy;
        private CustomBtn btnLogin;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}