using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Service.Interface;
using Vns.CapPhatKinhPhi.Domain;

namespace Vns.CapPhatKinhPhi.Service.Interface
{
    public interface IReportCapPhatService : IErpService<Info, System.Guid>
    {
        IList<RpNganSachTongHop> GetKeHoachCapPhat(DateTime TuNgay, DateTime DenNgay, VnsLoaiChungTu objLoaiChungTu);
        IList<RpChiTietNganSach> GetBangKeChiTiet(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId);
        IList<RpChiTietNganSach> GetNganSachTongHop(DateTime TuNgay, DateTime DenNgay, Guid DonViId);
        IList<RpChiTietNganSach> GetNganSachTongHopTheoDonVi(DateTime TuNgay, DateTime DenNgay, Guid DonViId);
        IList<RpChiTietNganSach> GetNganSachTongHopTheoDonVi(DateTime TuNgay, DateTime DenNgay, Guid DonViId, Guid CapPhatId);
        IList<RpChiTietNganSach> GetBangKeKeHoach(DateTime TuNgay, DateTime DenNgay, String MaCt, Guid DonViId);
    }
}
