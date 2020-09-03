using System;
using System.Collections.Generic;
using System.Text;

namespace ExmploClaseInterfaz
{
    class Pistola : IDisparar
    {
        public string HeadShoot()
        {
            return "Piu piu";
        }
    }
}
