using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.CapPhatKinhPhi.Domain;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System;

namespace Vns.CapPhatKinhPhi.Service.Interface
{
	public interface IInfoService:IErpService<Info, System.Guid>
	{
        IList<Info> GetLikeMa(String Ma);
	}
}
