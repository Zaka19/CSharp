using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    public abstract class ObjectGeneric
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Life;

        public int Life
        {
            get { return _Life; }
            set { _Life = value; }
        }

        private char _Body;

        public char Body
        {
            get { return _Body; }
            set { _Body = value; }
        }

        //public Posicion PosicionObjecto;

        public void ability() { }
    }
    //public struct Posicion
    //{
    //    public int x { get; set; }
    //    public int y { get; set; }
    //}
}
