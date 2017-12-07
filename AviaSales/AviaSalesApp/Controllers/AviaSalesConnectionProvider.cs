using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using AviaSalesApp.Common;
using NLog;
using AppContext = AviaSalesApp.Common.AppContext;

namespace AviaSalesApp.Controllers
{
    public class AviaSalesConnectionProvider
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly AviaSalesConnection _aviaSales = new AviaSalesConnection();

        public AviaSalesConnection AviaSalesConnection => _aviaSales;

        public AviaSalesConnectionProvider(AppContext ctx)
        {

        }

        public bool SetAppRole(AppRoles role, string pass)
        {
            var conn = AviaSalesConnection.Database.Connection;
            var initialState = conn.State;
            try
            {
                if (initialState != ConnectionState.Open)
                    conn.Open();
                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "sp_setapprole";
                    cmd.Parameters.Add(new SqlParameter("@rolename", role.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@password", pass));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                logger.ConditionalDebug(ex.Message);

                return false;
            }
            return true;
        }
    }
}