using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;

namespace Server.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SQLiteConnection("Test.db");
            {
                db.BeginTransaction();
                db.CreateTable<TestTable>();
                db.Insert(new TestTable() {Text = "First"});
                db.Close();
            }
        }
    }
}
