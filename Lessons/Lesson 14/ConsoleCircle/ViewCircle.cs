using Lesson15_2;
using System;

namespace ConsoleCircle
{
    internal class ViewCircle : IView
    {
        public event EventHandler Initialized = delegate { };
        public event EventHandler<DirectionEventArgs> DirectionChanged = delegate { };
        public void Render(float X, float Y, float Radius)
        {
            int[,] array = new int[20, 20];
            array[(int)X / 10, (int)Y / 10] = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void OnInit()
        {
            Initialized.Invoke(this, EventArgs.Empty);            
        }
    }
}
