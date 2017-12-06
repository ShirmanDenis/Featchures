using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesApp.Common;

namespace AviaSalesApp
{
    interface ILoginView
    {
        event EventHandler Logged;
        event EventHandler RoleSelected;

        AppRoles Role { get; set; }
        string Password { get; set; }
        bool PasswordEnabled { get; set; }

        void SetRoles(IEnumerable<string> roles);
    }
}
