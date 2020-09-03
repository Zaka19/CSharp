using System;

namespace EjemploDelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona human = new Persona();
            human.Nombre = "Zakariae";
            human.Edad = 20;
            human.MostrarStatsPersona = MostrarStats;
            human.Ejecutar();
        }

        public static void MostrarStats(string nombre,int edad)
        {
            Console.WriteLine("Nombre : {0} /n Edad: {1}", nombre,edad);
        }
    }
}
