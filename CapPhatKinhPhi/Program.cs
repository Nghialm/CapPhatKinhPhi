﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vns.Erp.Core;
using System.Web.Security;

namespace CapPhatKinhPhi
{
    static class Program
    {
        private static bool _IsAuthenticated = false;

        public static bool IsAuthenticated
        {
            get { return Program._IsAuthenticated; }
            set { Program._IsAuthenticated = value; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Membership.CreateUser("admin", "admin");
            //IVnsLoaiChungTuService VnsLoaiChungTuService =(IVnsLoaiChungTuService)ObjectFactory.GetObject("VnsLoaiChungTuService");
            //VnsLoaiChungTu loaiCT = VnsLoaiChungTuService.GetById(new Guid("0509F230-CCCB-433F-9B06-DD5DF6F37581"));
            //VnsHtSoCtMax max = new VnsHtSoCtMax();
            //max.LoaichungtuId = loaiCT.LoaiChungTuId;
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
            //if (IsAuthenticated)
            //{
            //    FrmMain frmMain = (FrmMain)ObjectFactory.GetObject("frmMain");
            //    Application.Run(frmMain);

            //    //XtraForm frmxtraForm = (XtraForm)ObjectFactory.GetObject("frmxtraForm");
            //    //Application.Run(frmxtraForm);

            //}

            CapPhatKinhPhi.CultureHelper.SetCulture2();

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if (IsAuthenticated)
            {
                FrmMain frmMain = (FrmMain)ObjectFactory.GetObject("frmMain");
                Application.Run(frmMain);

                //XtraForm frmxtraForm = (XtraForm)ObjectFactory.GetObject("frmxtraForm");
                //Application.Run(frmxtraForm);

            }

        }
    }
}
