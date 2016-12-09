
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Criterion;
using Vns.Erp.Core;
namespace Vns.CapPhatKinhPhi.Dao.NHibernate
{
	[Serializable]
	public sealed class VnsKhNganSachDao:GenericDao<VnsKhNganSach,System.Guid>,IVnsKhNganSachDao
	{
        public IList<RpNganSachTongHop> GetKeHoachTrongNam(String MaCt, DateTime TuNgay, DateTime DenNgay)
        {
            try
            {
                String HQuery = "select sum(d.SoTien) as SoTien, h.MaCt as MaCt, d.LoaiKhoanId as LoaiKhoanId, d.KhoanChiId as KhoanChiId, h.DonViId as DonViId " +
                    "from VnsKhNganSach h inner join h.LstNganSach d " +
                    "where h.NgayKeHoach >= :TuNgay And h.NgayKeHoach <= :DenNgay " +
                    (string.IsNullOrEmpty(MaCt) ? "" : " and h.MaCt = :MaCt ") +
                    "Group by h.MaCt, d.LoaiKhoanId, d.KhoanChiId, h.DonViId";

                IQuery query = NHibernateSession.CreateQuery(HQuery);
                if (!String.IsNullOrEmpty(MaCt)) query.SetParameter("MaCt", MaCt);
                query.SetParameter("TuNgay", TuNgay);
                query.SetParameter("DenNgay", DenNgay);
                query.SetResultTransformer(Transformers.AliasToBean<RpNganSachTongHop>());
                IList<RpNganSachTongHop> lst = query.List<RpNganSachTongHop>();

                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteBy(String MaCt, DateTime TuNgay, DateTime DenNgay, Boolean TuDong)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<VnsKhNganSach>();
            isearch.Add(Restrictions.Eq("MaCt", MaCt));
            isearch.Add(Restrictions.Between("NgayKeHoach", TuNgay, DenNgay));
            isearch.Add(Restrictions.Eq("TuDong", TuDong));

            IList<VnsKhNganSach> lst = isearch.List<VnsKhNganSach>();
            foreach (VnsKhNganSach tmp in lst)
                DeleteById(tmp.Id);
        }

        public IList<RpChiTietNganSach> GetBangKeChiTiet(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<VnsKhNganSach>().CreateAlias("LstNganSach", "d");

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

            IList<VnsKhNganSach> lst = new List<VnsKhNganSach>();
            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            lst = isearch.List<VnsKhNganSach>();
            IList<RpChiTietNganSach> lstRp = new List<RpChiTietNganSach>();
            foreach (VnsKhNganSach tmph in lst)
            {
                foreach (VnsCtNganSach tmpd in tmph.LstNganSach)
                {
                    RpChiTietNganSach rp = new RpChiTietNganSach(tmph, tmpd);
                    lstRp.Add(rp);
                }
            }

            return lstRp;
        }

        public IList<VnsKhNganSach> LoadBy(Guid LoaiCt, int Nam)
        {
            ICriteria isearch = NHibernateSession.CreateCriteria<VnsKhNganSach>();

            isearch.Add(Restrictions.Eq("LoaiCt", LoaiCt));


            isearch.Add(Restrictions.Le("NgayCt", VnsConvert.CEndOfDate(new DateTime(Nam, 12, 31))));
            isearch.Add(Restrictions.Ge("NgayCt", VnsConvert.CStartOfDate(new DateTime(Nam, 1, 1))));

            IList<VnsKhNganSach> lst = new List<VnsKhNganSach>();
            isearch.SetResultTransformer(Transformers.DistinctRootEntity);
            lst = isearch.List<VnsKhNganSach>();
            return lst;
        }
	}
}
