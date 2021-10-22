using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Archer : Character
    {
        int _range;

        public override int Health 
        { 
            get => base.Health; 
            set
            {
                if (value < 0)
                    _health = 0;
                else if (_health > 75)
                    _health = 75;
                else
                    _health = value;
            }
        }
        public Archer():base()
        {
            //Health = 75;
            //_range = 10;           
        }

        public Archer(int at, int ar, int range) : base(at, ar)
        {
            _range = range;
        }

        public override void TakeDamage(int damage)
        {           
            Health += 10;
        }
    }
}
