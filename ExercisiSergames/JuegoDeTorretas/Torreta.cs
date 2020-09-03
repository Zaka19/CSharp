using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeTorretas
{
    public class Torreta
    {
        public Posicio a;

        private string Nombre;

        public string _Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private int Rango;

        public int _Rango
        {
            get { return Rango; }
            set { Rango = value; }
        }

        private int Ataque;

        public int _Ataque
        {
            get { return Ataque; }
            set { Ataque = value; }
        }

        public Torreta (string Nombre, int Ataque,int Rango,int x,int y)
        {
            _Nombre = Nombre;
            _Ataque = Ataque;
            _Rango = Rango;
            a.x = x;
            a.y = y;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Ataque: {Ataque}, PosicioX: {a.x}, PosicioY: {a.y}, Rango: {Rango}";
        }

        public override bool Equals(object obj)
        {
            return obj is Torreta torreta &&
                   EqualityComparer<Posicio>.Default.Equals(a, torreta.a) &&
                   Nombre == torreta.Nombre &&
                   Rango == torreta.Rango &&
                   Ataque == torreta.Ataque;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(a, Nombre, Rango, Ataque);
        }
    }

    public struct Posicio
    {
        public int x { get; set; }
        public int y { get; set; }

        public Posicio(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

}
