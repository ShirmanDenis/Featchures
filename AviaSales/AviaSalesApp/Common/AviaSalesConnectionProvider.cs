using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using AviaSalesApp.Common;
using NLog;
using AppContext = AviaSalesApp.Common.AppContext;

namespace AviaSalesApp.Common
{
    public class AviaSalesConnectionProvider : IDisposable
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        
        public AviaSalesConnection AviaSalesConnection { get; } = new AviaSalesConnection();
        public AppContext Context { get; }

        public AviaSalesConnectionProvider(AppContext ctx)
        {
            Context = ctx;
        }

        public void SetAppRole(AppRoles role, string pass)
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
                    var su = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                logger.ConditionalDebug(ex.Message);
                throw;
            }

        }

        public void Dispose()
        {
            AviaSalesConnection?.Dispose();
        }
    }
}