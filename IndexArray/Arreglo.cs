using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexArray
{
    internal class Arreglo
    {
        private int[] arreglo;

        public Arreglo(int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public int ObtenerElemento(int indice)
        {
            if (indice < 0 || indice >= arreglo.Length)
            {
                throw new IndexOutOfRangeException("El índice está fuera del rango válido del arreglo.");
            }
            return arreglo[indice];
        }
    }
}
