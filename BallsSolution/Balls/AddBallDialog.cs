using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls
{
    public partial class AddBallDialog : Form
    {
        public Point Position { get; private set; }

        public Point Speed { get; private set; }

        public int Mass { get; private set; }

        public int Radius { get; private set; }

        public AddBallDialog(Point location, int w, int h)
        {
            InitializeComponent();
            upDownLocationX.Maximum = w;
            upDownLoacationY.Maximum = h;
            upDownLocationX.Value = location.X;
            upDownLoacationY.Value = location.Y;
        }

        private void AddBallDialog_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var location = new Point
            {
                X = (int) upDownLocationX.Value,
                Y = (int) upDownLoacationY.Value
            };
            Position = location;

            var speed = new Point
            {
                X = (int)upDownSpeedX.Value,
                Y = (int)upDownSpeedY.Value
            };
            Speed = speed;

            Mass = (int)upDownMass.Value;
            Radius = (int) upDownRadius.Value;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
