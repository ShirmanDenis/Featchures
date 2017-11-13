using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormParser
{
    class FormSpec : BaseSpec
    {
        public HashSet<ButtonSpec> Buttons { get; }
        public HashSet<LabelSpec> Labels { get; }
        public HashSet<TextBoxSpec> TextBoxes { get; }
        public HashSet<BaseSpec> InnerForms { get; }

        public SizeF AutoScaleDimensions { get; set; }
        public AutoScaleMode AutoScaleMode { get; set; }

        public FormSpec()
        {
            Buttons = new HashSet<ButtonSpec>();
            Labels = new HashSet<LabelSpec>();
            TextBoxes = new HashSet<TextBoxSpec>();
            InnerForms = new HashSet<BaseSpec>();
        }

        public override void LoadOptions(Control control)
        {
            base.LoadOptions(control);

            IsOptionsLoad = false;

            var form = control as Form;
            if (form == null) throw new Exception("FromSpec can load only Form options!");

            AutoScaleMode = form.AutoScaleMode;
            AutoScaleDimensions = form.AutoScaleDimensions;

            IsOptionsLoad = true;
        }
    }
}
