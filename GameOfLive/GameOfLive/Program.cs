using System;
using System.Threading;
namespace GameOfLive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game gc = new Game(1000,100,new RandomTable(),new Mostrar());
            gc.LlenarMesa();
            gc.StartGame();
        }
    }
}
