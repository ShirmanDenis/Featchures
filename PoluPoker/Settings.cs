using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
