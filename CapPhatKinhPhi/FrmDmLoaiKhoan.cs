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
    public partial class FrmDmLoaiKhoan : Form
    {
        #region Property Service
        public IVnsMaLoaiKhoanService VnsMaLoaiKhoanService;
        #endregion

        public FrmDmLoaiKhoan()
        {
            InitializeComponent();
        }
        
        public FormUpdate FormStatus;
        IList<VnsMaLoaiKhoan> lstDanhMuc = new List<VnsMaLoaiKhoan>();
        IList<VnsMaLoaiKhoan> lstBind = new List<VnsMaLoaiKhoan>();
        VnsMaLoaiKhoan SelectObject = new VnsMaLoaiKhoan();

        private void BindCombo()
        {
            lstBind = VnsMaLoaiKhoanService.GetAll();
            this.grlDmLoaiKhoan.Properties.DataSource = lstBind;
            this.grlDmLoaiKhoan.Properties.DisplayMember = "Ma";
            this.grlDmLoaiKhoan.Properties.ValueMember = "Id";
        }
        private void BindData()
        {
            // Hien thi du lieu len gridcontrol
            lstDanhMuc = new List<VnsMaLoaiKhoan>();
            lstDanhMuc = VnsMaLoaiKhoanService.GetAll();
            
            this.gctDonVi.DataSource = lstDanhMuc;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormStatus = FormUpdate.Insert;
            SetStatus(FormStatus);
            SetObjectToControl(new VnsMaLoaiKhoan());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvDonVi.FocusedRowHandle < 0) return;

            if (!Commons.Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?")) return;

            VnsMaLoaiKhoanService.Delete(SelectObject);
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
            SelectObject = (VnsMaLoaiKhoan)gvDonVi.GetRow(gvDonVi.FocusedRowHandle);

            if (SelectObject == null) return;

            FormStatus = FormUpdate.Update;
            SetObjectToControl(SelectObject);
        }

        private void SaveData()
        {
            VnsMaLoaiKhoan tmp = new VnsMaLoaiKhoan();
            tmp = GetObjectFromControl();

            switch (FormStatus)
            {
                case FormUpdate.Insert:
                    VnsMaLoaiKhoanService.Save(tmp);
                    break;
                case FormUpdate.Update:
                    tmp.Id = SelectObject.Id;
                    VnsMaLoaiKhoanService.SaveOrUpdate(tmp);
                    break;
            }

            ReloadData(FormStatus, tmp);
        }

        private void ReloadData(FormUpdate status, VnsMaLoaiKhoan tmp)
        {
            switch (status)
            {
                case FormUpdate.Insert:
                    lstDanhMuc.Add(tmp);
                    if (tmp.ChiTiet == 0) lstBind.Add(tmp);
                    break;
                case FormUpdate.Update:
                    SelectObject = tmp;
                    break;
                case FormUpdate.Delete:
                    lstDanhMuc.Remove(SelectObject);
                    break;
            }

            
            gctDonVi.DataSource = lstDanhMuc;
            gctDonVi.RefreshDataSource();

            grlDmLoaiKhoan.Refresh();
        }

        private void SetObjectToControl(VnsMaLoaiKhoan objDonvi)
        {
            this.txtMa.EditValue = objDonvi.Ma;
            this.txtTenLoaiKhoan.EditValue = objDonvi.Ten;
            this.txtMaChuong.EditValue = objDonvi.MaChuong;
            this.grlDmLoaiKhoan.EditValue = objDonvi.IdCha;
            this.txtMaHang.EditValue = objDonvi.MaHang;
            this.txtMoTa.EditValue = objDonvi.MoTa;
        }

        private VnsMaLoaiKhoan GetObjectFromControl()
        {
            VnsMaLoaiKhoan _tmp = new VnsMaLoaiKhoan();
            _tmp.MaChuong = txtMaChuong.Text;
            _tmp.Ma = txtMa.Text;
            _tmp.Ten = txtTenLoaiKhoan.Text;
            VnsMaLoaiKhoan cha = new VnsMaLoaiKhoan();
            cha = (VnsMaLoaiKhoan)ComboHelper.GetSelectData(grlDmLoaiKhoan);
            if (cha == null)
            {
                _tmp.IdCha = new Guid();
                _tmp.MaCha = "";
            }
            else
            {
                _tmp.IdCha = cha.Id;
                _tmp.MaCha = cha.Ma;
            }
            
            _tmp.MaHang = txtMaHang.Text;
            _tmp.MoTa = txtMoTa.Text;
            _tmp.ChiTiet = VnsCheck.IsNullGuid(grlDmLoaiKhoan.EditValue) ? 0 : 1;
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
            if (txtMa.Text.Trim() == "")
            {
                Commons.Message_Warning("Bạn chưa nhập tên đơn vị");
                txtMa.Focus();
                return false;
            }

            if (txtMaChuong.Text.Trim() == "")
            {
                Commons.Message_Warning("Bạn chưa nhập mã đơn vị");
                txtMaChuong.Focus();
                return false;
            }

            if (grlDmLoaiKhoan.EditValue == null)
            {
                Commons.Message_Warning("Bạn chưa chọn loại đơn vị");
                grlDmLoaiKhoan.Focus();
                return false;
            }
            return true;
        }
    }
}
