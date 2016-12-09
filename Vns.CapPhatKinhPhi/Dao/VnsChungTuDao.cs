
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Criterion;
using Vns.Erp.Core;
namespace Vns.CapPhatKinhPhi.Dao.NHibernate
{
	[Serializable]
	public sealed class VnsChungTuDao:GenericDao<VnsChungTu,System.Guid>,IVnsChungTuDao
	{
        public IList<RpNganSachTongHop> GetCapPhatTrongNam(String MaCt, DateTime TuNgay, DateTime DenNgay)
        {
            String HQuery = "select sum(d.SoTien) as SoTien, h.MaCt as MaCt, d.LoaiKhoanId as LoaiKhoanId, d.KhoanChiId as KhoanChiId, h.DonViId as DonViId " +
                "from VnsChungTu h inner join h.LstGiaoDich d " +
                "where h.NgayHt >= :TuNgay And h.NgayHt <= :DenNgay " +
                (string.IsNullOrEmpty(MaCt) ? " " : " and h.MaCt = :MaCt ") +
                "Group by h.MaCt, d.LoaiKhoanId, d.KhoanChiId, h.DonViId";

            IQuery query = NHibernateSession.CreateQuery(HQuery);
            if (!String.IsNullOrEmpty(MaCt)) query.SetParameter("MaCt", MaCt);
            query.SetParameter("TuNgay", TuNgay);
            query.SetParameter("DenNgay", DenNgay);
            query.SetResultTransformer(Transformers.AliasToBean<RpNganSachTongHop>());
            IList<RpNganSachTongHop> lst = query.List<RpNganSachTongHop>();

            return lst;
        }

        public IList<RpChiTietNganSach> GetBangKeChiTiet(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<VnsChungTu>().CreateAlias("LstGiaoDich", "d");

            if (!string.IsNullOrEmpty(MaCt))
            {
                isearch.Add(Restrictions.Eq("MaCt", MaCt));
            }

            isearch.Add(Restrictions.Le("NgayCt", VnsConvert.CEndOfDate(DenNgay)));
            isearch.Add(Restrictions.Ge("NgayCt", VnsConvert.CStartOfDate(TuNgay)));

            if (!VnsCheck.IsNullGuid(DonViId))
            {
                isearch.Add(Restrictions.Eq("DonViId", DonViId));
            }

            isearch.AddOrder(new Order("NgayCt", true));

            IList<VnsChungTu> lst = new List<VnsChungTu>();
            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            lst = isearch.List<VnsChungTu>();
            IList<RpChiTietNganSach> lstRp = new List<RpChiTietNganSach>();
            foreach (VnsChungTu tmph in lst)
            {
                foreach (VnsGiaoDich tmpd in tmph.LstGiaoDich)
                {
                    RpChiTietNganSach rp = new RpChiTietNganSach(tmph, tmpd);
                    lstRp.Add(rp);
                }
            }

            return lstRp;
        }

        public IList<VnsChungTu> LoadBy(Guid LoaiCt, int Nam)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<VnsChungTu>();

            isearch.Add(Restrictions.Eq("LoaiCt", LoaiCt));


            isearch.Add(Restrictions.Le("NgayCt", VnsConvert.CEndOfDate(new DateTime(Nam, 12, 31))));
            isearch.Add(Restrictions.Ge("NgayCt", VnsConvert.CStartOfDate(new DateTime(Nam, 1, 1))));

            IList<VnsChungTu> lst = new List<VnsChungTu>();
            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            lst = isearch.List<VnsChungTu>();
            return lst;
        }
	}
}
