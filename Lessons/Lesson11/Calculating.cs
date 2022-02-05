using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Calculating
    {
        public static double Calculate (Vector velocity)
        {
            double vx = velocity.GetVx();
            double vy = velocity.GetVy();
            double time = 2 * vy / 9.81;
            double x = time * vx;

            return x;
        }
    }
}
