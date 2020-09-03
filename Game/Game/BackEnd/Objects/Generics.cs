using Game.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Characters
{
    public abstract class Generics
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public Position Position { get; set; }

        public abstract void AbilityOrAction();
    }
}
