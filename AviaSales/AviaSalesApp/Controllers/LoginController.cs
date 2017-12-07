using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesApp.Common;
using NLog;
using AppContext = AviaSalesApp.Common.AppContext;

namespace AviaSalesApp.Controllers
{
    public delegate void LoggingValidatedEventHandler(bool success, string msg);

    class LoginController
    {
        private AppContext _context;
        private AviaSalesConnectionProvider _provider;
        public event LoggingValidatedEventHandler LoggingValidated;

        public ILoginView View { get; set; }
        public AviaSalesConnectionProvider ConnectionProvider { get { return _provider; } }

        public LoginController(ILoginView view)
        {
            View = view;
            View.Logged += View_Logged;
            View.RoleSelected += View_RoleSelected;
        }
        private void View_Logged(object sender, EventArgs e)
        {
            var succes = false;
            var msg = "";
            try
            {
                _context = new AppContext(View.Role);
                _provider = new AviaSalesConnectionProvider(_context);
                succes = ConnectionProvider.SetAppRole(View.Role, View.Password);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            LoggingValidated?.Invoke(succes, msg);

            if (_context.AppRole == AppRoles.Client)
                View.Factory.CreateScheduleView(_provider).Show();
        }

        private void View_RoleSelected(object sender, EventArgs e)
        {
            if (View.Role == AppRoles.Client)
            {
                View.Password = "0000";
                View.PasswordEnabled = false;
            }
            else
            {
                View.PasswordEnabled = true;
                View.Password = "";
            }
        }
    }
}
