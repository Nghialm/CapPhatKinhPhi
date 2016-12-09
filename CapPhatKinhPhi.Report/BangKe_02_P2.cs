using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Vns.CapPhatKinhPhi.Domain;
using System.Collections.Generic;

namespace CapPhatKinhPhi.Report 
{
    public partial class BangKe_02_P2 : DevExpress.XtraReports.UI.XtraReport
    {
        public BangKe_02_P2()
        {
            InitializeComponent();
        }

        public IList<RpChiTietNganSach> GetData(Guid DonViId,IList<RpChiTietNganSach> LstTemp)
        { 
            IList<RpChiTietNganSach> lstReturn = new List<RpChiTietNganSach>();
            foreach(RpChiTietNganSach obj in LstTemp)
            {
                if(obj.DonViId == DonViId)
                    lstReturn.Add(obj);
            }
            return lstReturn;
        }


    }
}
