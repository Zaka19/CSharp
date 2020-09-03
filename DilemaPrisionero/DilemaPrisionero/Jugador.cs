using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
     class Jugador
    {
        public string Nombre { get; set; }
        public int Eleccion { get; set; }
        public int Dinero = 0;
        IEstrategia _iestrategia;
        public Jugador(string nombre,IEstrategia Iestrategia)
        {
            Nombre = nombre;
            _iestrategia = Iestrategia;
        }

        public void Eleccio()
        {
            Eleccion = _iestrategia.DevuelveAccion();
        }
    }
}
