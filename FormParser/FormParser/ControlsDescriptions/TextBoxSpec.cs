using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParser.ControlsDescriptions
{
    public class TextBoxSpec : BaseSpec
    {
        public override string ControlType => typeof(TextBox).Name;

        public override Control CreateControl()
        {
            var textBox = new TextBox();

            LoadOptionsOnControl(textBox);

            return textBox;
        }
    }
}
