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
	public class VnsKhNganSachService:GenericService<VnsKhNganSach,System.Guid>, IVnsKhNganSachService
	{
	    public IVnsKhNganSachDao VnsKhNganSachDao
        {
            get { return (IVnsKhNganSachDao)Dao; }
            set { Dao = value; }
        }

        public IList<VnsKhNganSach> LoadByChungTu(Guid LoaiCt)
        {
            IList props = new ArrayList();
            IList values = new ArrayList();
            props.Add("LoaiCt");
            values.Add(LoaiCt);

            return VnsKhNganSachDao.List(-1, -1, props, values, null);
        }

        public IList<VnsKhNganSach> LoadBy(Guid LoaiCt, int Nam)
        {
            return VnsKhNganSachDao.LoadBy(LoaiCt, Nam);
        }
	}
}