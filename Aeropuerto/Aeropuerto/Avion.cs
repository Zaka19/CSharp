using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    class Avion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set;}
        public string Autonomia { get; set; }
        public List<Vuelo> Vuelos { get; set; }
    }
}
