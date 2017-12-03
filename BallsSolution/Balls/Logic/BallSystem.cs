using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Single;
using MathNet.Numerics.Random;

namespace Balls.Logic
{
    class BallSystem
    {
        private readonly Random _random = new Random();
        private readonly List<Ball> Balls = new List<Ball>();

        private Size SystemBounds;

        public BallSystem(int ballsCount, int radius, int width, int height)
        {
            SystemBounds = new Size(width, height);
            for (int i = 0; i < ballsCount; i++)
            {
                var b = new Ball(radius)
                {
                    Location =
                    {
                        [0] = _random.Next(width),
                        [1] = _random.Next(height)
                    },
                    Acceleration =
                    {
                        [0] = 1.5f,
                        [1] = 1.5f
                    }
                };

                b.Location.CopyTo(b.DeltaLocation);
                Balls.Add(b);
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
                    if (Distance.Euclidean(p1, p2) < Balls[i].Radius + Balls[j].Radius)
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
                        Balls[i].Push(DenseVector.OfVector(-penetrationDirection
                            .Multiply((float)penetrationDepth * 0.5f)));
                        Balls[j].Push(DenseVector.OfVector(penetrationDirection
                            .Multiply((float)(penetrationDepth * 0.5))));

                        Balls[i].Bounce();
                        Balls[j].Bounce();

                        float bounce = 0.9f; //коэффициент отскока, [0..1]
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
            foreach (var ball in Balls)
            {
                ball.Move(dt);
            }
        }

        public void DrawSystem(Graphics graphics)
        {
            foreach (var ball in Balls)
            {
                ball.Draw(graphics);
            }
        }
    }
}
