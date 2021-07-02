using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ArshiaDev.Core.Classes
{
    public static class ToShamsi
    {
        public static string Shamsi(this DateTime now)
        {
            PersianCalendar pc = new PersianCalendar();

            return pc.GetYear(now).ToString("0000") + "/" + pc.GetMonth(now).ToString("00")+"/" + pc.GetDayOfMonth(now).ToString("00");
        }
    }
}
