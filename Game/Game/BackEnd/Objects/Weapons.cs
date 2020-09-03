using Game.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Objects
{
    class Weapons : Generics
    {
        public Weapons(string _body)
        {
            Body = _body;
        }

        public int Damage { get; set; }
        public int Heal { get; set; }

        public override void AbilityOrAction()
        {
            throw new NotImplementedException();
        }
    }
}
