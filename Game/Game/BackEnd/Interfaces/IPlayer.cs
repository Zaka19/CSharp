using Game.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    interface IPlayer
    { 
        public int Life { get; set; }
        public List<Weapons> Weapons { get; set; }
    }
}
