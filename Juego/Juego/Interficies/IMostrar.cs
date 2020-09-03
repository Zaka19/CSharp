using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    interface IMostrar
    {
        void VisualizarDungeon(ObjectGeneric[,] Dungeon,int size);
        void VisualizarBatalla(List<Monsters> Monstruos, Heroe heroe);
        void Batalla(List<Monsters> Monstruos, Heroe heroe);
    }
}
