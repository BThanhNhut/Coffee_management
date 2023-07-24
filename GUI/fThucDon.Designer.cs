namespace GUI
{
    partial class frm_ThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThucDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtn_them_ql = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_xoa_ql = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_sua_ql = new DevExpress.XtraBars.BarButtonItem();
            this.btn_refresh_thucan = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gv_thucdon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_loai = new System.Windows.Forms.ComboBox();
            this.txt_gia = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenthucan = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tenmon = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dongia = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thucdon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenthucan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenmon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongia)).BeginInit();
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
            this.bbtn_them_ql,
            this.bbtn_xoa_ql,
            this.bbtn_sua_ql,
            this.btn_refresh_thucan});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_them_ql, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_xoa_ql, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtn_sua_ql, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_refresh_thucan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtn_them_ql
            // 
            this.bbtn_them_ql.Caption = "Thêm";
            this.bbtn_them_ql.Id = 0;
            this.bbtn_them_ql.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_them_ql.ImageOptions.Image")));
            this.bbtn_them_ql.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_them_ql.ImageOptions.LargeImage")));
            this.bbtn_them_ql.Name = "bbtn_them_ql";
            this.bbtn_them_ql.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_them_ql_ItemClick);
            // 
            // bbtn_xoa_ql
            // 
            this.bbtn_xoa_ql.Caption = "Xóa ";
            this.bbtn_xoa_ql.Id = 1;
            this.bbtn_xoa_ql.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_xoa_ql.ImageOptions.Image")));
            this.bbtn_xoa_ql.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_xoa_ql.ImageOptions.LargeImage")));
            this.bbtn_xoa_ql.Name = "bbtn_xoa_ql";
            this.bbtn_xoa_ql.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_xoa_ql_ItemClick);
            // 
            // bbtn_sua_ql
            // 
            this.bbtn_sua_ql.Caption = "Sửa";
            this.bbtn_sua_ql.Id = 2;
            this.bbtn_sua_ql.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtn_sua_ql.ImageOptions.Image")));
            this.bbtn_sua_ql.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtn_sua_ql.ImageOptions.LargeImage")));
            this.bbtn_sua_ql.Name = "bbtn_sua_ql";
            this.bbtn_sua_ql.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_sua_ql_ItemClick);
            // 
            // btn_refresh_thucan
            // 
            this.btn_refresh_thucan.Caption = "refresh";
            this.btn_refresh_thucan.Id = 3;
            this.btn_refresh_thucan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh_thucan.ImageOptions.Image")));
            this.btn_refresh_thucan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh_thucan.ImageOptions.LargeImage")));
            this.btn_refresh_thucan.Name = "btn_refresh_thucan";
            this.btn_refresh_thucan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_refresh_thucan_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1764, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 965);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1764, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 965);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1764, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 965);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gv_thucdon);
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Controls.Add(this.cbo_loai);
            this.layoutControl1.Controls.Add(this.txt_gia);
            this.layoutControl1.Controls.Add(this.txt_tenthucan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1764, 965);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gv_thucdon
            // 
            this.gv_thucdon.Location = new System.Drawing.Point(12, 69);
            this.gv_thucdon.MainView = this.gridView1;
            this.gv_thucdon.MenuManager = this.barManager1;
            this.gv_thucdon.Name = "gv_thucdon";
            this.gv_thucdon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gv_thucdon.Size = new System.Drawing.Size(1740, 869);
            this.gv_thucdon.TabIndex = 10;
            this.gv_thucdon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.gv_thucdon;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã thức ăn";
            this.gridColumn5.FieldName = "MaTA";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên thức ăn";
            this.gridColumn6.FieldName = "TenTA";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Loại thức ăn";
            this.gridColumn7.FieldName = "Loai";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Gía tiền";
            this.gridColumn8.FieldName = "Gia";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(124, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1788, 431);
            this.panel1.TabIndex = 9;
            // 
            // cbo_loai
            // 
            this.cbo_loai.FormattingEnabled = true;
            this.cbo_loai.Location = new System.Drawing.Point(100, 39);
            this.cbo_loai.Name = "cbo_loai";
            this.cbo_loai.Size = new System.Drawing.Size(1652, 24);
            this.cbo_loai.TabIndex = 8;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(972, 12);
            this.txt_gia.MenuManager = this.barManager1;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(780, 23);
            this.txt_gia.StyleController = this.layoutControl1;
            this.txt_gia.TabIndex = 7;
            // 
            // txt_tenthucan
            // 
            this.txt_tenthucan.Location = new System.Drawing.Point(100, 12);
            this.txt_tenthucan.MenuManager = this.barManager1;
            this.txt_tenthucan.Name = "txt_tenthucan";
            this.txt_tenthucan.Size = new System.Drawing.Size(780, 23);
            this.txt_tenthucan.StyleController = this.layoutControl1;
            this.txt_tenthucan.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1904, 435);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 20);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tenmon,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.dongia});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1764, 965);
            this.Root.TextVisible = false;
            // 
            // tenmon
            // 
            this.tenmon.Control = this.txt_tenthucan;
            this.tenmon.Location = new System.Drawing.Point(0, 0);
            this.tenmon.Name = "tenmon";
            this.tenmon.Size = new System.Drawing.Size(872, 27);
            this.tenmon.Text = "Tên thức uốn";
            this.tenmon.TextSize = new System.Drawing.Size(84, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 930);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1744, 15);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbo_loai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1744, 30);
            this.layoutControlItem1.Text = "Loại đồ uốn";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gv_thucdon;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 57);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1744, 873);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // dongia
            // 
            this.dongia.Control = this.txt_gia;
            this.dongia.Location = new System.Drawing.Point(872, 0);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(872, 27);
            this.dongia.Text = "Đơn giá";
            this.dongia.TextSize = new System.Drawing.Size(84, 16);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã thức ăn";
            this.gridColumn1.FieldName = "MaTA";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Thức ăn";
            this.gridColumn2.FieldName = "TenTA";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại thức ăn";
            this.gridColumn3.FieldName = "Loai";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Gía tiền";
            this.gridColumn4.FieldName = "Gia";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // frm_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 965);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_ThucDon";
            this.Text = "Thực đơn thức ăn";
            this.Load += new System.EventHandler(this.fThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_thucdon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenthucan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenmon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongia)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbtn_them_ql;
        private DevExpress.XtraBars.BarButtonItem bbtn_xoa_ql;
        private DevExpress.XtraBars.BarButtonItem bbtn_sua_ql;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txt_gia;
        private DevExpress.XtraEditors.TextEdit txt_tenthucan;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem tenmon;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem dongia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.ComboBox cbo_loai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btn_refresh_thucan;
        private DevExpress.XtraGrid.GridControl gv_thucdon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}