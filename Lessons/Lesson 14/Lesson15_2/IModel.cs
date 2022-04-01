using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_2
{
    public interface IModel
    {
        float X { get; set; }
        float Y { get; set; }
        float Radius { get; set;}

        void Init ();
        void Move(string direction);
        event EventHandler<MovedEventArgs> Moved;
    }

    public class MovedEventArgs
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; set; }
    }
}
