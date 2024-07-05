/*
 Objetivo: implementar varias clases y sus asociaciones, usar propiedades, enumeraciones o constantes donde se necesite.

Modifique el juego anterior

Dos jugadores, Dos dados y Apuestas
Tres modos de apuesta {conservador -1/2, arriesgado -2/5, desesperado -4/15}
Cada jugador cuenta con $100 iniciales y un pozo de $10000.
El juego termina cuando el pozo o el saldo de algún jugador llega a cero.
 */

using DadosParte2;

internal class Program
{
    private static void Main(string[] args)
    {
        int saldo1 = 100;
        int apuesta1 = 0;
        int apuesta2 = 0;
        int saldo2 = 100;
        Jugadores j1 = new Jugadores(saldo1, "j1");
        Jugadores j2 = new Jugadores(saldo2, "j2");
        int casino = 10000;
        Dado d = new Dado();
        int prueba = (saldo2 * 15) + (saldo1 * 15);
        int pruebaj1 = saldo1 * 4;
        int pruebaj2 = saldo2 * 4;
        if (casino >= prueba)
        {
            Console.WriteLine("Ingrese el numero que saldra de la suma de ambos dados para jugador1:");
            int.TryParse(Console.ReadLine(), out int dados1);
            Console.WriteLine($"ingrese cuanto apostara el jugador 1, su saldo actual es{saldo1}");
            int.TryParse(Console.ReadLine(), out apuesta1);
            Console.WriteLine("Ingrese su tipo de apuesta: ");
            foreach (Apuestas.apuestas valor in Enum.GetValues(typeof(Apuestas.apuestas)))
            {
                Console.WriteLine(valor);
            }
            string eleccion1 = Console.ReadLine().ToLower();

            switch (eleccion1)
            {
                case "conservador":

                    pruebaj1 = apuesta1;
                    if (saldo1 > pruebaj1)
                    {
                        Console.WriteLine("Ingrese el numero que saldra de la suma de ambos dados para jugador2:");
                        int.TryParse(Console.ReadLine(), out int dados2);
                        Console.WriteLine($"ingrese cuanto apostara el jugador 2, su saldo actual es{saldo2}");
                        int.TryParse(Console.ReadLine(), out apuesta2);
                        Console.WriteLine("Ingrese su tipo de apuesta: ");
                        foreach (Apuestas.apuestas valor in Enum.GetValues(typeof(Apuestas.apuestas)))
                        {
                            Console.WriteLine(valor);
                        }
                        string eleccion2 = Console.ReadLine().ToLower();
                        switch (eleccion2)
                        {
                            case "conservador":
                                pruebaj2 = apuesta2;
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;

                            case "arriesgado":
                                pruebaj2 = (apuesta2 * 2);
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;

                            case "desesperado":
                                pruebaj2 = (apuesta2 * 4);
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("Ingreso una opcion incorracta");
                                break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("El jugador 1 no tiene ese dinero");
                        break;
                    }

                    break;

                case "arriesgado":
                    pruebaj1 = (apuesta1 * 2);
                    if (saldo1 > pruebaj1)
                    {
                        Console.WriteLine("Ingrese el numero que saldra de la suma de ambos dados para jugador2:");
                        int.TryParse(Console.ReadLine(), out int dados2);
                        Console.WriteLine($"ingrese cuanto apostara el jugador 2, su saldo actual es{saldo2}");
                        int.TryParse(Console.ReadLine(), out apuesta2);
                        Console.WriteLine("Ingrese su tipo de apuesta: ");
                        foreach (Apuestas.apuestas valor in Enum.GetValues(typeof(Apuestas.apuestas)))
                        {
                            Console.WriteLine(valor);
                        }
                        string eleccion2 = Console.ReadLine().ToLower();
                        switch (eleccion2)
                        {
                            case "conservador":
                                pruebaj2 = apuesta2;
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;

                            case "arriesgado":
                                pruebaj2 = (apuesta2 * 2);
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;

                            case "desesperado":
                                pruebaj2 = (apuesta2 * 4);
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("Ingreso una opcion incorracta");
                                break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("El jugador 1 no tiene ese dinero");
                        break;
                    }
                    break;
                case "desesperado":
                    pruebaj1 = (apuesta1 * 4);
                    if (saldo1 > pruebaj1)
                    {
                        Console.WriteLine("Ingrese el numero que saldra de la suma de ambos dados para jugador2:");
                        int.TryParse(Console.ReadLine(), out int dados2);
                        Console.WriteLine($"ingrese cuanto apostara el jugador 2, su saldo actual es{saldo2}");
                        int.TryParse(Console.ReadLine(), out apuesta2);
                        Console.WriteLine("Ingrese su tipo de apuesta: ");
                        foreach (Apuestas.apuestas valor in Enum.GetValues(typeof(Apuestas.apuestas)))
                        {
                            Console.WriteLine(valor);
                        }
                        string eleccion2 = Console.ReadLine().ToLower();

                        switch (eleccion2)
                        {
                            case "conservador":
                                pruebaj2 = apuesta2;
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;

                            case "arriesgado":
                                pruebaj2 = (apuesta2 * 2);
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 1 no tiene ese dinero");
                                    break;
                                }
                                break;

                            case "desesperado":
                                pruebaj2 = (apuesta2 * 4);
                                if (saldo2 > pruebaj2)
                                {
                                    d.Lanzar(dados1, dados2, eleccion1, eleccion2, ref apuesta1, ref apuesta2, ref casino, ref saldo1, ref saldo2);

                                    Console.WriteLine($"El saldo actual del jugador1 es {saldo1}");
                                    Console.WriteLine($"El saldo actual del jugador2 es {saldo2}");
                                    Console.WriteLine($"El saldo actual del casino es {casino}");
                                }
                                else
                                {
                                    Console.WriteLine("El jugador 2 no tiene ese dinero");
                                    break;
                                }
                                break;

                            default:
                                Console.WriteLine("Ingreso una opcion incorracta");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El jugador 1 no tiene ese dinero");
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Ingreso una opcion incorracta");
                    break;
            }

        }
        else
        {
            Console.WriteLine("No hay sufieciente dinero en el pozo");
        }

    }
}