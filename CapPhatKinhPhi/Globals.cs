using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core;
using System.Globalization;
using System.Threading;

namespace CapPhatKinhPhi
{
    class Globals
    {
    }

    public class CultureHelper
    {
        public static void SetCulture2()
        {
            CultureManagement objData = new CultureManagement();
            CultureSettingInfo info = objData.GetInfo_2();
            CultureInfo culInfo = new CultureInfo(info.Code);
            culInfo.DateTimeFormat.ShortDatePattern = info.DateFormat;
            culInfo.DateTimeFormat.ShortTimePattern = info.TimeFormat;
            culInfo.DateTimeFormat.DateSeparator = info.DateSeparator;
            culInfo.DateTimeFormat.TimeSeparator = info.TimeSeparator;
            culInfo.NumberFormat.NumberDecimalSeparator = info.DecimalSeparator;
            if (info.GroupSeparator.Equals("space"))
            {
                culInfo.NumberFormat.NumberGroupSeparator = " ";
            }
            else
            {
                culInfo.NumberFormat.NumberGroupSeparator = info.GroupSeparator;
            }
            Thread.CurrentThread.CurrentCulture = culInfo;
        }
    }
}
