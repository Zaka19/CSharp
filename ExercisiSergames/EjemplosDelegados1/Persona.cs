using System;
using System.Collections.Generic;
using System.Text;

namespace EjemplosDelegados1
{
    class Persona
    {
        //Creamos las propiedades que tendra nuestro objecto Persona
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

        //Creamos el Delegado con su firma
        public delegate void Mostrar(string nombre, int edad);

        //Creamos la variable del tipo del delegado
        public Mostrar MostrarStatsPersona;

        //Este metodo se encargara de ejecutar el metodo que le pasemos des de Program
        public void Ejecutar()
        {
            MostrarStatsPersona(Nombre, Edad);
        }

        //Con esta manera no nos hace falta crear la variable de tipo delegado
        public void Ejecutar(Mostrar m, string nombre, int edad)
        {
            m(nombre, edad);
        }
        //Metodos
        public void MostrarStatsCompletas(string nombre, int edad)
        {
            Console.WriteLine("Nombre: {0} \nEdad: {1}", nombre, edad);
        }

        public void MostrarStatsEdad(string nombre, int edad)
        {
            Console.WriteLine("Edad: {0}", edad);
        }

        public void MostrarStatsNombre(string nombre, int edad)
        {
            Console.WriteLine("Nombre: {0}", nombre);
        }

        //Metodo que se encarga de meter a los otros metodos dentro de la variable de tip delegado
        public void AñadirMetodo(Mostrar m)
        {
            MostrarStatsPersona += m;
        }
    }
}
