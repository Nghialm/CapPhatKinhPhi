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
using System.Xml;

namespace CapPhatKinhPhi
{
    public partial class FrmNamKeToan : DevExpress.XtraEditors.XtraForm
    {
        public IReportCapPhatService ReportCapPhatService;
        //public IVnsLoaiChungTuService VnsLoaiChungTuService;
        
        public FrmNamKeToan()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            IList<RpChiTietNganSach> lst = ReportCapPhatService.GetBangKeKeHoach(DateTime.MinValue, DateTime.MaxValue, "", Null.NullGuid);

            List<int> dsNam = new List<int>();
            int year = 0;
            foreach (RpChiTietNganSach tmp  in lst)
            {
                if (year != tmp.NgayCt.Year)
                {
                    year = tmp.NgayCt.Year;
                    dsNam.Add(year);
                    cboNam.Properties.Items.Add(year);
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string namketoan = cboNam.Text;
            General.NamKeToan = int.Parse(cboNam.Text);
            GetXmlInfo.WriteInfo(namketoan);

            this.Close();
        }

        private VnsLoaiChungTu objLoaiChungTu = new VnsLoaiChungTu();
        private void FrmTongHopKinhPhi_Load(object sender, EventArgs e)
        {
            int namketoan = GetXmlInfo.GetNamKeToan();
            cboNam.Text = namketoan.ToString();
            BindGrid();
        }

        private void FrmNamKeToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}