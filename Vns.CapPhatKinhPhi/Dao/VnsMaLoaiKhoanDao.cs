
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.CapPhatKinhPhi.Dao.NHibernate
{
	[Serializable]
	public sealed class VnsMaLoaiKhoanDao:GenericDao<VnsMaLoaiKhoan,System.Guid>,IVnsMaLoaiKhoanDao
	{
        public IList<VnsMaLoaiKhoan> GetChiTiet(Int32 ChiTiet)
        {
            String sql = "Select a from VnsMaLoaiKhoan a " +
                                       " where a.ChiTiet = :ChiTiet " +
                                       " Order by Ma";

            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("ChiTiet", ChiTiet);
            IList<VnsMaLoaiKhoan> ls = q.List<VnsMaLoaiKhoan>();

            return ls;
        }
	}
}
