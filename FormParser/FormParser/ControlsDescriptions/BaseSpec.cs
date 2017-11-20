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

        public void SetDescription(Dictionary<string, object> description)
        {
            var type = GetType();

            foreach (var pair in description)
            {
                var property = type.GetProperty(pair.Key);

                Debug.Assert(property != null);

                if (property.SetMethod == null) continue;

                var value = description[pair.Key];
                property.SetValue(this, value);
            }
        }

        //public virtual IDictionary<string, object> GetDescription()
        //{
        //    var description = new Dictionary<string, object>
        //    {
        //        {"ClassName", GetType().Name },
        //        {"Text", Text},
        //        {"Name", Name },
        //        {"ClientSize", ClientSize },
        //        {"Location", Location }
        //    };

        //    return description;
        //}

        //public virtual void SetDescription(IDictionary<string, object> description)
        //{
        //    object text;
        //    if (description.TryGetValue("Text", out text))
        //        Text = text.ToString();

        //    object name;
        //    if (description.TryGetValue("Name", out name))
        //        Name = name.ToString();

        //    object clientSize;
        //    if (description.TryGetValue("ClientSize", out clientSize))
        //        ClientSize = (Size) clientSize;

        //    Location = (Point)description["Location"];
        //}
    }
}