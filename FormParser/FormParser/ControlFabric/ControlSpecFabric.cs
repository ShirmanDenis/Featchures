using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormParser.ControlsDescriptions;

namespace FormParser.ControlFabric
{
    class ControlSpecFabric : IControlSpecFabric
    {
        private readonly Dictionary<string, Type> ControlSpecs = new Dictionary<string, Type>()
        {
            {"TextBox", typeof(TextBoxSpec) },
            {"Label", typeof(LabelSpec) },
            {"Form", typeof(FormSpec) },
            {"Button", typeof(ButtonSpec) }
        };

        public BaseSpec CreateControlSpec(string controlTypeName)
        {
            Type type;
            if (!ControlSpecs.TryGetValue(controlTypeName, out type))
                throw new Exception($"\"{controlTypeName}\" is not registered");

            var ctor = type.GetConstructor(Type.EmptyTypes);

            Debug.Assert(ctor != null);

            return (BaseSpec)ctor.Invoke(null);
        }

        public void RegisterControlSpec<T>(string controlTypeName) where T : BaseSpec, new()
        {
            ControlSpecs.Add(controlTypeName, typeof(T));
        }
    }
}
