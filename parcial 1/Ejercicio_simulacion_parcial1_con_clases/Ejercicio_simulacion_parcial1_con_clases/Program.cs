using Ejercicio_simulacion_parcial1_con_clases;

internal class Program
{
    public static void Main(string[] args)
    {
        Metodos m = new Metodos();
        DateTime[][] intervalos = new DateTime[4][];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ingrese el año inicial del intervalo {i + 1}");
            int añoInicio = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el mes inicial del intervalo {i + 1}");
            int mesInicio = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el día inicial del intervalo {i + 1}");
            int diaInicio = int.Parse(Console.ReadLine());
            DateTime fechaInicio = new DateTime(añoInicio, mesInicio, diaInicio);

            Console.WriteLine($"Ingrese el año final del intervalo {i + 1}");
            int añoFinal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el mes final del intervalo {i + 1}");
            int mesFinal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el día final del intervalo {i + 1}");
            int diaFinal = int.Parse(Console.ReadLine());
            DateTime fechaFinal = new DateTime(añoFinal, mesFinal, diaFinal);

            intervalos[i] = new DateTime[] { fechaInicio, fechaFinal };
        }

        DateTime[][] resultado = m.UnirIntervalos(intervalos);

        Console.WriteLine("Intervalos resultantes:");
        foreach (DateTime[] intervalo in resultado)
        {
            Console.WriteLine($"Inicio: {intervalo[0]}, Fin: {intervalo[1]}");
        }
    }
}