using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Weapon
    {
        private int _damage;
        private int _maxAmmo;
        private int _ammo;
        public string Name { get; }


        public Weapon (string name, int ammo, int damage)
        {
            _damage = damage;
            _maxAmmo = ammo;
            _ammo = _maxAmmo;
            Name = name;
        }

        public int Shoot()
        {
            if (_ammo > 0)
            {
                _ammo--;
                return _damage;
            }
            else
            {
                return 0;
            }
        }

        public void Reload()
        {
            _ammo = _maxAmmo;
        }

        public int Ammo
        {
            get
            {
                return _ammo;
            }
        }
    }
}
