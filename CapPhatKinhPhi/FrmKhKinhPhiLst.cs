using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vns.Erp.Core;
using Vns.Erp.Core.Domain;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Core;

namespace CapPhatKinhPhi
{
    public partial class FrmKhKinhPhiLst : Form
    {
        public IVnsLoaiChungTuService VnsLoaiChungTuService;
        public IVnsKhNganSachService VnsKhNganSachService;
        public String MaLoaiChungTu = "CP";
        public VnsLoaiChungTu objLoaiChungTu;
        public VnsKhNganSach objChungTu = new VnsKhNganSach();


        public FrmKhKinhPhiLst()
        {
            InitializeComponent();
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            grcDanhSach.ShowPrintPreview();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmKhKinhPhiEdit frmUnc = (FrmKhKinhPhiEdit)ObjectFactory.GetObject("FrmKhKinhPhiEdit");
            frmUnc.objLoaiChungTu = objLoaiChungTu;
            frmUnc.FormStatus = FormUpdate.Insert;
            frmUnc.ShowDialog();

            if (frmUnc.IsOk)
            {
                LoadData();
                if(frmUnc.objChungTu!=null)
                setFocusGridview(frmUnc.objChungTu.Id);
            }
        }

        private void setFocusGridview(Guid CtId)
        {
            List<VnsKhNganSach> lst = new List<VnsKhNganSach>();
            lst = (List<VnsKhNganSach>)grvDanhSach.DataSource;
            for (int i = 0; i < grvDanhSach.RowCount; i++)
            {
                if (lst[i].Id == CtId)
                {
                    grvDanhSach.FocusedRowHandle = i;
                    return;
                }

            }
        }

        private void FrmTamUng_Load(object sender, EventArgs e)
        {
            BindCombo();
            LoadData();
        }

        private void LoadData()
        {
            //IList<VnsKhNganSach> lstLoaiChungTu = VnsKhNganSachService.LoadByChungTu(objLoaiChungTu.Id);
            IList<VnsKhNganSach> lstLoaiChungTu = VnsKhNganSachService.LoadBy(objLoaiChungTu.Id, General.NamKeToan);
            grcDanhSach.DataSource = lstLoaiChungTu;
            grcDanhSach.RefreshDataSource();

            groupControlDs.Text = "Danh sách " + objLoaiChungTu.Ten;
        }

        private void LoadDataDetail(VnsKhNganSach selChungTu)
        {
           //IList<VnsGiaoDich> lstDetail = selChungTu.LstGiaoDich;
            if (selChungTu == null)
            { grcChiTiet.DataSource = null; return; }

            grcChiTiet.DataSource = selChungTu.LstNganSach;
        }

        private void BindCombo()
        {
            MaLoaiChungTu = this.AccessibleDescription;
            objLoaiChungTu = VnsLoaiChungTuService.GetByMa(MaLoaiChungTu);
            if(objLoaiChungTu!=null)
                this.Text = objLoaiChungTu.Ten;
                      
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grvDanhSach.FocusedRowHandle < 0)
            {
                MessageBox.Show("Không có bản ghi nào được lựa chọn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int i = grvDanhSach.FocusedRowHandle;

            objChungTu = (VnsKhNganSach)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);

            FrmKhKinhPhiEdit frmUnc = (FrmKhKinhPhiEdit)ObjectFactory.GetObject("FrmKhKinhPhiEdit");
            frmUnc.objLoaiChungTu = objLoaiChungTu;
            frmUnc.objChungTu = objChungTu;
            frmUnc.FormStatus = FormUpdate.Update;
            frmUnc.ShowDialog();
            if (frmUnc.IsOk)
            {
                LoadData();
            }
            grvDanhSach.FocusedRowHandle = i;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grvDanhSach.FocusedRowHandle < 0)
            {
                MessageBox.Show("Không có bản ghi nào được lựa chọn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objChungTu = (VnsKhNganSach)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            if (this.objChungTu != null)
            {
                if(MessageBox.Show("Bạn có muốn chứng từ " + objChungTu.SoChungTu, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.VnsKhNganSachService.DeleteById(objChungTu.Id);
                    LoadData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grvDanhSach.FocusedRowHandle < 0)
            {
                grcChiTiet.DataSource = null;
                return;
            }
            objChungTu = (VnsKhNganSach)grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle);
            LoadDataDetail(objChungTu);
        }

        private void FrmUyNhiemChi_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
                {
                    btnThem_Click(btnThem, null);
                }
                else if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
                {
                    btnSua_Click(btnSua, null);
                }
                else if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
                {
                    btnXoa_Click(btnXoa, null);
                }
            }
            catch (Exception ex)
            {
                Commons.Message_Error(ex);
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDanhSach.FocusedRowHandle < 0 || grvDanhSach.RowCount == 0)
                {
                    MessageBox.Show("Không có bản ghi nào được lựa chọn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<VnsKhNganSach> tmp = new List<VnsKhNganSach>();

                List<RpChiTietNganSach> lstRp = new List<RpChiTietNganSach>();

                foreach (VnsCtNganSach tmpd in objChungTu.LstNganSach)
                {
                    RpChiTietNganSach rp = new RpChiTietNganSach(objChungTu, tmpd);
                    lstRp.Add(rp);
                }

                lstRp.Sort(ComparePhieuByKhoanChi);
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

                List<Info> TempLstThamSo = new List<Info>();
                TempLstThamSo = General.lstThamSo.ToList();

                Info objThamSo = new Info();
                objThamSo.Ma = "p_SoTienBangChu";
                objThamSo.GiaTri = ReportHelper.DocTienBangChu((long)GetSoTien(), " đồng");
                TempLstThamSo.Add(objThamSo);

                objThamSo = new Info();
                objThamSo.Ma = "p_NgayBaoCao";
                objThamSo.GiaTri = "Hà Nội, ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
                TempLstThamSo.Add(objThamSo);

                objThamSo = new Info();
                objThamSo.Ma = "p_TieuDe";
                objThamSo.GiaTri = objLoaiChungTu.Ten.ToUpper();
                TempLstThamSo.Add(objThamSo);

                frmInPhieu frmIn = new frmInPhieu(TempLstThamSo, lstRp);
                frmIn.ShowDialog();
            }
            catch (Exception ex)
            {
                Commons.Message_Error(ex);
            }

        }
        private decimal GetSoTien()
        {
            decimal sotien = 0;

            foreach (VnsCtNganSach obj in objChungTu.LstNganSach)
            {
                sotien += obj.SoTien;
            }
            return sotien;
        }
        private int ComparePhieuByKhoanChi(RpChiTietNganSach x, RpChiTietNganSach y)
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
                    int retvalDoanDienID = 0;
                    return retvalDoanDienID = x.KhoanChi.CompareTo(y.KhoanChi);
                }
            }
        }
    }
}
