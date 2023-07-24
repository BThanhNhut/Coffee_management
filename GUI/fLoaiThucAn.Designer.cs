namespace GUI
{
    partial class frm_LoaiThucAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoaiThucAn));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtn_themloaithucan = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_xoaloaithucan = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_refesh_loaithucan = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gv_loaithucan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_loaithucan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.bbtn_themloaithucan,
            this.bbtn_xoaloaithucan,
            this.bbtn_refesh_loaithucan});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_themloaithucan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_xoaloaithucan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_refesh_loaithucan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtn_themloaithucan
            // 
            this.bbtn_themloaithucan.Caption = "Thêm";
            this.bbtn_themloaithucan.Id = 0;
            this.bbtn_themloaithucan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_themloaithucan.ImageOptions.Image")));
            this.bbtn_themloaithucan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_themloaithucan.ImageOptions.LargeImage")));
            this.bbtn_themloaithucan.Name = "bbtn_themloaithucan";
            this.bbtn_themloaithucan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_themloaithucan_ItemClick);
            // 
            // bbtn_xoaloaithucan
            // 
            this.bbtn_xoaloaithucan.Caption = "Xóa";
            this.bbtn_xoaloaithucan.Id = 1;
            this.bbtn_xoaloaithucan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_xoaloaithucan.ImageOptions.Image")));
            this.bbtn_xoaloaithucan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_xoaloaithucan.ImageOptions.LargeImage")));
            this.bbtn_xoaloaithucan.Name = "bbtn_xoaloaithucan";
            // 
            // bbtn_refesh_loaithucan
            // 
            this.bbtn_refesh_loaithucan.Caption = "refresh";
            this.bbtn_refesh_loaithucan.Id = 2;
            this.bbtn_refesh_loaithucan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_refesh_loaithucan.ImageOptions.Image")));
            this.bbtn_refesh_loaithucan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_refesh_loaithucan.ImageOptions.LargeImage")));
            this.bbtn_refesh_loaithucan.Name = "bbtn_refesh_loaithucan";
            this.bbtn_refesh_loaithucan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_refesh_loaithucan_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1033);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 974);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 974);
            // 
            // gv_loaithucan
            // 
            this.gv_loaithucan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_loaithucan.Location = new System.Drawing.Point(0, 59);
            this.gv_loaithucan.MainView = this.gridView1;
            this.gv_loaithucan.MenuManager = this.barManager1;
            this.gv_loaithucan.Name = "gv_loaithucan";
            this.gv_loaithucan.Size = new System.Drawing.Size(1924, 974);
            this.gv_loaithucan.TabIndex = 4;
            this.gv_loaithucan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gv_loaithucan.Click += new System.EventHandler(this.gv_loaithucan_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gv_loaithucan;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã loại thức ăn";
            this.gridColumn1.FieldName = "MaLoai_TA";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên loại thức ăn";
            this.gridColumn2.FieldName = "TenLoai";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // frm_LoaiThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.gv_loaithucan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_LoaiThucAn";
            this.Text = "Loại thức ăn";
            this.Load += new System.EventHandler(this.fLoaiThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_loaithucan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbtn_themloaithucan;
        private DevExpress.XtraBars.BarButtonItem bbtn_xoaloaithucan;
        private DevExpress.XtraBars.BarButtonItem bbtn_refesh_loaithucan;
        private DevExpress.XtraGrid.GridControl gv_loaithucan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}