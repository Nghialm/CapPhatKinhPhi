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
	public class VnsCtNganSachService:GenericService<VnsCtNganSach,System.Guid>, IVnsCtNganSachService
	{
	    public IVnsCtNganSachDao VnsCtNganSachDao
        {
            get { return (IVnsCtNganSachDao)Dao; }
            set { Dao = value; }
        }
	}
}