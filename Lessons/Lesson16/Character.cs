using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public class Character
    {
        public (float X, float Y) Pos { get; set; }

        public (float X, float Y) direction { get; set; }
        public float Speed { get; set; }

        public Collider2D Collider { get; set; }
        public Character ((float x, float y) pos)
        {
            Pos = pos;
            Speed = 5;
            float rad = 15;
            Collider = new Collider2D((Pos.X + rad, Pos.Y + rad), rad);
        }

        public void Move ()
        {
            Pos = (Pos.X + direction.X*Speed, Pos.Y + direction.Y * Speed);
            Collider.Center = (Collider.Center.X + direction.X * Speed, Collider.Center.Y + direction.Y * Speed);
        }

    }
}
