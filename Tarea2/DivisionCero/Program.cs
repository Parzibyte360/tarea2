using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.DivisionCero
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Ingrese el dividendo: ");
                int dividendo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                int resultado = Dividir(dividendo, divisor);
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("La división entre cero no está permitida.");
            }

            Console.ReadLine();
        }

        static int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            return dividendo / divisor;
        }
    }
}
