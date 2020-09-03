using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerables
{
    class Aula : IEnumerable<Alumno>
    {
        private List<Alumno> lista = new List<Alumno>();
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private int _Capacidad;

        public int Capacidad
        {
            get { return _Capacidad; }
            set { _Capacidad = value; }
        }

        public void Matricular(Alumno chicoIa)
        {
            if(lista.Count + 1 <= this.Capacidad)
            {
                lista.Add(chicoIa);
            }
            else
            {
                throw new Exception("Has superado la capacidad.");
            }
        }

        public void Expulsar(Alumno chicoIa)
        {
            lista.Remove(chicoIa);
        }

        public IEnumerator<Alumno> GetEnumerator()
        {
            return ((IEnumerable<Alumno>)lista).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Alumno>)lista).GetEnumerator();
        }

        public Alumno this[int index]
        {
            get { return lista[index]; }
            set { /*lista.Insert(index, value);*/ lista[index] = value; }
        }

       

        public static Aula operator +(Aula Aula1, Alumno alumno)
        {
            Aula1.Matricular(alumno);
            return Aula1; 
        }

        public static Aula operator +(Aula Aula1, Aula Aula2)
        {
            if (Aula2.lista.Count + Aula1.lista.Count < Aula1.Capacidad)
            {
                foreach (Alumno alumno in Aula2)
                {
                    Aula1.Matricular(alumno);
                }
            }
            return Aula1;
        }


    }
}
