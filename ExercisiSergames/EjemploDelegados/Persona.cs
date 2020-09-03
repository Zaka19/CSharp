using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploDelegados
{
    class Persona
    {
        private string _Nombre;
        private int _Edad;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        public delegate void Mostrar (string nombre, int edad);
        public Mostrar MostrarStatsPersona;
        
        public void Ejecutar()
        {
            MostrarStatsPersona(Nombre, Edad);
        }
    }
}
