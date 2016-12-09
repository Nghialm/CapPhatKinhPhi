using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraReports.Parameters;
using Vns.CapPhatKinhPhi.Domain;

namespace CapPhatKinhPhi
{
    public class GridHelper
    {
        public static bool CheckAddNewRow(GridView _GridView)
        {
            return CheckAddNewRow(_GridView, true);
        }

        public static bool CheckAddNewRow(GridView _GridView, bool _ShowConfirm)
        {
            if ((_GridView.IsLastRow))
            {
                int i = 0;
                for (int j = 0; j <= _GridView.Columns.Count - 1; j++)
                {
                    if (_GridView.Columns[j].Visible)
                        i = i + 1;
                }

                //int GroupCount = _GridView.GroupCount;
                int GroupCount = 0;

                if (_GridView.GetVisibleColumn(i - 1 - GroupCount).Visible)
                {
                    if (_GridView.FocusedColumn.VisibleIndex == i - 1 - GroupCount)
                    {
                        if ((_ShowConfirm))
                        {
                            DialogResult dr = MessageBox.Show("Bạn có muốn thêm dòng mới không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dr == DialogResult.Yes)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                }

            }
            return false;
        }

        public static void SetFocusAfterAddRow(GridView _grv)
        {
            int i = _grv.RowCount -1;
            int group_count = GetGroupRowCount(_grv);
            _grv.FocusedRowHandle = i + group_count;
            _grv.FocusedColumn = _grv.GetVisibleColumn(0);
        }

        public static void SetFocusAfterAddRowWithAdd(GridView _grv)
        {
            int i = _grv.RowCount;
            int group_count = 0;
            int selectrow = i + group_count;
            _grv.FocusedRowHandle = selectrow;
            _grv.FocusedColumn = _grv.GetVisibleColumn(0);
        }



        private static int GetGroupRowCount(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            for (int i = -1; i >= int.MinValue; i--)
            {
                if (!view.IsValidRowHandle(i))
                    return -(i + 1);
            }
            return 0;
        }
    }

    public class ComboHelper
    {
        public static object GetSelectData(DevExpress.XtraEditors.GridLookUpEdit grlLoaiTSCD)
        {
            return grlLoaiTSCD.Properties.GetRowByKeyValue(grlLoaiTSCD.EditValue);
        }

        public static object GetSelectData(DevExpress.XtraEditors.LookUpEdit grlLoaiTSCD)
        {
            return grlLoaiTSCD.Properties.GetDataSourceRowByKeyValue(grlLoaiTSCD.EditValue);
        }

        public static object GetSelectData(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit, object svalue)
        {
            return repositoryItemLookUpEdit.GetDataSourceRowByKeyValue(svalue);
        }

        public static object GetSelectData(DevExpress.XtraGrid.Views.Grid.GridView rp)
        {
            return rp.GetRow(rp.FocusedRowHandle);
        }
    }

    public class ReportHelper
    {
        public static List<Parameter> getParamValue(IList<Info> lstThamSoHt)
        {
            List<Parameter> lst = new List<Parameter>();
            Parameter obj;//= new Parameter();

            foreach (Info objThamSo in lstThamSoHt)
            {
                obj = new Parameter();
                obj.Name = objThamSo.Ma;
                obj.Value = objThamSo.GiaTri;
                lst.Add(obj);
            }

            return lst;
        }

        public static void SetParamValue(IList<Info> lstThamSoHt, ParameterCollection lstParamReport)
        {
            List<Parameter> lst = getParamValue(lstThamSoHt);
            int paramCount = lstParamReport.Count;
            foreach (Parameter item in lst)
            {
                for (int i = 0; i < paramCount; i++)
                {
                    if (item.Name.ToUpper() == lstParamReport[i].Name.ToUpper())
                    {
                        lstParamReport[i].Value = item.Value;
                        lstParamReport[i].Description = item.Description;
                        lstParamReport[i].Visible = false;
                    }
                }
            }
        }

        #region "read string of number"
        private static string[] ChuSo = new string[10] { " không", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
        private static string[] Tien = new string[6] { "", " nghìn", " triệu", " tỷ", " nghìn tỷ", " triệu tỷ" };
        // Hàm đọc số thành chữ
        public static string DocTienBangChu(long SoTien, string strTail)
        {
            int lan, i;
            long so;
            string KetQua = "", tmp = "";
            int[] ViTri = new int[6];
            if (SoTien < 0) return "Số tiền âm !";
            if (SoTien == 0) return "Không đồng !";
            if (SoTien > 0)
            {
                so = SoTien;
            }
            else
            {
                so = -SoTien;
            }
            //Kiểm tra số quá lớn
            if (SoTien > 8999999999999999)
            {
                SoTien = 0;
                return "";
            }
            ViTri[5] = (int)(so / 1000000000000000);
            so = so - long.Parse(ViTri[5].ToString()) * 1000000000000000;
            ViTri[4] = (int)(so / 1000000000000);
            so = so - long.Parse(ViTri[4].ToString()) * +1000000000000;
            ViTri[3] = (int)(so / 1000000000);
            so = so - long.Parse(ViTri[3].ToString()) * 1000000000;
            ViTri[2] = (int)(so / 1000000);
            ViTri[1] = (int)((so % 1000000) / 1000);
            ViTri[0] = (int)(so % 1000);
            if (ViTri[5] > 0)
            {
                lan = 5;
            }
            else if (ViTri[4] > 0)
            {
                lan = 4;
            }
            else if (ViTri[3] > 0)
            {
                lan = 3;
            }
            else if (ViTri[2] > 0)
            {
                lan = 2;
            }
            else if (ViTri[1] > 0)
            {
                lan = 1;
            }
            else
            {
                lan = 0;
            }
            for (i = lan; i >= 0; i--)
            {
                tmp = DocSo3ChuSo(ViTri[i]);
                KetQua += tmp;
                if (ViTri[i] != 0) KetQua += Tien[i];
                if ((i > 0) && (!string.IsNullOrEmpty(tmp))) KetQua += ",";//&& (!string.IsNullOrEmpty(tmp))
            }
            if (KetQua.Substring(KetQua.Length - 1, 1) == ",") KetQua = KetQua.Substring(0, KetQua.Length - 1);
            KetQua = KetQua.Trim() + strTail;
            return KetQua.Substring(0, 1).ToUpper() + KetQua.Substring(1);
        }
        // Hàm đọc số có 3 chữ số
        public static string DocSo3ChuSo(int baso)
        {
            int tram, chuc, donvi;
            string KetQua = "";
            tram = (int)(baso / 100);
            chuc = (int)((baso % 100) / 10);
            donvi = baso % 10;
            if ((tram == 0) && (chuc == 0) && (donvi == 0)) return "";
            if (tram != 0)
            {
                KetQua += ChuSo[tram] + " trăm";
                if ((chuc == 0) && (donvi != 0)) KetQua += " linh";
            }
            if ((chuc != 0) && (chuc != 1))
            {
                KetQua += ChuSo[chuc] + " mươi";
                if ((chuc == 0) && (donvi != 0)) KetQua = KetQua + " linh";
            }
            if (chuc == 1) KetQua += " mười";
            switch (donvi)
            {
                case 1:
                    if ((chuc != 0) && (chuc != 1))
                    {
                        KetQua += " mốt";
                    }
                    else
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
                case 5:
                    if (chuc == 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    else
                    {
                        KetQua += " lăm";
                    }
                    break;
                default:
                    if (donvi != 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
            }
            return KetQua;
        }
        #endregion
    }
}
