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

    class LoginController : IDisposable
    {
        public event LoggingValidatedEventHandler LoggingValidated;

        private AppContext _context;
        private AviaSalesConnectionProvider _provider;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ILoginView View { get; set; }
        public AviaSalesConnectionProvider ConnectionProvider => _provider;

        public LoginController(ILoginView view)
        {
            View = view;
            View.Logged += View_Logged;
            View.RoleSelected += View_RoleSelected;
        }

        private void View_Logged(object sender, EventArgs e)
        {
            var success = true;
            var msg = "";
            try
            {
                _context = new AppContext(View.Role);
                _provider = new AviaSalesConnectionProvider(_context);
                
                ConnectionProvider.SetAppRole(View.Role, View.Password);
            }
            catch (Exception ex)
            {
                success = false;
                msg = ex.InnerException?.Message ?? ex.Message;
                _logger.ConditionalDebug(ex);
            }
            LoggingValidated?.Invoke(success, msg);

            if (!success) return;

            View.Hide();
            if (_context.AppRole == AppRoles.Client)
                View.Factory.CreateScheduleView(_provider, View).Show();
            if (_context.AppRole == AppRoles.Receptionist)
                View.Factory.CreateRegisterView(_provider, View).Show();
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

        public void Dispose()
        {
            View.Logged -= View_Logged;
            View.RoleSelected -= View_RoleSelected;

            _provider?.Dispose();
        }
    }
}
