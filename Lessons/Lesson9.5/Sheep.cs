using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._5
{
    class Sheep: IMovable
    {
        public void Move()
        {
            Console.WriteLine("Овца идет");
        }
    }
}
