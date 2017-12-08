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
            return lhs <= instance && instance >= rhs;
        }
    }

    internal static class Helper
    {
    }
}
