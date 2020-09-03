using System;

namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            BaseJuego bj = new BaseJuego(new ParteVisual(),10);
            bj.Start();
        }
    }
}
