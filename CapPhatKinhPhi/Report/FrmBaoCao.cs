using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.CapPhatKinhPhi.Domain;
using DevExpress.XtraReports.UI;

namespace CapPhatKinhPhi.Report
{
    public partial class FrmBaoCao : Form
    {
        public IReportCapPhatService ReportCapPhatService;

        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBangKe_Load(object sender, EventArgs e)
        {
            BindCombo();
        }

        private void BindCombo()
        {
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            IList<RpChiTietNganSach> lst = new List<RpChiTietNganSach>();

            IList<Info> TempLstThamSo = General.lstThamSo;

            Info objThamSo = new Info();
            objThamSo.Ma = "p_DateInput";
            objThamSo.GiaTri = ucDate.Value_info.Ten;
            TempLstThamSo.Add(objThamSo);

            //objThamSo = new Info();
            //objThamSo.Ma = "p_DonVi";
            //objThamSo.GiaTri = cboLoaiCt.Text;
            //TempLstThamSo.Add(objThamSo);

            objThamSo = new Info();
            objThamSo.Ma = "p_NgayBaoCao";
            objThamSo.GiaTri = "Hà Nội, ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
            TempLstThamSo.Add(objThamSo);

            ReportHelper.getParamValue(General.lstThamSo);

            XtraReport rp;
            switch (this.AccessibleDescription)
            {
                case "BaoCao_01":
                    rp = new Report.BaocCao_01();
                    ReportHelper.SetParamValue(TempLstThamSo, rp.Parameters);
                    lst = ReportCapPhatService.GetNganSachTongHop(ucDate.StartDate, ucDate.EndDate, new Guid());
                    rp.DataSource = GetSTT(lst);
                    rp.ShowPreviewDialog();
                    break;
                case "BaoCao02_KP":
                    rp = new Report.BaoCao02_KP();
                    ReportHelper.SetParamValue(TempLstThamSo, rp.Parameters);
                    lst = ReportCapPhatService.GetNganSachTongHopTheoDonVi(ucDate.StartDate, ucDate.EndDate, new Guid());
                    rp.DataSource = lst;
                    rp.ShowPreviewDialog();
                    break;
                case "BaoCao03_KP":
                    rp = new Report.BaoCao03_KP();
                    ReportHelper.SetParamValue(TempLstThamSo, rp.Parameters);
                    lst = ReportCapPhatService.GetNganSachTongHopTheoDonVi(ucDate.StartDate, ucDate.EndDate, new Guid());
                    rp.DataSource = lst;
                    rp.ShowPreviewDialog();
                    break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private List<RpChiTietNganSach> GetSTT(IList<RpChiTietNganSach> lst)
        {
            string MaLoaiKhoan = "";
            int STT = 0;
            List<RpChiTietNganSach> lstTemp = new List<RpChiTietNganSach>();
            foreach (RpChiTietNganSach rp in lst)
            {
                lstTemp.Add(rp);
            }

            lstTemp.Sort(CompareReport);
            foreach (RpChiTietNganSach rpTemp in lstTemp)
            {
                if (!rpTemp.MaLoaiKhoan.Equals(MaLoaiKhoan))
                {
                    MaLoaiKhoan = rpTemp.MaLoaiKhoan;
                    STT++;
                }
                rpTemp.SttGroup = STT;                
            }
            return lstTemp;
        }


        private int CompareReport(RpChiTietNganSach x, RpChiTietNganSach y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retvalMaLoaiKhoan = 0;
                    return retvalMaLoaiKhoan = x.MaLoaiKhoan.CompareTo(y.MaLoaiKhoan);

                }
            }
        }
    }
}
