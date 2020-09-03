using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Juego
{
    class MovmentMonster : IMovment
    {
        public bool comprobar(int mov, int size, int x, int y,ObjectGeneric[,] Dungeon)
        {
            
            bool state = true;

            if ((mov == 1 && x == 1) || (mov == 3 && x == size) || (mov == 2 && y == 1) || (mov == 4 && y == size))
            {
                state = false;
            }
            else if ((mov == 1 && Dungeon[x - 1, y].Body == '#') || (mov == 3 && Dungeon[x + 1, y].Body == '#') || (mov == 2 && Dungeon[x, y - 1].Body == '#') || (mov == 4 && Dungeon[x, y + 1].Body == '#'))
            {
                state = false;
            }
            else if ((mov == 1 && Dungeon[x - 1, y].Body == '?') || (mov == 3 && Dungeon[x + 1, y].Body == '?') || (mov == 2 && Dungeon[x, y - 1].Body == '?') || (mov == 4 && Dungeon[x, y + 1].Body == '?'))
            {
                state = false;
            }

            return state;
        }

        public ObjectGeneric[,] Movimiento(ObjectGeneric[,] Dungeon, int x, int y, int size)
        {
            Random sc = new Random();
            int Mov = sc.Next(1,5);
            if (comprobar(Mov, size-1, x, y,Dungeon))
            {
                switch (Mov)
                {
                    case 1:
                        Dungeon[x - 1, y] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                    case 2:
                        Dungeon[x, y - 1] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                    case 3:
                        Dungeon[x + 1, y] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                    case 4:
                        Dungeon[x, y + 1] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                }
            }
            return Dungeon;
        }
    }
}
