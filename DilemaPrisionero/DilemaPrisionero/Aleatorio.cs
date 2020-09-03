using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    class Aleatorio : IEstrategia
    {
        public int DevuelveAccion()
        {
            Random rm = new Random();
            return rm.Next(0, 2);
        }
    }
}
