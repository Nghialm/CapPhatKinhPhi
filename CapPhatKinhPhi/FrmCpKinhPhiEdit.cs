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
//using QuanLyDoanRa.Reports;
using Vns.Core;
using DevExpress.XtraGrid.Views.Grid;

namespace CapPhatKinhPhi
{
    public partial class FrmCpKinhPhiEdit : Form
    {
        #region Property Service
        public IVnsLoaiChungTuService VnsLoaiChungTuService;
        public IVnsChungTuService VnsChungTuService;
        public IVnsGiaoDichService VnsGiaoDichService;
        public IVnsDmDonViService VnsDmDonViService;
        public IVnsDmKhoanChiService VnsDmKhoanChiService;
        public IVnsMaLoaiKhoanService VnsMaLoaiKhoanService;
        public IReportCapPhatService ReportCapPhatService;
        #endregion

        #region Variable
        public FormUpdate FormStatus;
        public VnsLoaiChungTu objLoaiChungTu;
        private IList<VnsGiaoDich> lstGiaoDich;
        private IList<VnsGiaoDich> lstDelGiaoDich;

        VnsChungTu _ChungTu = new VnsChungTu();
        public bool IsOk = false;
        public VnsChungTu objChungTu
        {
            get { return _ChungTu; }
            set { _ChungTu = value; }
        }

        #endregion

        #region "Functions"
        public FrmCpKinhPhiEdit()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            switch (FormStatus)
            {
                case FormUpdate.Update:
                    objChungTu = VnsChungTuService.GetById(objChungTu.Id);
                    SetObject();
                    break;
                case FormUpdate.Insert:
                    objChungTu = new VnsChungTu();
                    SetObject();
                    break;
            }
        }

        private void BindCombo()
        {
            this.cboDmDonVi.Properties.DataSource = VnsDmDonViService.GetAll();
            this.cboDmDonVi.Properties.DisplayMember = "Ma";
            this.cboDmDonVi.Properties.ValueMember = "Id";

            this.grlKhoanChi.DataSource = VnsDmKhoanChiService.GetAll();

            this.grlLoaiKhoan.DataSource = VnsMaLoaiKhoanService.GetChiTiet(1);
        }

        private void AddRow()
        {
            DateTime beforeAdd = DateTime.Now;
            System.Threading.Thread.Sleep(1);
            if (lstGiaoDich == null) lstGiaoDich = new List<VnsGiaoDich>();

            VnsGiaoDich tmp = new VnsGiaoDich();
            if (_GridView.FocusedRowHandle >= 0)
                tmp = (VnsGiaoDich)_GridView.GetRow(_GridView.FocusedRowHandle);

            if (tmp == null)
                lstGiaoDich.Add(new VnsGiaoDich());
            else
            {
                VnsGiaoDich tmpAddRow = new VnsGiaoDich();
                tmpAddRow.KhoanChiId = tmp.KhoanChiId;
                tmpAddRow.ObjDmKhoanChi = tmp.ObjDmKhoanChi;
                tmpAddRow.DienGiai = tmp.DienGiai;
                tmpAddRow.NoiDungCapPhat = txtNoiDung.Text;
                lstGiaoDich.Add(tmpAddRow);
            }

            //_GridView.s
            //_GridControl.DataSource = lstGiaoDich;
            _GridView.RefreshData();

            SetFocusAfterAdd(_GridView, beforeAdd);
        }

        private int SetFocusAfterAdd(GridView _GridView, DateTime beforeAdd)
        {
            for (int i = 0; i < _GridView.RowCount -1; i++)
            {
                if (!_GridView.IsValidRowHandle(i)) continue;
                VnsGiaoDich tmp = (VnsGiaoDich)_GridView.GetRow(i);
                if (tmp != null)
                {
                    if (tmp.GioThemMoi >= beforeAdd)
                        return i;
                }
            }
            return 0;
        }

        private void DeleteRow()
        {
            if (_GridView.FocusedRowHandle < 0) return;

            VnsGiaoDich gd = (VnsGiaoDich)_GridView.GetRow(_GridView.FocusedRowHandle);
            if (lstDelGiaoDich == null)
                lstDelGiaoDich = new List<VnsGiaoDich>();
            lstDelGiaoDich.Add(gd);
            _GridView.DeleteSelectedRows();
            _GridView.RefreshData();
        }

        private void GetObject()
        {
            if (this.objChungTu == null)
                this.objChungTu = new VnsChungTu();

            bool flg = false;
            switch (FormStatus)
            {
                case FormUpdate.Insert:
                    flg = true;
                    ucCtuSo.Soct(objLoaiChungTu.Id, dteNgayCt.DateTime.Month, dteNgayCt.DateTime.Year);
                    ucCtuSo.Text = ucCtuSo.SO_CHUNG_TU;
                    //ucCtuSo.Text = "1";
                    break;
                case FormUpdate.Update:
                    flg = false;
                    break;
            }

            this.objChungTu.LoaiCt = objLoaiChungTu.Id;
            this.objChungTu.MaCt = objLoaiChungTu.MaLoaiChungTu;
            this.objChungTu.NgayCt = (DateTime)dteNgayCt.EditValue;
            this.objChungTu.NgayHt = (DateTime)dteNgayCt.EditValue;
            //this.ChungTu.NguoiGiaoDich = txtNguoiNhan.Text;
            this.objChungTu.SoChungTu = ucCtuSo.Text;
            this.objChungTu.NoiDung = txtNoiDung.Text;
            objChungTu.DonViId = (Guid)cboDmDonVi.EditValue;
            objChungTu.ObjDmDonVi = (VnsDmDonVi)ComboHelper.GetSelectData(cboDmDonVi);
            objChungTu.TuDong = false;

            //VnsChungTuService.SaveChungTu(flg, this.ChungTu, lstGiaoDich, lstDelGiaoDich);
            VnsChungTuService.SaveOrUpdate(objChungTu);
            this.IsOk = true;
            this.Close();
        }

        private void SetObject()
        {
            dteNgayCt.EditValue = objChungTu.NgayCt;
            //txtNguoiNhan.Text = objChungTu.NguoiGiaoDich;
            ucCtuSo.Text = objChungTu.SoChungTu;
            txtNoiDung.Text = objChungTu.NoiDung;

            //lstGiaoDich = VnsGiaoDichService.GetByChungTu(objChungTu.Id);
            this.objChungTu = objChungTu;
            cboDmDonVi.EditValue = objChungTu.DonViId;
            lstGiaoDich = objChungTu.LstGiaoDich;
            _GridControl.DataSource = lstGiaoDich;
        }

        private Boolean CheckInput()
        {
            if (dteNgayCt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày chứng từ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dteNgayCt.Focus();
                return false;
            }

            //if (dteNgayht.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập ngày hạch toán", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dteNgayht.Focus();
            //    return false;
            //}

            if (cboDmDonVi.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDmDonVi.Focus();
                return false;
            }

            if (_GridView.RowCount == 0)
            {
                MessageBox.Show("Bạn chưa nhập chi tiết hạch toán", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (VnsGiaoDich obj in lstGiaoDich)
            {
                if (obj.KhoanChiId == Guid.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập khoản chi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (obj.SoTien == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số tiền", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (obj.LoaiKhoanId == Guid.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập loại khoản", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region "Events"
        private void FrmEditTamUng_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormUpdate.Insert)
            {
                btnInPhieu.Enabled = false;
            }
            else
            {
                btnInPhieu.Enabled = true;
            }

            //this.Text = objLoaiChungTu.Ten;
            //_groupControlCt.Text = "Chi tiết " + objLoaiChungTu.Ten;
            BindCombo();
            BindData();

            ucCtuSo.SetFocus();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput())
                    return;
                GetObject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvTamUng_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (_GridView.FocusedRowHandle < 0) return;
                VnsGiaoDich tmp = (VnsGiaoDich)_GridView.GetRow(_GridView.FocusedRowHandle);
                switch (e.Column.Name)
                {
                    case "colKhoanChiId":
                        VnsDmKhoanChi tmpkc = (VnsDmKhoanChi)grlKhoanChi.GetRowByKeyValue(tmp.KhoanChiId);
                        if (tmpkc == null) return;
                        tmp.ObjDmKhoanChi = tmpkc;
                        tmp.DienGiai = tmpkc.TenKhoanChi;
                        break;
                    case "colLoaiKhoanId":
                        tmp.ObjVnsMaLoaiKhoan = (VnsMaLoaiKhoan)grlLoaiKhoan.GetRowByKeyValue(tmp.LoaiKhoanId);
                        break;
                }
                _GridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvTamUng_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter)
                    return;

                if (GridHelper.CheckAddNewRow(_GridView, true))
                {
                    AddRow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNgayChungTu_Leave(object sender, EventArgs e)
        {
            //if (dteNgayCt.Text != "")
            //    dteNgayht.DateTime = dteNgayCt.DateTime;
        }

        #endregion

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                List<VnsKhNganSach> tmp = new List<VnsKhNganSach>();

                List<RpChiTietNganSach> lstRp = new List<RpChiTietNganSach>();               
                foreach (VnsGiaoDich tmpd in lstGiaoDich)
                {
                    RpChiTietNganSach rp = new RpChiTietNganSach(objChungTu, tmpd);
                    lstRp.Add(rp);
                }

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

            foreach (VnsGiaoDich obj in lstGiaoDich)
            {
                sotien += obj.SoTien;
            }
            return sotien;
        }

        private void FrmUyNhiemChiEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
                {
                    btnSave_Click(btnSave, null);
                }

                switch (e.KeyCode)
                {
                    case Keys.F4:
                        AddRow();
                        break;
                    case Keys.F8:
                        DeleteRow();
                        break;
                }
            }
            catch (Exception ex)
            {
                Commons.Message_Error(ex);
            }
        }

        private void cboDmDonVi_EditValueChanged(object sender, EventArgs e)
        {
            VnsDmDonVi tmp = (VnsDmDonVi)ComboHelper.GetSelectData(cboDmDonVi);
            if (tmp == null) return;

            txtTenDonVi.Text = tmp.TenDonvi;
        }

        

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            IList<RpChiTietNganSach> lst = new List<RpChiTietNganSach>();
            DateTime TuNgay, DenNgay;
            Guid DonviId = (Guid)cboDmDonVi.EditValue;
            DateTime tmpdate = (DateTime)dteNgayCt.EditValue ;
            TuNgay = new DateTime(tmpdate.Year, 1, 1);
            DenNgay = new DateTime(tmpdate.Year, 12, 31);

            //Tong so tien cap phat
            Decimal sotienduoccap = 0;
            foreach (VnsGiaoDich tmp in lstGiaoDich)
            {
                sotienduoccap += tmp.SoTien;
            }

            if (VnsCheck.IsNullGuid(DonviId)) return;
            lst = ReportCapPhatService.GetNganSachTongHopTheoDonVi(TuNgay, DenNgay, DonviId, objChungTu.Id);

            FrmCpCheckKinhPhi frm = new FrmCpCheckKinhPhi();
            frm.lst = lst;
            frm.SoTienLapPhieu = sotienduoccap;
            frm.ShowDialog();
            //rp.DataSource = lst;
        }

        private void btnInUNC_Click(object sender, EventArgs e)
        {
            Report.FrmInUNC frmin = new Report.FrmInUNC();
            frmin.objChungTu = objChungTu;
            frmin.LstGiaoDich = lstGiaoDich;
            frmin.ShowDialog();
        }

    }
}
