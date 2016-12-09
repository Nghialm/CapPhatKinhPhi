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
	public interface IVnsMaLoaiKhoanService:IErpService<VnsMaLoaiKhoan, System.Guid>
	{
        IList<VnsMaLoaiKhoan> GetChiTiet(Int32 ChiTiet);
	}
}
