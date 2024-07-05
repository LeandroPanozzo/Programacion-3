using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosParte2
{
    internal class Dado
    {
        Random random = new Random();
        bool result1;
        bool result2;


        public void Lanzar(int jugadordado1, int jugadordado2, string apuesta1, string apuesta2, ref int monto1, ref int monto2, ref int result, ref int saldo1, ref int saldo2)
        {
            int valor = random.Next(0, 7);
            int valor2 = random.Next(0, 7);

            int reult = valor2 + valor;

            if (reult == jugadordado1)
            {
                result1 = true;
            }
            else
            {
                result1 = false;
            }
            if (reult == jugadordado2)
            {

                result2 = true;
            }
            else
            {

                result2 = false;
            }

            if (result1 == true)
            {
                Console.WriteLine("ganaste jugador 1");

                switch (apuesta1)
                {
                    case "conservador":

                        result -= monto1;

                        saldo1 += monto1;
                        break;

                    case "arriesgado":
                        result -= (monto1 * 5);
                        saldo1 += monto1 * 5;
                        break;
                    case "desesperado":
                        result -= (monto1 * 15);
                        saldo1 += monto1 * 15;
                        break;
                    default:
                        Console.WriteLine("Ingreso una opcion incorracta");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"perdiste, el valor del dado1 es {valor} y el de dado 2 es {valor2}");

                switch (apuesta1)
                {
                    case "conservador":
                        result += monto1;
                        saldo1 -= monto1;
                        break;

                    case "arriesgado":
                        result += (monto1 * 2);
                        saldo1 -= monto1 * 2;
                        break;
                    case "desesperado":
                        result += (monto1 * 4);
                        saldo1 -= monto1 * 4;
                        break;
                    default:
                        Console.WriteLine("Ingreso una opcion incorracta");
                        break;
                }
            }
            if (result1 == true)
            {
                Console.WriteLine("ganaste jugador 2");
                switch (apuesta2)
                {
                    case "conservador":
                        result -= monto2;
                        saldo2 += monto2;
                        break;

                    case "arriesgado":
                        result -= (monto2 * 5);
                        saldo2 += monto2 * 5;
                        break;
                    case "desesperado":
                        result -= (monto2 * 15);
                        saldo2 += monto2 * 15;
                        break;
                    default:
                        Console.WriteLine("Ingreso una opcion incorracta");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"perdiste, el valor del dado1 es {valor} y el de dado 2 es {valor2}");
                switch (apuesta2)
                {
                    case "conservador":
                        result += monto2;
                        saldo2 -= monto2;
                        break;

                    case "arriesgado":
                        result += (monto2 * 2);
                        saldo2 -= monto2 * 2;
                        break;
                    case "desesperado":
                        result += (saldo2 * 4);
                        saldo2 -= monto2 * 4;
                        break;
                    default:
                        Console.WriteLine("Ingreso una opcion incorracta");
                        break;
                }
            }
        }
    }
}
