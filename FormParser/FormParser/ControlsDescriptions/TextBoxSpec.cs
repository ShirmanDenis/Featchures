using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParser.ControlsDescriptions
{
    public class TextBoxSpec : BaseSpec
    {
        public override string ControlType { get { return typeof(TextBox).Name; } }

        public bool CanInputNumbers { get; set; }

        public TextBoxSpec()
        {
            CanInputNumbers = true;
        }

        public override Control CreateControl()
        {
            var textBox = new TextBox();

            LoadOptionsOnControl(textBox);

            return textBox;
        }

        protected override void LoadOptionsOnControl(Control control)
        {
            base.LoadOptionsOnControl(control);

            if (!CanInputNumbers)
            {
                control.TextChanged += (s, e) =>
                {
                    var regex = new Regex("\\d+");

                    control.BackColor = 
                    regex.IsMatch(control.Text) ? 
                        Color.Red : 
                        Color.AliceBlue;
                };
            }
        }

        public override void SetDescription(IDictionary<string, object> description)
        {
            base.SetDescription(description);

            CanInputNumbers = bool.Parse(description["CanInputNumbers"].ToString());
        }
    }
}
