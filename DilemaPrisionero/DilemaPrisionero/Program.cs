using System;
using DilemaPrisionero;
using System.Collections;
using System.Collections.Generic;

namespace DilemaPrisionero
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador pere = new Jugador("Coopera", new Coopera());
            Jugador carla = new Jugador("Descarta", new Descarta());
            Jugador pedro = new Jugador("Aleatorio", new Aleatorio());
            Juego game = new Juego(new List<Jugador> { pere, carla, pedro }, 50 , new Logica(), new Write());
            game.JuegoEmpezar();
        }
    }
}
