using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLive
{
    public interface IMostrar
    {
        void Mostrar(Cell[,] PreviousTable, int size);
    }
}
