using Game.Characters;
using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Objects
{
    class Enemy : Generics, IPlayer
    {
        public Enemy(string _name, int _life, string _body)
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
