/*
 dadas una fecha de inicio y una fecha de fin, la aplicación debe listar todas las fechas cuya posición en el año sea un 
número primo y que correspondan a un día entre lunes y viernes.
Las fechas deben ingresarse en orden creciente con el formato "diano:ddMMaa". Se proporciona un ejemplo para el rango entre
el 01/01/2019 y el 15/02/2019, y la salida esperada es: 2:020119,3:030119,7:070119,11:110119,17:170119,23:230119,29:290119,31:310119,37:060219,43:120219.
Se aclara que, por ejemplo, el quinto día del año, aunque es un número primo, no se lista porque corresponde a un sábado.
Como ayuda, se proporcionan los primeros 10 números primos: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29.
Finalmente, se solicita ingresar el resultado considerando las fechas entre el 01/10/2018 y el 10/09/2019, y se indica que la pista es que son 47 fechas.
 */

using System.Security.Cryptography.X509Certificates;

using System;

internal class Program
{
    static void Main(string[] args)
    {
        int cont = 0;
        Console.WriteLine("Ingrese el año de inicio");
        int.TryParse(Console.ReadLine(), out int año1);
        Console.WriteLine("Ingrese el mes de inicio");
        int.TryParse(Console.ReadLine(), out int mes1);
        Console.WriteLine("Ingrese el día de inicio");
        int.TryParse(Console.ReadLine(), out int dia1);

        DateTime fechaInicio = new DateTime(año1, mes1, dia1);

        Console.WriteLine("Ingrese el año final");
        int.TryParse(Console.ReadLine(), out int año2);
        Console.WriteLine("Ingrese el mes final");
        int.TryParse(Console.ReadLine(), out int mes2);
        Console.WriteLine("Ingrese el día final");
        int.TryParse(Console.ReadLine(), out int dia2);
        DateTime fechaFinal = new DateTime(año2, mes2, dia2);

        Console.WriteLine("Las fechas cuya posición en el año es un número primo y que no son fines de semana son:");

        for (DateTime fecha = fechaInicio; fecha <= fechaFinal; fecha = fecha.AddDays(1))
        {
            if (EsPrimo(fecha.DayOfYear) && fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
            {
                Console.WriteLine($"{cont}: {fecha:ddMMyyyy}");
                cont++;
            }
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero == 2)
            return true;
        if (numero % 2 == 0)
            return false;

        int raizCuadrada = (int)Math.Sqrt(numero);
        for (int i = 3; i <= raizCuadrada; i += 2)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
