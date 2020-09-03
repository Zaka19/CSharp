using System;
using System.Collections.Generic;
using System.Text;

namespace Juego.BaseDeDatos
{
    class IntroduceDatos
    {
        public void PedirDatos()
        {
            Jugador Player = new Jugador();
            Console.Write("Introduce tu nombre; ");
            Player.Nombre = Console.ReadLine();
            Player.Fecha = DateTime.Now;
        }

        public void AñadirBDD(int puntos,Jugador Player)
        {
            using (var contexto = new Context())
            {
                Player.Puntuacion = puntos;
                contexto.Jugadores.Add(Player);
                contexto.SaveChanges();
            }
        }
    }
}
