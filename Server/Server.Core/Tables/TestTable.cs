using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Server.Core
{
    [Table("TestTable")]
    class TestTable
    {
        [NotNull]
        [PrimaryKey]
        [AutoIncrement]
        public int TestID { get; set; }
        
        public string Text { get; set; }
    }
}
