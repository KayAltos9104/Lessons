using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class KroganMerc:Character
    {
        private int _armor;
        public KroganMerc(): base()
        {
            _hp = 400;
            _shields = 100;
            _armor = 200;
            Name = "Wrex";
            _currentWeapon = new Weapon("shotgun", 6, 120);
        }
        protected override void Attack(Character p)
        {
            base.Attack(p);
            p.TakeDamage(_currentWeapon.Shoot());
        }

        public override void TakeDamage(int damage)
        {
            if (_shields > 0)
            {
                _shields -= 2*damage;
            }
            else if (_armor > 0)
            {
                _armor -= damage;
            }
            else
            {
                _hp -= 2*damage;
            }
        }
        public override void Update(Character p, out string log)
        {
            base.Update(p, out log);
            if (_currentWeapon.Ammo < 1)
            {
                _currentWeapon.Reload();
                log += $"{Name} перезарядил свой {_currentWeapon.Name}";
            }
               
        }
    }
}
