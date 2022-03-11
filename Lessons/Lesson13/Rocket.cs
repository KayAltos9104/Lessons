using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Rocket
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        protected double _velX;
        protected double _velY;
        

        public Rocket(double x, double y, double velX, double velY)
        {
            X = x;
            Y = y;
            _velX = velX;
            _velY = velY;
        }

        public virtual void Move()
        {
            X += _velX;
            Y += _velY;
        }
    }
}
