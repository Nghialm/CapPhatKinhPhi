using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.CapPhatKinhPhi.Domain
{
    public class RpChiTietNganSach
    {
        private Guid _Id = new Guid();

        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private Guid _IDDetail = new Guid();

        public Guid IDDetail
        {
            get { return _IDDetail; }
            set { _IDDetail = value; }
        }

        private string _MaCt = String.Empty;

        public string MaCt
        {
            get { return _MaCt; }
            set { _MaCt = value; }
        }
        private string _SoCt = String.Empty;

        public string SoCt
        {
            get { return _SoCt; }
            set { _SoCt = value; }
        }
        private DateTime _NgayCt = DateTime.Now;

        public DateTime NgayCt
        {
            get { return _NgayCt.Date; }
            set { _NgayCt = value; }
        }
        private DateTime _NgayHt = DateTime.Now;

        public DateTime NgayHt
        {
            get { return _NgayHt.Date; }
            set { _NgayHt = value; }
        }
        private string _Loai = String.Empty;

        public string Loai
        {
            get { return _Loai; }
            set { _Loai = value; }
        }
        private string _Khoan = String.Empty;

        public string Khoan
        {
            get { return _Khoan; }
            set { _Khoan = value; }
        }
        private Decimal _TongTien = 0;

        public Decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        private Decimal _SoTien = 0;

        public Decimal SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }

        private string _KhoanChi = String.Empty;

        public string KhoanChi
        {
            get { return _KhoanChi; }
            set { _KhoanChi = value; }
        }

        private string _TenDonVi = String.Empty;

        public string TenDonVi
        {
            get { return _TenDonVi; }
            set { _TenDonVi = value; }
        }

        private Guid _DonViId = new Guid();

        public Guid DonViId
        {
            get { return _DonViId; }
            set { _DonViId = value; }
        }

        private String _NoiDung = String.Empty;

        public String NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        private String _NhomDonVi = String.Empty;

        public String NhomDonVi
        {
            get { return _NhomDonVi; }
            set { _NhomDonVi = value; }
        }

        private String _TenKhoanChi = String.Empty;

        public String TenKhoanChi
        {
            get { return _TenKhoanChi; }
            set { _TenKhoanChi = value; }
        }

        private String _TenNhomDonVi = String.Empty;

        public String TenNhomDonVi
        {
            get { return _TenNhomDonVi; }
            set { _TenNhomDonVi = value; }
        }

        public String MaLoaiKhoan
        {
            get { return string.Format("{0} - {1}", _Loai, _Khoan); }
        }

        public String DisplayMaLoaiKhoan 
        {
            get 
            {
                if (SttGroup == 0)
                    return string.Format("Loại {0} - Khoản {1}", _Loai, _Khoan);
                else
                    return string.Format("{0} - Loại {1} - Khoản {2}", SttGroup, _Loai, _Khoan);
            }
        }

        public int SttGroup { get; set; }

        private string _NoiDungCapPhat;

        public string NoiDungCapPhat
        {
            get { return _NoiDungCapPhat; }
            set { _NoiDungCapPhat = value; }
        }

        private string _MaNguonNs;
        public string MaNguonNs
        {
            get { return _MaNguonNs; }
            set { _MaNguonNs = value; }
        }

        private string _NienDoNs;
        public string NienDoNs
        {
            get { return _NienDoNs; }
            set { _NienDoNs = value; }
        }

        #region Extend property Khoan Chi
        private Decimal _HoatDong = 0;
        public Decimal HoatDong
        {
            get { return _HoatDong; }
            set { _HoatDong = value; }
        }

        private Decimal _SuaChuaTx = 0;
        public Decimal SuaChuaTx
        {
            get { return _SuaChuaTx; }
            set { _SuaChuaTx = value; }
        }

        private Decimal _SuaChuaL = 0;
        public Decimal SuaChuaL
        {
            get { return _SuaChuaL; }
            set { _SuaChuaL = value; }
        }

        private Decimal _MuaSam = 0;
        public Decimal MuaSam
        {
            get { return _MuaSam; }
            set { _MuaSam = value; }
        }

        private Decimal _Khac = 0;
        public Decimal Khac
        {
            get { return _Khac; }
            set { _Khac = value; } 
        }

        private Decimal _STT = 0;
        public Decimal STT 
        {
            get { return _STT; }
            set { _STT = value; }
        }

        private Decimal GetSoTienTheoKhoanChi(String Dk)
        {
            //if (Dk != _KhoanChi && Dk!= "") return 0;

            if (_KhoanChi == Dk) return _SoTien;
            else
                if (Dk == "" && _KhoanChi != "01" && _KhoanChi != "02" && _KhoanChi != "03" && _KhoanChi != "04")
                    return _SoTien;
                else
                    return 0;
        }
        #endregion

        #region Extend property Nhom Don Vi
        private Decimal _NDV_HC = 0;
        public Decimal NDV_HC
        {
            get { return _NDV_HC; }
            set { _NDV_HC = value; }
        }

        private Decimal _NDV_XB = 0;
        public Decimal NDV_XB
        {
            get { return _NDV_XB; }
            set { _NDV_XB = value; }
        }

        private Decimal _NDV_T = 0;
        public Decimal NDV_T
        {
            get { return _NDV_T; }
            set { _NDV_T = value; }
        }

        private Decimal _NDV_K = 0;
        public Decimal NDV_K
        {
            get { return _NDV_K; }
            set { _NDV_K = value; }
        }

        private Decimal GetSoTienTheoNhomDonVi(String Dk)
        {
            if (_NhomDonVi == Dk) return _SoTien;
            else
                if (Dk == "" && _NhomDonVi != "01" && _NhomDonVi != "02" && _NhomDonVi != "03" && _NhomDonVi != "04")
                    return _SoTien;
                else
                    return 0;
        }

        private Decimal _LKP_SD = 0;

        public Decimal LKP_SD
        {
            get { return _LKP_SD; }
            set { _LKP_SD = value; }
        }
        private Decimal _LKP_DN = 0;

        public Decimal LKP_DN
        {
            get { return _LKP_DN; }
            set { _LKP_DN = value; }
        }
        private Decimal _LKP_BX = 0;

        public Decimal LKP_BX
        {
            get { return _LKP_BX; }
            set { _LKP_BX = value; }
        }
        private Decimal _LKP_CP = 0;

        public Decimal LKP_CP
        {
            get { return _LKP_CP; }
            set { _LKP_CP = value; }
        }

        private Decimal GetSoTienTheoNghiepVu(String Dk)
        {
            if (Dk != _MaCt) return 0;

            switch (Dk)
            {
                case "CP":
                    return _SoTien;
                case "KH_DN":
                    return _SoTien;
                case "KH_SD":
                    return _SoTien;
                case "KH_BX":
                    return _SoTien;
                default:
                    return _SoTien;
            }
        }

        public String BC_TenNghiepVu
        {
            get
            {
                switch (_MaCt)
                {
                    case "CP":
                        return "- Kinh phí đã cấp";
                    case "KH_DN":
                        return "   - Dự toán đầu năm";
                    case "KH_SD":
                        return "   - Kinh phí chuyển tiếp";
                    case "KH_BX":
                        return "   - Kinh phí bổ sung trong năm";
                    case "KH":
                        return "- Tổng số kinh phí được cấp";
                    case "CN":
                        return "- Kinh phí còn lại";
                    default:
                        return "";
                }
            }
        }

        public String BC_TenNghiepVu_Tong
        {
            get
            {
                switch (_MaCt)
                {
                    case "CP":
                        return "2- Kinh phí đã cấp";
                    case "KH_DN":
                        return "   - Dự toán đầu năm";
                    case "KH_SD":
                        return "   - Kinh phí chuyển tiếp";
                    case "KH_BX":
                        return "   - Kinh phí bổ sung trong năm";
                    case "KH":
                        return "1- Tổng số kinh phí được cấp";
                    case "CN":
                        return "3- Kinh phí còn lại";
                    default:
                        return "";
                }
            }
        }



        public String BC_MaCt
        {
            get
            {
                switch (_MaCt)
                {
                    case "CP":
                        return "2.0." + _MaCt;
                    case "KH_DN":
                        return "1.2." + _MaCt;
                    case "KH_SD":
                        return "1.1." + _MaCt;
                    case "KH_BX":
                        return "1.3." + _MaCt;
                    case "KH":
                        return "1.0." + _MaCt;
                    case "CN":
                        return "3.0." + _MaCt;
                    default:
                        return "";
                }
            }
        }
                
        #endregion

        #region Thong tin in phieu

        private String _TaiKhoanDonVi;

        public String TaiKhoanDonVi
        {
            get { return _TaiKhoanDonVi; }
            set { _TaiKhoanDonVi = value; }
        }

        private String _NganHangDonVi;

        public String NganHangDonVi
        {
            get { return _NganHangDonVi; }
            set { _NganHangDonVi = value; }
        }

        #endregion

        #region Ham tao
        public RpChiTietNganSach() { }
        public RpChiTietNganSach(VnsChungTu h, VnsGiaoDich d)
        {
            _Id = h.Id;
            _IDDetail = d.Id;
            _MaCt = h.MaCt;
            _NgayCt = h.NgayCt;
            _NgayHt = h.NgayHt;
            _SoCt = h.SoChungTu;
            _TenDonVi = h.ObjDmDonVi.TenDonvi;
            _NganHangDonVi = h.ObjDmDonVi.objDmNganHang.TenNganHang;
            _TaiKhoanDonVi = h.ObjDmDonVi.SoTaiKhoan;
            _DonViId = h.DonViId;
            _NoiDung = d.DienGiai;
            _KhoanChi = d.ObjDmKhoanChi.Ma;
            _Loai = d.ObjVnsMaLoaiKhoan.MaCha;
            _Khoan = d.ObjVnsMaLoaiKhoan.Ma;
            _NhomDonVi = h.ObjDmDonVi.objDmNhomDonVi.Ma;
            _TenKhoanChi = d.ObjDmKhoanChi.TenKhoanChi;
            _TenNhomDonVi = h.ObjDmDonVi.objDmNhomDonVi.TenNhom;
            _SoTien = d.SoTien;
            _NoiDungCapPhat = d.NoiDungCapPhat;
            _MaNguonNs = d.MaNguonNs;
            _NienDoNs = d.NienDoNs;

            //Gan so tien khoan chi
            _HoatDong = GetSoTienTheoKhoanChi("01");
            _SuaChuaTx = GetSoTienTheoKhoanChi("02");
            _SuaChuaL = GetSoTienTheoKhoanChi("03");
            _MuaSam = GetSoTienTheoKhoanChi("04");
            _Khac = GetSoTienTheoKhoanChi("");

            //Gan so tien nhom don vi
            _NDV_HC = GetSoTienTheoNhomDonVi("01");
            _NDV_XB = GetSoTienTheoNhomDonVi("02");
            _NDV_T = GetSoTienTheoNhomDonVi("03");
            _NDV_K = GetSoTienTheoNhomDonVi("04");

            //Gan so tien theo nghiep vu
            _LKP_SD = GetSoTienTheoNghiepVu("KH_SD");
            _LKP_DN = GetSoTienTheoNghiepVu("KH_DN");
            _LKP_BX = GetSoTienTheoNghiepVu("KH_BX");
            _LKP_CP = GetSoTienTheoNghiepVu("CP");
        }
        public RpChiTietNganSach(VnsKhNganSach h, VnsCtNganSach d)
        {
            _Id = h.Id;
            _IDDetail = d.Id;
            _MaCt = h.MaCt;
            _NgayCt = h.NgayCt;
            _NgayHt = h.NgayKeHoach;
            _SoCt = h.SoChungTu;
            _TenDonVi = h.ObjDmDonVi.TenDonvi;
            _NganHangDonVi = h.ObjDmDonVi.objDmNganHang.TenNganHang;
            _TaiKhoanDonVi = h.ObjDmDonVi.SoTaiKhoan;
            _DonViId = h.DonViId;
            _NoiDung = h.NoiDung;
            _NoiDungCapPhat = d.NoiDungCapPhat;
            _KhoanChi = d.ObjDmKhoanChi.Ma;
            _Loai = d.ObjVnsMaLoaiKhoan.MaCha;
            _Khoan = d.ObjVnsMaLoaiKhoan.Ma;
            _NhomDonVi = h.ObjDmDonVi.objDmNhomDonVi.Ma;
            _TenKhoanChi = d.ObjDmKhoanChi.TenKhoanChi;
            _TenNhomDonVi = h.ObjDmDonVi.objDmNhomDonVi.TenNhom;
            _SoTien = d.SoTien;

            //Gan so tien khoan chi
            _HoatDong = GetSoTienTheoKhoanChi("01");
            _SuaChuaTx = GetSoTienTheoKhoanChi("02");
            _SuaChuaL = GetSoTienTheoKhoanChi("03");
            _MuaSam = GetSoTienTheoKhoanChi("04");
            _Khac = GetSoTienTheoKhoanChi("");

            //Gan so tien nhom don vi
            _NDV_HC = GetSoTienTheoNhomDonVi("01");
            _NDV_XB = GetSoTienTheoNhomDonVi("02");
            _NDV_T = GetSoTienTheoNhomDonVi("03");
            _NDV_K = GetSoTienTheoNhomDonVi("04");

            //Gan so tien theo nghiep vu
            _LKP_SD = GetSoTienTheoNghiepVu("KH_SD");
            _LKP_DN = GetSoTienTheoNghiepVu("KH_DN");
            _LKP_BX = GetSoTienTheoNghiepVu("KH_BX");
            _LKP_CP = GetSoTienTheoNghiepVu("KH_CP");
        }
        #endregion

        #region Ham so sanh
        public static int ComparePhieuByKhoanChi(RpChiTietNganSach x, RpChiTietNganSach y)
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
                    //if (string.IsNullOrEmpty(y.KhoanChi)) return 0;
                    return retvalDoanDienID = -1 * x.KhoanChi.CompareTo(y.KhoanChi);
                }
            }
        }

        public static int ComparePhieuByNgay_SoCt(RpChiTietNganSach x, RpChiTietNganSach y)
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
                    //if (string.IsNullOrEmpty(y.KhoanChi)) return 0;
                    retvalDoanDienID = x.NgayCt.Date.CompareTo(y.NgayCt.Date);
                    if (retvalDoanDienID == 0)
                    {
                        return x.SoCt.CompareTo(y.SoCt);
                    }
                    else
                        return retvalDoanDienID;
                }
            }
        }
        #endregion
    }
}
