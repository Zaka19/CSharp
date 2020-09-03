using System;
using System.Collections.Generic;
using System.Text;

namespace Eercicio2
{
    class Administracion
    {
        public void Alta(Empleado empleado)
        {
            Console.WriteLine(empleado.GetSetNombre + " estas dado de alta.");  
        }
        public void Baja(Empleado empleado)
        {
            Console.WriteLine( empleado.GetSetNombre + " estas dado de baja.");
        }
    }
}
