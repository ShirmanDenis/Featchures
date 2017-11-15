using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormParser.Attributes;

namespace FormParser
{
    public class BaseSpec
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public Size ClientSize { get; set; }    
        public Point Location { get; set; }

        public virtual void LoadOptionsFromControl(Control control)
        {
            Text = control.Text;
            Name = control.Name;
            ClientSize = control.ClientSize;
            Location = control.Location;
        }

        public virtual Control CreateControl()
        {
            var control = new Control();
            LoadOptionsOnControl(control);
            return control;
        }

        protected virtual void LoadOptionsOnControl(Control control)
        {
            control.Text = Text;
            control.Name = Name;
            control.ClientSize = ClientSize;
            control.Location = Location;
        }

        //public void LoadFromXml(string xml)
        //{
        //    new XmlSerializer().DeserializeObject(xml, this);
        //}

        //public string WriteToXml()
        //{
        //    return new XmlSerializer().SerializeObject(this);
        //}
    }
}
