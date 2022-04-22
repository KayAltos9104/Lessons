using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public class Bullet:Character
    {
        public Bullet((float x, float y) pos): base(pos)
        {
            Pos = pos;
            Speed = 1;
            float rad = 5;
            Collider = new Collider2D((Pos.X + rad, Pos.Y + rad), rad);
        }
    }
}
