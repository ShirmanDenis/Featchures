using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesApp.Common
{
    public class AppContext
    {
        public AppRoles AppRole { get; private set; }

        public AppContext(AppRoles appRole)
        {
            AppRole = appRole;
        }
    }
}
