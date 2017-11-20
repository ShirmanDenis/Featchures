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

        public override string ControlType { get { return typeof(Form).Name; } }

        public override void LoadOptionsFromControl(Control control)
        {
            base.LoadOptionsFromControl(control);

            var form = control as Form;
            if (form != null)
            {
                AutoScaleDimensions = form.AutoScaleDimensions;
                AutoScaleMode = form.AutoScaleMode;
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
            }
        }
    }
}
