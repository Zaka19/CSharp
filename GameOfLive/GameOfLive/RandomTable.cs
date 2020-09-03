using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLive
{
    class RandomTable : IGame
    {
        Random rnd = new Random();
        public Cell[,] Method(Cell[,] PresentRound, int lenghtTotal)
        {
            int lenght = lenghtTotal - 2;
            for (int row = 0; row < lenghtTotal; row++)
            {
                for (int col = 0; col < lenghtTotal; col++)
                {
                    PresentRound[row, col] = new Cell(row, col, false);
                }
            }

            for (int row = 1; row <= lenght; row++)
            {
                for (int col = 1; col <= lenght; col++)
                {
                    if (rnd.Next(0, 2) == 1)
                    {
                        PresentRound[row, col].State = true;
                    }
                    else
                    {
                        PresentRound[row, col].State = false;
                    }
                }
            }
            return PresentRound;
        }
    }
}
