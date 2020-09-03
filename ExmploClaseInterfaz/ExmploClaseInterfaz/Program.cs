using System;

namespace ExmploClaseInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {/*
            IGirar[] girar = { new Vehiculo(), new Torreta() };
            foreach(IGirar giro in girar)
            {
                Console.WriteLine(giro.GirarHaciaDerecha() + " " + giro.GirarHaciaIzquierda());
            }
            */
            Torreta tor = new Torreta();
            tor.GirarHaciaIzquierda();
            tor.Mostrar();
        }
    }
}
