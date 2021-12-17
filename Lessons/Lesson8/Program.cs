using System;
using System.Collections.Generic;

namespace Lesson8
{
    class Program
    {
        static void Main()
        {
            Person p = new Person();
            Person p2 = new Person();
            Person p3 = (Person)p.Clone();
            p3.Name = "Artem";
            if (p2==p)
            {
                Console.WriteLine(p2+p);            
            }
            
            //string s = "Igor Lebedev KTN";
            //string input = Console.ReadLine();

            //var array = new List<int> { 1, 2, 999, 480, 1991 };

            //string name = input.Substring(0, 4);
            //name = "Artem";
            //string surname = input.Substring(4);

            //input = input.Remove(4);

            //input = input.ToLower();
            //do
            //{
            //    switch (input)
            //    {                    
            //        case "write":
            //            {
            //                Console.WriteLine("Игорь молодец");
            //                break;
            //            }
            //    }
            //    input = Console.ReadLine();
            //    input = input.ToLower();
            //} while (input != "exit");
        }
    }
}
