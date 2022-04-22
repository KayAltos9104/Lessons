using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_2
{
    public class Circle : IModel
    {
        public float X { get ; set; }
        public float Y { get; set; }
        public float Radius { get; set ; }

        public event EventHandler<MovedEventArgs> Moved = delegate { };

        public void Init()
        {
            X = 100;
            Y = 100;
            Radius = 20;
            Moved.Invoke(this, new MovedEventArgs { X = this.X, Y = this.Y, Radius = this.Radius });
        }

        public void Move(string direction)
        {
            switch (direction)
            {
                case "right":
                    {
                        X += 10;
                        break;
                    }
                case "down":
                    {
                        Y += 10;
                        break;
                    }
                case "left":
                    {
                        X -= 10;
                        break;
                    }
                case "up":
                    {
                        Y -= 10;
                        break;
                    }
            }
            Moved.Invoke(this, new MovedEventArgs {X = this.X, Y = this.Y, Radius = this.Radius});    
        }
    }
}
