using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisiSergames
{
    class CuentaCorriente
    {
        public delegate void Alerta(string mensaje,int numero);
        public Alerta listaAlertas;
        private string nombre;
        private double saldo;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Saldo
        { get { return saldo; } set { saldo = value;  } }

        public void Ejecutar()
        {
            listaAlertas("Tiene un saldo de " + saldo + ".");
        }
    }
}
