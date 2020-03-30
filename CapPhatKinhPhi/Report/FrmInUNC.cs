using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.CapPhatKinhPhi.Domain;

namespace CapPhatKinhPhi.Report
{
    public partial class FrmInUNC : DevExpress.XtraEditors.XtraForm
    {
        private IList<VnsGiaoDich> _lstGiaoDich;
        public IList<VnsGiaoDich> LstGiaoDich
        {
            get { return _lstGiaoDich; }
            set { _lstGiaoDich = value; }
        }
        VnsChungTu _ChungTu = new VnsChungTu();
        public VnsChungTu objChungTu
        {
            get { return _ChungTu; }
            set { _ChungTu = value; }
        }

        public FrmInUNC()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<VnsKhNganSach> tmp = new List<VnsKhNganSach>();

            List<RpChiTietNganSach> lstRp = new List<RpChiTietNganSach>();
            RpChiTietNganSach rp = new RpChiTietNganSach();

            int vonglap = 5;
            if (_lstGiaoDich.Count > 5) vonglap = _lstGiaoDich.Count;
            for (int i = 0; i < vonglap; i++)
            {
                if (5 > i) //neu nho hon 5 dong thi lay binh thuong
                {
                    if (_lstGiaoDich.Count > i)
                        rp = new RpChiTietNganSach(objChungTu, _lstGiaoDich[i]);
                    else
                        rp = new RpChiTietNganSach();

                    lstRp.Add(rp);
                }
                else
                {
                    lstRp[4].SoTien += _lstGiaoDich[i].SoTien;
                    lstRp[4].NoiDung = "Tổng hợp";
                }
            }
            //foreach (VnsGiaoDich tmpd in lstGiaoDich)
            //{
            //    i++;
            //}

            lstRp.Sort(RpChiTietNganSach.ComparePhieuByKhoanChi);
            string KhoanChi = "";
            decimal STT = 0;

            foreach (RpChiTietNganSach tmpd in lstRp)
            {
                if (tmpd.KhoanChi != KhoanChi)
                {
                    KhoanChi = tmpd.KhoanChi;
                    STT++;
                }
                tmpd.STT = STT;
            }

            Report.InUyNhiemChi rpPhieu = new Report.InUyNhiemChi();
            Report.InUyNhiemChi_N2017 rpPhieu_2017 = new Report.InUyNhiemChi_N2017();
            Report.InUyNhiemChi_N2020 rpPhieu_2020 = new Report.InUyNhiemChi_N2020();

            int ind = cboUyNhiemChi.SelectedIndex;



            objChungTu.NgayHt = (DateTime)txtNgayLap.EditValue;

            switch (ind)
            {
                case 0:
                    rpPhieu.ObjVnsChungTu = objChungTu;
                    rpPhieu.ObjVnsDmDonvi = objChungTu.ObjDmDonVi;
                    ReportHelper.SetParamValue(General.lstThamSo, rpPhieu.Parameters);
                    rpPhieu.Parameters["p_SoUNC"].Value = txtSoUNC.Text;
                    rpPhieu.DataSource = lstRp;
                    rpPhieu.ShowPreviewDialog();
                    break;
                case 1:
                    rpPhieu_2017.ObjVnsChungTu = objChungTu;
                    rpPhieu_2017.ObjVnsDmDonvi = objChungTu.ObjDmDonVi;
                    ReportHelper.SetParamValue(General.lstThamSo, rpPhieu_2017.Parameters);
                    rpPhieu_2017.Parameters["p_SoUNC"].Value = txtSoUNC.Text;
                    rpPhieu_2017.DataSource = lstRp;
                    rpPhieu_2017.ShowPreviewDialog();
                    break;
                case 2:
                    rpPhieu_2020.ObjVnsChungTu = objChungTu;
                    rpPhieu_2020.ObjVnsDmDonvi = objChungTu.ObjDmDonVi;
                    ReportHelper.SetParamValue(General.lstThamSo, rpPhieu_2020.Parameters);
                    rpPhieu_2020.Parameters["p_SoUNC"].Value = txtSoUNC.Text;
                    rpPhieu_2020.DataSource = lstRp;
                    rpPhieu_2020.ShowPreviewDialog();
                    break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInUNC_Load(object sender, EventArgs e)
        {
            txtNgayLap.EditValue = _ChungTu.NgayCt.AddDays(1);

            cboUyNhiemChi.SelectedIndex = 1;
        }
    }
}