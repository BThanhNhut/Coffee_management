namespace GUI
{
    partial class frm_DoanhThu
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
            this.dtp_ngayvao = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayra = new System.Windows.Forms.DateTimePicker();
            this.gv_doanhthu = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_chuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_doanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_ngayvao
            // 
            this.dtp_ngayvao.Location = new System.Drawing.Point(121, 9);
            this.dtp_ngayvao.Name = "dtp_ngayvao";
            this.dtp_ngayvao.Size = new System.Drawing.Size(259, 22);
            this.dtp_ngayvao.TabIndex = 0;
            // 
            // dtp_ngayra
            // 
            this.dtp_ngayra.Location = new System.Drawing.Point(514, 7);
            this.dtp_ngayra.Name = "dtp_ngayra";
            this.dtp_ngayra.Size = new System.Drawing.Size(289, 22);
            this.dtp_ngayra.TabIndex = 1;
            // 
            // gv_doanhthu
            // 
            this.gv_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_doanhthu.Location = new System.Drawing.Point(0, 40);
            this.gv_doanhthu.MainView = this.cardView1;
            this.gv_doanhthu.Name = "gv_doanhthu";
            this.gv_doanhthu.Size = new System.Drawing.Size(1924, 1015);
            this.gv_doanhthu.TabIndex = 2;
            this.gv_doanhthu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.cardView1.GridControl = this.gv_doanhthu;
            this.cardView1.Name = "cardView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Bàn";
            this.gridColumn1.FieldName = "TenBan";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tổng tiền";
            this.gridColumn2.FieldName = "TongTien";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời gian vào";
            this.gridColumn3.FieldName = "NgayVao";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thời gian ra";
            this.gridColumn4.FieldName = "NgayRa";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giảm giá (%)";
            this.gridColumn5.FieldName = "GiamGia";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_chuyen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.dtp_ngayvao);
            this.panel1.Controls.Add(this.dtp_ngayra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 41);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(409, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(860, 6);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(118, 23);
            this.btn_thongke.TabIndex = 2;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_chuyen
            // 
            this.btn_chuyen.Location = new System.Drawing.Point(1487, 11);
            this.btn_chuyen.Name = "btn_chuyen";
            this.btn_chuyen.Size = new System.Drawing.Size(225, 23);
            this.btn_chuyen.TabIndex = 5;
            this.btn_chuyen.Text = "Chuyển qua biểu đồ";
            this.btn_chuyen.UseVisualStyleBackColor = true;
           
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gv_doanhthu);
            this.Name = "frm_DoanhThu";
            this.Text = "Doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.gv_doanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ngayvao;
        private System.Windows.Forms.DateTimePicker dtp_ngayra;
        private DevExpress.XtraGrid.GridControl gv_doanhthu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thongke;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chuyen;
    }
}