using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Balls.Logic
{
    static class Helper
    {
        public static PointF FromVector2(Vector<float> vector)
        {
            return new PointF(vector[0], vector[1]);
        }
    }
}
