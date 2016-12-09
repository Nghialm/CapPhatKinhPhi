
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
namespace Vns.CapPhatKinhPhi.Dao.NHibernate
{
	[Serializable]
	public sealed class VnsHtSoCtMaxDao:GenericDao<VnsHtSoCtMax,System.Guid>,IVnsHtSoCtMaxDao
	{
        public VnsHtSoCtMax GetByThangNamEtc(Guid LoaichungtuId, int Thang, int Nam)
        {
            String sql = "Select a from VnsHtSoCtMax a " +
                            " where a.LoaichungtuId = :LoaichungtuId " +
                            " and Thang = :Thang " +
                            " and Nam = :Nam ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("LoaichungtuId", LoaichungtuId);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            IList<VnsHtSoCtMax> ls = q.List<VnsHtSoCtMax>();
            VnsHtSoCtMax maxct = new VnsHtSoCtMax();
            if (ls == null || ls.Count == 0)
            {
                maxct.LoaichungtuId = LoaichungtuId;
                maxct.Thang = Thang;
                maxct.Nam = Nam;
                maxct.SoChungtuMax = 1;
                Save(maxct);
            }
            else
            {
                maxct = ls[0];
                maxct.SoChungtuMax = ls[0].SoChungtuMax + 1;
                Update(maxct);
            }
            return maxct;
        }

        public VnsHtSoCtMax ResetGetByThangNamEtc(Guid LoaichungtuId, int Thang, int Nam)
        {
            String sql = "Select a from VnsHtSoCtMax a " +
                                       " where a.LoaichungtuId = :LoaichungtuId " +
                                       " and Thang = :Thang " +
                                       " and Nam = :Nam ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("LoaichungtuId", LoaichungtuId);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            IList<VnsHtSoCtMax> ls = q.List<VnsHtSoCtMax>();
            VnsHtSoCtMax maxct = new VnsHtSoCtMax();
            if (ls == null || ls.Count == 0)
            {
                maxct.LoaichungtuId = LoaichungtuId;
                maxct.Thang = Thang;
                maxct.Nam = Nam;
                maxct.SoChungtuMax = 0;
                Save(maxct);
            }
            else
            {
                maxct = ls[0];
                maxct.SoChungtuMax = 0;
                Update(maxct);
            }
            return maxct;
        }

        public VnsHtSoCtMax SetSoChungTuMaxByThangNamEtc(Guid LoaichungtuId, int SoChungTuMax, int Thang, int Nam)
        {
            String sql = "Select a from VnsHtSoCtMax a " +
                                       " where a.LoaichungtuId = :LoaichungtuId " +
                                       " and Thang = :Thang " +
                                       " and Nam = :Nam ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("LoaichungtuId", LoaichungtuId);
            q.SetParameter("Thang", Thang);
            q.SetParameter("Nam", Nam);
            IList<VnsHtSoCtMax> ls = q.List<VnsHtSoCtMax>();
            VnsHtSoCtMax maxct = new VnsHtSoCtMax();
            if (ls == null || ls.Count == 0)
            {
                maxct.LoaichungtuId = LoaichungtuId;
                maxct.Thang = Thang;
                maxct.Nam = Nam;
                maxct.SoChungtuMax = SoChungTuMax;
                Save(maxct);
            }
            else
            {
                maxct = ls[0];
                maxct.SoChungtuMax = SoChungTuMax;
                Update(maxct);
            }
            return maxct;
        }
	}
}
