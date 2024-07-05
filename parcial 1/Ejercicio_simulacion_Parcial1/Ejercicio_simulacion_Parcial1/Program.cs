using System;

internal class Program
{
    private static void Main(string[] args)
    {
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


        //intervalo estara contituido por:
        /*
         intervalo[0]= fechaInicio[0][0] fechaFinal[0][1]
         intervalo[1]= fechaInicio[1][0] fechaFinal[1][1]
         intervalo[2]= fechaInicio[2][0] fechaFinal[2][1]
         intervalo[3]= fechaInicio[3][0] fechaFinal[3][1]
         */


        Console.WriteLine("Intervalos ingresados:");
        for (int i = 0; i < 4; i++)
        {
            TimeSpan duracion = intervalos[i][1] - intervalos[i][0];
            Console.WriteLine($"Intervalo {i + 1}: Desde {intervalos[i][0].ToString("dd/MM/yyyy HH:mm")} hasta {intervalos[i][1].ToString("dd/MM/yyyy HH:mm")}, Duración: {duracion.TotalHours} horas");
        }

        DateTime[][] resultado = UnirIntervalos(intervalos);

        Console.WriteLine("Intervalos resultantes:");
        foreach (DateTime[] intervalo in resultado)
        {
            TimeSpan duracionIntervalo = intervalo[1] - intervalo[0];
            Console.WriteLine($"Inicio: {intervalo[0].ToString("dd/MM/yyyy HH:mm")}, Fin: {intervalo[1].ToString("dd/MM/yyyy HH:mm")}, Duración: {duracionIntervalo.TotalHours} horas");
        }
    }
    
        
    private static DateTime[][] UnirIntervalos(DateTime[][] intervalos)
    {
        // aunque se estén comparando "de a dos" elementos durante el proceso de ordenamiento, la comparación se realiza
        // entre todos los elementos del arreglo para lograr el ordenamiento completo
        Array.Sort(intervalos, (a, b) => a[0].CompareTo(b[0])); //voy comparando la fecha inicio de cada intervalo
                                                                //para acomodar del principio a fin

        int n = intervalos.Length; //da 4 porque es un arreglo de longitud, si fuera  bidimensional el arreglo es decir:
        //[,] lenght daria 16 porque seria 4x4
        int count = 1;

        // Contar la cantidad de intervalos resultantes
        for (int i = 1; i < n; i++)
        {
            if (intervalos[i][0] > intervalos[i - 1][1])// Esta condición verifica si el inicio del intervalo actual
                                                        // es mayor que el final del intervalo anterior, lo que indica
                                                        // que no hay superposición entre los dos intervalos y se debe
                                                        // contar como un nuevo intervalo (fecha de incion de el segundo
                                                        // intervalo menos fecha final del intervalo anterior)
                count++;
        }

        DateTime[][] resultado = new DateTime[count][]; //pongo cont porque me cuenta los intervalos nuevos (los que se superpusieron)
        //las nuevas filas que habra
        int index = 0;
        //inicio y fin del primer intervalo
        DateTime inicio = intervalos[0][0];
        DateTime fin = intervalos[0][1];

        // Fusionar intervalos
        for (int i = 1; i < n; i++)
        {
            if (intervalos[i][0] <= fin) //si es menor es porque se solapan
            {
                if (intervalos[i][1] > fin) //si el final del intervalo es mayor al intervalo fin que era nuestro limite
                {
                    fin = intervalos[i][1]; //fin tendra ahora como limite el final de este intervalo que estamos revisando
                }
            }
            else
            {
                //Usar index++ dentro de la asignación es una forma concisa de hacer dos cosas al mismo tiempo: asignar el valor y luego incrementar el índice.
                resultado[index++] = new DateTime[] { inicio, fin }; //si no se solapan agrego el intervalo al arreglo
                inicio = intervalos[i][0]; //ahora inicio y fin empezaran en el intervalo que acabamos de revisar
                fin = intervalos[i][1];
            }
        }

        resultado[index] = new DateTime[] { inicio, fin }; //por ultimo agrego el ultimo intervalo a revisar

        return resultado;
    }
        
        
}