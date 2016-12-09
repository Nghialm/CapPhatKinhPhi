namespace CapPhatKinhPhi.Report
{
    partial class FrmBangKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBangKe));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiCt = new DevExpress.XtraEditors.LookUpEdit();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ucDate = new CapPhatKinhPhi.Controls.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiCt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Loại Nghiệp vụ";
            // 
            // cboLoaiCt
            // 
            this.cboLoaiCt.EnterMoveNextControl = true;
            this.cboLoaiCt.Location = new System.Drawing.Point(124, 58);
            this.cboLoaiCt.Name = "cboLoaiCt";
            this.cboLoaiCt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiCt.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLoaiChungTu", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên")});
            this.cboLoaiCt.Properties.NullText = "";
            this.cboLoaiCt.Size = new System.Drawing.Size(180, 20);
            this.cboLoaiCt.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.ImageList = this.imageCollection1;
            this.btnIn.Location = new System.Drawing.Point(124, 99);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.imageCollection1.Images.SetKeyName(21, "accept.png");
            this.imageCollection1.Images.SetKeyName(22, "arrow_refresh.png");
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ImageIndex = 8;
            this.btnThoat.ImageList = this.imageCollection1;
            this.btnThoat.Location = new System.Drawing.Point(229, 99);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.ucDate);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnIn);
            this.groupControl1.Controls.Add(this.cboLoaiCt);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(465, 134);
            this.groupControl1.TabIndex = 0;
            // 
            // ucDate
            // 
            this.ucDate.EndDate = new System.DateTime(((long)(0)));
            this.ucDate.Location = new System.Drawing.Point(4, 25);
            this.ucDate.Name = "ucDate";
            this.ucDate.Size = new System.Drawing.Size(432, 25);
            this.ucDate.StartDate = new System.DateTime(((long)(0)));
            this.ucDate.TabIndex = 0;
            // 
            // FrmBangKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(465, 134);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBangKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng kê";
            this.Load += new System.EventHandler(this.FrmBangKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiCt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DateTimeInput ucDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboLoaiCt;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}