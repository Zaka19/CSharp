using System;
using System.Collections.Generic;
using System.Text;

namespace DilemaPrisionero
{
    class Coopera : IEstrategia
    {
        public int DevuelveAccion()
        {
            return 1;
        }
    }
}
