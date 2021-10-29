using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Soldier: Character
    {


        public Soldier (): base()
        {
            _hp = 200;
            _shields = 200;
            Name = "Shepard";
            _currentWeapon = new Weapon("rifle", 50, 30);
        }

        public Soldier(string name) : base()
        {
            _hp = 200;
            _shields = 200;
            Name = name;
            _currentWeapon = new Weapon("rifle", 50, 30);
        }

        public override void Update(Character p, out string log)
        {
            base.Update(p, out log);
            if (_currentWeapon.Ammo < 10)
            {
                _currentWeapon.Reload();
                log += $"{Name} перезарядил свой {_currentWeapon.Name}";
            }
            _hp += 20;
               
        }
    }
}
