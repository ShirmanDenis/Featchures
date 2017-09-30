using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace GLBuilding.Core.BuildingBase
{

    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        double DistanceTo(Point other)
        {
            return Sqrt((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y));
        }
        void Rotate(Point around, double angleInDegree, Direction direction = Direction.ClockWise)
        {
            var rad = angleInDegree * PI / 180;

            if (direction == Direction.ClockWise)
            {
                var t_x = X;
                var t_y = Y;
                X = around.X + (t_x - around.X) * Cos(rad) - (t_y - around.Y) * Sin(rad);
                Y = around.Y + (t_y - around.Y) * Cos(rad) + (t_x - around.X) * Sin(rad);
            }
            else
            {
                var t_x = X;
                var t_y = Y;
                X = around.X + (t_x - around.X) * Cos(rad) + (t_y - around.Y) * Sin(rad);
                Y = around.Y + (t_y - around.Y) * Cos(rad) - (t_x - around.X) * Sin(rad);
            }
        }
    };
}
