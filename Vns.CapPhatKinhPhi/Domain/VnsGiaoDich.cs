using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
	public partial class VnsGiaoDich : DomainObject<System.Guid>
    {
        private VnsDmKhoanChi _ObjDmKhoanChi = new VnsDmKhoanChi();

        public VnsDmKhoanChi ObjDmKhoanChi
        {
            get { return _ObjDmKhoanChi; }
            set { _ObjDmKhoanChi = value; }
        }
        private VnsMaLoaiKhoan _ObjVnsMaLoaiKhoan = new VnsMaLoaiKhoan();

        public VnsMaLoaiKhoan ObjVnsMaLoaiKhoan
        {
            get { return _ObjVnsMaLoaiKhoan; }
            set { _ObjVnsMaLoaiKhoan = value; }
        }

        private DateTime _GioThemMoi = DateTime.Now;

        public DateTime GioThemMoi
        {
            get { return _GioThemMoi; }
            set { _GioThemMoi = value; }
        }
	}
}