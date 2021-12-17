using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._91
{
    abstract class CellularAutomata
    {
        public CellType[,] field;

        public abstract void InitialConfigGen();
        public abstract void TransitionRule();

        public List<CellType> NeighborsCalc(int xCenter, int yCenter)
        {
            List<CellType> neighbors = new List<CellType>();
            for (int y = yCenter - 1; y <=yCenter + 1; y++)
                for (int x = xCenter - 1; x<= xCenter + 1; x++)
                {
                    if (x == xCenter && y == yCenter)
                        continue;
                    else if (y>0&&x>0&&y<field.GetLength(1)&& x < field.GetLength(0))
                    {
                        neighbors.Add(field[x, y]);
                    }
                    else
                    {
                        neighbors.Add(CellType.dead);
                    }
                }
            return neighbors;
        }

        public enum CellType: int
        {
            dead = 0,
            live = 1
        }
    }
}
