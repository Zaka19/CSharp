using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    interface IMostrar
    {
        void Mostrar(int ronda,Jugador jugador1, Jugador jugador2);
        void MostrarFinal(List<Jugador> Jugadores);
    }
}
