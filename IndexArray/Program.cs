using IndexArray;

class Program
{
    static void Main(string[] args)
    {
        int[] datos = { 1, 2, 3, 4, 5 };
        Arreglo miArreglo = new Arreglo(datos);

        try
        {
            Console.Write("Ingrese el índice para obtener el elemento: ");
            int indice = int.Parse(Console.ReadLine());
            int elemento = miArreglo.ObtenerElemento(indice);
            Console.WriteLine("El elemento obtenido es: " + elemento);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("El índice está fuera del rango válido del arreglo.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Debe ingresar un número entero válido como índice.");
        }

        Console.ReadLine();
    }
}