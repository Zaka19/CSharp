using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ExmploClaseInterfaz;
namespace ExmploClaseInterfaz
{
    class Torreta : IGirar
    {
        public int Posicion { get; set; }
        private ArrayList arryList1 = new ArrayList();
        public void GirarHaciaDerecha()
        {
            arryList1.Add("D");
        }

        public void GirarHaciaIzquierda()
        {
            arryList1.Add("I");
        }
        public void Mostrar()
        {
            foreach(var element in arryList1)
            {
                if(element == "D")
                {
                    Posicion = Posicion + 90;
                }
                else if (element == "I")
                {
                    Posicion = Posicion - 90;
                }
                Posicion = (360 + Posicion) % 360;

                Console.Write(element + " " + Posicion + " ");
            }
        }
    }
}
