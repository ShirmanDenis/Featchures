using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormParser.Attributes;

namespace FormParser
{
    abstract class BaseSpec
    {
        public string Text { get; private set; }
        public string Name { get; private set; }
        public Size ClientSize { get; private set; }    
        public Point Location { get; private set; }

        [IgnoreSerialization]
        public bool IsOptionsLoad { get; protected set; }

        public virtual void LoadOptions(Control control)
        {
            Name = control.Name;
            Text = control.Text;
            ClientSize = control.ClientSize;
            Location = control.Location;

            IsOptionsLoad = true;
        }
    }
}
