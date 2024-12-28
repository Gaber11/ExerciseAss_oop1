using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x; 
            Y = y;
        }
        public double Distance(Point point01 , Point point02)
        {
            double xe =point02.X - point01.X;
            double ye = point02.Y - point01.Y;
            return Math.Sqrt(xe * xe + ye * ye);
        }

    }
}
