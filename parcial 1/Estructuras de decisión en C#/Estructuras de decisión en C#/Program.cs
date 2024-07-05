/*
 Objetivo: Comprender la aplicación de las estructuras de decisión.
Ejercicio:

Cree una aplicación de consola.
Solicite el ingreso de un texto y controle que no esté vacío.
Despliegue un menú que muestre 3 opciones (Texto en mayúscula, Texto en minúscula y Texto Original).
Capture la entrada con Console.Readkey y realice la opción solicitada.
 */
using System.Reflection;

internal class Program
{
    static void Main(string[] args)
    {
        bool seguir = true;

        do
        {
            Console.WriteLine("Ingrese un texto:");
            string texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("No ha ingresado ningún texto. Por favor, inténtelo de nuevo.");
            }
            else
            {
                bool resp = true;

                while (resp)
                {
                    Console.WriteLine("\n1-Mostrar texto en mayúsculas");
                    Console.WriteLine("2-Mostrar texto en minúsculas");
                    Console.WriteLine("3-Mostrar texto original");
                    Console.WriteLine("4-Salir");

                    

                    switch (Console.ReadKey().Key)//Console.ReadKey().Key se utiliza para leer la tecla que el usuario presiona después de ingresar el texto. 
                    {
                        case ConsoleKey.D1: // Estos casos se activan cuando el usuario presiona la tecla "1" desde el teclado normal (no en el teclado numérico) o la tecla "1" en el teclado numérico, respectivamente.
                        case ConsoleKey.NumPad1:
                            Console.WriteLine("\n" + texto.ToUpper());
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Console.WriteLine("\n" + texto.ToLower());
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Console.WriteLine("\n" + texto);
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Console.WriteLine("\nPrograma finalizado.");
                            resp = false;
                            break;
                        default:
                            Console.WriteLine("\nOpción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        } while (seguir);
    }
}