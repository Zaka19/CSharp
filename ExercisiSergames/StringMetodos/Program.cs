using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace StringMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string primera = "Luz azul";

            //Console.WriteLine(primera.palidromo());
            //Console.WriteLine(primera.TrimAll());
            //Console.WriteLine(primera.reverse());
            //Console.WriteLine(primera.toTitle());
        }
    }

    static class Extensio
    {
        public static string TrimAll(this string paraula)
        {
            //1r metodo
            //char[] Palabras = paraula.ToCharArray();
            //string palabra = null;
            //for (int a = 0; a < Palabras.Length; a++)
            //{
            //    if (Palabras[a] == ' ')
            //    {
            //        for (int b = a; b < Palabras.Length; b++)
            //        {
            //            Palabras[a] = Palabras[a + 1];
            //        }
            //    }    
            //}

            //for(int c = 0; c < Palabras.Length; c++)
            //{
            //    palabra = palabra + Palabras[c];
            //}

            //2n metodo
            //string segona = "";
            //foreach (char letra in paraula)
            //{
            //    if (letra != ' ')
            //    {
            //        segona = segona + letra;
            //    }
            //};

            //3r metodo

            return paraula.Replace(" ", "");
        }

        public static string reverse(this string paraula)
        {
            char[] paraules = paraula.ToCharArray();
            int max = paraules.Length;
            string paraula1 = null;
            for(int a = max - 1; a >= 0 ; a--)
            {
                paraula1 = paraula1 + paraules[a];
            }
            return paraula1;
        }

        public static bool palidromo(this string paraula)
        {
            paraula = paraula.TrimAll().ToLower();
            string paraula1 = paraula.reverse();
            return paraula.Equals(paraula1);
        }

        public static string toTitle(this string paraula)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            ti.Clone();
            return ti.ToTitleCase(paraula);
        }
    }
}
