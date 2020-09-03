using Game.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    interface IMap
    {
        Generics[,] GenerateMap(int col, int row);
        Generics[,] ModifyMap(IList<Generics> _characters, Generics[,] _map);
        void DrawMap(Generics[,] _map);
    }
}
