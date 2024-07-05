/*
 Consigna:
• El astrologo Baltazar Lazar requiere una aplicación que le facilite su trabajo para la creación del horóscop zodiacal 
semanal.
• Antes de hacer la predicción se deberá solicitar: nombre y fecha de nacimiento.
• Recuerde que a cada signo zodiacal le corresponde un periodo fijo, de aproximadamente 30 días cada año.
• Según la fecha de nacimiento, se determinará que signo le corresponde.
• La predicción para cada signo cuenta con tres aspectos: bienestar, dinero y amor.
• Existe un conjunto de frases genéricas para cada aspecto que la astrologa redactó de antemano (no importa el signo).
• Para hacer la predicción de cada aspecto, se tomará una frase "al azar" de su respectivo conjunto.
• Si bien es "al azar, se deberá devolver la misma predicción para idéntica combinación de fecha de nacimiento y semana del
año particular en que se consulta.
• Como funcionalidad adicional, deberá darle su signo compatible para la semana, con similar
comportamiento de aleatoriedad explicado arriba.
Consideraciones:
• Elabore una aplicación de consola en C#.
• Podrá hacer uso de los elementos del lenguaje vistos hasta el momento.
• Los signos y el conjunto de predicciones posibles para cada aspecto estarán precargados en el programa.
• Deberá incluir al menos tres signos para las pruebas del programa.
• En el archivo adjunto se incluyen frases para cada aspecto que podrá usar.
• Además de la funcionalidad del código se valorará su correcto diseño.
• Asegúrese de incluir todos los archivos de la solución en un archivo zip.
 */
using Microsoft.VisualBasic;
using System.Globalization;
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombre=Console.ReadLine();
        Console.WriteLine("Ingrese el año que nacio: ");
        int.TryParse(Console.ReadLine(), out int año);
        Console.WriteLine("Ingrese el mes que nacio: ");
        int.TryParse(Console.ReadLine(), out int mes);
        Console.WriteLine("Ingrese el dia que nacio: ");
        int.TryParse(Console.ReadLine(), out int dia);
        DateTime fecha = new DateTime(año,mes,dia);

        CultureInfo cu = CultureInfo.CurrentCulture;//primero obtiene la información de la cultura actual
                                                    //(CultureInfo.CurrentCulture), que incluye la regla de la semana
                                                    //del calendario (CalendarWeekRule)
        Calendar calendar = cu.Calendar;//representa el calendario asociado con la cultura especificada
                                        //ci.DateTimeFormat.CalendarWeekRule:

        //Este es el segundo argumento del método.Define la regla que se utilizará para determinar la primera semana del
        //año.Está basado en las configuraciones culturales actuales(CultureInfo).Diferentes culturas pueden tener
        //diferentes reglas sobre qué constituye la primera semana del año
        int semanaDelAño = calendar.GetWeekOfYear(fecha, cu.DateTimeFormat.CalendarWeekRule, cu.DateTimeFormat.FirstDayOfWeek);
        //cu.DateTimeFormat.FirstDayOfWeek Este es el tercer y último argumento. Indica cuál es el primer día de la semana según la cultura actual
        //(CultureInfo). Por ejemplo, en muchos países de occidente el primer día de la semana es el domingo, mientras
        //que en otros puede ser el lunes o cualquier otro día. Esto influye en cómo se calculan las semanas del año.

        int suma = año + mes + dia + semanaDelAño;


        string[] signosCompatibles = {"Acuario", "Piscis", "Aries", "Tauro", "Géminis", "Cáncer",
            "Leo", "Virgo", "Libra", "Escorpio", "Sagitario", "Capricornio" };

        string[] aspectos = { "Bienestar: te va a ir bien en la vida", "Dinero: vas a tener mucha plata", "amor: vas a encontrar pareja" };

        string signo = ObtenerSigno(fecha);

        Console.WriteLine($"El usuario: {nombre} es del signo: {signo}");

        PrediccionYCompatibles(signosCompatibles, aspectos, suma);

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    public static string ObtenerSigno(DateTime fechaNacimiento)
    {
        int dia = fechaNacimiento.Day;
        int mes = fechaNacimiento.Month;
        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
            return "Aries";
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
            return "Tauro";
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            return "Géminis";
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            return "Cáncer";
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            return "Leo";
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            return "Virgo";
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            return "Libra";
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            return "Escorpio";
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            return "Sagitario";
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            return "Capricornio";
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            return "Acuario";
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
            return "Piscis";
        else
            return "Error: Fecha de nacimiento no válida";
    }

    public static void PrediccionYCompatibles(string[] signosCompatibles, string[] aspectos, int suma)
    {
        for (int i = 0; i < suma; i++)//solo itera hasta el valor final porque empieza en 0
        {
            int indice = i % aspectos.Length; //si i es mayor que arreglo.Length, lo que significa que hemos excedido
                                              //el tamaño del arreglo en nuestras iteraciones. Al tomar el resto de la
                                              //división por arreglo.Length, nos aseguramos de que el índice resultante
                                              //esté dentro del rango válido. Si i es menor que arreglo.Length, el resultado
                                              //será simplemente i, lo que significa que accederemos al elemento en la
                                              //posición i del arreglo esta línea de código nos proporciona un índice que será cíclico
                                              

            // Solo imprimir el valor en la posición 
            if (i == suma - 1)
            {
                Console.WriteLine("Su predicción semanal será:");
                Console.WriteLine(aspectos[indice]);

                Console.WriteLine("El signo compatible con usted esta semana será:");
                Console.WriteLine(signosCompatibles[indice]);
            }
            
        }
    }
}