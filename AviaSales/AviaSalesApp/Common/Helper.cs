using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesApp.Common
{
    internal static class DateTimeExtensions
    {
        public static bool Between(this DateTime instance, DateTime lhs, DateTime rhs)
        {
            return lhs.Day <= instance.Day &&
                   lhs.Month <= instance.Month &&
                   lhs.Year <= instance.Year &&
                   rhs.Day >= instance.Day &&
                   rhs.Month >= instance.Month &&
                   rhs.Year >= instance.Year;
        }
    }

    internal static class Helper
    {
    }
}
