using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Service;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.CapPhatKinhPhi.Dao;
using Spring.Transaction.Interceptor;

namespace Vns.CapPhatKinhPhi.Service
{
    public class ReportCapPhatService : GenericService<Info, System.Guid>, IReportCapPhatService
    {
        public IVnsChungTuDao VnsChungTuDao;
        public IVnsKhNganSachDao VnsKhNganSachDao;
        public IVnsDmDonViDao VnsDmDonViDao;
        public IVnsDmKhoanChiDao VnsDmKhoanChiDao;
        public IVnsMaLoaiKhoanDao VnsMaLoaiKhoanDao;
        public IVnsHtSoCtMaxDao VnsHtSoCtMaxDao;

        private int CompareReport(RpNganSachTongHop x, RpNganSachTongHop y)
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
                    return retvalDoanDienID = y.DonViId.CompareTo(x.DonViId);

                }
            }
        }

        private int CompareBangKeByKhoanChi(RpChiTietNganSach x, RpChiTietNganSach y)
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
                    return retvalDoanDienID = y.MaLoaiKhoan.CompareTo(x.MaLoaiKhoan);
                }
            }
        }

        private int CompareBangKeByIDASC(RpChiTietNganSach x, RpChiTietNganSach y) 
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
                    return retvalDoanDienID = x.Id.CompareTo(y.Id);
                }
            }
        }

        public IList<RpNganSachTongHop> GetKeHoachCapPhat(DateTime TuNgay, DateTime DenNgay, VnsLoaiChungTu objLCT)
        {
            VnsKhNganSachDao.DeleteBy(objLCT.MaLoaiChungTu, TuNgay.AddYears(1), DenNgay.AddYears(1), true);

            IList<RpNganSachTongHop> lstKh = VnsKhNganSachDao.GetKeHoachTrongNam("", TuNgay, DenNgay);
            IList<RpNganSachTongHop> lstCp = VnsChungTuDao.GetCapPhatTrongNam("", TuNgay, DenNgay);

            List<RpNganSachTongHop> lstKeHoachNamSau = new List<RpNganSachTongHop>();
            List<RpNganSachTongHop> lstDuPhong = new List<RpNganSachTongHop>();

            IList<VnsDmDonVi> lstDonvi = new List<VnsDmDonVi>();
            IList<VnsMaLoaiKhoan> lstMaLoaiKhoan = new List<VnsMaLoaiKhoan>();
            IList<VnsDmKhoanChi> lstKhoanChi = new List<VnsDmKhoanChi>();

            lstDonvi = VnsDmDonViDao.GetAll();
            lstMaLoaiKhoan = VnsMaLoaiKhoanDao.GetAll();
            lstKhoanChi = VnsDmKhoanChiDao.GetAll();

            foreach (RpNganSachTongHop objKh in lstKh)
            {
                lstKeHoachNamSau.Add(objKh);
            }

            foreach (RpNganSachTongHop objCp in lstCp)
            {
                Boolean flg = false;
                foreach (RpNganSachTongHop objKhNamSau in lstKeHoachNamSau)
                {
                    if (objKhNamSau.DonViId == objCp.DonViId &&
                        objKhNamSau.KhoanChiId == objCp.KhoanChiId &&
                        objKhNamSau.LoaiKhoanId == objCp.LoaiKhoanId)
                    {
                        flg = true;

                        objKhNamSau.SoTien = objKhNamSau.SoTien - objCp.SoTien;
                        continue;
                    }
                }

                if (!flg)
                {
                    objCp.SoTien = objCp.SoTien * -1;
                    lstDuPhong.Add(objCp);
                }
            }

            if (lstDuPhong.Count > 0)
                foreach (RpNganSachTongHop rp in lstDuPhong)
                    lstKeHoachNamSau.Add(rp);

            lstKeHoachNamSau.Sort(CompareReport);

            Guid DonViId = new Guid();
            VnsKhNganSach objKhNganSach = new VnsKhNganSach();
            List<VnsKhNganSach> lstKhNganSach = new List<VnsKhNganSach>();

            int sochungtumax = 0;
            for (int i = 0; i < lstKeHoachNamSau.Count; i++)
            {
                if (DonViId != lstKeHoachNamSau[i].DonViId)
                {
                    sochungtumax++;
                    DonViId = lstKeHoachNamSau[i].DonViId;
                    objKhNganSach = new VnsKhNganSach();
                    List<String> lstCt = GetSoCT_prefix(objLCT,sochungtumax, 1, DenNgay.Year + 1);
                    objKhNganSach.SoChungTu = lstCt[0] + lstCt[1];
                    objKhNganSach.DonViId = DonViId;
                    objKhNganSach.ObjDmDonVi = GetDonVi(DonViId, lstDonvi);
                    objKhNganSach.LoaiCt = objLCT.Id;
                    objKhNganSach.MaCt = objLCT.MaLoaiChungTu;
                    objKhNganSach.NgayCt = DenNgay.AddDays(1);
                    objKhNganSach.NgayKeHoach = DenNgay.AddDays(1);
                    objKhNganSach.NoiDung = "Chuyen so du nam truoc";
                    objKhNganSach.TuDong = true;

                    lstKhNganSach.Add(objKhNganSach);
                }

                VnsCtNganSach objns = new VnsCtNganSach();
                objns.KhoanChiId = lstKeHoachNamSau[i].KhoanChiId;
                objns.ObjDmKhoanChi = GetDmKhoanChi(objns.KhoanChiId, lstKhoanChi);
                objns.LoaiKhoanId = lstKeHoachNamSau[i].LoaiKhoanId;
                objns.ObjVnsMaLoaiKhoan = GetMaLoaiKhoan(objns.LoaiKhoanId, lstMaLoaiKhoan);
                objns.SoTien = lstKeHoachNamSau[i].SoTien;
                objns.DienGiai = objns.ObjDmKhoanChi.TenKhoanChi;
                objns.NoiDungCapPhat = "Số dư năm trước chuyển sang";

                if (objns.SoTien > 0)
                    objKhNganSach.LstNganSach.Add(objns);
            }

            VnsHtSoCtMaxDao.SetSoChungTuMaxByThangNamEtc(objLCT.Id, sochungtumax, 1, DenNgay.Year + 1);

            for (int i = 0; i < lstKhNganSach.Count; i++)
            {
                if (lstKhNganSach[i].LstNganSach.Count > 0)
                    VnsKhNganSachDao.SaveOrUpdate(lstKhNganSach[i]);
            }

            return lstKeHoachNamSau;
        }

        public IList<RpChiTietNganSach> GetBangKeChiTiet(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId)
        {
            List<RpChiTietNganSach> lst = new List<RpChiTietNganSach>();
            if (string.IsNullOrEmpty(MaCt))
            {
                lst.AddRange(VnsChungTuDao.GetBangKeChiTiet(TuNgay, DenNgay, "", new Guid()));
                lst.AddRange(VnsKhNganSachDao.GetBangKeChiTiet(TuNgay, DenNgay, "", new Guid()));
                lst.Sort(CompareBangKeByIDASC);
                return lst;
            }

            if (MaCt == "CP")
            {
                lst.AddRange(VnsChungTuDao.GetBangKeChiTiet(TuNgay, DenNgay, MaCt, new Guid()));
                lst.Sort(CompareBangKeByIDASC);
                return lst;
            }
            else
            {
                lst.AddRange(VnsKhNganSachDao.GetBangKeChiTiet(TuNgay, DenNgay, MaCt, new Guid()));
                lst.Sort(CompareBangKeByIDASC);
                return lst;
            }
        }

        public IList<RpChiTietNganSach> GetBangKeKeHoach(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId)
        {
            List<RpChiTietNganSach> lst = new List<RpChiTietNganSach>();
            lst.AddRange(VnsKhNganSachDao.GetBangKeChiTiet(TuNgay, DenNgay, MaCt, new Guid()));
            return lst;
        }

        public IList<RpChiTietNganSach> GetNganSachTongHopTheoDonVi(DateTime TuNgay, DateTime DenNgay, Guid DonViId)
        {
            List<RpChiTietNganSach> lst = new List<RpChiTietNganSach>(GetBangKeChiTiet(TuNgay, DenNgay, "", DonViId));
            return lst;
        }
        public IList<RpChiTietNganSach> GetNganSachTongHopTheoDonVi(DateTime TuNgay, DateTime DenNgay, Guid DonViId, Guid CapPhatId)
        {
            List<RpChiTietNganSach> lst = new List<RpChiTietNganSach>(GetBangKeChiTiet(TuNgay, DenNgay, "", DonViId));
            for (int i = lst.Count - 1; i > 0; i-- )
            {
                if (lst[i].Id == CapPhatId)
                {
                    lst.RemoveAt(i);

                }
            }
            return lst;
        }

        public IList<RpChiTietNganSach> GetNganSachTongHop(DateTime TuNgay, DateTime DenNgay, Guid DonViId)
        {
            List<RpChiTietNganSach> lst = new List<RpChiTietNganSach>(GetBangKeChiTiet(TuNgay, DenNgay, "", DonViId));

            lst.Sort(CompareBangKeByKhoanChi);
            List<RpChiTietNganSach> lstthem = new List<RpChiTietNganSach>();
            string malk = String.Empty;
            RpChiTietNganSach tmpCapTong = new RpChiTietNganSach();
            RpChiTietNganSach tmpConLai = new RpChiTietNganSach();

            IList<String> dsLoaiChungTu = new List<String>();

            dsLoaiChungTu.Add("CP");
            dsLoaiChungTu.Add("KH_DN");
            dsLoaiChungTu.Add("KH_SD");
            dsLoaiChungTu.Add("KH_BX");

            foreach (RpChiTietNganSach tmp in lst)
            {
                if (malk != tmp.MaLoaiKhoan)
                {
                    tmpCapTong = new RpChiTietNganSach();
                    tmpCapTong.MaCt = "KH";
                    tmpCapTong.Loai = tmp.Loai;
                    tmpCapTong.Khoan = tmp.Khoan;
                    tmpConLai = new RpChiTietNganSach();
                    tmpConLai.MaCt = "CN";
                    tmpConLai.Loai = tmp.Loai;
                    tmpConLai.Khoan = tmp.Khoan;

                    lstthem.Add(tmpCapTong);
                    lstthem.Add(tmpConLai);

                    foreach (String tmplct in dsLoaiChungTu)
                    {
                        RpChiTietNganSach draff = new RpChiTietNganSach();
                        draff.MaCt = tmplct;
                        draff.Loai = tmp.Loai;
                        draff.Khoan = tmp.Khoan;
                        lstthem.Add(draff);
                    }

                    malk = tmp.MaLoaiKhoan;
                }

                if (tmp.MaCt.StartsWith("KH"))
                {
                    tmpCapTong.NDV_HC += tmp.NDV_HC;
                    tmpCapTong.NDV_XB += tmp.NDV_XB;
                    tmpCapTong.NDV_T += tmp.NDV_T;
                    tmpCapTong.NDV_K += tmp.NDV_K;

                    tmpConLai.NDV_HC += tmp.NDV_HC;
                    tmpConLai.NDV_XB += tmp.NDV_XB;
                    tmpConLai.NDV_T += tmp.NDV_T;
                    tmpConLai.NDV_K += tmp.NDV_K;
                }
                else
                {
                    tmpConLai.NDV_HC -= tmp.NDV_HC;
                    tmpConLai.NDV_XB -= tmp.NDV_XB;
                    tmpConLai.NDV_T -= tmp.NDV_T;
                    tmpConLai.NDV_K -= tmp.NDV_K;
                }

                tmpCapTong.SoTien = tmpCapTong.NDV_HC + tmpCapTong.NDV_XB + tmpCapTong.NDV_T + tmpCapTong.NDV_K;
                tmpConLai.SoTien = tmpConLai.NDV_HC + tmpConLai.NDV_XB + tmpConLai.NDV_T + tmpConLai.NDV_K;
            }
            
            lst.AddRange(lstthem);
            return lst;
        }

        #region Private Function
        private VnsDmDonVi GetDonVi(Guid Id, IList<VnsDmDonVi> lst)
        {
            foreach (VnsDmDonVi tmp in lst)
            {
                if (tmp.Id == Id) return tmp;
            }

            return null;
        }

        private VnsDmKhoanChi GetDmKhoanChi(Guid Id, IList<VnsDmKhoanChi> lst)
        {
            foreach (VnsDmKhoanChi tmp in lst)
            {
                if (tmp.Id == Id) return tmp;
            }

            return null;
        }

        private VnsMaLoaiKhoan GetMaLoaiKhoan(Guid Id, IList<VnsMaLoaiKhoan> lst)
        {
            foreach (VnsMaLoaiKhoan tmp in lst)
            {
                if (tmp.Id == Id) return tmp;
            }

            return null;
        }
        #endregion

        #region So chung tu
        [Transaction]
        public List<string> GetSoCT_prefix(VnsLoaiChungTu objLct, int SoChungtuMax, int THANG, int NAM)
        {
            List<string> lst_str = new List<string>();
            string Prefix = "";
            string So_CT = "";
            decimal m_SoCT_old = SoChungtuMax;
            VnsLoaiChungTu obj = objLct;

            if (!string.IsNullOrEmpty(obj.MauSoCt))
            {
                string m_prefix_old = obj.MauSoCt;
                Prefix = GetPrefix(m_prefix_old, NAM, THANG);
            }

            So_CT = GetSoCT(m_SoCT_old, 6);
            lst_str.Add(Prefix);
            lst_str.Add(So_CT);
            return lst_str;
        }

        private string GetPrefix(string p_prefix, decimal p_Nam, decimal p_Thang)
        {
            string m_Prefix = "";

            string p_thang_temp = "";
            if (p_Thang < 10)
            {
                p_thang_temp = "0" + p_Thang.ToString();
            }
            else
            {
                p_thang_temp = p_Thang.ToString();
            }

            switch (p_prefix)
            {
                case "[YYMM]":
                    m_Prefix = p_Nam.ToString().Substring(2, 2) + p_thang_temp;
                    break;
                case "[YYYYMM]":
                    m_Prefix = p_Nam.ToString() + p_thang_temp;
                    break;
                case "[YYYYMM-]":
                    m_Prefix = p_Nam.ToString() + p_thang_temp + "-";
                    break;
                case "[YYYY/MM]":
                    m_Prefix = p_Nam.ToString() + "/" + p_thang_temp;
                    break;
                case "[YYYY/MM-]":
                    m_Prefix = p_Nam.ToString() + "/" + p_thang_temp + "-";
                    break;
                case "[MM/YYYY-]":
                    m_Prefix = p_thang_temp + "/" + p_Nam.ToString() + "-";
                    break;
                default:
                    m_Prefix = p_prefix;
                    break;
            }

            return m_Prefix;
        }

        private string GetSoCT(decimal p_old, decimal So_kt)
        {
            string m_SoCT = "";

            if (p_old.ToString().Length >= So_kt)
            {
                m_SoCT = p_old.ToString();
            }
            else
            {
                decimal perleng = So_kt - p_old.ToString().Length;
                m_SoCT = str(So_kt).Substring(0, Convert.ToInt32(perleng)) + p_old.ToString();
            }

            return m_SoCT;
        }

        private string str(decimal kt)
        {
            string r_str = "";
            for (int i = 1; i <= kt; i++)
            {
                r_str = r_str + "0";
            }
            return r_str;
        }

        #endregion
    }
}
