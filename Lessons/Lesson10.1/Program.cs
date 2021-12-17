using System;

namespace Lesson10._1
{
    class Program
    {       
        static void Main()
        {
            //CustomEvent += Handler1;
            //CustomEvent += Handler2;

            //CustomEvent.Invoke();
            //Class1 c = new Class1();
            //c.CustomEvent += Handler1;
            //c.CustomEvent += Handler2;

            //c.ClickEvent();
            Student s = new Student();
            s.Dead += Handler1;
            s.Dead += Handler2;

            s.Update();
            s.Update();
        }
        static void Handler1()
        {
            Console.WriteLine("Ты, вроде бы, сдох?");
        }
        static void Handler2()
        {
            Console.WriteLine("А, разве, нет?");
        }
    }
}
