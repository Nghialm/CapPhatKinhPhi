namespace CapPhatKinhPhi
{
    partial class FrmKhoiPhucDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoiPhucDuLieu));
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBrower = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhoiPhuc = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(78, 23);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(271, 20);
            this.txtDuongDan.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Chọn file";
            // 
            // btnBrower
            // 
            this.btnBrower.ImageList = this.imageCollection1;
            this.btnBrower.Location = new System.Drawing.Point(355, 23);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(41, 20);
            this.btnBrower.TabIndex = 17;
            this.btnBrower.Text = "...";
            this.btnBrower.ToolTip = "Chọn file .db";
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
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
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ImageIndex = 8;
            this.btnThoat.ImageList = this.imageCollection1;
            this.btnThoat.Location = new System.Drawing.Point(316, 57);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.ImageIndex = 4;
            this.btnKhoiPhuc.ImageList = this.imageCollection1;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(232, 57);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(80, 23);
            this.btnKhoiPhuc.TabIndex = 15;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtDuongDan);
            this.panelControl1.Controls.Add(this.btnKhoiPhuc);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnBrower);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(414, 99);
            this.panelControl1.TabIndex = 20;
            // 
            // FrmKhoiPhucDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(422, 107);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmKhoiPhucDuLieu";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBrower;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnKhoiPhuc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}