using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public interface IModel
    {
        event EventHandler<ModelUpdatedEventArgs> Updated;
        void UpdateCharacter((float x, float y) newPos);

        void Shoot((float x, float y) newPos);
        void Update();
    }

    public class ModelUpdatedEventArgs
    {
        public (float x, float y) Pos { get; set; }
        public List<Bullet> bullets { get; set; }
        public List<Character> enemies { get; set; }
    }
}
