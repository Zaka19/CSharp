using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using GameOfLive;
namespace GameOfLive
{
    public class Game
    {
        private static int size;
        private static int rounds;
        private static bool FinishGame;
        public int Size { get { return size; } set { size = value; } }
        public Cell[,] PreviousRound;

        IGame _igame;
        IMostrar _imostrar;

        public Game(int Size,int Rounds,IGame _Igame,IMostrar _Imostrar)
        {
            size = Size + 2;
            rounds = Rounds;
            _igame = _Igame;
            _imostrar = _Imostrar;
        }

        public void LlenarMesa()
        {
            PreviousRound = new Cell[size, size];
            PreviousRound = _igame.Method(PreviousRound,size);
            _imostrar.Mostrar(PreviousRound, size);
            Thread.Sleep(100);
            Console.Clear();
        }

        public void StartGame()
        {
            for (int round = 1; round < rounds; round++)
            {
                PreviousRound = MethodGame.LogicGame(PreviousRound, size);
                Console.WriteLine();
                _imostrar.Mostrar(PreviousRound, size);
                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}
