using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.CapPhatKinhPhi.Domain
{
	public partial class VnsChungTu : DomainObject<System.Guid>
    {
        private IList<VnsGiaoDich> _LstGiaoDich = new List<VnsGiaoDich>();
        public virtual IList<VnsGiaoDich> LstGiaoDich
        {
            get { return _LstGiaoDich; }
            set { _LstGiaoDich = value; }
        }

        private VnsDmDonVi _ObjDmDonVi = new VnsDmDonVi();
        public VnsDmDonVi ObjDmDonVi
        {
            get { return _ObjDmDonVi; }
            set { _ObjDmDonVi = value; }
        }
	}
}