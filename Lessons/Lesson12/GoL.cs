using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;

namespace Lesson12
{
    class GoL : CellularAutomata
    {
        Random rnd = new Random();
        protected Cell[,] _fieldBuffer;
        public GoL (int len, int wid) :base(len, wid)
        {
            _fieldBuffer = new Cell[len, wid];
            for (int x = 0; x < _fieldBuffer.GetLength(0); x++)
                for (int y = 0; y < _fieldBuffer.GetLength(0); y++)
                {
                    _fieldBuffer[x, y] = new Cell();
                }
        }

        public override void InitGen()
        {
            for (int x = 1; x < _field.GetLength(0)-1; x++)
                for (int y = 1; y < _field.GetLength(0)-1; y++)
                {
                    int live = rnd.Next(0, 2);
                    if (live == 1)
                    {
                        _field[x, y].SetState((int)StateList.alive);
                    }
                    else
                    {
                        _field[x, y].SetState((int)StateList.dead);
                    }                    
                }
        }

        public override void TransitionRule()
        {
             
            
            for (int x = 0; x < _fieldBuffer.GetLength(0); x++)
                for (int y = 0; y < _fieldBuffer.GetLength(0); y++)
                {
                    _fieldBuffer[x, y] = new Cell();
                }

            for (int x = 1; x < _field.GetLength(0)-1; x++)
                for (int y = 1; y < _field.GetLength(0)-1; y++)
                {
                    int live_counter = 0;

                    for (int xN = x-1; xN <= x + 1; xN++)
                        for (int yN = y-1; yN <= y+1; yN++)
                        {
                            if (xN == x && yN == y)
                                continue;
                            if (_field[xN, yN].State == (int)StateList.alive)
                                live_counter++;
                        }

                    if (live_counter==3)
                    {
                        _fieldBuffer[x, y].SetState((int)StateList.alive);
                    }
                    else if (live_counter > 3|| live_counter <2)
                    {
                        _fieldBuffer[x, y].SetState((int)StateList.dead);
                    }
                    else
                    {
                        _fieldBuffer[x, y].SetState((int)_field[x, y].State);
                    }
                }
            for (int x = 1; x < _field.GetLength(0) - 1; x++)
                for (int y = 1; y < _field.GetLength(0) - 1; y++)
                {
                    _field[x, y].SetState(_fieldBuffer[x, y].State);
                }
        }

        public new enum StateList
        {
            dead = 0,
            alive = 1
        }
    }
}
