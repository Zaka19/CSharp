using System;
using System.Collections.Generic;
using System.Text;
using static CustomGenericsç.Program;

namespace CustomGenericsç
{
    class Productos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Productos(string nombre,double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void CambiarPrecio(Cambiar delegado)
        {
           Precio = delegado(Precio);
        }

        public override string ToString()
        {
            return "El precio es " + Precio + ".";
        }
    }
}
