using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.CapPhatKinhPhi.Service.Interface
{
	public interface IVnsChungTuService:IErpService<VnsChungTu, System.Guid>
	{
        IList<VnsChungTu> LoadByChungTu(Guid LoaiCt);
        IList<VnsChungTu> LoadBy(Guid LoaiCt, int Nam);
	}
}
