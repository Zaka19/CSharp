using Game.BackEnd;
using Game.Characters;
using Game.FrontEnd;
using Game.Interfaces;
using Game.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Game
{
    class Main
    {
        int _col;
        int _row;
        IMap _map;
        Hero _hero;

        List<Generics> _generics = new List<Generics>();
        List<Enemy> _enemys = new List<Enemy>();

        HeroMove _moveH = new HeroMove();
        EnemyMove _moveE = new EnemyMove();
        Battle _battle = new Battle();
        Random rnd = new Random();

        public Main(int col, int row, Hero hero, IMap map)
        {
            _col = col;
            _row = row;
            _hero = hero;
            _map = map;
        }

        public void Start()
        {
            Generics[,] all = new Generics[_col, _row];

            all = _map.GenerateMap(_col, _row);

            GenerateHero();
            GenerateEnemys();

            _map.DrawMap(_map.ModifyMap(_generics, all));

            while (true)
            {
                UpdateMovementHero(all);
                _hero.Position = _moveH.Move(_hero.Position, all);

                UpdateMovementMonsters(all);
                _moveE.Move(all, _generics);

                Console.Clear();

                _map.DrawMap(_map.ModifyMap(_generics, all));

                Console.WriteLine(_battle.DetectEnemys(all, _hero));

                if(_battle.DetectEnemys(all, _hero))
                {
                    _battle.VisualizarBatalla(_battle.DetectNumberEnemys(all, _hero), _hero);
                    _map.DrawMap(_map.ModifyMap(_generics, all));
                }
            }
        }

        void GenerateHero()
        {
            int x = rnd.Next(1, _col - 1);
            int y = rnd.Next(1, _row - 1);

            _hero.Position = new Position(x, y);

            _generics.Add(_hero);
        }

        void GenerateEnemys()
        {

            Enemy _enemy;

            for (int num = 0; num < 3; num++)
            {
                int x = rnd.Next(1, _col - 1);
                int y = rnd.Next(1, _row - 1);

                while (_hero.Position.X == x && _hero.Position.Y == y)
                {

                    x = rnd.Next(1, _col - 1);
                    y = rnd.Next(1, _row - 1);

                }

                _enemy = new Enemy("Slug", 3, " ☻ ");

                _enemy.Position = new Position(x, y);

                _generics.Add(_enemy);

                _enemys.Add(_enemy);
            }
        }

        void UpdateMovementHero(Generics[,] all)
        {
            all[_hero.Position.X, _hero.Position.Y] = new Weapons("   ");
        }

        void UpdateMovementMonsters(Generics[,] all)
        {
            _enemys.ForEach(x =>
            {
                all[x.Position.X, x.Position.Y] = new Weapons("   ");
            });
        }

    }
}
