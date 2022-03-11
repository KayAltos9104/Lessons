using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class AA_Rocket:Rocket
    {
        public double _detectRad;
        public AA_Rocket (double x, double y, double velX, double velY, double detectRad): base(x, y, velX, velY)
        {
            _detectRad = detectRad;
        }

        public override void Move()
        {
            base.Move();
        }



        public void DetectEnemy (List<Rocket> rocketsList)
        {
            foreach (var r in rocketsList)
            {
                if ((r.X-this.X)* (r.X - this.X) + (r.Y - this.Y)*(r.Y - this.Y)<=(this._detectRad* this._detectRad))
                {
                    double angleTan = (r.X - this.X) / (r.Y - this.Y);
                    double angle = Math.Atan(angleTan);
                    double velocity = Math.Sqrt(_velX * _velX + _velY * _velY);
                    _velX = velocity * Math.Cos(angle);
                    _velY = velocity * Math.Sin(angle);

                }
            }
        }
    }
}
