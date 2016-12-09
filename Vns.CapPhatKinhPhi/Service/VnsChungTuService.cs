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
	public class VnsChungTuService:GenericService<VnsChungTu,System.Guid>, IVnsChungTuService
	{
	    public IVnsChungTuDao VnsChungTuDao
        {
            get { return (IVnsChungTuDao)Dao; }
            set { Dao = value; }
        }

        public IList<VnsChungTu> LoadByChungTu(Guid LoaiCt)
        {
            IList props = new ArrayList();
            IList values = new ArrayList();
            props.Add("LoaiCt");
            values.Add(LoaiCt);

            return VnsChungTuDao.List(-1, -1, props, values, null);
        }

        public IList<VnsChungTu> LoadBy(Guid LoaiCt, int Nam)
        {
            return VnsChungTuDao.LoadBy(LoaiCt, Nam);
        }
	}
}