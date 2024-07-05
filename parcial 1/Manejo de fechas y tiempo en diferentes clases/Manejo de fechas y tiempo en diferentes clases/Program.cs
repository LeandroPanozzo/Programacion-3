using Manejo_de_fechas_y_tiempo_en_diferentes_clases;

internal class Program
{
    public static void Main(string[] args)
    {
        ClassSumarDiasLaborables SDL=new ClassSumarDiasLaborables();
        ClassObtenerDiasCalendario ODC = new ClassObtenerDiasCalendario();
        ClassObtenerDiasLaborables ODL = new ClassObtenerDiasLaborables();
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
        ODC.ObtenerDiasCalendario(fechaInicio, fechaFinal);
        


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
        
        DateTime[] diasLaborables = ODL.ObtenerDiasLaborables(fechaInicio, fechaFinal, contferiados);

        Console.WriteLine("Los días laborables entre esos días serán:");
        foreach (DateTime fecha in diasLaborables)
        {
            Console.WriteLine(fecha.ToString("yyyy MM dd"));
        }
        
        DateTime[] diasLaborablessuma = SDL.SumarDiasLaborables(fechafuncion3, nuevaFecha, contferiados);

        Console.WriteLine($"Los dias laborables entre los días {dias} serán:");
        foreach (DateTime fecha in diasLaborablessuma)
        {
            Console.WriteLine(fecha.ToString("yyyy MM dd"));
        }
    }
}