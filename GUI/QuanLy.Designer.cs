namespace GUI
{
    partial class frm_QuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLy));
            this.flp_banan = new System.Windows.Forms.FlowLayoutPanel();
            this.lsv_hoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_thucan = new System.Windows.Forms.ComboBox();
            this.cbo_loaithucan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_banchon = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.ListHinh = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_chucvu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_banan
            // 
            this.flp_banan.AutoScroll = true;
            this.flp_banan.Location = new System.Drawing.Point(88, 25);
            this.flp_banan.Name = "flp_banan";
            this.flp_banan.Size = new System.Drawing.Size(673, 731);
            this.flp_banan.TabIndex = 0;
            // 
            // lsv_hoadon
            // 
            this.lsv_hoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_hoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsv_hoadon.FullRowSelect = true;
            this.lsv_hoadon.GridLines = true;
            this.lsv_hoadon.HideSelection = false;
            this.lsv_hoadon.Location = new System.Drawing.Point(51, 40);
            this.lsv_hoadon.Name = "lsv_hoadon";
            this.lsv_hoadon.Size = new System.Drawing.Size(797, 512);
            this.lsv_hoadon.TabIndex = 3;
            this.lsv_hoadon.UseCompatibleStateImageBehavior = false;
            this.lsv_hoadon.View = System.Windows.Forms.View.Details;
            this.lsv_hoadon.SelectedIndexChanged += new System.EventHandler(this.lsv_hoadon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên thức ăn";
            this.columnHeader1.Width = 331;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gía tiền";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng Tiền";
            this.columnHeader4.Width = 266;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txt_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tongtien.ForeColor = System.Drawing.Color.Red;
            this.txt_tongtien.Location = new System.Drawing.Point(254, 30);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(249, 25);
            this.txt_tongtien.TabIndex = 7;
            this.txt_tongtien.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền hóa đơn :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsv_hoadon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(800, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 595);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.btn_themmon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbo_thucan);
            this.groupBox2.Controls.Add(this.cbo_loaithucan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(790, 625);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 187);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác nghiệp vụ";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(515, 97);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(139, 27);
            this.txt_soluong.TabIndex = 5;
            this.txt_soluong.Text = "1";
            // 
            // btn_themmon
            // 
            this.btn_themmon.Location = new System.Drawing.Point(515, 28);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(139, 41);
            this.btn_themmon.TabIndex = 4;
            this.btn_themmon.Text = "Thêm Món";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thức ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại thức ăn";
            // 
            // cbo_thucan
            // 
            this.cbo_thucan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_thucan.FormattingEnabled = true;
            this.cbo_thucan.Location = new System.Drawing.Point(139, 96);
            this.cbo_thucan.Name = "cbo_thucan";
            this.cbo_thucan.Size = new System.Drawing.Size(341, 27);
            this.cbo_thucan.TabIndex = 1;
            // 
            // cbo_loaithucan
            // 
            this.cbo_loaithucan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_loaithucan.FormattingEnabled = true;
            this.cbo_loaithucan.Location = new System.Drawing.Point(139, 42);
            this.cbo_loaithucan.Name = "cbo_loaithucan";
            this.cbo_loaithucan.Size = new System.Drawing.Size(341, 27);
            this.cbo_loaithucan.TabIndex = 0;
            this.cbo_loaithucan.SelectedIndexChanged += new System.EventHandler(this.cbo_loaithucan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bàn được chọn :";
            // 
            // lbl_banchon
            // 
            this.lbl_banchon.AutoSize = true;
            this.lbl_banchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_banchon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_banchon.Location = new System.Drawing.Point(213, 85);
            this.lbl_banchon.Name = "lbl_banchon";
            this.lbl_banchon.Size = new System.Drawing.Size(117, 25);
            this.lbl_banchon.TabIndex = 12;
            this.lbl_banchon.Text = "Chưa chọn";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_thanhtoan.Location = new System.Drawing.Point(29, 204);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(139, 41);
            this.btn_thanhtoan.TabIndex = 6;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // ListHinh
            // 
            this.ListHinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListHinh.ImageStream")));
            this.ListHinh.TransparentColor = System.Drawing.Color.Transparent;
            this.ListHinh.Images.SetKeyName(0, "check (1).png");
            this.ListHinh.Images.SetKeyName(1, "Screenshot 2022-12-10 090656.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giảm giá :";
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(162, 142);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(102, 30);
            this.txt_giamgia.TabIndex = 14;
            this.txt_giamgia.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_giamgia);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_tongtien);
            this.groupBox3.Controls.Add(this.btn_thanhtoan);
            this.groupBox3.Controls.Add(this.lbl_banchon);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(1706, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 252);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thanh toán";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(83, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tennv.Location = new System.Drawing.Point(68, 157);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(120, 26);
            this.lbl_tennv.TabIndex = 17;
            this.lbl_tennv.Text = "Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_chucvu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_tennv);
            this.panel1.Location = new System.Drawing.Point(1707, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 324);
            this.panel1.TabIndex = 4;
            // 
            // lbl_chucvu
            // 
            this.lbl_chucvu.AutoSize = true;
            this.lbl_chucvu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_chucvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_chucvu.Location = new System.Drawing.Point(117, 192);
            this.lbl_chucvu.Name = "lbl_chucvu";
            this.lbl_chucvu.Size = new System.Drawing.Size(120, 26);
            this.lbl_chucvu.TabIndex = 20;
            this.lbl_chucvu.Text = "Nhân Viên";
            // 
            // frm_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 965);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flp_banan);
            this.Name = "frm_QuanLy";
            this.Text = "QuanLy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_banan;
        private System.Windows.Forms.ListView lsv_hoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_thucan;
        private System.Windows.Forms.ComboBox cbo_loaithucan;
        private System.Windows.Forms.Button btn_themmon;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_banchon;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.ImageList ListHinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_chucvu;
    }
}