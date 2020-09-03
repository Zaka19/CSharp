using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLive
{
    public interface IGame
    {
        Cell[,] Method(Cell[,] PresentRound,int lenghtTotal);
    }
}
