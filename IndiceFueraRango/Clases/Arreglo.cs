using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceFueraRango.Clases
{
    public class Arreglo
    {
        private int[] Elementos;

        public Arreglo(int[] elementos)
        {
            Elementos = elementos;
        }

        public int ObtenerElemento(int indice)
        {
            if (indice < 0 || indice >= Elementos.Length)
            {
                throw new IndexOutOfRangeException($"Esta fuera del rango en indice {indice}");
            }
            return Elementos[indice];
        }
    }
}
