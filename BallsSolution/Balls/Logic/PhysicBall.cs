using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Single;

namespace Balls.Logic
{
    public class PhysicBall
    {
        public event EventHandler ColorChanged;
        public event EventHandler LineWidthChanged;
        public event EventHandler MassChanged;
        public event EventHandler RadiusChanged;
        public event EventHandler LocationChanged;
        public event EventHandler SpeedChanged;
        public event EventHandler Changed;


        private Color _color = Color.Red;
        private int _lineWidth = 1;
        private float _mass = 1;
        private int _radius = 1;

        public Rectangle Bounds => GetBounds();

        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                ColorChanged?.Invoke(this, EventArgs.Empty);
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }
        
        public int LineWidth
        {
            get { return _lineWidth; }
            set
            {
                _lineWidth = value;
                LineWidthChanged?.Invoke(this, EventArgs.Empty);
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        public float Mass
        {
            get { return _mass; }
            set
            {
                _mass = value; 
                MassChanged?.Invoke(this, EventArgs.Empty);
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                RadiusChanged?.Invoke(this, EventArgs.Empty);
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        public void SetLocation(Point location)
        {
            Location[0] = location.X;
            Location[1] = location.Y;
            LocationChanged?.Invoke(this, EventArgs.Empty);
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public void SetSpeed(Point speed)
        {
            Speed[0] = speed.X;
            Speed[1] = speed.Y;
            SpeedChanged?.Invoke(this, EventArgs.Empty);
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public Vector<float> Location { get; private set; }
        public Vector<float> Speed { get; private set; }

        public PhysicBall()
        {
            Location = CreateVector.Dense<float>(2);
            Speed = CreateVector.Dense<float>(2);
        }

        public void Move(float dt)
        {
            var acceleration = (Speed * dt - Speed) / dt;
            Location = Location + Speed * Location + acceleration * dt * dt / 2;

            LocationChanged?.Invoke(this, EventArgs.Empty);
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color, LineWidth))
            {
                var rect = new Rectangle(Helper.FromVector2(Location), new Size(Radius * 2, Radius * 2));

                graphics.DrawEllipse(pen, rect);
            }
        }

        private Rectangle GetBounds()
        {
            return new Rectangle(Helper.FromVector2(Location),
                new Size(Radius * 2, Radius * 2));
        }
    }
}
