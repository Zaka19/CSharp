using System;
using System.Collections.Generic;
using System.Text;

namespace Eercicio2
{
    class Empleado
    {
        private string Nombre;
        public string GetSetNombre{
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }

        }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }
    }
}
