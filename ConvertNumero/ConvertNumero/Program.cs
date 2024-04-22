using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.ConvertNumero
{
    class Program
    {
        static void Main()
        {
            {
                try
                {
                    Console.Write("Ingrese una cadena para convertir a número: ");
                    string cadena = Console.ReadLine();
                    int numero = Convert.ConvertirNumero(cadena);
                    Console.WriteLine("El número convertido es: " + numero);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("La cadena no representa un número válido.");
                }

                Console.ReadLine();
            }
        }
    }
}

