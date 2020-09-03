using System;
using System.Collections.Generic;
using System.Text;

namespace Aeropuerto
{
    class Vuelo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdAvion { get; set; }
        public int IdPiloto { get; set; }
        public Avion Avion { get; set; }
        public Piloto Piloto { get; set; }
    }
}
