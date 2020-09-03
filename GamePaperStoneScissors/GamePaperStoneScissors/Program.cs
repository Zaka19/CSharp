using System;
using BackEnd.Objects;

namespace FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player1 = new Player();
            Player Player2 = new Player();
            Game game = new Game();
            game.Round = 1;

            Player1.Name = AskName.Name();
            Console.WriteLine();
            Player2.Name = AskName.Name(); ;
            Console.Clear();

            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
            Start.StartGame(Player1, Player2, game);
        }
    }
}
