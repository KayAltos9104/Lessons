using System;
using System.Collections.Generic;

namespace Lesson9._5
{
    class Program
    {
        static void Main()
        {
            List<IMovable> m = new List<IMovable>();
            Wolf w = new Wolf();
            Sheep s = new Sheep();
            m.Add(w);
            m.Add(s);

            foreach (var a in m)
            {
                a.Move();
                if (a is IAttackable)
                {
                    var f = (IAttackable)a;
                    f.Attack();
                }                
            }
        }
    }
}
