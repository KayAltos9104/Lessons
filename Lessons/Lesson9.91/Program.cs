using System;

namespace Lesson9._91
{
    class Program
    {
        static void Main()
        {
            CellularAutomata CA = new CA_GameOfLife();
            Render(CA.field);
            Console.ReadKey();
            while (true)
            {
                CA.TransitionRule();
                Render(CA.field);
                Console.ReadKey();
            }
        }

        static void Render(CellularAutomata.CellType[,] field)
        {
            Console.Clear();
            for (int y = 0; y < field.GetLength(1); y++)
            {
                for (int x = 0; x < field.GetLength(0); x++)
                {
                    switch (field[x, y])
                    {
                        case CellularAutomata.CellType.dead:
                            {
                                Console.ResetColor();
                                Console.Write("D");
                                break;
                            }
                        case CellularAutomata.CellType.live:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("L");
                                break;
                            }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
