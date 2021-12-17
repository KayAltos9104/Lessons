using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Topor: ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Плавает как топор");
        }
    }
}
