using System;
using System.Collections.Generic;

namespace Lesson10
{
    class Program
    {
        delegate void EmptyMethod();
        delegate int MathAct(int a, int b);
        
        static void Main()
        {
            int cursor = 1;
            EmptyMethod del1;
            MathAct del2;
            del2 = Method3;
            Console.WriteLine(del2(5, 5));
            Dictionary<int, EmptyMethod> actions = new Dictionary<int, EmptyMethod>();
            actions.Add(1, Method1);
            actions.Add(2, Method2);
            del1 = actions[cursor];
            while (true)
            {
                
                var key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            cursor--;                            
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            cursor++;
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            del1();
                            break;
                        }
                }
                del1 = actions[cursor];
            }
            //del1 = Method1;
            //del1();
            //del1 = Method2;
            //del1();

            //del1 = Method1;
            //del1 += Method2;
            //del1 += Method1;
            ////del1();
            //Method3(del1);
            //List<Animal> aList = new List<Animal>();
            //foreach (var an in aList)
            //{
            //    an.Eat();
            //    an.Move();
            //    an.Breed();
            //    if (an is ISwimable)
            //    {
            //        var a = (ISwimable)an;
            //        a.Swim();
            //    }               
            //}
        }
        static void Action(EmptyMethod d)
        {
            d();
        }
        static void Method1()
        {
            Console.WriteLine("Я лучший!");
        }
        static void Method2()
        {
            Console.WriteLine("Нет, я!");
        }

        static int Method3(int a, int b)
        {
            return a + b;
        }
    }    
}
