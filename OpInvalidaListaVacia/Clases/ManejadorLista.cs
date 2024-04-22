using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpInvalidaListaVacia.Clases
{
    public class ManejadorLista
    {
        private List<int> Lista;

        public ManejadorLista()
        {
            Lista = new List<int>();
        }

        public void InsertarElemento(int elemento)
        {
            Lista.Add(elemento);
            Console.WriteLine($"Se inserto el elemento {elemento} correctamente.");
        }

        public void EliminarElemento()
        {
            if (Lista.Count == 0)
            {
                throw new InvalidOperationException("Operacion Invalida, la lista esta vacia");
            }

            Lista.RemoveAt(Lista.Count - 1);
            Console.WriteLine($"Se elimino el ultimo elemento de la lista quedan {Lista.Count} elementos");
        }
    }
}
