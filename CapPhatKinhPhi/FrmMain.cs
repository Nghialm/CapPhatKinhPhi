using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.Erp.Core;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.Core;
using Vns.CapPhatKinhPhi.Domain;

namespace CapPhatKinhPhi
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public IInfoService InfoService;

        private void LoadThamSoHeThong()
        {
            General.lstThamSo = InfoService.GetAll();

            foreach (Info tmp in General.lstThamSo)
            {
                switch (tmp.Ma)
                {
                    case "p_TenDv":
                        General.TenDv = tmp.GiaTri;
                        break;
                    case "p_DiaChi":
                        General.DiaChi = tmp.GiaTri;
                        break;
                    case "p_KB_Dv":
                        General.KBDv = tmp.GiaTri;
                        break;
                    case "p_Ma_TKKT":
                        General.MaTkkt = tmp.GiaTri;
                        break;
                    case "p_Ma_DV_QHNS":
                        General.MaDvQhns = tmp.GiaTri;
                        break;
                }
            }

            General.NamKeToan = GetXmlInfo.GetNamKeToan();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadThamSoHeThong();

            barsttNamKt.Caption = "Năm kế toán: " + General.NamKeToan;
        }

        #region He thong

        private void barNamKt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNamKeToan frmNamKeToan = (FrmNamKeToan)ObjectFactory.GetObject("FrmNamKeToan");
            frmNamKeToan.ShowDialog();
            
            barsttNamKt.Caption = "Năm Kế toán : " + General.NamKeToan;
        }

        private void barBackUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackupDuLieu frm = new FrmBackupDuLieu();
            frm.ShowDialog();
        }

        private void barRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhoiPhucDuLieu frm = new FrmKhoiPhucDuLieu();
            frm.ShowDialog();
        }

        private void barThamSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThamSoHeThong frmThamSoHeThong = (frmThamSoHeThong)ObjectFactory.GetObject("frmThamSoHeThong");
            frmThamSoHeThong.Show();
        }

        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Commons.Message_Confirm("Bạn có chắc chắn muốn thoát?"))
            {
                Application.Exit();
            }
        }

        #endregion

        #region Cap ngan sach
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhKinhPhiLst FrmKhKinhPhiLst = (FrmKhKinhPhiLst)ObjectFactory.GetObject("FrmKhKinhPhiLst");
            FrmKhKinhPhiLst.AccessibleDescription = "KH_SD";
            FrmKhKinhPhiLst.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhKinhPhiLst FrmKhKinhPhiLst = (FrmKhKinhPhiLst)ObjectFactory.GetObject("FrmKhKinhPhiLst");
            FrmKhKinhPhiLst.AccessibleDescription = "KH_DN";
            FrmKhKinhPhiLst.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKhKinhPhiLst FrmKhKinhPhiLst = (FrmKhKinhPhiLst)ObjectFactory.GetObject("FrmKhKinhPhiLst");
            FrmKhKinhPhiLst.AccessibleDescription = "KH_BX";
            FrmKhKinhPhiLst.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCpKinhPhiLst FrmCpKinhPhiLst = (FrmCpKinhPhiLst)ObjectFactory.GetObject("FrmCpKinhPhiLst");
            FrmCpKinhPhiLst.ShowDialog();
        }
        #endregion

        #region Bao cao

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTongHopKinhPhi FrmKhKinhPhiLst = (FrmTongHopKinhPhi)ObjectFactory.GetObject("FrmTongHopKinhPhi");
            FrmKhKinhPhiLst.AccessibleDescription = "KH_SD";
            FrmKhKinhPhiLst.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FrmBangKe FrmBangKe = (Report.FrmBangKe)ObjectFactory.GetObject("FrmBangKe");
            FrmBangKe.AccessibleDescription = "BangKe_01";
            FrmBangKe.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FrmBangKe FrmBangKe = (Report.FrmBangKe)ObjectFactory.GetObject("FrmBangKe");
            FrmBangKe.AccessibleDescription = "BangKe_02";
            FrmBangKe.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FrmBaoCao FrmBaoCao = (Report.FrmBaoCao)ObjectFactory.GetObject("FrmBaoCao");
            FrmBaoCao.AccessibleDescription = "BaoCao02_KP";
            FrmBaoCao.ShowDialog();            
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FrmBaoCao FrmBaoCao = (Report.FrmBaoCao)ObjectFactory.GetObject("FrmBaoCao");
            FrmBaoCao.AccessibleDescription = "BaoCao_01";
            FrmBaoCao.ShowDialog();
        }

        #endregion

        #region Danh muc
        private void barDmNh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDmNganHang FrmDmNganHang = (FrmDmNganHang)ObjectFactory.GetObject("FrmDmNganHang");
            FrmDmNganHang.Show();
        }

        private void barDmLk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDmLoaiKhoan FrmDmLoaiKhoan = (FrmDmLoaiKhoan)ObjectFactory.GetObject("FrmDmLoaiKhoan");
            FrmDmLoaiKhoan.Show();
        }

        private void barDmKc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDmKhoanChi FrmDmKhoanChi = (FrmDmKhoanChi)ObjectFactory.GetObject("FrmDmKhoanChi");
            FrmDmKhoanChi.Show();
        }

        private void barDmDv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDonVi frmDonVi = (FrmDonVi)ObjectFactory.GetObject("frmDonVi");
            frmDonVi.Show();
        }

        private void barDmLDv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDmNhomDonvi FrmDmNhomDonvi = (FrmDmNhomDonvi)ObjectFactory.GetObject("FrmDmNhomDonvi");
            FrmDmNhomDonvi.Show();
        }
        private void btnQuanTriNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanTriNguoiDung FrmQuanTriNguoiDung = (FrmQuanTriNguoiDung)ObjectFactory.GetObject("FrmQuanTriNguoiDung");
            FrmQuanTriNguoiDung.Show();
        }
        #endregion

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.FrmBaoCao FrmBaoCao = (Report.FrmBaoCao)ObjectFactory.GetObject("FrmBaoCao");
            FrmBaoCao.AccessibleDescription = "BaoCao03_KP";
            FrmBaoCao.ShowDialog(); 
        }

       
        
    }
}