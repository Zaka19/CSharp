using System;
using System.Collections.Generic;
using System.Text;
using GameOfLive;
namespace GameOfLive
{
    public class MethodGame
    {
        public static Cell[,] LogicGame(Cell[,] PresentTable,int lenghtTotal)
        {
            Cell[,] NextRound = new Cell[lenghtTotal,lenghtTotal];
            int LENGHT = lenghtTotal - 2;

            for (int row = 0; row < lenghtTotal; row++)
            {
                for (int col = 0; col < lenghtTotal; col++)
                {
                    NextRound[row, col] = new Cell(row, col, false);
                }
            }

                for (int row = 1; row <= LENGHT; row++)
                {
                    for (int col = 1; col <= LENGHT; col++)
                    {
                        if (NightBiardNumber(/*PresentTable[a,b].Row,PresentTable[a, b].Col*/row,col,PresentTable) > 3 && PresentTable[row, col].State == true)
                        {
                        NextRound[row, col].State = false;
                        }
                        else if (NightBiardNumber(/*PresentTable[a,b].Row,PresentTable[a, b].Col*/row, col, PresentTable) < 2 && PresentTable[row, col].State == true)
                        {
                        NextRound[row, col].State = false;
                        }
                        else if ((NightBiardNumber(/*PresentTable[a,b].Row,PresentTable[a, b].Col*/row, col, PresentTable) == 3 || NightBiardNumber(/*PresentTable[a,b].Row,PresentTable[a, b].Col*/row, col, PresentTable) == 2) && PresentTable[row, col].State == true)
                        {
                        NextRound[row, col].State = true;
                        }
                        else if (NightBiardNumber(/*PresentTable[a,b].Row,PresentTable[a, b].Col*/row, col, PresentTable) == 3 && PresentTable[row, col].State == false)
                        {
                        NextRound[row, col].State = true;
                        }
                    }
                }

            return NextRound;
        }

        public static int NightBiardNumber(int row, int col,Cell[,] Present)
        {
            int nightBoard = 0;

            for(int a = row - 1; a <= row + 1; a++)
            {
                for (int b = col - 1; b <= col + 1; b++)
                {
                    if (a == row && b == col) { }
                    else if(Present[a,b].State == true)
                    {
                        nightBoard++;
                    }
                }
            }
            return nightBoard;
        }
    }
}
