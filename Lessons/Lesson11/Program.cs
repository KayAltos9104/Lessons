using System;

namespace Lesson11
{
    class Program
    {
        static void Main()
        {
            Vector vel = new Vector(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            var result = Calculating.Calculate(vel);
            //Console.Write('2656');
            for (int i = 0; i <= result; i++)
                Console.Write(" _ ");
            Console.WriteLine('\u263a');
            //Console.WriteLine("X");
            Console.WriteLine("Расстояние: {0}", result);

            Console.ReadKey();
        }
    }
}
