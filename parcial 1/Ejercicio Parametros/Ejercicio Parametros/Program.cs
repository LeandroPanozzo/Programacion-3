/*
 Implementar una función Moda, que reciba como valores una cantidad indeterminada de enteros y devuelva la moda (estadística), el valor mínimo y el valor máximo.
Invocar este método y mostrar los resultados por consola.
Elija los modificadores mas adecuados
 */
using System.Security.Cryptography.X509Certificates;

using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese cuántos valores desea ingresar:");
        int.TryParse(Console.ReadLine(), out int val);

        int[] valores = new int[val];
        for (int i = 0; i < val; i++)
        {
            Console.WriteLine($"Ingrese el entero número {i + 1}:");
            int.TryParse(Console.ReadLine(), out valores[i]);
        }

        int moda;
        int min;
        int max;

        moda = CalcularModa(valores, out min, out max);

        Console.WriteLine($"La moda es: {moda}");
        Console.WriteLine($"El valor mínimo es: {min}");
        Console.WriteLine($"El valor máximo es: {max}");
    }

    public static int CalcularModa(int[] valores, out int min, out int max)
    {
        var repeticiones = valores.GroupBy(n => n).OrderByDescending(g => g.Count());
        int moda = repeticiones.First().Key;

        min = valores.Min();
        max = valores.Max();

        return moda;
    }
}
