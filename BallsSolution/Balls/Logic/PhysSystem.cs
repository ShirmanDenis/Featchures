using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls.Logic
{
    class PhysSystem
    {
        public readonly List<PhysicBall> Balls = new List<PhysicBall>();

        public PhysicBall GetBallAt(Point position)
        {
            return Balls.FirstOrDefault(b => b.Bounds.Contains(position));
        }

        public void Move(float dt)
        {
            foreach (var physicBall in Balls)
                physicBall.Move(dt);
        }

        public void DrawSystem(Graphics g)
        {
            foreach (var physicBall in Balls)
                physicBall.Draw(g);
        }
    }
}
