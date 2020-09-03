using System;
using System.Collections.Generic;
using EjemplosDelegados1;

namespace EjemplosDelegados1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Persona human = new Persona();
            human.Nombre = "Zakariae";
            human.Edad = 20;
            human.MostrarStatsPersona = human.MostrarStatsEdad;
            human.Ejecutar();

            human.Ejecutar(human.MostrarStatsEdad, "Zakariae", 20);

            human.AñadirMetodo(human.MostrarStatsCompletas);
            human.AñadirMetodo(human.MostrarStatsNombre);
            human.AñadirMetodo(human.MostrarStatsEdad);
            human.MostrarStatsPersona("Zakariae", 20);
        }

        public static void Hola(string nombre , int edad)
        {
            Console.WriteLine("Hola {0}", nombre);
        }
    }
}

