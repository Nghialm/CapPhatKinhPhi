using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.CapPhatKinhPhi.Domain;
using Vns.CapPhatKinhPhi.Dao;
using Vns.CapPhatKinhPhi.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;

namespace Vns.CapPhatKinhPhi.Service
{
	public class InfoService:GenericService<Info,System.Guid>, IInfoService
	{
	    public IInfoDao InfoDao
        {
            get { return (IInfoDao)Dao; }
            set { Dao = value; }
        }

        public IList<Info> GetLikeMa(String Ma)
        {
            return InfoDao.GetLikeMa(Ma);
        }
	}
}