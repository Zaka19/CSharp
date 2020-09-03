using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DilemaPrisionero;

namespace DilemaPrisionero
{
    class Juego 
    {
       private List<Jugador> Jugadores;
        private int Rondas;
        ILogica Llogica;
        IMostrar Mostrar;
        public Juego(List<Jugador> jugadores,int rondas,ILogica logica,IMostrar mostrar)
        {
            Jugadores = jugadores;
            Rondas = rondas;
            Llogica = logica;
            Mostrar = mostrar;
        }

        public void JuegoEmpezar()
        {
            for(int ronda = 0; ronda < Rondas; ronda++)
            {
                for (int a = 0; a < Jugadores.Count - 1; a++)
                {
                    for (int b = a + 1; b < Jugadores.Count; b++)
                    {
                        Jugadores[a].Eleccio();
                        Jugadores[b].Eleccio();
                        Llogica.LogicaJuego((Jugador)Jugadores[a], (Jugador)Jugadores[b]);
                        Mostrar.Mostrar(ronda + 1, (Jugador)Jugadores[a], (Jugador)Jugadores[b]);
                    }
                }
            }
         Mostrar.MostrarFinal(Jugadores);  
        }
    }
}
