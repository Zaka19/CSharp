using System;
using System.Collections.Generic;
using System.Text;
using BackEnd.Objects;
using FrontEnd.Method;
using BackEnd.Method;

namespace FrontEnd
{
    class Start
    {
        public static void StartGame(Player Player1,Player Player2,Game game)
        {
            Console.WriteLine("Round "+game.Round);
            Console.WriteLine(Player1.Name);
            Player1.Option = AskOption.Ask();
            Console.WriteLine();
            Console.WriteLine(Player2.Name);
            Player2.Option = AskOption.Ask();
            Console.WriteLine();
            game.Winner = WhoWin.SwitchP1(Player1, Player2);
            Console.WriteLine(game.Winner);
            game.Round++;
        
        }
    }
}
