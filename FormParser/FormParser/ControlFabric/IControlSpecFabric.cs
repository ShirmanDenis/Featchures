using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParser.ControlFabric
{
    interface IControlSpecFabric
    {
        BaseSpec CreateControlSpec(string controlTypeName);
        void RegisterControlSpec<T>(string controlTypeName) where T : BaseSpec, new();
    }
}
