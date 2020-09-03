using System;
using System.Collections.Generic;
using System.Linq;

namespace JuegoDeTorretas
{
    class Program
    {
        static void Main(string[] args)
        {
            string TorretaInicio = "Torreta";
            int Numero = 0;
            string TorretaNom = "";

            List<Torreta> listaTorretas = new List<Torreta>();

            for (int x = 50; x < 400; x += 100)
            {
                for (int y = 50; y < 400; y += 100)
                {
                    TorretaNom = TorretaInicio + Numero;
                    listaTorretas.Add(new Torreta(TorretaNom, ((x + y)/ 10),100,y, x));
                    Console.WriteLine(listaTorretas[Numero]);
                    Numero++;
                }
                Console.WriteLine();
            }

            var res1 = listaTorretas.Where(s => s._Ataque > 50);
            Console.WriteLine("Exercisi 1");
            Console.WriteLine(String.Join("\n", res1));

            var res2 = listaTorretas.Where(s => s._Ataque > 50 && s.a.y == 50);
            Console.WriteLine("Exercisi 2");
            Console.WriteLine(String.Join("\n", res2));

            var res3 = listaTorretas.OrderByDescending(s => s._Ataque).ThenByDescending(s => s.a.y);
            Console.WriteLine("Exercisi 3");
            Console.WriteLine(String.Join("\n", res3));

            var res4 = listaTorretas.Average(s => s._Ataque);
            Console.WriteLine("Exercisi 4");
            Console.WriteLine(String.Join("\n", res4));

            var res5 = listaTorretas.Where(s => s._Ataque == listaTorretas.Min(a => a._Ataque));
            Console.WriteLine("Exercisi 5");
            Console.WriteLine(String.Join("\n", res5));

            var res6 = listaTorretas.Any(s => s._Ataque > 60);
            Console.WriteLine("Exercisi 6");
            Console.WriteLine(String.Join("\n", res6));

            var res7 = listaTorretas.Where(s => s._Rango >= CoordenadasLlegar(200, 200, s.a));
            Console.WriteLine("Exercisi 7");
            //int AtaqueTotal = 0;
            //foreach (var torreta in res7)
            //{
            //   AtaqueTotal = AtaqueTotal + torreta._Ataque;
            //}
            var CuidaoAtaquePotente = res7.Sum(s => s._Ataque);
            Console.WriteLine(String.Join("\n", res7));
            Console.WriteLine("El tanque recibira un daño total de " + CuidaoAtaquePotente + " .");
        }

        public static double CoordenadasLlegar(int x, int y, Posicio a)
        {
            int total = 0;
            int total1 = 0;

            total = x - a.x;
            total1 = y - a.y;
            return Math.Sqrt(Math.Pow(total, 2) + Math.Pow(total1, 2));
        }
    }
}
