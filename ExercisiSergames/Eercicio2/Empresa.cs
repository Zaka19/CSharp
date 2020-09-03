using System;
using System.Collections.Generic;
using System.Text;

namespace Eercicio2
{
    class Empresa
    {
        public delegate void DespedirContratar(Empleado nombre);
        public event DespedirContratar Despe;
        public event DespedirContratar Contrata;
        List<Empleado> Empleados = new List<Empleado>();

        public void Contratar(Empleado empleado)
        {
            Empleados.Add(empleado);
            Contrata?.Invoke(empleado);
        }

        public void Despedir(Empleado empleado)
        {
            Empleados.Remove(empleado);
            Despe?.Invoke(empleado);
        }
    }
}
