using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosLinQ2
{
    class Alumno
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        private double _Nota;

        public double Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }

        public Alumno(string nombre,int edad,double nota)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Edad: " + Edad + "Nota: " + Nota;
        }
    }
}
