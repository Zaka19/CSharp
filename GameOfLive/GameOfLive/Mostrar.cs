using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLive
{
    class Mostrar : IMostrar
    {
        void IMostrar.Mostrar(Cell[,] PreviousTable, int size)
        {
            Random ran = new Random();
            size = size - 2;
            for (int a = 1; a <= size; a++)
            {
                for (int b = 1; b <= size; b++)
                {
                    if(PreviousTable[a, b].State == true)
                    {
                        Console.Write( ran.Next(0,8) + " ");
                    }
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
