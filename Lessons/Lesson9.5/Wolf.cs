using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._5
{
    class Wolf: IMovable, IAttackable
    {
        public void Move()
        {
            Console.WriteLine("Волк идет");
        }
        public void Attack()
        {
            Console.WriteLine("Волк атакует!");
        }
    }
}
