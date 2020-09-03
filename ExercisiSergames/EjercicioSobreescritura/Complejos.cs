using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSobreescritura
{
    class Complejos
    {
        private int X;

        public int GetX
        {
            get { return X; }
            set { X = value; }
        }
        private int myVar;

        public int Y
        {
            get { return Y; }
            set { Y = value; }
        }

        public Complejos(int _X,int _Y)
        {
            X = _X;
            Y = _Y;
        }
        /*
                public override string ToString()
                {
                    return 
                }
        */
        public static Complejos operator +(Complejos Primero, Complejos Segundo) => new Complejos((Primero.GetX + Segundo.GetX), (Primero.Y + Segundo.Y));
        public static Complejos operator -(Complejos Primero, Complejos Segundo) => new Complejos((Primero.GetX - Segundo.GetX), (Primero.Y - Segundo.Y));
        public static Complejos operator ++(Complejos Primero) => new Complejos((Primero.GetX + 1),(Primero.Y + 1));
        public static Complejos operator --(Complejos Primero) => new Complejos((Primero.GetX - 1),(Primero.Y - 1));

    }
}
