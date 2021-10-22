using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Character c = new Character();
            int t = c.Health;

            Archer arch = new Archer(10,10,11);
            arch.TakeDamage(15);
        }
    }
}

