using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class GameCycle : IModel
    {
        public event EventHandler<ModelUpdatedEventArgs> Updated = delegate { };

        Character _player;

        List<Character> _enemies = new List<Character>();

        List<Bullet> bullets = new List<Bullet>();

        public GameCycle()
        {
            _player = new Character((100,100));
            Character enemy = new Character((300, 300));
            _enemies.Add(enemy);
        }

        public void Update()
        {
            _player.Move();
            foreach (var b in bullets)
            {
                foreach (var e in _enemies)
                {
                    if (Collider2D.IsCollided(b.Collider, e.Collider))
                    {
                        b.direction = (0, 0);
                    }
                }
                b.Move();
            }
                
            foreach (var e in _enemies)
                e.Move();
           
            Updated.Invoke(this, new ModelUpdatedEventArgs() { Pos = _player.Pos, bullets = this.bullets, enemies = _enemies });
        }  
        public void UpdateCharacter((float x, float y) newPos)
        {
            float xDir = newPos.x - _player.Pos.X;
            float yDir = newPos.y - _player.Pos.Y;

            float module = (float)Math.Sqrt(xDir * xDir + yDir * yDir);
            xDir = xDir / module;
            yDir = yDir / module;

            _player.direction = (xDir, yDir);
            
        }

        public void Shoot((float x, float y) newPos)
        {
            float xDir = newPos.x - _player.Pos.X;
            float yDir = newPos.y - _player.Pos.Y;

            float module = (float)Math.Sqrt(xDir * xDir + yDir * yDir);
            xDir = xDir / module;
            yDir = yDir / module;

            Bullet b = new Bullet((_player.Pos.X+15,_player.Pos.Y+15 ));
            b.direction = (xDir, yDir);
            bullets.Add(b);
        }
    }
}
