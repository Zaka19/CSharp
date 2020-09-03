using Game.Characters;
using Game.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    interface IMove
    {
        Position Move(Position _positionHero, Generics[,] _generic);
        bool Block(Position _position, string _move, Generics[,] _generic);
        bool CorrectKey(string _movement);
    }
}
