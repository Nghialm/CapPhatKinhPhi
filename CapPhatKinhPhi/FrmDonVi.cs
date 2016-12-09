using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Service.Interface;
using System.Collections;
using Vns.Erp.Core.Domain;
using Vns.Core;

namespace CapPhatKinhPhi
{
    public partial class FrmDonVi : Form
    {
        #region Property Service
        public IVnsDmDonViService VnsDmDonViService;
        public IVnsDmNhomDonViService VnsDmNhomDonViService;
        public IVnsDmNganHangService VnsDmNganHangService;
        #endregion

        public FrmDonVi()
        {
            InitializeComponent();
        }
        
        public FormUpdate FormStatus;
        IList<VnsDmDonVi> lstDmDonvi = new List<VnsDmDonVi>();
        VnsDmDonVi SelectObject = new VnsDmDonVi();

        private void BindCombo()
        {
            this.cboDmNganHang.Properties.DataSource = VnsDmNganHangService.GetAll();
            this.cboDmNganHang.Properties.DisplayMember = "TenNganHang";
            this.cboDmNganHang.Properties.ValueMember = "Id";

            this.cboNhomDonvi.Properties.DataSource = VnsDmNhomDonViService.GetAll();
            this.cboNhomDonvi.Properties.DisplayMember = "TenNhom";
            this.cboNhomDonvi.Properties.ValueMember = "Id";
        }
        private void BindData()
        {
            // Hien thi du lieu len gridcontrol
            lstDmDonvi = new List<VnsDmDonVi>();
            lstDmDonvi = VnsDmDonViService.GetAll();
            
            this.gctDonVi.DataSource = lstDmDonvi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormStatus = FormUpdate.Insert;
            SetStatus(FormStatus);
            SetObjectToControl(new VnsDmDonVi());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvDonVi.FocusedRowHandle < 0) return;

            if (!Commons.Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?")) return;

            VnsDmDonViService.Delete(SelectObject);
            FormStatus = FormUpdate.Delete;
            ReloadData(FormStatus, SelectObject);
            FormStatus = FormUpdate.Update;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            SaveData();

            BindData();

            FormStatus = FormUpdate.View;
            SetStatus(FormStatus);


            //SetObjectToControl(SelectObject);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormStatus = FormUpdate.View;
            SetStatus(FormStatus);
        }

        private void FrmDonVi_Load(object sender, EventArgs e)
        {
            BindCombo();
            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDonVi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDonVi.FocusedRowHandle < 0)
            {
                return;
            }
            SelectObject = (VnsDmDonVi)gvDonVi.GetRow(gvDonVi.FocusedRowHandle);

            if (SelectObject == null) return;

            FormStatus = FormUpdate.Update;
            SetObjectToControl(SelectObject);
        }

        private void SaveData()
        {
            VnsDmDonVi tmp = new VnsDmDonVi();
            tmp = GetObjectFromControl();

            switch (FormStatus)
            {
                case FormUpdate.Insert:
                    VnsDmDonViService.Save(tmp);
                    break;
                case FormUpdate.Update:
                    tmp.Id = SelectObject.Id;
                    VnsDmDonViService.SaveOrUpdate(tmp);
                    break;
            }

            ReloadData(FormStatus, tmp);
        }

        private void ReloadData(FormUpdate status, VnsDmDonVi tmp)
        {
            switch (status)
            {
                case FormUpdate.Insert:
                    lstDmDonvi.Add(tmp);
                    break;
                case FormUpdate.Update:
                    SelectObject = tmp;
                    break;
                case FormUpdate.Delete:
                    lstDmDonvi.Remove(SelectObject);
                    break;
            }

            
            gctDonVi.DataSource = lstDmDonvi;
            gctDonVi.RefreshDataSource();
        }

        private void SetObjectToControl(VnsDmDonVi objDonvi)
        {
            this.txtTenDonVi.EditValue = objDonvi.TenDonvi;
            this.txtMaDonVi.EditValue = objDonvi.Ma;
            this.cboDmNganHang.EditValue = objDonvi.NganHangId;
            this.cboNhomDonvi.EditValue = objDonvi.NhomDonviId;
            txtDiaChi.EditValue = objDonvi.DiaChi;
            txtSoTaiKhoan.EditValue = objDonvi.SoTaiKhoan;
            txtMaDvQhns.EditValue = objDonvi.MaDvQhns;
            txtMaTkCo.EditValue = objDonvi.MaTkCo;
        }

        private VnsDmDonVi GetObjectFromControl()
        {
            VnsDmDonVi _tmp = new VnsDmDonVi();
            _tmp.Ma = txtMaDonVi.Text;
            _tmp.TenDonvi = txtTenDonVi.Text;
            _tmp.NganHangId = (Guid)cboDmNganHang.EditValue;
            _tmp.objDmNganHang = (VnsDmNganHang)ComboHelper.GetSelectData(cboDmNganHang);
            _tmp.NhomDonviId = (Guid)cboNhomDonvi.EditValue;
            _tmp.objDmNhomDonVi = (VnsDmNhomDonVi)ComboHelper.GetSelectData(cboNhomDonvi);
            _tmp.MaDvQhns = txtMaDvQhns.Text;
            _tmp.SoTaiKhoan = txtSoTaiKhoan.Text;
            _tmp.DiaChi = txtDiaChi.Text;
            _tmp.MaTkCo = txtMaTkCo.Text;
            return _tmp;
        }

        private void SetStatus(FormUpdate status)
        {
            switch (status)
            {
                case FormUpdate.Insert:
                    btnThem.Enabled = false;
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;

                    groupDetail.Enabled = true;
                    groupList.Enabled = false;
                    break;
                case FormUpdate.Update:
                    btnThem.Enabled = true;
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;

                    groupDetail.Enabled = true;
                    groupList.Enabled = true;
                    break;
                case FormUpdate.View:
                    btnThem.Enabled = true;
                    btnLuu.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;

                    groupDetail.Enabled = true;
                    groupList.Enabled = true;
                    break;
            }
 
        }

        private Boolean CheckInput()
        {
            if (txtTenDonVi.Text.Trim() == "")
            {
                Commons.Message_Warning("Bạn chưa nhập tên đơn vị");
                txtTenDonVi.Focus();
                return false;
            }

            if (txtMaDonVi.Text.Trim() == "")
            {
                Commons.Message_Warning("Bạn chưa nhập mã đơn vị");
                txtMaDonVi.Focus();
                return false;
            }

            if (cboDmNganHang.EditValue == null)
            {
                Commons.Message_Warning("Bạn chưa chọn loại đơn vị");
                cboDmNganHang.Focus();
                return false;
            }
            return true;
        }
    }
}
