using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public interface IView
    {
        event EventHandler<CharacterEventArgs> CharacterUpdated;
        event EventHandler<ShootEventArgs> Shooted;
        event EventHandler OnUpdateModel;
        void Draw((float x, float y) pos, List<Bullet> bullets, List<Character> enemies);
        void Show();
    }

    public class ShootEventArgs
    {
        public (float x, float y) Position { get; set; }
    }

    public class CharacterEventArgs:EventArgs
    {
        public (float x, float y) Position {get;set;}
    }
}
