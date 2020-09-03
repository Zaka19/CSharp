using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerables
{
    class Alumno
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private int _Nota;

        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }

        public Alumno(string nombre, int nota)
        {
            Nombre = nombre;
            Nota = nota;
        }
    }
}
