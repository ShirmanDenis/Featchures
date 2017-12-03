using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balls.Logic;

namespace Balls.BallEditor
{
    public partial class BallEditor : UserControl
    {
        private PhysicBall _ball;

        public BallEditor()
        {
            InitializeComponent();
            upDownLocationX.Maximum = int.MaxValue;
            upDownLocationY.Maximum = int.MaxValue;

            CollectColors();

            cmBxColor.MouseWheel += LeValue_MouseWheel;
        }

        public void SetBall(PhysicBall ball)
        {
            if (_ball != null)
                UnSubScribe();

            _ball = ball;

            SetBallsPropertiesToEditor();
            SubScribe();
        }

        private void SetBallsPropertiesToEditor()
        {
            upDownWidth.Value = _ball.LineWidth;
            upDownRadius.Value = _ball.Radius;
            upDownMass.Value = (decimal) _ball.Mass;
            upDownLocationX.Value = (decimal) _ball.Location[0];
            upDownLocationY.Value = (decimal) _ball.Location[1];
            upDownSpeedX.Value = (decimal) _ball.Speed[0];
            upDownSpeedY.Value = (decimal) _ball.Speed[0];
            var index = cmBxColor.Items.IndexOf(_ball.Color.Name);
            cmBxColor.SelectedIndex = index;
        }

        private void SubScribe()
        {
            _ball.Changed += _ball_Changed;
        }

        private void UnSubScribe()
        {
            _ball.Changed -= _ball_Changed;
        }

        private void _ball_Changed(object sender, EventArgs e)
        {
            SetBallsPropertiesToEditor();
        }

        private void cmBxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var rect = e.Bounds;

            e.DrawBackground();

            if (e.Index >= 0)
            {
                var colorName = ((ComboBox)sender).Items[e.Index].ToString();
                SolidBrush b;
                int colorRectWidth;
                int colorRectHeight;
                using (var f = new Font("Arial", 9, FontStyle.Regular))
                {
                    var c = Color.FromName(colorName);
                    b = new SolidBrush(c);

                    colorRectWidth = (int)(rect.Width);
                    colorRectHeight = rect.Height;
                    //g.DrawString(colorName, f, Brushes.Black, rect.X + colorRectWidth + 10, rect.Y);
                }
                g.FillRectangle(b, rect.X + 2, rect.Y + 1, colorRectWidth, colorRectHeight - 2);
            }
            e.DrawFocusRectangle();
        }

        private void LeValue_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void CollectColors()
        {
            var colorType = typeof(Color);
            var propertiesInfo = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (var property in propertiesInfo)
            {
                cmBxColor.Items.Add(property.Name);
            }

            var systemColors = typeof(SystemColors);
            var properties = systemColors.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (var property in properties)
            {
                cmBxColor.Items.Add(property.Name);
            }
        }

        private void cmBxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var colorName = cmBxColor.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(colorName))
                _ball.Color = Color.FromName(colorName);
        }

        private void upDownWidth_ValueChanged(object sender, EventArgs e)
        {
            _ball.LineWidth = (int) upDownWidth.Value;
        }

        private void upDownRadius_ValueChanged(object sender, EventArgs e)
        {
            _ball.Radius = (int) upDownRadius.Value;
        }

        private void upDownLocationX_ValueChanged(object sender, EventArgs e)
        {
            _ball.Location[0] = (float) upDownLocationX.Value;
        }

        private void upDownLocationY_ValueChanged(object sender, EventArgs e)
        {
            _ball.Location[1] = (float) upDownLocationY.Value;
        }

        private void upDownSpeedX_ValueChanged(object sender, EventArgs e)
        {
            _ball.Speed[0] = (float) upDownSpeedX.Value;
        }

        private void upDownSpeedY_ValueChanged(object sender, EventArgs e)
        {
            _ball.Speed[1] = (float) upDownSpeedY.Value;
        }

        private void upDownMass_ValueChanged(object sender, EventArgs e)
        {
            _ball.Mass = (float) upDownMass.Value;
        }
    }
}
