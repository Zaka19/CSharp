using Game.Characters;
using Game.FrontEnd;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero _hero = new Hero("Zaka", 10, " ♣ ");
            Main _m = new Main(10, 10, _hero, new ViewUser());
            _m.Start();
        }
    }
}
