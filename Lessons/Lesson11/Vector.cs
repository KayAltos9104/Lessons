using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Vector
    {
        public double Angle { get; }
        public double Module { get;}
        public Vector (double angle, double module)
        {
            Angle = angle;
            Module = module;
        }
        public double GetVx ()
        {            
            return Module * Math.Cos(ConvertToRad(Angle));
        }
        public double GetVy()
        {
            return Module * Math.Sin(ConvertToRad(Angle));
        }
        public static double ConvertToRad(double angleDeg)
        {
            return (angleDeg * Math.PI / 180);
        }
        public static double ConvertToDeg(double angleRad)
        {
            return (angleRad * 180 / Math.PI);
        }
    }
}
