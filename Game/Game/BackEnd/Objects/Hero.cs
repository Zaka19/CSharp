using Game.Interfaces;
using Game.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Characters
{
    class Hero : Generics, IPlayer
    {
        public Hero(string _name, int _life, string _body)
        {
            Name = _name;
            Life = _life;
            Body = _body;
        }

        public int Life { get; set; }
        public List<Weapons> Weapons { get; set; }

        public override void AbilityOrAction()
        {
            throw new NotImplementedException();
        }
    }
}
