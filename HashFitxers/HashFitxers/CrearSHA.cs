using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HashFitxers
{
    class CrearSHA
    {
        public void Main(string entrada, string fitxer)
        {
            LlegirHASH lh = new LlegirHASH();

            string path = fitxer+".sha";

            string codeHash = lh.Read(entrada);

            if(codeHash.Equals("Falla lectura") || codeHash.Equals("Fitxer buit"))
            {
                Console.WriteLine(codeHash);
            }
            else
            {
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    File.WriteAllText(Path.GetFullPath(path), codeHash);
                }
                else
                {
                    Console.WriteLine("Ruta incorrecta o fitxer creat.");
                    Console.ReadKey();
                }
            }
        }
    }
}
