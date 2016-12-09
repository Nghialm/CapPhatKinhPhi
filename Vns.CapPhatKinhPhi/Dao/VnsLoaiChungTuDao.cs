
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
namespace Vns.CapPhatKinhPhi.Dao.NHibernate
{
	[Serializable]
	public sealed class VnsLoaiChungTuDao:GenericDao<VnsLoaiChungTu,System.Guid>,IVnsLoaiChungTuDao
	{
        public VnsLoaiChungTu GetByMa(String MaLoaiChungTu)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<VnsLoaiChungTu>();
            isearch.Add(Restrictions.Eq("MaLoaiChungTu", MaLoaiChungTu));

            IList<VnsLoaiChungTu> lst = isearch.List<VnsLoaiChungTu>();
            if (lst != null && lst.Count > 0)
                return lst[0];
            else
                return null;
        }
	}
}
