using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemplosLinQ2
{
    class Program
    {
        static void Main(string[] args)
        {
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

            List<int> Enteros = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
            };

            var res = Enteros.Where(s => s.esPrimo());
            var res1 = Enteros.Where(s => s.esPar());
            Console.WriteLine(String.Join(",", res));
            Console.WriteLine(String.Join(",", res1));
            Console.WriteLine(Enteros.Sum());
            Console.WriteLine(Enteros.Max());
            Console.WriteLine(res.Sum());
            Console.WriteLine(res.Max());

            var agrupar = from lista in listaAlumnos where lista.Edad > 30 select lista.Edad;
        }
    }
}
