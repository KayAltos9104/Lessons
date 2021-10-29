using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public abstract class Character
    {
        protected int _hp;
        protected int  _shields;
        protected Weapon _currentWeapon;
        public string Name { get; protected set; }

        protected virtual void Attack (Character p)
        {
            p.TakeDamage(_currentWeapon.Shoot());
        }

        public virtual void TakeDamage (int damage)
        {
            if (this._shields>0)
            {
                this._shields -= damage;
            }
            else
            {
                this._hp -= damage;
            }
        }

        public virtual void Update (Character p, out string log)
        {
            Attack(p);
            log = $"{Name} атаковал {p.Name}\n";
            _shields += 10;
             log += $"{ Name} восстановил щиты до  {_shields}";
        }
    }
}
