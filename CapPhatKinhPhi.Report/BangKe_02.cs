using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Vns.CapPhatKinhPhi.Domain;
using System.Collections.Generic;

namespace CapPhatKinhPhi.Report
{
    public partial class BangKe_02 : DevExpress.XtraReports.UI.XtraReport
    {
        public BangKe_02()
        {
            InitializeComponent();
        }

        IList<RpChiTietNganSach> mlst = new List<RpChiTietNganSach>();

        public BangKe_02(IList<RpChiTietNganSach> plst)
        {
            InitializeComponent();
            mlst = plst;
        }

        private void xrSubreport1_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BangKe_02_P2 p2 = (BangKe_02_P2)((XRSubreport)sender).ReportSource;

            if (this.GetCurrentColumnValue("DonViId") != null)
                p2.DataSource = p2.GetData(new Guid(this.GetCurrentColumnValue("DonViId").ToString()), mlst);
        }

    }
}
