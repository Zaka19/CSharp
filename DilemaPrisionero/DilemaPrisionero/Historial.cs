using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    class Historial 
    {
        static int[,] Story;

        public static void StoryAdd(List<Jugador> Jugadores,int rondas)
        {
            Story = new int[Jugadores.Count, Jugadores.Count];
            for(int ordre = 0; ordre < Jugadores.Count; ordre++)
            {
                Story[rondas,ordre] = Jugadores[ordre].Eleccion;
            }
        }

        public static int ComprobarJugada(int pisicionJugador)
        {
            int triada = 0;

            return triada;
        }
    }
}
