using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
     class Logica : ILogica
    {
        int[,] JugadaArray1 = { { 3, -5 }, { 5, -1 } };
        int[,] JugadaArray2 = { { 3, 5 }, { -5, -1 } };

        public void LogicaJuego(Jugador jugador1, Jugador jugador2)
        {
            int precio = 0;
            precio = JugadaArray2[jugador2.Eleccion, jugador1.Eleccion];
            jugador2.Dinero += precio;
            precio = JugadaArray1[jugador2.Eleccion, jugador1.Eleccion];
            jugador1.Dinero += precio;
        }
    }
}
