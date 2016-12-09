namespace CapPhatKinhPhi
{
    partial class FrmDmLoaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDmLoaiKhoan));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grlDmLoaiKhoan = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenLoaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaChuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
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
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlDmLoaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
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
            this.panelControl1.Controls.Add(this.grlDmLoaiKhoan);
            this.panelControl1.Controls.Add(this.txtMaHang);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtTenLoaiKhoan);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtMoTa);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtMaChuong);
            this.panelControl1.Controls.Add(this.txtMa);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(9, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(570, 168);
            this.panelControl1.TabIndex = 0;
            // 
            // grlDmLoaiKhoan
            // 
            this.grlDmLoaiKhoan.EditValue = "Id";
            this.grlDmLoaiKhoan.Location = new System.Drawing.Point(116, 41);
            this.grlDmLoaiKhoan.Name = "grlDmLoaiKhoan";
            this.grlDmLoaiKhoan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.grlDmLoaiKhoan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.grlDmLoaiKhoan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlDmLoaiKhoan.Properties.ImmediatePopup = true;
            this.grlDmLoaiKhoan.Properties.NullText = "";
            this.grlDmLoaiKhoan.Properties.View = this.gridLookUpEdit1View;
            this.grlDmLoaiKhoan.Size = new System.Drawing.Size(125, 20);
            this.grlDmLoaiKhoan.TabIndex = 9;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã";
            this.gridColumn1.FieldName = "Ma";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "Ten";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(116, 93);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(125, 20);
            this.txtMaHang.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(33, 96);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Hạng";
            // 
            // txtTenLoaiKhoan
            // 
            this.txtTenLoaiKhoan.Location = new System.Drawing.Point(390, 67);
            this.txtTenLoaiKhoan.Name = "txtTenLoaiKhoan";
            this.txtTenLoaiKhoan.Size = new System.Drawing.Size(125, 20);
            this.txtTenLoaiKhoan.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(307, 70);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tên Loại - Khoản";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(116, 119);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(399, 20);
            this.txtMoTa.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Mô tả";
            // 
            // txtMaChuong
            // 
            this.txtMaChuong.Location = new System.Drawing.Point(116, 15);
            this.txtMaChuong.Name = "txtMaChuong";
            this.txtMaChuong.Size = new System.Drawing.Size(125, 20);
            this.txtMaChuong.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(116, 67);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(125, 20);
            this.txtMa.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mã cha";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Chương";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Loại - Khoản";
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 16;
            this.btnThem.ImageList = this.imageCollection1;
            this.btnThem.Location = new System.Drawing.Point(9, 204);
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
            this.btnLuu.Location = new System.Drawing.Point(181, 204);
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
            this.btnHuy.Location = new System.Drawing.Point(267, 204);
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
            this.groupDetail.Size = new System.Drawing.Size(1010, 240);
            this.groupDetail.TabIndex = 0;
            this.groupDetail.Text = "Thông Tin";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageIndex = 8;
            this.btnXoa.ImageList = this.imageCollection1;
            this.btnXoa.Location = new System.Drawing.Point(95, 204);
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
            this.groupList.Location = new System.Drawing.Point(4, 244);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1010, 338);
            this.groupList.TabIndex = 1;
            this.groupList.Text = "Danh Sách";
            // 
            // gctDonVi
            // 
            this.gctDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctDonVi.Location = new System.Drawing.Point(2, 22);
            this.gctDonVi.MainView = this.gvDonVi;
            this.gctDonVi.Name = "gctDonVi";
            this.gctDonVi.Size = new System.Drawing.Size(1006, 314);
            this.gctDonVi.TabIndex = 3;
            this.gctDonVi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonVi});
            // 
            // gvDonVi
            // 
            this.gvDonVi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colIDCha,
            this.colMaChuong,
            this.colMaHang,
            this.colMoTa});
            this.gvDonVi.GridControl = this.gctDonVi;
            this.gvDonVi.Name = "gvDonVi";
            this.gvDonVi.OptionsBehavior.ReadOnly = true;
            this.gvDonVi.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvDonVi.OptionsView.ShowAutoFilterRow = true;
            this.gvDonVi.OptionsView.ShowGroupPanel = false;
            this.gvDonVi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMa, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDonVi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDonVi_FocusedRowChanged);
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã loại khoản";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên loại khoản";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colIDCha
            // 
            this.colIDCha.Caption = "Mã loại";
            this.colIDCha.FieldName = "IdCha";
            this.colIDCha.Name = "colIDCha";
            this.colIDCha.OptionsColumn.ReadOnly = true;
            // 
            // colMaChuong
            // 
            this.colMaChuong.Caption = "Mã chương";
            this.colMaChuong.FieldName = "MaChuong";
            this.colMaChuong.Name = "colMaChuong";
            this.colMaChuong.Visible = true;
            this.colMaChuong.VisibleIndex = 2;
            // 
            // colMaHang
            // 
            this.colMaHang.Caption = "Mã hạng";
            this.colMaHang.FieldName = "MaHang";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Visible = true;
            this.colMaHang.VisibleIndex = 3;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 4;
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
            // FrmDmLoaiKhoan
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
            this.Name = "FrmDmLoaiKhoan";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại khoản";
            this.Load += new System.EventHandler(this.FrmDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlDmLoaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtMaChuong;
        private DevExpress.XtraEditors.TextEdit txtMa;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCha;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChuong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtMaHang;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraEditors.GridLookUpEdit grlDmLoaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}