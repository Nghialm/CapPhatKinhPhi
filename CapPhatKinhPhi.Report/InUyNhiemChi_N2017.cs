using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Vns.CapPhatKinhPhi.Domain;
using System.Collections.Generic;

namespace CapPhatKinhPhi.Report
{
    public partial class InUyNhiemChi_N2017 : DevExpress.XtraReports.UI.XtraReport
    {
        public InUyNhiemChi_N2017()
        {
            InitializeComponent();
        }


        private VnsDmDonVi _ObjVnsDmDonvi = new VnsDmDonVi();
        public VnsDmDonVi ObjVnsDmDonvi
        {
            get { return _ObjVnsDmDonvi; }
            set { _ObjVnsDmDonvi = value; }
        }

        private VnsChungTu _ObjVnsChungTu;
        public VnsChungTu ObjVnsChungTu
        {
            get { return _ObjVnsChungTu; }
            set { _ObjVnsChungTu = value; }
        }

        private Decimal m_SoTien =0 ;
        private DateTime m_NgayCt;
        public InUyNhiemChi_N2017(VnsChungTu p_objChungTu, VnsDmDonVi p_KhachHang, IList<VnsGiaoDich> p_lstGiaoDich, Decimal p_SoTien, DateTime p_NgayCt)
        {
            InitializeComponent();
            //m_KhachHang = p_KhachHang;
            //m_SoTien = p_SoTien;
            //m_NgayCt = p_NgayCt;
            //m_objChungTu = p_objChungTu; 
        }

        private void InUyNhiemChi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                m_NgayCt = _ObjVnsChungTu.NgayHt;
                
                xrDv_Nt.Text = _ObjVnsDmDonvi.TenDonvi.ToUpper();
                //xrMaDVQHNS_NT.Text += " " + _ObjVnsDmDonvi.;
                xrDiaChiDv_Nt.Text += " " + _ObjVnsDmDonvi.DiaChi;
                xrTkDv_Nt.Text += " " + _ObjVnsDmDonvi.SoTaiKhoan;
                xrKbDv_Nt.Text += " " + _ObjVnsDmDonvi.objDmNganHang.MoTa;
                xrTkCo.Text += " " + _ObjVnsDmDonvi.MaTkCo;
                txtMaTKKT.Text = " " + _ObjVnsDmDonvi.SoTaiKhoan;
                string s = _ObjVnsChungTu.SoChungTu;
                if (s.Contains("/"))
                {
                    s = s.Split('/')[1];
                }

                lblSoCt.Text += p_SoUNC.Value.ToString();
                xrTienDuocHuong1.Text = xrTienDuocHuong1.Text;
                lblNgay.Text="Lập ngày "+m_NgayCt.ToString("dd")+" Tháng "+m_NgayCt.ToString("MM")+" Năm "+m_NgayCt.ToString("yyyy");

                Decimal sotien = 0;
                foreach (VnsGiaoDich tmp in _ObjVnsChungTu.LstGiaoDich)
                {
                    sotien += tmp.SoTien;
                }
                String Sotienbangchu = NumberToStringHelper.DocTienBangChu(Convert.ToInt64(sotien), " đồng./.");

                string[] sotienspl = Sotienbangchu.Split(' ');
                string tientong1 = "", tientong2 = ""; ;
                string tienduochuong1 = "", tienduochuong2 = "";
                int i = 0;
                foreach (string chu in sotienspl)
                {
                    if (i < 15) tientong1 += chu + " ";
                    else tientong2 += chu + " ";
                    i++;
                }
                xrTienDuocHuong1.Text = tientong1;
                xrTienDuocHuong2.Text = tientong2;

                i = 0;
                foreach (string chu in sotienspl)
                {
                    if (i < 18) tienduochuong1 += chu + " ";
                    else tienduochuong2 += chu + " ";
                    i++;
                }
                xrTienDuocHuong1.Text = tienduochuong1;
                xrTienDuocHuong2.Text = tienduochuong2;

                //Commons.Report.SetParamValue(General.lstThamSo, this.Parameters);
                
                //this.DataSource =Commons.Commons.ToDataTable<VnsGiaoDich>(m_lstGiaoDich);
            }
            catch (Exception ex)
            {
                //Commons.Commons.Message_Error(ex);
            }
        }

        
    }
}
