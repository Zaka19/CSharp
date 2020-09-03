using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HashFitxers
{
    class CompararHash
    {
        public void Main(string entrada, string fitxer)
        {
            LlegirHASH lh = new LlegirHASH();
            string text = "";
            try
            {
                 text = File.ReadAllText(Path.GetFullPath(fitxer + ".sha"));
            }
            catch(Exception e)
            {
                 text = "Fitxer no trobat.";
            }

            string codeHash = lh.Read(entrada);

            if (text.Equals(codeHash))
            {
                Console.WriteLine("Son el mateix.");
            }
            else if (text.Equals("Fitxer no trobat."))
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("No son el mateix.");
            }
        }
    }
}
