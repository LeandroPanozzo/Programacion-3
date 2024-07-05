/*
 Realice una clase utilitaria de manejo de tiempo y fechas que cumpla con los siguiente:
1. Que contegan los métodos:
a. ObtenerDiasCalendario() obtiene los días entre dos fechas
b. ObtenerDiasLaborables() obtiene los días laborables entre dos fechas
c. SumarDiasLaborables() obtiene una fecha sumando una cantidad de días a una fecha
inicial
2. Considere fines de semanas y feriados
3. Puede guardar los feriados en un arreglo
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el año inicial");
        int.TryParse(Console.ReadLine(), out int añoInicio);
        Console.WriteLine("Ingrese el mes inicial");
        int.TryParse(Console.ReadLine(), out int mesInicio);
        Console.WriteLine("Ingrese el dia inicial");
        int.TryParse(Console.ReadLine(), out int diaInicio);
        DateTime fechaInicio = new DateTime(añoInicio, mesInicio, diaInicio);


        Console.WriteLine("Ingrese el año final");
        int.TryParse(Console.ReadLine(), out int añoFinal);
        Console.WriteLine("Ingrese el mes final");
        int.TryParse(Console.ReadLine(), out int mesFinal);
        Console.WriteLine("Ingrese el dia final");
        int.TryParse(Console.ReadLine(), out int diaFinal);
        DateTime fechaFinal = new DateTime(añoFinal, mesFinal, diaFinal);

        ObtenerDiasCalendario(fechaInicio, fechaFinal);

        Console.WriteLine("Ingrese la cantidad de feriados hay entre esos dias");
        int.TryParse(Console.ReadLine(), out int cont);
        DateTime[] contferiados = new DateTime[cont];
        for (int i = 0; i < cont; i++)
        {
            Console.WriteLine("Ingrese el año del feriado");
            int.TryParse(Console.ReadLine(), out int añoferiado);
            Console.WriteLine("Ingrese el mes del feriado");
            int.TryParse(Console.ReadLine(), out int mesferiado);
            Console.WriteLine("Ingrese el dia del feriado");
            int.TryParse(Console.ReadLine(), out int diaferiado);
            DateTime f = new DateTime(añoferiado, mesferiado, diaferiado);
            contferiados[i] = f;
        }

        

        Console.WriteLine("Ingrese la cantidad de dias que desea ver en que seran laborables a partir de la fecha incial:");
        Console.WriteLine("fecha inicial: año");
        int.TryParse(Console.ReadLine(), out int añoFuncion3);
        Console.WriteLine("fecha inicial: mes");
        int.TryParse(Console.ReadLine(), out int mesFuncion3);
        Console.WriteLine("fecha inicial: dia");
        int.TryParse(Console.ReadLine(), out int diaFuncion3);
        DateTime fechafuncion3 = new DateTime(añoFuncion3, mesFuncion3, diaFuncion3);
        Console.WriteLine("ingrese la cantidad de dias que desea ver despues de la fecha inicial (ej: 10 para 10 dias");
        int.TryParse(Console.ReadLine(), out int dias);

        int suma = diaFuncion3 + dias;

        DateTime nuevaFecha = new DateTime(añoFuncion3, mesFuncion3, suma);

        //En resumen, diasLaborables y guardar apuntarán al mismo arreglo en la memoria, lo que significa que cualquier
        //cambio realizado en guardar también se reflejará en diasLaborables, y viceversa.
        DateTime[] diasLaborables = ObtenerDiasLaborables(fechaInicio, fechaFinal, contferiados);

        Console.WriteLine("Los días laborables entre esos días serán:");
        foreach (DateTime fecha in diasLaborables)
        {
            Console.WriteLine(fecha.ToString("yyyy MM dd"));
        }

        DateTime[] diasLaborablessuma = SumarDiasLaborables(fechafuncion3, nuevaFecha, contferiados);

        Console.WriteLine($"Los dias laborables entre los días {dias} serán:");
        foreach (DateTime fecha in diasLaborablessuma)
        {
            Console.WriteLine(fecha.ToString("yyyy MM dd"));
        }
    }

    static void ObtenerDiasCalendario(DateTime fechaInicio, DateTime fechaFinal)
    {
        //obtiene los días entre dos fechas
        TimeSpan fechaDias = fechaFinal - fechaInicio;
        Console.WriteLine($"Los dias entre dos fechas sera: {fechaDias.Days}");
    }

    static DateTime[] ObtenerDiasLaborables(DateTime fechaInicio, DateTime fechaFinal, DateTime[] feriados)
    {
        //diferencia entre fechaFinal y fechaInicio como un objeto TimeSpan, y luego obtiene la propiedad Days de ese TimeSpan
        //+ 1: Esto se suma al número de días calculados para asegurar que el array tenga suficiente espacio para almacenar
        //todas las fechas entre fechaInicio y fechaFinal, incluyendo ambos extremos.
        DateTime[] guardar = new DateTime[(fechaFinal - fechaInicio).Days + 1];
        int cont = 0;
        
        for (DateTime fecha = fechaInicio; fecha <= fechaFinal; fecha = fecha.AddDays(1))
        {
            if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(fecha))
            {
                guardar[cont++] = fecha;
            }
        }

        Array.Resize(ref guardar, cont);
        return guardar;
    }

    static DateTime[] SumarDiasLaborables(DateTime fechaInicio, DateTime nuevaFecha, DateTime[] feriados)
    {
        DateTime[] guardar = new DateTime[(nuevaFecha - fechaInicio).Days + 1];
        int cont = 0;

        for (DateTime fecha = fechaInicio; fecha <= nuevaFecha; fecha = fecha.AddDays(1))
        {
            if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(fecha))
            {
                guardar[cont++] = fecha;
            }
        }

        Array.Resize(ref guardar, cont);
        //estamos redimensionando el arreglo guardar para que tenga exactamente cont elementos.
        //El modificador ref se utiliza aquí para pasar el arreglo por referencia, lo que significa que los cambios
        //realizados dentro del método afectarán al arreglo original que se pasó como argumento.
        return guardar; //Finalmente, el método devuelve el arreglo guardar con el tamaño ajustado
    }
}
