using System;
using System.Collections.Generic;
using System.Text;

namespace ExmploClaseInterfaz
{
    class Soldado
    {
        private IDisparar Ataque;
        public Soldado(IDisparar arma)
        {
            Ataque = arma;
        }
        public void Disparar()
        {
            Console.WriteLine(Ataque.HeadShoot());
        }
    }
}
