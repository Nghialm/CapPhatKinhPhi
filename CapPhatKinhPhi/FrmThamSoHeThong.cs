using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Core;

namespace CapPhatKinhPhi
{
    public partial class frmThamSoHeThong : Form
    {
        public frmThamSoHeThong()
        {
            InitializeComponent();
        }

        #region"Variables"

        public IInfoService InfoService;
        //private Info objThamSo;
        IList<Info> lstThamSo = new List<Info>();
        IList<Info> lstDelThamSo = new List<Info>();

        #endregion

        #region"Functions"

        private void LoadData()
        {
            lstThamSo = InfoService.GetAll();
            grcThamSo.DataSource = lstThamSo;
        }

        private void AddNewRow()
        {
            Info obj = new Info();
            lstThamSo.Add(obj);
            grvThamSo.RefreshData();
            GridHelper.SetFocusAfterAddRow(grvThamSo);
        }

        private void DeleteRow()
        { 
            if (grvThamSo.FocusedRowHandle < 0)
                return;
            Info obj =(Info)grvThamSo.GetRow(grvThamSo.FocusedRowHandle);
            grvThamSo.DeleteSelectedRows();
            grvThamSo.RefreshData();
            if (obj.Id != new Guid())
            {
                lstDelThamSo.Add(obj);
            }
        }

        private void SaveData()
        { 
            //Save data
            foreach (Info obj in lstThamSo)
            {
                InfoService.SaveOrUpdate(obj);
            }

            //Delete data
            foreach (Info obj in lstDelThamSo)
            {
                InfoService.DeleteById(obj.Id);
            }
        }

        #endregion

        #region"Events"

        private void frmThamSoHeThong_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch(Exception ex)
            {
                Commons.Message_Error(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Commons.Message_Confirm("Bạn có chắc chắn muốn lưu thay đổi??"))
                {
                    SaveData();
                    LoadData();
                    Commons.Message_Information("Lưu thành công");
                }
            }
            catch (Exception ex)
            {
                Commons.Message_Error(ex);
            }
        }

        private void grvThamSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                if(GridHelper.CheckAddNewRow(grvThamSo))
                {
                    AddNewRow();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThamSoHeThong_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                { 
                    case Keys.F4:
                        AddNewRow();
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

        #endregion  
    }
}