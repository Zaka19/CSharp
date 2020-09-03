
using System;

namespace CustomGenericsç
{
    class Program
    {
        public delegate void Empresa(string nombre);
        public delegate double Cambiar(double numero);
        static void Main(string[] args)
        {
            //Empresa sc = Bienvenida;
            //sc("Pasiona");
            Cambiar cb = Descuento;
            Productos pr = new Productos("Wii", 12.02);
            pr.CambiarPrecio(cb);
            Console.WriteLine(pr);
            cb = Aumento;
            pr.CambiarPrecio(cb);
            Console.WriteLine(pr);
        }

        public static void Bienvenida(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        public static double Descuento(double numero) {
           return numero - (numero * 0.1);
        }
        public static double Aumento(double numero) {
            return numero * 1.05;
        }
        public static double Rebaja(double numero) {
            return numero / 2;
        }
    }
}
