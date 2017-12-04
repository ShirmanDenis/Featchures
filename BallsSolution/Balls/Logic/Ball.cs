using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Single;
namespace Balls.Logic
{
    class Ball
    {
        private readonly Timer _bounceTimer = new Timer();

        public Color Color { get; set; } = Color.Red;
        public int LineWidth { get; set; } = 1;
        public Vector<float> Location { get; set; }
        public Vector<float> DeltaLocation { get; set; }
        public Vector<float> Acceleration { get; private set; }
        public int Radius { get; set; }

        public Ball(int radius = 1)
        {
            Radius = radius;
            Location = new DenseVector(2);
            DeltaLocation = new DenseVector(2);
            Acceleration = DenseVector.OfArray(new float[]{1, 1});
            _bounceTimer.Enabled = false;
            _bounceTimer.Interval = 100;
            _bounceTimer.Tick += _bounceTimer_Tick;
        }

        private void _bounceTimer_Tick(object sender, EventArgs e)
        {
            UnBounce();
        }

        public void Move(float dt)
        {
            DeltaLocation += Acceleration * dt * dt;
            Location += DeltaLocation;
        }

        public void Push(DenseVector delta)
        {
            Location += delta;
            DeltaLocation += delta;
        }

        public void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color, LineWidth))
            {
                var rect = new RectangleF(Helper.FromVector2(Location), new Size(Radius * 2, Radius * 2));

                graphics.DrawEllipse(pen, rect);
            }
        }

        public void Bounce()
        {
            _bounceTimer.Start();
            Color = Color.LimeGreen;
        }

        private void UnBounce()
        {
            _bounceTimer.Stop();
            Color = Color.Red;
        }
    }
}
