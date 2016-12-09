using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Dao;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;

namespace Vns.CapPhatKinhPhi.Service
{
	public class VnsMaLoaiKhoanService:GenericService<VnsMaLoaiKhoan,System.Guid>, IVnsMaLoaiKhoanService
	{
	    public IVnsMaLoaiKhoanDao VnsMaLoaiKhoanDao
        {
            get { return (IVnsMaLoaiKhoanDao)Dao; }
            set { Dao = value; }
        }

        public IList<VnsMaLoaiKhoan> GetChiTiet(Int32 ChiTiet)
        {
            return VnsMaLoaiKhoanDao.GetChiTiet(ChiTiet);
        }
	}
}