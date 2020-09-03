using System;
using System.Collections.Generic;
using System.Text;
using BackEnd;

namespace FrontEnd.Method
{
    public class AskOption
    {
        public static String Ask()
        {
            String OptionPlayer = "";

            Console.Write(Strings.SelectOption);
            OptionPlayer = Console.ReadLine();
            OptionPlayer.ToUpper();

            while(OptionPlayer != Strings.Stone && OptionPlayer != Strings.Paper && OptionPlayer != Strings.Scissors && OptionPlayer != Strings.Lizard && OptionPlayer != Strings.Spoke)
            {
                Console.WriteLine(Strings.ErrorOption);
                OptionPlayer = Console.ReadLine();
                OptionPlayer.ToUpper();
                Console.WriteLine();
            }

            return OptionPlayer;
        }
    }
}
