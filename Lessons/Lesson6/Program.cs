using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main()
        {
            Soldier Shepard = new Soldier();
            KroganMerc Wrex = new KroganMerc();
            string log;
            for (int i = 0; i < 100; i++)
            {
                log = "";
                Shepard.Update(Wrex, out log);
                Console.WriteLine(log);
                Wrex.Update(Shepard, out log);                
                Console.WriteLine(log);
                Console.ReadKey();
            }
            int r = Sum(5, 30);
            double t = Sum(1.5, 4.0);

            
        }

        static int Sum (int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static int Sum (int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
