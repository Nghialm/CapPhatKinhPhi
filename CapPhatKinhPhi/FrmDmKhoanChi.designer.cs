namespace CapPhatKinhPhi
{
    partial class FrmDmKhoanChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDmKhoanChi));
            this.groupDetail = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupList = new DevExpress.XtraEditors.GroupControl();
            this.grdDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiDoanRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiDoanRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupDetail)).BeginInit();
            this.groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupList)).BeginInit();
            this.groupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDetail
            // 
            this.groupDetail.Controls.Add(this.btnHuy);
            this.groupDetail.Controls.Add(this.btnXoa);
            this.groupDetail.Controls.Add(this.btnLuu);
            this.groupDetail.Controls.Add(this.btnThem);
            this.groupDetail.Controls.Add(this.panelControl2);
            this.groupDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDetail.Location = new System.Drawing.Point(4, 4);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(1000, 134);
            this.groupDetail.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 20;
            this.btnHuy.ImageList = this.imageCollection1;
            this.btnHuy.Location = new System.Drawing.Point(267, 95);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            // btnXoa
            // 
            this.btnXoa.ImageIndex = 8;
            this.btnXoa.ImageList = this.imageCollection1;
            this.btnXoa.Location = new System.Drawing.Point(95, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageIndex = 2;
            this.btnLuu.ImageList = this.imageCollection1;
            this.btnLuu.Location = new System.Drawing.Point(181, 95);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 16;
            this.btnThem.ImageList = this.imageCollection1;
            this.btnThem.Location = new System.Drawing.Point(9, 95);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtMoTa);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtMa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(9, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(552, 79);
            this.panelControl2.TabIndex = 0;
            // 
            // txtMoTa
            // 
            this.txtMoTa.EnterMoveNextControl = true;
            this.txtMoTa.Location = new System.Drawing.Point(93, 54);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(444, 20);
            this.txtMoTa.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Mô tả";
            // 
            // txtTen
            // 
            this.txtTen.EnterMoveNextControl = true;
            this.txtTen.Location = new System.Drawing.Point(384, 19);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(153, 20);
            this.txtTen.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(350, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tên";
            // 
            // txtMa
            // 
            this.txtMa.EnterMoveNextControl = true;
            this.txtMa.Location = new System.Drawing.Point(93, 19);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(152, 20);
            this.txtMa.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã";
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.grdDanhMuc);
            this.groupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupList.Location = new System.Drawing.Point(4, 138);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1000, 434);
            this.groupList.TabIndex = 1;
            this.groupList.Text = "Danh sách";
            // 
            // grdDanhMuc
            // 
            this.grdDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDanhMuc.Location = new System.Drawing.Point(2, 22);
            this.grdDanhMuc.MainView = this.gvDanhMuc;
            this.grdDanhMuc.Name = "grdDanhMuc";
            this.grdDanhMuc.Size = new System.Drawing.Size(996, 410);
            this.grdDanhMuc.TabIndex = 0;
            this.grdDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiDoanRa,
            this.colTenLoaiDoanRa,
            this.colMoTa});
            this.gvDanhMuc.GridControl = this.grdDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.gvDanhMuc.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMaLoaiDoanRa, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhMuc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhMuc_FocusedRowChanged);
            // 
            // colMaLoaiDoanRa
            // 
            this.colMaLoaiDoanRa.Caption = "Mã";
            this.colMaLoaiDoanRa.FieldName = "Ma";
            this.colMaLoaiDoanRa.Name = "colMaLoaiDoanRa";
            this.colMaLoaiDoanRa.OptionsColumn.ReadOnly = true;
            this.colMaLoaiDoanRa.Visible = true;
            this.colMaLoaiDoanRa.VisibleIndex = 0;
            // 
            // colTenLoaiDoanRa
            // 
            this.colTenLoaiDoanRa.Caption = "Tên";
            this.colTenLoaiDoanRa.FieldName = "TenKhoanChi";
            this.colTenLoaiDoanRa.Name = "colTenLoaiDoanRa";
            this.colTenLoaiDoanRa.OptionsColumn.ReadOnly = true;
            this.colTenLoaiDoanRa.Visible = true;
            this.colTenLoaiDoanRa.VisibleIndex = 1;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageIndex = 18;
            this.btnClose.ImageList = this.imageCollection1;
            this.btnClose.Location = new System.Drawing.Point(917, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.btnClose);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(4, 572);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1000, 40);
            this.panelControl3.TabIndex = 2;
            // 
            // FrmDmKhoanChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1008, 616);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.groupDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmDmKhoanChi";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Khoản chi";
            this.Load += new System.EventHandler(this.FrmLoaiDoanRa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDetail)).EndInit();
            this.groupDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupList)).EndInit();
            this.groupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl groupDetail;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupList;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiDoanRa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiDoanRa;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
    }
}