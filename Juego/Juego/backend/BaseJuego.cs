using Juego.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juego
{
    class BaseJuego
    {
        DetectarBatalla db = new DetectarBatalla();
        MovmentHeroe mv = new MovmentHeroe();
        MovmentMonster mvh = new MovmentMonster();
        Random randomPosition = new Random();
        static int Size = 0;
        IMostrar _Mostrar;
        static int xHeroe, yHeroe;
        public BaseJuego(IMostrar Mostrar,int size)
        {
            Size = size;
            _Mostrar = Mostrar;
        }

        ObjectGeneric[,] Dungeon;

        public void Start()
        {
            Dungeon = new ObjectGeneric[Size, Size];

            InicializarDungeon(Dungeon);
            SpawnMonsters(Dungeon, (Size / 10) * 4);
            SpawnHeroe(Dungeon);
            _Mostrar.VisualizarDungeon(Dungeon, Size-1);

            for (int a = 0; a < 100; a++)
            {
                WhilePlay();
            }
        }

        public void WhilePlay()
        {
            Dungeon = mv.Movimiento(Dungeon, xHeroe, yHeroe, Size - 1);
            UPDATEMovimientosHeroes();
            MovimientosMonstruos();
            _Mostrar.VisualizarDungeon(Dungeon, Size-1);

            if (db.Detectar(xHeroe, yHeroe, Dungeon))
            {
                List<Monsters> Monstruos = db.DetectarNumMonsters(xHeroe, yHeroe, Dungeon);
                Heroe h = (Heroe)Dungeon[xHeroe, yHeroe];
                _Mostrar.VisualizarBatalla(Monstruos, h);
                _Mostrar.VisualizarDungeon(Dungeon, Size - 1);
            }
        }

        public void MovimientosMonstruos()
        {
            for (int x = 1; x < Size - 1; x++)
            {
                for (int y = 1; y < Size - 1; y++)
                {
                    if (Dungeon[x, y].Body == '?')
                    {
                        Dungeon = mvh.Movimiento(Dungeon, x, y, Size - 1);
                    }
                }
            }
        }

        public void UPDATEMovimientosHeroes()
        {
            for (int x = 1; x < Size - 1; x++)
            {
                for (int y = 1; y < Size - 1; y++)
                {
                    if (Dungeon[x, y].Body == '#')
                    {
                        xHeroe = x;
                        yHeroe = y;
                    }
                }
            }
        }

        private void SpawnMonsters(ObjectGeneric[,] dungeon, int Monsters)
        {
            int x, y;
           
            for (int a = 0; a < Monsters; a++)
            {
                x = randomPosition.Next(1, Size - 1);
                y = randomPosition.Next(1, Size - 1);
                Dungeon[x, y] = new Monsters("Monster", 50, '?');
            }
        }
        
        private void SpawnHeroe(ObjectGeneric[,] dungeon)
        {
            
            xHeroe = randomPosition.Next(1, Size - 1);
            yHeroe = randomPosition.Next(1, Size - 1);
            Dungeon[xHeroe, yHeroe] = new Heroe("Heroe", 200, '#');
        }

        private void InicializarDungeon(ObjectGeneric[,] dungeon)
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    Dungeon[x, y] = new ObjectsNulls(' ');
                }
            }
        }
    }
}
