namespace CapPhatKinhPhi
{
    partial class FrmDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonVi));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaTkCo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDvQhns = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboNhomDonvi = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboDmNganHang = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaDonVi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDonVi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.groupDetail = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupList = new DevExpress.XtraEditors.GroupControl();
            this.gctDonVi = new DevExpress.XtraGrid.GridControl();
            this.gvDonVi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNganHangId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTkCo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDvQhns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomDonvi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDmNganHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDetail)).BeginInit();
            this.groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupList)).BeginInit();
            this.groupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 18;
            this.btnClose.ImageList = this.imageCollection1;
            this.btnClose.Location = new System.Drawing.Point(925, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "&Đóng";
            this.btnClose.ToolTip = "Phím tắt Ctrl + C";
            this.btnClose.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "About.png");
            this.imageCollection1.Images.SetKeyName(1, "accept.png");
            this.imageCollection1.Images.SetKeyName(2, "application_edit.png");
            this.imageCollection1.Images.SetKeyName(3, "arrow_refresh.png");
            this.imageCollection1.Images.SetKeyName(4, "book_notebook.png");
            this.imageCollection1.Images.SetKeyName(5, "book_open.png");
            this.imageCollection1.Images.SetKeyName(6, "calendar_32.png");
            this.imageCollection1.Images.SetKeyName(7, "Close.png");
            this.imageCollection1.Images.SetKeyName(8, "cross_octagon.png");
            this.imageCollection1.Images.SetKeyName(9, "find.png");
            this.imageCollection1.Images.SetKeyName(10, "Go.png");
            this.imageCollection1.Images.SetKeyName(11, "group.png");
            this.imageCollection1.Images.SetKeyName(12, "Help.png");
            this.imageCollection1.Images.SetKeyName(13, "Home.png");
            this.imageCollection1.Images.SetKeyName(14, "nangcao.png");
            this.imageCollection1.Images.SetKeyName(15, "people-icon.png");
            this.imageCollection1.Images.SetKeyName(16, "plus_16.png");
            this.imageCollection1.Images.SetKeyName(17, "Shutdown.png");
            this.imageCollection1.Images.SetKeyName(18, "stop.png");
            this.imageCollection1.Images.SetKeyName(19, "tuychon.png");
            this.imageCollection1.Images.SetKeyName(20, "user_delete.png");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMaTkCo);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtMaDvQhns);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtSoTaiKhoan);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.cboNhomDonvi);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.cboDmNganHang);
            this.panelControl1.Controls.Add(this.txtMaDonVi);
            this.panelControl1.Controls.Add(this.txtTenDonVi);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(9, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(628, 159);
            this.panelControl1.TabIndex = 0;
            // 
            // txtMaTkCo
            // 
            this.txtMaTkCo.Location = new System.Drawing.Point(116, 135);
            this.txtMaTkCo.Name = "txtMaTkCo";
            this.txtMaTkCo.Size = new System.Drawing.Size(125, 20);
            this.txtMaTkCo.TabIndex = 11;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(46, 138);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Mã tk có lq";
            // 
            // txtMaDvQhns
            // 
            this.txtMaDvQhns.Location = new System.Drawing.Point(402, 83);
            this.txtMaDvQhns.Name = "txtMaDvQhns";
            this.txtMaDvQhns.Size = new System.Drawing.Size(125, 20);
            this.txtMaDvQhns.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(332, 86);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Mã Đv QHNS";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(411, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(46, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(116, 83);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(125, 20);
            this.txtSoTaiKhoan.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Số tài khoản";
            // 
            // cboNhomDonvi
            // 
            this.cboNhomDonvi.EditValue = "Id";
            this.cboNhomDonvi.Location = new System.Drawing.Point(116, 57);
            this.cboNhomDonvi.Name = "cboNhomDonvi";
            this.cboNhomDonvi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboNhomDonvi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhomDonvi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhom", "Tên")});
            this.cboNhomDonvi.Properties.NullText = "Chọn Giá Trị";
            this.cboNhomDonvi.Size = new System.Drawing.Size(125, 20);
            this.cboNhomDonvi.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Nhóm đơn vị";
            // 
            // cboDmNganHang
            // 
            this.cboDmNganHang.EditValue = "Id";
            this.cboDmNganHang.Location = new System.Drawing.Point(402, 57);
            this.cboDmNganHang.Name = "cboDmNganHang";
            this.cboDmNganHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboDmNganHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDmNganHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNganHang", "Tên")});
            this.cboDmNganHang.Properties.NullText = "Chọn Giá Trị";
            this.cboDmNganHang.Size = new System.Drawing.Size(125, 20);
            this.cboDmNganHang.TabIndex = 3;
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.Location = new System.Drawing.Point(116, 5);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.Size = new System.Drawing.Size(125, 20);
            this.txtMaDonVi.TabIndex = 0;
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Location = new System.Drawing.Point(116, 31);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(411, 20);
            this.txtTenDonVi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(327, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngân hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã Đơn Vị";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đơn Vị";
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 16;
            this.btnThem.ImageList = this.imageCollection1;
            this.btnThem.Location = new System.Drawing.Point(9, 197);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.ToolTip = "Phím tắt Ctrl + I";
            this.btnThem.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageIndex = 2;
            this.btnLuu.ImageList = this.imageCollection1;
            this.btnLuu.Location = new System.Drawing.Point(181, 197);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.ToolTip = "Phím tắt Ctrl + U";
            this.btnLuu.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 20;
            this.btnHuy.ImageList = this.imageCollection1;
            this.btnHuy.Location = new System.Drawing.Point(267, 197);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.ToolTip = "Phím tắt Ctrl + H ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupDetail
            // 
            this.groupDetail.Controls.Add(this.btnHuy);
            this.groupDetail.Controls.Add(this.btnLuu);
            this.groupDetail.Controls.Add(this.btnThem);
            this.groupDetail.Controls.Add(this.btnXoa);
            this.groupDetail.Controls.Add(this.panelControl1);
            this.groupDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDetail.Location = new System.Drawing.Point(4, 4);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(1010, 235);
            this.groupDetail.TabIndex = 0;
            this.groupDetail.Text = "Thông Tin Đơn Vị";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageIndex = 8;
            this.btnXoa.ImageList = this.imageCollection1;
            this.btnXoa.Location = new System.Drawing.Point(95, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.ToolTip = "Phím tắt Ctrl + D";
            this.btnXoa.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.gctDonVi);
            this.groupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList.Location = new System.Drawing.Point(4, 239);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1010, 343);
            this.groupList.TabIndex = 1;
            this.groupList.Text = "Danh Sách Đơn Vị";
            // 
            // gctDonVi
            // 
            this.gctDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctDonVi.Location = new System.Drawing.Point(2, 22);
            this.gctDonVi.MainView = this.gvDonVi;
            this.gctDonVi.Name = "gctDonVi";
            this.gctDonVi.Size = new System.Drawing.Size(1006, 319);
            this.gctDonVi.TabIndex = 3;
            this.gctDonVi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonVi});
            // 
            // gvDonVi
            // 
            this.gvDonVi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDonVi,
            this.colTenDonVi,
            this.colLoaiDonVi,
            this.colNganHangId});
            this.gvDonVi.GridControl = this.gctDonVi;
            this.gvDonVi.Name = "gvDonVi";
            this.gvDonVi.OptionsBehavior.ReadOnly = true;
            this.gvDonVi.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvDonVi.OptionsView.ShowAutoFilterRow = true;
            this.gvDonVi.OptionsView.ShowGroupPanel = false;
            this.gvDonVi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMaDonVi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDonVi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDonVi_FocusedRowChanged);
            // 
            // colMaDonVi
            // 
            this.colMaDonVi.Caption = "Mã Đơn Vị";
            this.colMaDonVi.FieldName = "Ma";
            this.colMaDonVi.Name = "colMaDonVi";
            this.colMaDonVi.OptionsColumn.ReadOnly = true;
            this.colMaDonVi.Visible = true;
            this.colMaDonVi.VisibleIndex = 0;
            this.colMaDonVi.Width = 198;
            // 
            // colTenDonVi
            // 
            this.colTenDonVi.Caption = "Tên Đơn Vị";
            this.colTenDonVi.FieldName = "TenDonvi";
            this.colTenDonVi.Name = "colTenDonVi";
            this.colTenDonVi.OptionsColumn.ReadOnly = true;
            this.colTenDonVi.Visible = true;
            this.colTenDonVi.VisibleIndex = 1;
            this.colTenDonVi.Width = 325;
            // 
            // colLoaiDonVi
            // 
            this.colLoaiDonVi.Caption = "Nhóm đơn vị";
            this.colLoaiDonVi.FieldName = "objDmNhomDonVi.TenNhom";
            this.colLoaiDonVi.Name = "colLoaiDonVi";
            this.colLoaiDonVi.OptionsColumn.ReadOnly = true;
            this.colLoaiDonVi.Visible = true;
            this.colLoaiDonVi.VisibleIndex = 2;
            this.colLoaiDonVi.Width = 325;
            // 
            // colNganHangId
            // 
            this.colNganHangId.Caption = "Ngân hàng";
            this.colNganHangId.FieldName = "objDmNganHang.TenNganHang";
            this.colNganHangId.Name = "colNganHangId";
            this.colNganHangId.Visible = true;
            this.colNganHangId.VisibleIndex = 3;
            this.colNganHangId.Width = 329;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnClose);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(4, 582);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1010, 40);
            this.panelControl2.TabIndex = 2;
            // 
            // FrmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1018, 626);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDonVi";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đơn vị";
            this.Load += new System.EventHandler(this.FrmDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTkCo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDvQhns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomDonvi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDmNganHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDetail)).EndInit();
            this.groupDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupList)).EndInit();
            this.groupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboDmNganHang;
        private DevExpress.XtraEditors.TextEdit txtMaDonVi;
        private DevExpress.XtraEditors.TextEdit txtTenDonVi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.GroupControl groupDetail;
        private DevExpress.XtraEditors.GroupControl groupList;
        private DevExpress.XtraGrid.GridControl gctDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDonVi;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNganHangId;
        private DevExpress.XtraEditors.LookUpEdit cboNhomDonvi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSoTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaDvQhns;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMaTkCo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}