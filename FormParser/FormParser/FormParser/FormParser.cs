using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormParser.ControlFabric;
using Newtonsoft.Json;

namespace FormParser
{
    class FormParser
    {
        private readonly IControlSpecFabric SpecFabric;

        public FormParser(IControlSpecFabric specFabric)
        {
            SpecFabric = specFabric;
        }

        public Control ParseFromJson(string json)
        {
            var description = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            return ParseFromDescription(description);
        }

        private Control ParseFromDescription(Dictionary<string, object> description)
        {
            object type;
            if (!description.TryGetValue("ControlType", out type)) throw new Exception("Missing property ControlType");

            var controlSpec = SpecFabric.CreateControlSpec(type.ToString());

            controlSpec.SetDescription(description);

            var control = controlSpec.CreateControl();

            object children;
            if (!description.TryGetValue("Children", out children))
                return control;

            foreach (var childDescription in (IEnumerable<Dictionary<string, object>>)children)
            {
                var childControl = ParseFromDescription(childDescription);

                control.Controls.Add(childControl);
            }

            return control;
        }

        public string ConvertToJson(Form form, bool indent = false)
        {
            var controlSpec = SpecFabric.CreateControlSpec("Form");

            controlSpec.LoadOptionsFromControl(form);

            return BuildChildDescription(controlSpec.GetDescription(), form, indent);
        }

        private string BuildChildDescription(Dictionary<string, object> parentDescription, Control parentControl, bool indent)
        {
            var children = new List<Dictionary<string, object>>();

            foreach (Control innerControl in parentControl.Controls)
            {
                var innerSpec = SpecFabric.CreateControlSpec(innerControl.GetType().Name);

                innerSpec.LoadOptionsFromControl(innerControl);

                var childDescription = innerSpec.GetDescription();
                if (innerControl.Controls.Count != 0)
                    BuildChildDescription(childDescription, innerControl, indent);

                children.Add(childDescription);
            }

            parentDescription.Add("Children", children);

            return JsonConvert.SerializeObject(parentDescription, indent ? Formatting.Indented : Formatting.None);
        }
    }
}
