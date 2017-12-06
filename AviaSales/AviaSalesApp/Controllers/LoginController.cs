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

namespace AviaSalesApp.Controllers
{
    public delegate void LoggingValidatedEventHandler(bool success, string msg);

    class LoginController
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private readonly AviaSalesConnection aviaSales = new AviaSalesConnection();

        public event LoggingValidatedEventHandler LoggingValidated;

        public ILoginView View { get; set; }
        
        public LoginController(ILoginView view)
        {
            View = view;
            View.Logged += View_Logged;
            View.RoleSelected += View_RoleSelected;
            SetAppRolesOnView();
        }

        public void SetAppRolesOnView()
        {
            View.SetRoles(Enum.GetNames(typeof(AppRoles)));   
        }

        private void View_Logged(object sender, EventArgs e)
        {
            SetAppRole();
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

        private void SetAppRole()
        {
            var success = true;
            var msg = "";
            var conn = aviaSales.Database.Connection;
            var initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "sp_setapprole";
                    cmd.Parameters.Add(new SqlParameter("@rolename", View.Role.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@password", View.Password));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                logger.ConditionalDebug(ex.Message);

                success = false;
                msg = ex.Message;
            }
            finally
            {
                LoggingValidated?.Invoke(success, msg);
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
