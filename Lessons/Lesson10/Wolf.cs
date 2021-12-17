using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Wolf:Animal
    {
        public Wolf():base()
        {
            _speed = 2;
        }

        public Wolf(int health):base(health)
        {

        }
        public Wolf(bool live): this()
        {
            Console.WriteLine("Привет!");
        }
        public override void Move()
        {
            Console.WriteLine("Волк походил");
        }
        public override void Breed()
        {
            Console.WriteLine("Волк размножился");
        }
       
    }
}
