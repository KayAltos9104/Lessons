using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public class Collider2D
    {
        public (float X, float Y) Center { get; set;}
        public float Radius { get; set; }

        public Collider2D ((float X, float Y) center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool IsCollided (Collider2D c1, Collider2D c2)
        {
            var distance = Math.Sqrt((c2.Center.X - c1.Center.X) * (c2.Center.X - c1.Center.X) +
                (c2.Center.Y - c1.Center.Y) * (c2.Center.Y - c1.Center.Y));
            if (distance < c1.Radius + c2.Radius)
                return true;
            else
                return false;
        }
    }
}
