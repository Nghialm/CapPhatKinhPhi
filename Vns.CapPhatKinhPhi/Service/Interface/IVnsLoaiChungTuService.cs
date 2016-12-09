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
	public interface IVnsLoaiChungTuService:IErpService<VnsLoaiChungTu, System.Guid>
	{
        VnsLoaiChungTu GetByMa(String MaLoaiChungTu);
        List<string> GetSoCT_prefix(Guid LOAICHUNGTU_ID, int THANG, int NAM);
        void ResetSoChungTu(Guid LOAICHUNGTU_ID, int THANG, int NAM);
	}
}
