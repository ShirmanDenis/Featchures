using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParser
{
    public abstract class BaseSpec
    {
        public abstract string ControlType { get; }
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

        public abstract Control CreateControl();

        protected virtual void LoadOptionsOnControl(Control control)
        {
            control.Text = Text;
            control.Name = Name;
            control.ClientSize = ClientSize;
            control.Location = Location;
        }

        public Dictionary<string, object> GetDescription()
        {
            var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            return properties.ToDictionary(property => property.Name, property => property.GetValue(this));
        }

        public virtual void SetDescription(IDictionary<string, object> description)
        {
            object text;
            if (description.TryGetValue("Text", out text))
                Text = text.ToString();

            object name;
            if (description.TryGetValue("Name", out name))
                Name = name.ToString();

            object clientSize;
            if (description.TryGetValue("ClientSize", out clientSize))
            {
                var values = clientSize.ToString().Split(',').Select(i => i.Trim(' ')).ToList();

                ClientSize = new Size(int.Parse(values[0]), int.Parse(values[1]));
            }

            var strPoint = description["Location"];
            var pointValues = strPoint.ToString().Trim('{', '}').Split(',').Select(i => i.Trim(' ')).ToList();
            Location = new Point(int.Parse(pointValues[0]), int.Parse(pointValues[1]));
        }
    }
}