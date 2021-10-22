using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Character
    {
        protected int _health;
        public virtual int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (_health > 100)
                    _health = 100;
                else
                    _health = value;
            }
        }
        
        public int Attack { get; private set; }
        protected int _armor;

        public Character()
        {
            Attack = 20;
            _armor = 10;
            _health = 100;
        }

        public Character(int at, int ar)
        {
            Attack = at;
            _armor = ar;
        }
                
        public virtual void TakeDamage(int damage)
        {
            _health -= (damage - _armor);            
        }

    }
}
