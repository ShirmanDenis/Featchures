using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesApp.Common;

namespace AviaSalesApp.Controllers
{
    class LoginController
    {
        private readonly AviaSalesConnection aviaSales = new AviaSalesConnection();

        public ILoginView View { get; set; }
        
        public LoginController(ILoginView view)
        {
            View = view;
            View.Logged += View_Logged;
            View.RoleSelected += View_RoleSelected;
            SetAppRoles();
        }

        public void SetAppRoles()
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
            var conn = aviaSales.Database.Connection;
            var initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "sp_setapprole";
                    cmd.Parameters.Add(new SqlParameter("@rolename", View.Role));
                    cmd.Parameters.Add(new SqlParameter("@password", View.Password));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
