using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.CapPhatKinhPhi.Domain
{
    public class RpNganSachTongHop
    {
        private String _MaCt;

        public String MaCt
        {
            get { return _MaCt; }
            set { _MaCt = value; }
        }
        private Guid _DonViId;

        public Guid DonViId
        {
            get { return _DonViId; }
            set { _DonViId = value; }
        }
        private Guid _KhoanChiId;

        public Guid KhoanChiId
        {
            get { return _KhoanChiId; }
            set { _KhoanChiId = value; }
        }
        private Guid _LoaiKhoanId;

        public Guid LoaiKhoanId
        {
            get { return _LoaiKhoanId; }
            set { _LoaiKhoanId = value; }
        }
        private Decimal _SoTien;

        public Decimal SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }
    }
}
