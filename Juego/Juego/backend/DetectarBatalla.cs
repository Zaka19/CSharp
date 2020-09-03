using System;
using System.Collections.Generic;
using System.Text;

namespace Juego.backend
{
    class DetectarBatalla
    {
        public bool Detectar(int x, int y,ObjectGeneric[,] Dungeon)
        {
            bool state = false;

            for(int a = x - 1; a <= x + 1; a++)
            {
                for(int b = y - 1; b <= y + 1; b++)
                {
                    if(Dungeon[a,b].Body == '?')
                    {
                        state = true;
                    }
                }
            }

            return state;
        }

        public List<Monsters> DetectarNumMonsters(int x, int y, ObjectGeneric[,] Dungeon)
        {
            List<Monsters> Monstruos = new List<Monsters>();

            for (int a = x - 1; a <= x + 1; a++)
            {
                for (int b = y - 1; b <= y + 1; b++)
                {
                    if (Dungeon[a, b].Body == '?')
                    {
                        Monstruos.Add((Monsters)Dungeon[a, b]); 
                    }
                }
            }

            return Monstruos;
        }
    }
}
