using System;

namespace ExercisiSergames
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente cc = new CuentaCorriente();
            cc.Nombre = "Zaka";
            cc.Saldo = 1000;
            cc.listaAlertas = Aviso;
            cc.Saldo = 1500;
            cc.Ejecutar();
        }

        public static void Aviso(string aviso)
        {
            Console.WriteLine(aviso);
        }
    }
}
