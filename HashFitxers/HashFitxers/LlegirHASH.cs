using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HashFitxers
{
    class LlegirHASH
    {
        public string Read(string nameFitxer)
        {
            string codeHash = "";
            try
            {
                string line = File.ReadAllText(Path.GetFullPath(nameFitxer+".txt"));

                if (string.IsNullOrEmpty(line))
                {
                    codeHash = "Fitxer buit";
                }
                else
                {
                    // Convertim l'string a un array de bytes
                    byte[] bytesIn = Encoding.UTF8.GetBytes(line);
                    // Instanciar classe per fer hash

                    // fent servir using ja es delimita el seu àmbit i no cal fer dispose
                    using (SHA512Managed SHA512 = new SHA512Managed())
                    {
                        // Calcular hash
                        byte[] hashResult = SHA512.ComputeHash(bytesIn);

                        // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
                        // cal convertir-lo a un string

                        String textOut = BitConverter.ToString(hashResult).Replace("-", string.Empty);

                        codeHash = textOut;
                    }
                }
            }
            catch (Exception e)
            {
                codeHash = "Falla lectura";
            }

            return codeHash;
        }
    }
}
