using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
	public partial class VnsMaLoaiKhoan : DomainObject<System.Guid>
    {
        public String Loai_Khoan
        {
            get
            {
                if (String.IsNullOrEmpty(_MaCha))
                    return Ma;
                else
                    return MaCha + " - " + Ma;
            }
        }
	}
}