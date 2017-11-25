using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FormParser
{
    public class FormParser
    {
        private readonly Dictionary<string, Func<BaseSpec>> _specCreators = new Dictionary<string, Func<BaseSpec>>();

        public Control ParseFromJson(string json)
        {
            var description = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            return ParseFromDescription(description);
        }

        private Control ParseFromDescription(Dictionary<string, object> description)
        {
            if (!description.TryGetValue("ControlType", out object type)) throw new Exception("Missing property ControlType");

            if (!_specCreators.TryGetValue(type.ToString(), out Func<BaseSpec> specCreator)) throw new Exception($"Creator for type \"{type}\" does not exists");

            var controlSpec = specCreator();
            controlSpec.SetDescription(description);

            var control = controlSpec.CreateControl();

            if (!description.TryGetValue("Children", out object children))
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
            var controlSpec = _specCreators["Form"]();

            controlSpec.LoadOptionsFromControl(form);

            return BuildChildDescription(controlSpec.GetDescription(), form, indent);
        }

        private string BuildChildDescription(Dictionary<string, object> parentDescription, Control parentControl, bool indent)
        {
            var children = new List<Dictionary<string, object>>();
            foreach (Control innerControl in parentControl.Controls)
            {
                var innerSpec = _specCreators[innerControl.GetType().Name]();
                innerSpec.LoadOptionsFromControl(innerControl);

                var childDescription = innerSpec.GetDescription();
                if (innerControl.Controls.Count != 0)
                    BuildChildDescription(childDescription, innerControl, indent);

                children.Add(childDescription);
            }
            parentDescription.Add("Children", children);

            return JsonConvert.SerializeObject(parentDescription, indent ? Formatting.Indented : Formatting.None);
        }

        public void RegisterControlSpec(string controlType, Func<BaseSpec> controlSpecCreator)
        {
            _specCreators.Add(controlType, controlSpecCreator);
        }

        public bool IsControlRegistered(string controlType)
        {
            return _specCreators.ContainsKey(controlType);
        }
    }
}
