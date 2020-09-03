using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Juego
{
    public class MovmentHeroe : IMovment
    {

        public ObjectGeneric[,] Movimiento(ObjectGeneric[,] Dungeon, int x, int y,int size)
        {
            char Mov = Console.ReadKey().KeyChar;
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Mov = ti.ToUpper(Mov);

            if (comprobar(Mov, size-1, x, y,Dungeon))
            {
                switch (Mov)
                {
                    case 'W':
                        Dungeon[x - 1, y] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                    case 'A':
                        Dungeon[x, y - 1] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                    case 'S':
                        Dungeon[x + 1, y] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                    case 'D':
                        Dungeon[x, y + 1] = Dungeon[x, y];
                        Dungeon[x, y] = new ObjectsNulls(' ');
                        break;
                }
            }
                return Dungeon;
        }
        public bool comprobar(char mov, int size,int x, int y, ObjectGeneric[,] Dungeon)
        {
            bool state = true;

            if((mov == 'W' && x == 1) || (mov == 'S' && x == size) || (mov == 'A' && y == 1) || (mov == 'D' && y == size))
            {
                state = false;
            }
            else if ((mov == 'W' && Dungeon[x - 1,y].Body == '?') || (mov == 'S' && Dungeon[x + 1, y].Body == '?') || (mov == 'A' && Dungeon[x, y - 1].Body == '?') || (mov == 'D' && Dungeon[x, y + 1].Body == '?'))
            {
                state = false;
            }
            return state;
        }
    }
}
