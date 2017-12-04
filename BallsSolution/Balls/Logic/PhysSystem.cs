using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Balls.Logic
{
    class PhysSystem
    {
        public readonly List<PhysicBall> Balls = new List<PhysicBall>();

        public PhysicBall GetBallAt(Point position)
        {
            return Balls.FirstOrDefault(b => b.Bounds.Contains(position));
        }

        public void Normalize()
        {
            for (int i = 0; i < Balls.Count - 1; i++)
            {
                for (int j = i + 1; j < Balls.Count; j++)
                {
                    var p1 = Balls[i].Location;
                    var p2 = Balls[j].Location;
                    if (Distance.Euclidean(p1, p2) < Balls[i].Radius + Balls[j].Radius + Balls[i].LineWidth / 2 + Balls[j].LineWidth / 2)
                        // расстояние между центрами шаров меньше
                        // суммы их радиусов -> они пересекаются
                    {
                        var firstBallSpeed = ComputeSpeedAfterBounce(Balls[i], Balls[j]);
                        firstBallSpeed.CopyTo(Balls[i].Speed);
                        var secondBallSpeed = ComputeSpeedAfterBounce(Balls[j], Balls[i]);
                        secondBallSpeed.CopyTo(Balls[j].Speed);
                    }
                }
            }
        }

        public void Move(float dt)
        {
            Normalize();

            foreach (var physicBall in Balls)
                physicBall.Move(dt);
        }

        public void DrawSystem(Graphics g)
        {
            foreach (var physicBall in Balls)
                physicBall.Draw(g);
        }

        private Vector<float> ComputeSpeedAfterBounce(PhysicBall first, PhysicBall second)
        {
            return -first.Speed + 2 * (first.Mass * first.Speed + second.Mass * second.Speed) /
                   (first.Mass + second.Mass);
            //return ((first.Mass - second.Mass) * first.Speed +
            //        2 * second.Mass * second.Speed) / (first.Mass + second.Mass); ;
        }
    }
}
