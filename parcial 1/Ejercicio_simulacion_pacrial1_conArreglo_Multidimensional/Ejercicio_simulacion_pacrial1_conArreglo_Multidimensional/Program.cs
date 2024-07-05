internal class Program
{
    private static void Main(string[] args)
    {
        DateTime[,] intervalos = new DateTime[3, 2]; // 4 filas y 2 columnas

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++) // Utiliza j para iterar sobre las columnas
            {
                if (j == 0)
                {
                    Console.WriteLine($"Ingrese el año inicial del intervalo {i + 1}");
                    int añoInicio = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ingrese el mes inicial del intervalo {i + 1}");
                    int mesInicio = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ingrese el día inicial del intervalo {i + 1}");
                    int diaInicio = int.Parse(Console.ReadLine());
                    DateTime fechaInicio = new DateTime(añoInicio, mesInicio, diaInicio);

                    intervalos[i, j] = fechaInicio;
                }
                else if (j == 1)
                {
                    Console.WriteLine($"Ingrese el año final del intervalo {i + 1}");
                    int añoFinal = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ingrese el mes final del intervalo {i + 1}");
                    int mesFinal = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ingrese el día final del intervalo {i + 1}");
                    int diaFinal = int.Parse(Console.ReadLine());
                    DateTime fechaFinal = new DateTime(añoFinal, mesFinal, diaFinal);

                    intervalos[i, j] = fechaFinal;
                }
            }
        }

        Console.WriteLine("Intervalos ingresados:");
        for (int i = 0; i < 3; i++)
        {
            TimeSpan duracion = intervalos[i,1] - intervalos[i,0];
            Console.WriteLine($"Intervalo {i + 1}: Desde {intervalos[i,0].ToString("dd/MM/yyyy HH:mm")} hasta {intervalos[i,1].ToString("dd/MM/yyyy HH:mm")}, Duración: {duracion.TotalHours} horas");
        }
        DateTime[,] resultado = UnirIntervalos(intervalos, out int index);

        Console.WriteLine("Intervalos resultantes:");
        for(int i = 0;i < index+1;i++)
        {
            
                TimeSpan duracionIntervalo = resultado[i, 1] - resultado[i, 0];
                Console.WriteLine($"Intervalo {i + 1}: Desde {resultado[i, 0].ToString("dd/MM/yyyy HH:mm")} hasta {resultado[i, 1].ToString("dd/MM/yyyy HH:mm")}, Duración: {duracionIntervalo.TotalHours} horas");
            
        }
    }


    private static DateTime[,] UnirIntervalos(DateTime[,] intervalos, out int index)
    {
        // comienza obteniendo el número de filas y columnas de la matriz intervalos mediante los métodos GetLength(0) y
        // GetLength(1) respectivamente. Esto nos permite conocer el tamaño de la matriz para realizar operaciones sobre ella.
        int filas = intervalos.GetLength(0);
        int columnas = intervalos.GetLength(1);

        // Ordenar la matriz por la fecha de inicio (algoritmo de ordenamiento)
        for (int i = 0; i < filas - 1; i++)
        {
            for (int j = i + 1; j < filas; j++)
            {
                //Recorre la matriz y compara las fechas de inicio de cada intervalo con las de los intervalos siguientes.
                //Si encuentra una fecha de inicio menor, intercambia las filas para ordenar adecuadamente la matriz
                //según la fecha de inicio.
                if (intervalos[j, 0].CompareTo(intervalos[i, 0]) < 0) //si es menor a 0 significa que la fecha de inicio siguiente es menor
                {
                    // Intercambiar filas
                    for (int k = 0; k < columnas; k++)
                    {
                        DateTime temp = intervalos[i, k]; //guardo las fechas que estan antes en el arreglo que que son
                                                          //mayores a las siguientes en una veriable temporal
                        intervalos[i, k] = intervalos[j, k];
                        intervalos[j, k] = temp;
                    }
                }
            }
        }

        // Fusionar intervalos
        DateTime[,] resultado = new DateTime[filas, columnas];
        index = 0;
        DateTime inicio = intervalos[0, 0];
        DateTime fin = intervalos[0, 1];

        for (int i = 1; i < filas; i++)
        {
            //si la fecha de inicio del siguiente intervalo es menor a la fecha final del primer intervalo significa que se solapan
            if (intervalos[i, 0] <= fin)
            {
                //si el final del siguiente intervalo es mayor al final del primer intervalo se intercambia el valor de fin por este
                if (intervalos[i, 1] > fin)
                {
                    fin = intervalos[i, 1];
                }
            }
            else
            {
                //si no se solapan se lo agrega al arreglo nuevo como un intervalo a parte
                resultado[index, 0] = inicio;
                resultado[index, 1] = fin;
                index++;
                inicio = intervalos[i, 0];
                fin = intervalos[i, 1];
            }
        }

        //por ultimo agrego los ultimos intervcalos
        resultado[index, 0] = inicio;
        resultado[index, 1] = fin;

        return resultado;
    }

}

