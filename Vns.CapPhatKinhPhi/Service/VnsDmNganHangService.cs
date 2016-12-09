using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Dao;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;

namespace Vns.CapPhatKinhPhi.Service
{
	public class VnsDmNganHangService:GenericService<VnsDmNganHang,System.Guid>, IVnsDmNganHangService
	{
	    public IVnsDmNganHangDao VnsDmNganHangDao
        {
            get { return (IVnsDmNganHangDao)Dao; }
            set { Dao = value; }
        }
	}
}