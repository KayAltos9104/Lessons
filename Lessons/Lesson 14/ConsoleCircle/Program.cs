using Lesson15_2;
using System;

namespace ConsoleCircle
{
    internal class Program
    {
        static void Main()
        {
            var v = new ViewCircle();
            Presenter p = new Presenter(new Circle(), v);
           
            v.OnInit();
            Console.ReadKey();
            
        }
    }
}
