using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
	public partial class VnsDmDonVi : DomainObject<System.Guid>
    {
        private  VnsDmNganHang _objDmNganHang = new VnsDmNganHang();

        public virtual VnsDmNganHang objDmNganHang
        {
            get { return _objDmNganHang; }
            set { _objDmNganHang = value; }
        }

        private  VnsDmNhomDonVi _objDmNhomDonVi = new VnsDmNhomDonVi();
        public virtual VnsDmNhomDonVi objDmNhomDonVi
        {
            get { return _objDmNhomDonVi; }
            set { _objDmNhomDonVi = value; }
        }
	}
}