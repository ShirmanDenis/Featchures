using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseReplaceOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var opParser = new OpParser(new BaseDataProvider("data.txt"), "test.txt");
            opParser.Parse();
            var str = AppContext.BaseDirectory.Split('\\');
            str[str.Length - 2] = "";
            str[str.Length - 3] = "";

            var path = string.Join("\\", str.TakeWhile(s => !string.IsNullOrEmpty(s))) + "\\result.txt";
            if (File.Exists(path)) File.Delete(path);
            File.AppendAllText(path, opParser.Result.ToString());
        }
    }
}
