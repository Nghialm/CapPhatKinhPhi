using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using Vns.CapPhatKinhPhi.Domain;
using System.Collections.Generic;

namespace Vns.CapPhatKinhPhi.Dao
{
	public interface IVnsChungTuDao:IDao<VnsChungTu,System.Guid>
	{
        IList<RpNganSachTongHop> GetCapPhatTrongNam(String MaCt, DateTime TuNgay, DateTime DenNgay);
        IList<RpChiTietNganSach> GetBangKeChiTiet(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId);
        IList<VnsChungTu> LoadBy(Guid LoaiCt, int Nam);
	}
}