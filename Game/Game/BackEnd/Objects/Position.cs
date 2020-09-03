using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Objects
{
    public class Position
    {
        public Position(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
