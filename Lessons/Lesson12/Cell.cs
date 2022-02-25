using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Cell
    {
        public int State { get; private set; }           

        public Cell ()
        {
            State = 0;
        }

        public void SetState (int s)
        {
            State = s;
        }        
    }
}
