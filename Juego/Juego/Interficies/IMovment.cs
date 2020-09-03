using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    interface IMovment
    {
         ObjectGeneric[,] Movimiento(ObjectGeneric[,] Dungeon,int x, int y,int size);
    }
}
