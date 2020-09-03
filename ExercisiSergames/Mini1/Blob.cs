using System;
using System.Collections.Generic;
using System.Text;

namespace Mini1
{
    class Blob
    {
        private int Ataque;

        public int ATAQUE
        {
            get { return Ataque; }
            set { Ataque = value; }
        }

        public int Potencia
        {
            get { return Ataque + Defensa / 2; }
        }

        private int Defensa;

        public int DEFENSA
        {
            get { return Defensa; }
            set { Defensa = value; }
        }

        public Blob (int _ataque, int _defensa)
        {
            Ataque = _ataque;
            Defensa = _defensa;
        }

        public override string ToString()
        {
            return ATAQUE + "+" + DEFENSA;
        }

        public override bool Equals(object obj)
        {
            if (obj is Blob a)
            {
                return this.Potencia == a.Potencia;
            }
            return false;
        }
        public static bool operator == (Blob Primero, Blob Segundo)
        {
            return (Primero.Equals(Segundo));
        }

        public static bool operator != (Blob Primero, Blob Segundo)
        {
            return (!Primero.Equals(Segundo));
        }

        public static Blob operator +(Blob p1, Blob p2) => new Blob(p1.ATAQUE + p2.ATAQUE, p1.DEFENSA + p2.DEFENSA);
        public static Blob operator +(Blob p1, int p2) => new Blob(p1.ATAQUE + p2, p1.DEFENSA);
        public static Blob operator -(Blob p1, Blob p2) => new Blob(p1.ATAQUE - p2.ATAQUE, p1.DEFENSA - p2.DEFENSA);
        public static Blob operator -(Blob p1, int p2) => new Blob(p1.ATAQUE - p2, p1.DEFENSA);
        public static Blob operator *(Blob p1, int p2) => new Blob(p1.ATAQUE * p2, p1.DEFENSA * p2);
        public static Blob operator *(Blob p1, Blob p2) => new Blob(p1.ATAQUE * p2.ATAQUE, p1.DEFENSA * p2.DEFENSA);
        public static Blob operator ++(Blob p1) => new Blob(p1.ATAQUE + 1, p1.DEFENSA + 1);
        public static Blob operator --(Blob p1) => new Blob(p1.ATAQUE - 1, p1.DEFENSA - 1);
        public static bool operator <(Blob p1, Blob p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(Blob p1, Blob p2) => p1.CompareTo(p2) > 0;
        public static bool operator <=(Blob p1, Blob p2) => p1.CompareTo(p2) <= 0;
        public static bool operator >=(Blob p1, Blob p2) => p1.CompareTo(p2) >= 0;

        private int CompareTo(Blob p2)
        {
            int final;
            if ((this.Potencia) > (p2.Potencia)) { final = 1; }
            else if ((this.Potencia) < (p2.Potencia)) { final = -1; }
            else { final = 0; }
            return final;
        }
    }
}
