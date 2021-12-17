using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._1
{
    class Student
    {
        public delegate void EventHandlerCustom();
        public event EventHandlerCustom Dead;
        int _health = 2;

        public void Update()
        {
            _health--;
            if (_health <= 0)
                ClickEvent();
        }

        private void ClickEvent()
        {
            Dead.Invoke();
        }
    }
}
