using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._91
{
    class CA_GameOfLife:CellularAutomata
    {
        Random rnd = new Random();

        public CA_GameOfLife()
        {
            InitialConfigGen();
        }

        public override void InitialConfigGen()
        {
            field = new CellType[20, 20];
            for (int y = 0; y < field.GetLength(1); y++)
                for (int x = 0; x < field.GetLength(0); x++)
                {
                    //field[x, y] = (CellType)rnd.Next(0, 2);

                    field[5, 4] = CellType.live; 
                    field[5, 5] = CellType.live;                   
                    field[5, 6] = CellType.live;                    
                }
        }

        public override void TransitionRule()
        {
            CellType[,] bufField = new CellType[field.GetLength(0), field.GetLength(1)];            

            for (int y = 0; y < field.GetLength(1); y++)
                for (int x = 0; x < field.GetLength(0); x++)
                {
                    int live = 0;
                    var n = NeighborsCalc(x,y);
                    foreach (var state in n)
                    {
                        if (state == CellType.live)
                            live++;
                    }
                    if (live == 3)
                        bufField[x, y] = CellType.live;
                    else if (live < 2 || live > 3)
                        bufField[x, y] = CellType.dead;
                    else if (live == 2)
                        bufField[x, y] = field[x, y];
                }
            for (int y = 0; y < field.GetLength(1); y++)
                for (int x = 0; x < field.GetLength(0); x++)
                {
                    field[x, y] = bufField[x, y];
                }
        }

    }
}
