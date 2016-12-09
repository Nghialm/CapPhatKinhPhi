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
    public partial class FrmBangKe : Form
    {
        public IReportCapPhatService ReportCapPhatService;
        public IVnsLoaiChungTuService VnsLoaiChungTuService;

        public FrmBangKe()
        {
            InitializeComponent();
        }

        private void FrmBangKe_Load(object sender, EventArgs e)
        {
            BindCombo();
        }

        private void BindCombo()
        {
            IList<VnsLoaiChungTu> lstLoaiCt = new List<VnsLoaiChungTu>();
            lstLoaiCt = VnsLoaiChungTuService.GetAll();

            cboLoaiCt.Properties.DataSource = lstLoaiCt;
            cboLoaiCt.Properties.DisplayMember = "Ten";
            cboLoaiCt.Properties.ValueMember = "MaLoaiChungTu";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            VnsLoaiChungTu objct = (VnsLoaiChungTu)ComboHelper.GetSelectData(cboLoaiCt);
            IList<RpChiTietNganSach> lst = new List<RpChiTietNganSach>();
            string mact = objct == null ? "" : objct.MaLoaiChungTu;
            lst = ReportCapPhatService.GetBangKeChiTiet(ucDate.StartDate, ucDate.EndDate, mact, new Guid());

            IList<Info> TempLstThamSo = General.lstThamSo;

            Info objThamSo = new Info();
            objThamSo.Ma = "p_DateInput";
            objThamSo.GiaTri = ucDate.Value_info.Ten;
            TempLstThamSo.Add(objThamSo);

            objThamSo = new Info();
            objThamSo.Ma = "p_DonVi";
            objThamSo.GiaTri = cboLoaiCt.Text;
            TempLstThamSo.Add(objThamSo);

            objThamSo = new Info();
            objThamSo.Ma = "p_NgayBaoCao";
            objThamSo.GiaTri = "Hà Nội, ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
            TempLstThamSo.Add(objThamSo);

            objThamSo = new Info();
            objThamSo.Ma = "p_TieuDe";
            string TieuDe = cboLoaiCt.Text;
            objThamSo.GiaTri = TieuDe.ToUpper();
            TempLstThamSo.Add(objThamSo);

            ReportHelper.getParamValue(General.lstThamSo);
            List<RpChiTietNganSach> tmplst = new List<RpChiTietNganSach>(lst);

            XtraReport rp;
            switch (this.AccessibleDescription)
            {    
                case "BangKe_01":
                    rp = new Report.BangKe_01();
                    ReportHelper.SetParamValue(TempLstThamSo, rp.Parameters);
                    
                    tmplst = new List<RpChiTietNganSach>(lst);
                    tmplst.Sort(RpChiTietNganSach.ComparePhieuByNgay_SoCt);
                    tmplst = SortList(tmplst);
                    rp.DataSource = tmplst;               
                    rp.ShowPreviewDialog();
                    break;
                case "BangKe_02":
                    tmplst = new List<RpChiTietNganSach>(lst);
                    tmplst.Sort(RpChiTietNganSach.ComparePhieuByNgay_SoCt);
                    rp = new Report.BangKe_02(tmplst);
                    ReportHelper.SetParamValue(TempLstThamSo, rp.Parameters);
                    rp.DataSource = tmplst;
                    rp.ShowPreviewDialog();
                    break;
            }
        }

        private List<RpChiTietNganSach> SortList(List<RpChiTietNganSach> lst)
        {
            Guid Id = new Guid();
            decimal STT = 0;
            foreach (RpChiTietNganSach obj in lst)
            {
                if (Id != obj.Id)
                {                   
                    Id = obj.Id;
                    STT++;
                }
                obj.STT = STT;
            }
            return lst;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
