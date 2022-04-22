using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_2
{
    public interface IView
    {
        event EventHandler Initialized;
        event EventHandler<DirectionEventArgs> DirectionChanged;
        void Render(float X, float Y, float Radius);
    }

    public class DirectionEventArgs: EventArgs
    {
        string Direction { set; get;}
    }
}
