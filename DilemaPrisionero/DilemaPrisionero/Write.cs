using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DilemaPrisionero
{
    class Write : IMostrar
    {
        public void Mostrar(int ronda,Jugador jugador1, Jugador jugador2)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                      RONDA " + ronda + "           ");
            Console.WriteLine(jugador1.Nombre + " = " + jugador1.Eleccion + ":" + jugador2.Nombre + " = " + jugador2.Eleccion);
            Console.WriteLine("DINERO :");
            Console.WriteLine(jugador1.Nombre + " = " + jugador1.Dinero + ":" + jugador2.Nombre + " = " + jugador2.Dinero);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("SCORE: ");
        }

        public void MostrarFinal(List<Jugador> Jugadores)
        {
            Jugadores = Jugadores.OrderByDescending(o => o.Dinero).ToList();
            foreach (Jugador jugador in Jugadores)
            {
                Console.WriteLine(jugador.Nombre + " = " + jugador.Dinero);
            }
            
        }
    }
}
