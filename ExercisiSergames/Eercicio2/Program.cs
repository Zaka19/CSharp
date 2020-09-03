using System;

namespace Eercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado sc = new Empleado("Zaka");
            Empleado sc1 = new Empleado("Norden");
            Administracion ad = new Administracion();
            Empresa sa = new Empresa();

            sa.Contrata += ad.Alta;
            sa.Contratar(sc);
            sa.Contratar(sc1);

            sa.Despe += ad.Baja;
            sa.Despedir(sc);
        }
        public static void avisar(Empleado msg)
        {
            Console.WriteLine(msg.GetSetNombre);
        }
    }
}
