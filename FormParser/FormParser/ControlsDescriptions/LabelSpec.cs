using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParser.ControlsDescriptions
{
    class LabelSpec : BaseSpec
    {
        public override string ControlType { get { return typeof(Label).Name; } }

        public override Control CreateControl()
        {
            var label = new Label();
            LoadOptionsOnControl(label);
            return label;
        }
    }
}
