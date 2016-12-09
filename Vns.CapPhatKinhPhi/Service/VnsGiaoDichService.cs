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
	public class VnsGiaoDichService:GenericService<VnsGiaoDich,System.Guid>, IVnsGiaoDichService
	{
	    public IVnsGiaoDichDao VnsGiaoDichDao
        {
            get { return (IVnsGiaoDichDao)Dao; }
            set { Dao = value; }
        }
	}
}