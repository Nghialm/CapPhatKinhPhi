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
	public interface IVnsMaLoaiKhoanDao:IDao<VnsMaLoaiKhoan,System.Guid>
	{
        IList<VnsMaLoaiKhoan> GetChiTiet(Int32 ChiTiet);
	}
}