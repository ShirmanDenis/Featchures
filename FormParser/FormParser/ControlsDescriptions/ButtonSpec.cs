using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParser.ControlsDescriptions
{
    class ButtonSpec : BaseSpec
    {
        public override string ControlType { get { return typeof(Button).Name; } }

        public override Control CreateControl()
        {
            var button = new Button();
            LoadOptionsOnControl(button);
            return button;
        }
    }
}
