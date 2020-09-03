using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    class Piloto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Sueldo { get; set; }
        public List<Vuelo> Vuelos { get; set; }
    }
}
