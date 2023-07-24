namespace GUI
{
    partial class frm_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cb_hienmatkhau = new System.Windows.Forms.CheckBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_thoat = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 3);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel.Controls.Add(this.cb_hienmatkhau);
            this.panel.Controls.Add(this.btn_dangnhap);
            this.panel.Controls.Add(this.txt_matkhau);
            this.panel.Controls.Add(this.txt_taikhoan);
            this.panel.Controls.Add(this.pictureBox3);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.lbl_thoat);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(609, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(307, 450);
            this.panel.TabIndex = 1;
      
            // 
            // cb_hienmatkhau
            // 
            this.cb_hienmatkhau.AutoSize = true;
            this.cb_hienmatkhau.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_hienmatkhau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_hienmatkhau.Location = new System.Drawing.Point(89, 359);
            this.cb_hienmatkhau.Name = "cb_hienmatkhau";
            this.cb_hienmatkhau.Size = new System.Drawing.Size(135, 23);
            this.cb_hienmatkhau.TabIndex = 11;
            this.cb_hienmatkhau.Text = "Hiện mật khẩu";
            this.cb_hienmatkhau.UseVisualStyleBackColor = true;
            this.cb_hienmatkhau.CheckedChanged += new System.EventHandler(this.cb_hienmatkhau_CheckedChanged);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dangnhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dangnhap.Location = new System.Drawing.Point(90, 405);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(153, 33);
            this.btn_dangnhap.TabIndex = 10;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.White;
            this.txt_matkhau.Location = new System.Drawing.Point(89, 320);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(197, 23);
            this.txt_matkhau.TabIndex = 9;
            this.txt_matkhau.Text = "123";
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_taikhoan.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_taikhoan.Location = new System.Drawing.Point(89, 255);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(197, 23);
            this.txt_taikhoan.TabIndex = 8;
            this.txt_taikhoan.Text = "admin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.Password;
            this.pictureBox3.Location = new System.Drawing.Point(26, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.tk2;
            this.pictureBox2.Location = new System.Drawing.Point(26, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(87, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 1);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 1);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tk11;
            this.pictureBox1.Location = new System.Drawing.Point(124, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(187, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 3);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // lbl_thoat
            // 
            this.lbl_thoat.AutoSize = true;
            this.lbl_thoat.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thoat.ForeColor = System.Drawing.Color.White;
            this.lbl_thoat.Location = new System.Drawing.Point(265, 0);
            this.lbl_thoat.Name = "lbl_thoat";
            this.lbl_thoat.Size = new System.Drawing.Size(42, 40);
            this.lbl_thoat.TabIndex = 0;
            this.lbl_thoat.Text = "X";
            this.lbl_thoat.Click += new System.EventHandler(this.lbl_thoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.bg_login;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.CheckBox cb_hienmatkhau;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}