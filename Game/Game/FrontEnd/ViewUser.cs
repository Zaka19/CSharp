using Game.Interfaces;
using Game.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using Game.Objects;

namespace Game.FrontEnd
{
    class ViewUser : IMap
    {

        public void DrawMap(Generics[,] _map)
        {
            int a;
            int b;

            for (a = 0; a < Math.Sqrt(_map.Length); a++)
            {

                for(b = 0; b < Math.Sqrt(_map.Length); b++)
                {
                    Console.Write(_map[a, b].Body);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public Generics[,] GenerateMap(int col, int row)
        {
            int a;
            int b;

            Generics[,] Map = new Generics[col, row];

            Random rnd = new Random();

            //Num random to create start
            //int NumStart = rnd.Next(row);

            for (a = 0; a < row; a++)
            {
                //Map[a, b] = NumStart == a ? "   " : " # ";

                for(b = 0; b < col; b++)
                {
                    if ((a == 0 || b == 0 || a == col - 1) && Map[a, b] == null)
                    {
                        Map[a, b] = new Weapons(" # ");
                    }
                    else
                    {
                        //Map[a, b] = b % 2 == 0 && a % 2 == 0 && a != col - 2 && b != col - 2 ? " ╬ " : "   ";
                        Map[a, b] = new Weapons("   ");
                    }
                }

                b--;
                Map[a, b] = new Weapons(" # ");
            }

            return Map;
        }

        public Generics[,] ModifyMap(IList<Generics> _characters, Generics[,] _map)
        {
            foreach(Generics _generic in _characters)
            {
                _map[_generic.Position.X, _generic.Position.Y] = _generic;
            }

            return _map;
        }
    }
}
