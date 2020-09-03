using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HashFitxers
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarInfoHash mih = new MostrarInfoHash();
            CrearSHA cs = new CrearSHA();
            CompararHash ch = new CompararHash();

            string opcio = "";

            do
            {

                Console.WriteLine("A.Leer archivo y codificar-lo");
                Console.WriteLine("B.Crear archivo .sha con el codigo hash. (Guardado en C:\\Users\\USER\\source\\repos\\HashFitxers\\HashFitxers\\bin\\Debug\\netcoreapp3.0)");
                Console.WriteLine("C.Comparar archivo .sha con codigo hash.");
                Console.WriteLine("D.Salir.");
                Console.WriteLine("Elegeix una opcio: ");
                opcio = Console.ReadLine();
                opcio = opcio.ToUpper();

                switch (opcio)
                {
                    case "A":
                        mih.Main("test");
                        break;
                    case "B":
                        cs.Main("test", "codeToTest");
                        break;
                    case "C":
                        ch.Main("test", "codeToTest");
                        break;
                }
            } while (!opcio.Equals("D"));
        }
    }
}
