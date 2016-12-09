using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vns.CapPhatKinhPhi.Domain;

namespace CapPhatKinhPhi
{
    public partial class FrmCpCheckKinhPhi : DevExpress.XtraEditors.XtraForm
    {

        public IList<RpChiTietNganSach> lst = new List<RpChiTietNganSach>();
        public Decimal SoTienLapPhieu = 0;

        public FrmCpCheckKinhPhi()
        {
            InitializeComponent();
        }

        private void FrmCpCheckKinhPhi_Load(object sender, EventArgs e)
        {
            decimal sodu =0, daunam =0, bosung=0, dacap=0, conlai=0;
            foreach (RpChiTietNganSach tmp in lst)
            {
                sodu += tmp.LKP_SD;
                daunam += tmp.LKP_DN;
                bosung += tmp.LKP_BX;
                dacap += tmp.LKP_CP;
            }
            conlai = sodu + daunam + bosung - dacap;

            txtSoDu.EditValue = sodu;
            txtDauNam.EditValue = daunam;
            txtBoSung.EditValue = bosung;
            txtDaCap.EditValue = dacap;
            txtConLai.EditValue = conlai;
        }


    }
}