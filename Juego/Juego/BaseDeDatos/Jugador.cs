using System;
using System.Collections.Generic;
using System.Text;

namespace Juego.BaseDeDatos
{
    class Jugador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Puntuacion { get; set; }
    }
}
