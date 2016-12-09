using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.CapPhatKinhPhi.Dao
{
	public interface IVnsHtSoCtMaxDao:IDao<VnsHtSoCtMax,System.Guid>
	{
        VnsHtSoCtMax GetByThangNamEtc(Guid LoaichungtuId, int Thang, int Nam);
        VnsHtSoCtMax ResetGetByThangNamEtc(Guid LoaichungtuId, int Thang, int Nam);
        VnsHtSoCtMax SetSoChungTuMaxByThangNamEtc(Guid LoaichungtuId, int SoChungTuMax, int Thang, int Nam);
	}
}