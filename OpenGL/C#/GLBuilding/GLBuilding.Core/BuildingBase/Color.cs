using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLBuilding.Core
{
    public enum Direction
    {
        ClockWise,
        CounterClockWise
    };

    public class Color
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Color(byte r, byte g, byte b)
        {
            B = b;
            G = g;
            R = r;
        }

        public static Color Red()
        {
            return new Color(255, 0, 0);
        }
        public static Color Green()
        {
            return new Color(0, 255, 0);
        }
        public static Color Blue()
        {
            return new Color(0, 0, 255);
        }
        public static Color Yellow()
        {
            return new Color(255, 255, 0);
        }
        public static Color Turquoise()
        {
            return new Color(0, 255, 255);
        }
        public static Color Pink()
        {
            return new Color(255, 0, 255);
        }
        public static Color White()
        {
            return new Color(255, 255, 255);
        }
        public static Color Black()
        {
            return new Color(0, 0, 0);
        }
        public static Color Brown()
        {
            return new Color(128, 0, 0);
        }
        public static Color Orange()
        {
            return new Color(255, 128, 0);
        }
        public static Color Grey()
        {
            return new Color(128, 128, 128);
        }
        public void Assign(Color color)
        {
            R = color.R;
            G = color.G;
            B = color.B;
        }
    }
}
