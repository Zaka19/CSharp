using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HashFitxers
{
    class MostrarInfoHash
    {
        public void Main(string entrada)
        {
            LlegirHASH lh = new LlegirHASH();

            string text = File.ReadAllText(Path.GetFullPath(entrada+".txt"));

            string codeHash = lh.Read(entrada);

            if (codeHash.Equals("Falla lectura") || codeHash.Equals("Fitxer buit"))
            {
                Console.WriteLine(codeHash);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Text introduit: ");
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine("Text codificat: ");
                Console.WriteLine(codeHash);
                Console.ReadKey();
            }
        }
    }
}
