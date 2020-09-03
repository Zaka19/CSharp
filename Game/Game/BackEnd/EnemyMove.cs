using Game.Characters;
using Game.Interfaces;
using Game.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class EnemyMove 
    {
        public bool Block(Position _position, string _move, Generics[,] _generic, List<Generics> _enemys)
        {
            int x = _position.X;
            int y = _position.Y;

            Position position = new Position(x, y);

            position = SwitchMove(position, _move);

            return _generic[position.X, position.Y].Body == "   " && !_enemys.Any(x => x.Position.X == position.X && x.Position.Y == position.Y);
        }

        public void Move(Generics[,] _generic, List<Generics> _generics )
        {
            Random rnd = new Random();

            _generics.ForEach(x =>
            {
                if (x.GetType().ToString().Contains("Enemy")) { 

                    string _move = rnd.Next(1, 5).ToString();

                    while (!CorrectKey(_move) || !Block(x.Position, _move, _generic, _generics))
                    {
                        _move = rnd.Next(1, 4).ToString();
                    }

                    x.Position = SwitchMove(x.Position, _move);

                }
            });
        }

        public bool CorrectKey(string _movement)
        {
            List<string> _Movements = new List<string>() {"1", "2", "3", "4"};

            return _Movements.Any(x => x == _movement);
        }

        Position SwitchMove(Position position, string _move)
        {

            Position _position = position;

            switch (_move)
            {
                case "1":

                    _position.X = _position.X - 1;

                    break;

                case "2":

                    _position.Y = _position.Y - 1;

                    break;

                case "3":

                    _position.X = _position.X + 1;

                    break;

                case "4":

                    _position.Y = _position.Y + 1;

                    break;
            }

            return _position;
        }
    }
}
