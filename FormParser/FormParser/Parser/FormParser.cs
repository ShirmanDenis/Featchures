using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            object type;
            if (!description.TryGetValue("ControlType", out type)) throw new Exception("Missing property ControlType");

            Func<BaseSpec> specCreator;
            if (!_specCreators.TryGetValue(type.ToString(), out specCreator)) throw new Exception(string.Format("Creator for type \"{0}\" does not exists", type.ToString()));

            var controlSpec = specCreator();
            controlSpec.SetDescription(description);

            var control = controlSpec.CreateControl();

            object children;
            if (!description.TryGetValue("Children", out children))
                return control;

            foreach (var childDescription in (IEnumerable<JToken>)description["Children"])
            {
                var dict = childDescription.ToObject<Dictionary<string, object>>();
                var childControl = ParseFromDescription(dict);
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
