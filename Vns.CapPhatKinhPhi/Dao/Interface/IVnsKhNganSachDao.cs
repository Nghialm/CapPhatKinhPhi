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
	public interface IVnsKhNganSachDao:IDao<VnsKhNganSach,System.Guid>
	{
        IList<RpNganSachTongHop> GetKeHoachTrongNam(String MaCt, DateTime TuNgay, DateTime DenNgay);
        void DeleteBy(String MaCt, DateTime TuNgay, DateTime DenNgay, Boolean TuDong);
        IList<RpChiTietNganSach> GetBangKeChiTiet(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId);
        IList<VnsKhNganSach> LoadBy(Guid LoaiCt, int Nam);
	}
}