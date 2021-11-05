using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static Random rnd = new Random();
        static int[,] field;
        static int pushNum = 0;
        static void Main()
        {
            field = new int[20, 20];
            Gladiator g = new Gladiator(field);
            List<Gladiator> gList = new List<Gladiator>();

            for (int i = 0; i < 3; i++)
            {
                Gladiator newG = new Gladiator(field, rnd.Next(5, 15), rnd.Next(5, 15));
                gList.Add(newG);
            }

            for (int i = 0; i < 2; i++)
            {
                Archer newG = new Archer(field, rnd.Next(5, 15), rnd.Next(5, 15));
                gList.Add(newG);
            }
            Update();
            while (true)
            {
                ConsoleKeyInfo push = Console.ReadKey();                
                pushNum++;
                g.Move(push.Key);

                foreach (var glad in gList)
                {
                    int dir = rnd.Next(0, 4);
                    switch (dir)
                    {
                        case 0:
                            {
                                glad.Move(ConsoleKey.RightArrow);
                                break;
                            }
                        case 1:
                            {
                                glad.Move(ConsoleKey.DownArrow);
                                break;
                            }
                        case 2:
                            {
                                glad.Move(ConsoleKey.LeftArrow);
                                break;
                            }
                        case 3:
                            {
                                glad.Move(ConsoleKey.UpArrow);
                                break;
                            }
                    }
                }

                Update();
            }
            Console.ReadKey();

        }

        static void Update ()
        {
            Draw();            
        }

        static int T()
        {
            return 20;
        }

        static void Draw()
        {
            Console.Clear();
            for (int j = 0; j < field.GetLength(1); j++)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    if (field[i,j]==1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (field[i, j] == 2)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(field[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }  

    class Gladiator
    {
        int _health;
        int _damage;
        int _x;
        int _y;

        protected int visType = 1;

        int[,] _field;


        public Gladiator (int [,] field)
        {
            _field = field;
           
            _health = 100;
            _damage = 50;
            _x = 10;
            _y = 10;
            _field[_x, _y] = visType;
        }

        public Gladiator (int[,] field, int x, int y)
        {
            _field = field;

            _health = 100;
            _damage = 50;
            _x = x;
            _y = y;
            _field[_x, _y] = visType;
        }

        public void GetCoord (out int x, out int y)
        {
            x = _x;
            y = _y;
        }



        public void Move (ConsoleKey direction)
        {
            _field[_x, _y] = 0;
            switch (direction)
            {
                case ConsoleKey.RightArrow:
                    {
                        _x += 1;
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        _y += 1;
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        _x -= 1;
                        break;
                    }
                case ConsoleKey.UpArrow:
                    {
                        _y -= 1;
                        break;
                    }
            }
            _field[_x, _y] = visType;
        }
    }

    class Archer:Gladiator
    {
        public Archer (int[,] field, int x, int y) : base (field, x, y)
        {
            visType = 2;
        }
    }
}

