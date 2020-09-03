using System;
using System.Collections.Generic;
using System.Text;

namespace ExmploClaseInterfaz
{
    class Metralleta : IDisparar
    {
        public string HeadShoot()
        {
            return "Al carrer";
        }
    }
    class Bazoka : IDisparar
    {
        public string HeadShoot()
        {
            return "Boom";
        }
    }
}
