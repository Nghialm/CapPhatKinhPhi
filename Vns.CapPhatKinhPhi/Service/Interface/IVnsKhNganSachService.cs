using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Service;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.CapPhatKinhPhi.Service.Interface
{
	public interface IVnsKhNganSachService:IErpService<VnsKhNganSach, System.Guid>
	{
        IList<VnsKhNganSach> LoadByChungTu(Guid LoaiCt);
        IList<VnsKhNganSach> LoadBy(Guid LoaiCt, int Nam);
	}
}
