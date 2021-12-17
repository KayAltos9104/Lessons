using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    abstract class Animal
    {
        protected int _speed;
        int _health;
        int _activity;

        public Animal ()
        {
            _speed = 1;
            _health = 100;
            _activity = 50;            
        }        
        public Animal (int health)
        {
            _speed = 1;
            _health = health;
            _activity = 50;
        }        

        public abstract void Move();
        public abstract void Breed();

        public virtual void Eat()
        {
            Console.WriteLine("Плохо покушали");
        }
    }
}
