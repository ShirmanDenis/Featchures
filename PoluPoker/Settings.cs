using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoluPoker
{
    public enum RollUpMode
    {
        Tray,
        Minimized
    }
    public class Settings
    {
        public RollUpMode RollUpMode { get; set; } = RollUpMode.Tray;

        public TimeSpan AlertTime { get; set; } = TimeSpan.FromSeconds(5);

        public List<TableDesc> TableNames = new List<TableDesc>();


        public void Update(int id, string name)
        {
            var t = TableNames.First(desc => desc.Id == id);
            t.Name = name;
            var path = AppDomain.CurrentDomain.BaseDirectory + "Settings.json";
            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }

    }

    public class TableDesc
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
