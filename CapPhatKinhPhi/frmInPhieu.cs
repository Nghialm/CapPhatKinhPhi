using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.Erp.Core;
using Vns.CapPhatKinhPhi.Service;

namespace CapPhatKinhPhi
{
    public partial class frmInPhieu : DevExpress.XtraEditors.XtraForm
    {

        private IList<Info> LstThamSo;
        private List<RpChiTietNganSach> lstRp;

        public frmInPhieu()
        {
            InitializeComponent();
        }

        public frmInPhieu(IList<Info> p_LstThamSo, List<RpChiTietNganSach> p_lstRp) 
        {
            InitializeComponent();
            txtTenPhieu.Text = GetGtThamSo("p_TieuDe", p_LstThamSo);
            txtTenTruongPhong.Text = GetGtThamSo("p_TenTruongPhong", p_LstThamSo);           
            LstThamSo = p_LstThamSo;
            lstRp = p_lstRp;
            BindcboNguoiPheDuyet();
        }

        private void BindcboNguoiPheDuyet()
        {
            IInfoService InfoService;
            InfoService = (InfoService)ObjectFactory.GetObject("InfoService");
            IList<Info> lstInfo = InfoService.GetLikeMa("p_NguoiPheDuyet");
            foreach(Info obj in lstInfo)
            {   
                cboNguoiPheDuyet.Properties.Items.Add(obj.GiaTri);
            }           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetGtThamSo(string MaThamSo, IList<Info> p_LstThamSo)
        {
            string strReturn ="";
            if (p_LstThamSo.Count == 0)
            {
                strReturn = "";
            }
            else
            {
                foreach (Info obj in p_LstThamSo)
                {
                    if (obj.Ma == MaThamSo)
                    {
                        strReturn = obj.GiaTri;
                        break;
                    }
                }
            }

            return strReturn;

        }

        private void SetGtThamSo(string MaThamSo, IList<Info> p_LstThamSo, string strGiaTri) 
        {
            if (p_LstThamSo.Count == 0)
            {
                return;
            }
            else
            {
                foreach (Info obj in p_LstThamSo)
                {
                    if (obj.Ma == MaThamSo)
                    {
                        obj.GiaTri = strGiaTri;
                        break;
                    }
                }
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            Report.Phieu_KeHoach rpPhieu = new Report.Phieu_KeHoach();
            SetGtThamSo("p_TieuDe", LstThamSo, txtTenPhieu.Text);
            SetGtThamSo("p_TenChucVu", LstThamSo, cboNguoiPheDuyet.Text);
            SetGtThamSo("p_TenTruongPhong", LstThamSo, txtTenTruongPhong.Text);

            ReportHelper.SetParamValue(LstThamSo, rpPhieu.Parameters);
            rpPhieu.DataSource = lstRp;
            rpPhieu.ShowPreviewDialog();
        }
       
    }
}