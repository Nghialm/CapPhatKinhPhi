using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CapPhatKinhPhi.Report
{
    public partial class BaocCao_01 : DevExpress.XtraReports.UI.XtraReport
    {
        public BaocCao_01()
        {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BaoCao_01_Hearder detail = xrSubreport1.ReportSource as BaoCao_01_Hearder;
            detail.DataSource = this.DataSource;
        }

        int i = 0;
        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            i++;
            if (i == 1)
                e.Cancel = true;
        }

    }
}
