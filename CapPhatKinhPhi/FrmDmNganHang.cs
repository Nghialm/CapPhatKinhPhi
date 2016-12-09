using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vns.Erp.Core.Domain;
using System.Collections;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.Core;

namespace CapPhatKinhPhi
{
    public partial class FrmDmNganHang : Form
    {

        #region Property Service
        public IVnsDmNganHangService VnsDmNganHangService;
        #endregion

        public FormUpdate FormStatus;
        IList<VnsDmNganHang> lstDanhMuc = new List<VnsDmNganHang>();
        VnsDmNganHang SelectObject = new VnsDmNganHang();

        public FrmDmNganHang()
        {
            InitializeComponent();
        }

        private void BindCombo()
        {
        }

        private void BindData()
        {
            // Hien thi du lieu len gridcontrol
            lstDanhMuc = new List<VnsDmNganHang>();
            lstDanhMuc = VnsDmNganHangService.GetAll();
            
            this.grdDanhMuc.DataSource = lstDanhMuc;
        }

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormStatus = FormUpdate.Insert;
            SetStatus(FormStatus);
            SetObjectToControl(new VnsDmNganHang());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvDanhMuc.FocusedRowHandle < 0) return;

            if (!Commons.Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?")) return;

            VnsDmNganHangService.Delete(SelectObject);
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

        private void FrmLoaiDoanRa_Load(object sender, EventArgs e)
        {
            BindCombo();
            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhMuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvDanhMuc.FocusedRowHandle < 0)
            {
                return;
            }
            SelectObject = (VnsDmNganHang)gvDanhMuc.GetRow(gvDanhMuc.FocusedRowHandle);

            if (SelectObject == null) return;

            FormStatus = FormUpdate.Update;
            SetObjectToControl(SelectObject);
        }
        #endregion

        #region Function
        private void SaveData()
        {
            VnsDmNganHang tmp = new VnsDmNganHang();
            tmp = GetObjectFromControl();

            switch (FormStatus)
            {
                case FormUpdate.Insert:
                    VnsDmNganHangService.Save(tmp);
                    break;
                case FormUpdate.Update:
                    tmp.Id = SelectObject.Id;
                    VnsDmNganHangService.SaveOrUpdate(tmp);
                    break;
            }

            ReloadData(FormStatus, tmp);
        }

        private void ReloadData(FormUpdate status, VnsDmNganHang tmp)
        {
            switch (status)
            {
                case FormUpdate.Insert:
                    lstDanhMuc.Add(tmp);
                    break;
                case FormUpdate.Update:
                    SelectObject = tmp;
                    break;
                case FormUpdate.Delete:
                    lstDanhMuc.Remove(SelectObject);
                    break;
            }


            grdDanhMuc.DataSource = lstDanhMuc;
            grdDanhMuc.RefreshDataSource();
        }

        private void SetObjectToControl(VnsDmNganHang obj)
        {
            this.txtTen.EditValue = obj.TenNganHang;
            this.txtMa.EditValue = obj.Ma;
            txtMoTa.EditValue = obj.MoTa;
        }

        private VnsDmNganHang GetObjectFromControl()
        {
            VnsDmNganHang _tmp = new VnsDmNganHang();
            _tmp.Ma = txtMa.Text;
            _tmp.TenNganHang = txtTen.Text;
            _tmp.MoTa = txtMoTa.Text;
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

            if (txtTen.Text.Trim() == "")
            {
                Commons.Message_Warning("Bạn chưa nhập mã đơn vị");
                txtTen.Focus();
                return false;
            }

            return true;
        }
        #endregion
    }
}
