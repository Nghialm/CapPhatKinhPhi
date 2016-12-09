namespace CapPhatKinhPhi
{
    partial class FrmNamKeToan
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.cboNam = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(99, 39);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Lưu";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // cboNam
            // 
            this.cboNam.Location = new System.Drawing.Point(99, 12);
            this.cboNam.Name = "cboNam";
            this.cboNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNam.Size = new System.Drawing.Size(100, 20);
            this.cboNam.TabIndex = 3;
            // 
            // FrmNamKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 77);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.labelControl1);
            this.KeyPreview = true;
            this.Name = "FrmNamKeToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Năm kế toán";
            this.Load += new System.EventHandler(this.FrmTongHopKinhPhi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNamKeToan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cboNam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.ComboBoxEdit cboNam;
    }
}