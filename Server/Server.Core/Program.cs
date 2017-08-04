using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Server.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SQLiteConnection(@"DataBases\Test.db"))
            {
                
            }
        }
    }
}
