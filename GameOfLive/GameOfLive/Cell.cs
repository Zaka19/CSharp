using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLive
{
   public class Cell
    {
        public bool State { get; set; }
        /*
        public int Col { get; set; }
        public int Row { get; set; }
        */

        public Cell(int row, int col, bool state)
        {
            /*
            Row = row;
            Col = col;
            */
            State = state;
        }
    }
}
