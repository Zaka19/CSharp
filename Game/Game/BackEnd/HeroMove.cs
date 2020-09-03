using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game;
using Game.Characters;
using Game.Interfaces;
using Game.Objects;

namespace Game
{
    class HeroMove : IMove
    {
        public bool Block(Position _position, string _move, Generics[,] _generic)
        {
            int x = _position.X;
            int y = _position.Y;

            Position position = new Position(x, y);

            position = SwitchMove(position, _move);

            return _generic[position.X, position.Y].Body == "   ";
        }

        public Position Move(Position _positionHero, Generics[,] _generic)
        {
            string _move = Console.ReadKey().KeyChar.ToString();

            while (!CorrectKey(_move) || !Block(_positionHero, _move, _generic))
            {
                _move = Console.ReadKey().KeyChar.ToString();
            }

            return SwitchMove(_positionHero, _move);
        }

        public bool CorrectKey(string _movement)
        {
            List<string> _Movements = new List<string>() { "w", "a", "s", "d", "A", "W", "S", "D" };

            return _Movements.Any(x => x == _movement);
        }

        Position SwitchMove(Position position, string _move)
        {

            Position _position = position;

            switch (_move)
            {
                case "w":
                case "W":

                    _position.X = _position.X - 1;

                    break;

                case "a":
                case "A":

                    _position.Y = _position.Y - 1;

                    break;

                case "s":
                case "S":

                    _position.X = _position.X + 1;

                    break;

                case "d":
                case "D":

                    _position.Y = _position.Y + 1;

                    break;
            }

            return _position;
        }
    }
}
