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
                        if (Balls[i].Speed.Norm(2).Equals(0.0))
                        {
                            ComputeSpeedAfterBounce(Balls[j], Balls[i]);
                        }
                        else
                        {
                            ComputeSpeedAfterBounce(Balls[i], Balls[j]);
                        }
                    }
                }
            }
        }


        public void NormalizeSystem()
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
                        // шары удобнее всего расталкивать вдоль прямой, проходящей через их центры
                        var penetrationDirection = (p2 - p1).Normalize(2);
                        // глубина проникновения - это сумма радиусов двух шаров
                        // минус расстояние между их центрами
                        var penetrationDepth = Balls[i].Radius + Balls[j].Radius
                                               - Distance.Euclidean(p1, p2);

                        // расталкиваем шары в противоположенных направлениях
                        Balls[i].Push(-penetrationDirection
                            .Multiply((float)penetrationDepth * 0.5f));
                        Balls[j].Push(penetrationDirection
                            .Multiply((float)(penetrationDepth * 0.5)));


                        float bounce = 0.5f; //коэффициент отскока, [0..1]
                        //относительная скорость шариков
                        var relativeVelocity = Balls[i].DeltaLocation - Balls[j].DeltaLocation;
                        //тела обмениваются импульсом вдоль нормали контакта
                        float exchangeVelocity = (1.0f + bounce) * (relativeVelocity * penetrationDirection);
                        if (exchangeVelocity > 0)
                        {
                            Balls[i].DeltaLocation += penetrationDirection * exchangeVelocity * 0.5f;
                            Balls[j].DeltaLocation -= penetrationDirection * exchangeVelocity * 0.5f;
                        }
                    }
                }
            }
        }

        public void Move(float dt)
        {
            //Normalize();
            NormalizeSystem();

            foreach (var physicBall in Balls)
                physicBall.Move(dt);
        }

        public void DrawSystem(Graphics g)
        {
            foreach (var physicBall in Balls)
                physicBall.Draw(g);
        }

        private void ComputeSpeedAfterBounce(PhysicBall first, PhysicBall second)
        {
            var firstSpeed = (first.Mass - second.Mass) * first.Speed / (first.Mass + second.Mass);
            var secondSpeed = 2 * first.Mass * first.Speed / (first.Mass + second.Mass);
            firstSpeed.CopyTo(first.Speed);
            secondSpeed.CopyTo(second.Speed);
            //-first.Speed + 2 * (first.Mass * first.Speed + second.Mass * second.Speed) /
            //   (first.Mass + second.Mass);
            //return ((first.Mass - second.Mass) * first.Speed +
            //        2 * second.Mass * second.Speed) / (first.Mass + second.Mass); ;
        }
    }
}
