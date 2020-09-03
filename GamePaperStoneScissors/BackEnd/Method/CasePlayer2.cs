using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Method
{
    class CasePlayer2
    {
        public static String WinnerStone(String MovementPlayer2,String NamePlayer1,String NamePlayer2)
        {
            String HowWin = "";

            if(MovementPlayer2 == Strings.Paper)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else if(MovementPlayer2 == Strings.Scissors)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Spoke)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else 
            {
                HowWin = NamePlayer1 + Strings.Win;
            }

            return HowWin;

        }

        public static String WinnerPaper(String MovementPlayer2,String NamePlayer1, String NamePlayer2)
        {
            String HowWin = "";

            if (MovementPlayer2 == Strings.Stone)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Scissors)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Spoke)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else
            {
                HowWin = NamePlayer2 + Strings.Win;
            }

            return HowWin;

        }

        public static String WinnerScissors(String MovementPlayer2,String NamePlayer1, String NamePlayer2)
        {
            String HowWin = "";

            if (MovementPlayer2 == Strings.Stone)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Paper)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else if(MovementPlayer2 == Strings.Spoke)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else
            {
                HowWin = NamePlayer1 + Strings.Win;
            }

            return HowWin;

        }

        public static String WinnerSpoke(String MovementPlayer2, String NamePlayer1, String NamePlayer2)
        {
            String HowWin = "";

            if (MovementPlayer2 == Strings.Stone)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Paper)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Scissors)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else
            {
                HowWin = NamePlayer2 + Strings.Win;
            }

            return HowWin;

        }

        public static String WinnerLizard(String MovementPlayer2, String NamePlayer1, String NamePlayer2)
        {
            String HowWin = "";

            if (MovementPlayer2 == Strings.Stone)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Paper)
            {
                HowWin = NamePlayer1 + Strings.Win;
            }
            else if (MovementPlayer2 == Strings.Scissors)
            {
                HowWin = NamePlayer2 + Strings.Win;
            }
            else
            {
                HowWin = NamePlayer1 + Strings.Win;
            }

            return HowWin;

        }
    }
}
