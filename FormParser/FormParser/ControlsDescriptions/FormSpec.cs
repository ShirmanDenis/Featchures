using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FormParser.ControlsDescriptions;


namespace FormParser
{
    class FormSpec : BaseSpec
    {
        public readonly List<TextBoxSpec> TextBoxesSpecs  = new List<TextBoxSpec>();
        public readonly List<ButtonSpec>  ButtonSpecs = new List<ButtonSpec>();
        public readonly List<LabelSpec>   LabelSpecs = new List<LabelSpec>();

        public SizeF AutoScaleDimensions { get; set; }
        public AutoScaleMode AutoScaleMode { get; set; }

        public override Control CreateControl()
        {
            var form = new Form();

            LoadOptionsOnControl(form);
            
            form.SuspendLayout();
            form.ResumeLayout(false);
            form.PerformLayout();

            return form;
        }

        public override void LoadOptionsFromControl(Control control)
        {
            base.LoadOptionsFromControl(control);

            var form = control as Form;
            if (form != null)
            {
                AutoScaleDimensions = form.AutoScaleDimensions;
                AutoScaleMode = form.AutoScaleMode;
            }

            foreach (Control innerControl in control.Controls)
            {
                BaseSpec spec = null;

                if (innerControl is TextBox)
                {
                    spec = new TextBoxSpec();
                    TextBoxesSpecs.Add((TextBoxSpec)spec);
                }
                if (innerControl is Label)
                {
                    spec = new LabelSpec();
                    LabelSpecs.Add((LabelSpec)spec);
                }
                if (innerControl is Button)
                {
                    spec = new ButtonSpec();
                    ButtonSpecs.Add((ButtonSpec)spec);
                }

                if (spec != null)
                {
                    spec.LoadOptionsFromControl(innerControl); 
                }
            }
        }

        protected override void LoadOptionsOnControl(Control control)
        {
            base.LoadOptionsOnControl(control);

            var form = control as Form;
            if (form != null)
            {
                form.AutoScaleDimensions = AutoScaleDimensions;
                form.AutoScaleMode = AutoScaleMode;

                foreach (var buttonSpec in ButtonSpecs)
                    form.Controls.Add(buttonSpec.CreateControl());

                foreach (var labelSpec in LabelSpecs)
                    form.Controls.Add(labelSpec.CreateControl());

                foreach (var textBoxSpec in TextBoxesSpecs)
                    form.Controls.Add(textBoxSpec.CreateControl());
            }
        }
    }
}
