using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLive
{
    class Manual : IGame
    {
        public  Cell[,] Method(Cell[,] PresentRound, int lenghtTotal)
        {
            int lenght = lenghtTotal - 2;
            for (int row = 0; row < lenghtTotal; row++)
            {
                for (int col = 0; col < lenghtTotal; col++)
                {
                    PresentRound[row, col] = new Cell(row, col, false);
                }
            }

            int rowLlenar = 0;
            int colLlenar = 0;
            String s;

            do
            {
                Console.WriteLine("Introduce que fila y columna quieres llenar: ");
                rowLlenar = Convert.ToInt32(Console.ReadLine());
                colLlenar = Convert.ToInt32(Console.ReadLine());

                PresentRound[rowLlenar, colLlenar].State = true;

                Console.WriteLine("Quieres seguir introduciendo? ");
                 s = Console.ReadLine();

            } while (s.Equals("Si"));

            return PresentRound;
        }
    }
}
