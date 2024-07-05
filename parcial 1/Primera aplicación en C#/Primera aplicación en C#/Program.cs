/*
 Objetivo: Comprender el uso de variables, asignaciones y operaciones de forma simple en C#.

Cree una aplicación de consola
Solicite el ingreso de dos valores por pantalla
Al final muestre en forma descriptiva los resultados de aplicar las cuatro operaciones básicas
 */
internal class Program
{
    private static void Main(string[] args)
    {
        string continuar = "";
        while (continuar!="n") {
            Console.WriteLine("ingrese el primer valor");
            double.TryParse(Console.ReadLine(), out double val1);
            Console.WriteLine("ingrese el segundo valor");
            double.TryParse(Console.ReadLine(), out double val2);
            Console.WriteLine("suma: ");
            double suma= val1+val2;
            Console.WriteLine($"{val1} + {val2} = {suma}");
            Console.WriteLine("resta: ");
            double resta = val1 - val2;
            Console.WriteLine($"{val1} - {val2} = {resta}");
            Console.WriteLine("multiplicacion: ");
            double mult = val1 * val2;
            Console.WriteLine($"{val1} * {val2} = {mult}");
            
            Console.WriteLine("division: ");

            
                double divi = val1 / val2;
                Console.WriteLine($"{val1} / {val2} = {divi}");
                Console.WriteLine("si desea salir presione n");
                continuar = Console.ReadLine().ToLower();
                
            

        }
    }
}