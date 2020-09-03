using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    class Heroe : ObjectGeneric
    {
        public Heroe() { }
        public Heroe(string name, int life, char body)
        {
            Name = name;
            Life = life;
            Body = body;
            //PosicionObjecto.x = x;
            //PosicionObjecto.y = y;
        }
        public override string ToString()
        {
            return "Life: " + Life + " ";
        }
    }
}
