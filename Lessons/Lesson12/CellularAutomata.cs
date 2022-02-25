using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    abstract class CellularAutomata
    {
        protected Cell[,] _field;
        public CellularAutomata (int len, int wid)
        {            
            _field = new Cell [len, wid];
            for (int x = 0; x < _field.GetLength(0); x++)
                for (int y = 0; y < _field.GetLength(0); y++)
                {
                    _field[x, y] = new Cell();
                }
        }

        public abstract void InitGen();
        public abstract void TransitionRule();
        
        public Cell [,] GetField()
        {
            //return (Cell[,])_field.Clone();
            return _field;
        }

        public enum StateList
        {
            empty = 0
        }

    }
}
