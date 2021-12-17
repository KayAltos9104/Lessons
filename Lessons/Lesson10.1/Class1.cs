using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._1
{
    class Class1
    {
        public delegate void EventHandlerCustom();
        public event EventHandlerCustom CustomEvent;
        
        public Class1()
        {         

            
        }
        public void ClickEvent()
        {
            CustomEvent.Invoke();
        }
    }
}
