using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> Enteros = new List<int>()
            //{
            //    5,4,3,2,1,9,9,9
            //};

            //var res = from f in Enteros where f % 2 == 0 && f <= 20 orderby f descending select f;
            ////foreach (var a in res)
            ////{
            ////    Console.WriteLine(a);
            ////}
            //Console.WriteLine(String.Join(",", res));

            //Enteros.Add(20);

            //Console.WriteLine(String.Join(",", res));

            //var res1 = from g in Enteros group g by g;

            //foreach (var grup in res1)
            //{
            //    Console.WriteLine(String.Join(",", grup)); // Salen los que repiten
            //}

            List<Alumno> listaAlumnos = new List<Alumno>()
            {
            new Alumno("Eva",20,6.0),
            new Alumno("Ana",22,7.0),
            new Alumno("Rosa",22,4.0),
            new Alumno("Ot",20,3.0),
            new Alumno("Iu",30,6.8),
            new Alumno("Pep",32,5.9),
            new Alumno("Laia",30,2.3),
            new Alumno("Quim",32,1.7),
            };

            //1.- Alumnos que han aprobado mayores de 30 años.
            Console.WriteLine();
            Console.WriteLine("Exercisi 1");

            var ex1 = from lista in listaAlumnos
                      where lista.Nota >= 5 && lista.Edad > 30
                      select lista.Nombre;

            Console.WriteLine(String.Join("," , ex1));

            //2.- Agrupar por Aprobado/ Suspendido y mostrar la lista
            Console.WriteLine();
            Console.WriteLine("Exercisi 2");

            var ex2 = from lista2 in listaAlumnos
                      group lista2 by lista2.Nota >= 5;

            foreach (var grup in ex2)
            {
                Console.WriteLine("Alumnos " + grup.Key);
                foreach(var grup1 in grup)
                {
                    Console.WriteLine(grup1);
                }
            }

            //3.- Agrupar por la longitud del nombre ordenado de mayor a menor
            Console.WriteLine();
            Console.WriteLine("Exercisi 3");

            var ex3 = from lista3 in listaAlumnos
                      group lista3 by lista3.Nombre.Length into a
                      orderby a.Key descending
                      select a;

            foreach (var team in ex3)
            {
                Console.WriteLine("..............");
                foreach (var team1 in team)
                {
                    Console.WriteLine(team1);
                }
            }

            //4.- Agrupar por la longitud del nombre y mostrar aquellos grupos cuya suma de edades es mayor de 60
            Console.WriteLine();
            Console.WriteLine("Exercisi 4");

            var ex4 = from lista4 in listaAlumnos
                      group lista4 by lista4.Nombre.Length into a
                      where a.Sum(lista4 => lista4.Edad) > 60
                      orderby a.Key descending select a;

            foreach (var team in ex4)
            {
                Console.WriteLine("..............");
                foreach (var team1 in team)
                {
                    Console.WriteLine(team1);
                }
            }
        }
    }
}
