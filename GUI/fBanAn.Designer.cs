namespace GUI
{
    partial class frm_BanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BanAn));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtn_themban = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_xoaban = new DevExpress.XtraBars.BarButtonItem();
            this.btn_refesh_banan = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.gv_banan = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.MaBan = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TenBan = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_banan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtn_themban,
            this.bbtn_xoaban,
            this.btn_refesh_banan,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_themban, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_xoaban, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_refesh_banan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtn_themban
            // 
            this.bbtn_themban.Caption = "Thêm";
            this.bbtn_themban.Id = 0;
            this.bbtn_themban.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_themban.ImageOptions.Image")));
            this.bbtn_themban.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_themban.ImageOptions.LargeImage")));
            this.bbtn_themban.Name = "bbtn_themban";
            this.bbtn_themban.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_themban_ItemClick);
            // 
            // bbtn_xoaban
            // 
            this.bbtn_xoaban.Caption = "Xóa";
            this.bbtn_xoaban.Id = 1;
            this.bbtn_xoaban.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_xoaban.ImageOptions.Image")));
            this.bbtn_xoaban.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_xoaban.ImageOptions.LargeImage")));
            this.bbtn_xoaban.Name = "bbtn_xoaban";
            // 
            // btn_refesh_banan
            // 
            this.btn_refesh_banan.Caption = "refresh";
            this.btn_refesh_banan.Id = 2;
            this.btn_refesh_banan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refesh_banan.ImageOptions.Image")));
            this.btn_refesh_banan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_refesh_banan.ImageOptions.LargeImage")));
            this.btn_refesh_banan.Name = "btn_refesh_banan";
            this.btn_refesh_banan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_refesh_banan_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1035);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 984);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 984);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // gv_banan
            // 
            this.gv_banan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_banan.Location = new System.Drawing.Point(0, 51);
            this.gv_banan.MainView = this.bandedGridView1;
            this.gv_banan.MenuManager = this.barManager1;
            this.gv_banan.Name = "gv_banan";
            this.gv_banan.Size = new System.Drawing.Size(1924, 984);
            this.gv_banan.TabIndex = 4;
            this.gv_banan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.MaBan,
            this.TenBan});
            this.bandedGridView1.GridControl = this.gv_banan;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "THÔNG TIN BÀN";
            this.gridBand1.Columns.Add(this.MaBan);
            this.gridBand1.Columns.Add(this.TenBan);
            this.gridBand1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridBand1.ImageOptions.Image")));
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 188;
            // 
            // MaBan
            // 
            this.MaBan.Caption = "Mã Bàn";
            this.MaBan.FieldName = "MaBan";
            this.MaBan.MinWidth = 25;
            this.MaBan.Name = "MaBan";
            this.MaBan.OptionsColumn.ReadOnly = true;
            this.MaBan.Visible = true;
            this.MaBan.Width = 94;
            // 
            // TenBan
            // 
            this.TenBan.Caption = "Tên Bàn";
            this.TenBan.FieldName = "TenBan";
            this.TenBan.MinWidth = 25;
            this.TenBan.Name = "TenBan";
            this.TenBan.OptionsColumn.ReadOnly = true;
            this.TenBan.Visible = true;
            this.TenBan.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_BanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.gv_banan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_BanAn";
            this.Text = "fBanAn";
            this.Load += new System.EventHandler(this.frm_BanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_banan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbtn_themban;
        private DevExpress.XtraBars.BarButtonItem bbtn_xoaban;
        private DevExpress.XtraBars.BarButtonItem btn_refesh_banan;
        private DevExpress.XtraGrid.GridControl gv_banan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MaBan;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TenBan;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}