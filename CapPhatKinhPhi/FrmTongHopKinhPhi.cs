using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Core;

namespace CapPhatKinhPhi
{
    public partial class FrmTongHopKinhPhi : DevExpress.XtraEditors.XtraForm
    {
        public IReportCapPhatService ReportCapPhatService;
        public IVnsLoaiChungTuService VnsLoaiChungTuService;

        public FrmTongHopKinhPhi()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            
            int nam = int.Parse(txtNam.EditValue.ToString());
            ReportCapPhatService.GetKeHoachCapPhat(new DateTime(nam, 1, 1), new DateTime(nam, 12, 31), objLoaiChungTu);

            Commons.Message_Information("Đã xong");
        }
        
        private VnsLoaiChungTu objLoaiChungTu = new VnsLoaiChungTu(); 
        private void FrmTongHopKinhPhi_Load(object sender, EventArgs e)
        {
            txtNam.Text = DateTime.Now.Year.ToString();

            String MaLoaiChungTu = this.AccessibleDescription;
            objLoaiChungTu = VnsLoaiChungTuService.GetByMa(MaLoaiChungTu);
        }

        private void FrmTongHopKinhPhi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}