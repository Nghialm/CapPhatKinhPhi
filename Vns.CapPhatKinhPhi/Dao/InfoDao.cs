
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using NHibernate;
using NHibernate.Transform;
using System.Collections.Generic;
namespace Vns.CapPhatKinhPhi.Dao.NHibernate
{
	[Serializable]
	public sealed class InfoDao:GenericDao<Info,System.Guid>,IInfoDao
	{
        public IList<Info> GetLikeMa(String Ma)
        {
            String HQuery = "from Info i where i.Ma like :Ma";

            IQuery query = NHibernateSession.CreateQuery(HQuery);
            query.SetParameter("Ma", Ma + "%");
            IList<Info> lst = query.List<Info>();
            return lst;
        }
	}
}
