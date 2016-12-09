using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.CapPhatKinhPhi.Domain
{
	public partial class VnsKhNganSach : DomainObject<System.Guid>
    {
        private IList<VnsCtNganSach> _LstNganSach = new List<VnsCtNganSach>();
        public virtual IList<VnsCtNganSach> LstNganSach
        {
            get { return _LstNganSach; }
            set { _LstNganSach = value; }
        }

        private VnsDmDonVi _ObjDmDonVi = new VnsDmDonVi();
        public virtual VnsDmDonVi ObjDmDonVi
        {
            get { return _ObjDmDonVi; }
            set { _ObjDmDonVi = value; }
        }
	}
}