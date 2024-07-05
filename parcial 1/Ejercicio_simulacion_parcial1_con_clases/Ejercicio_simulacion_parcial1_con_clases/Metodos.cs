using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_simulacion_parcial1_con_clases
{
    internal class Metodos
    {
        public  DateTime[][] UnirIntervalos(DateTime[][] intervalos)
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
                                                            // contar como un nuevo intervalo
                    count++;
            }

            DateTime[][] resultado = new DateTime[count][]; //pongo cont porque me cuenta los intervalos nuevos (los que se superpusieron
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
}
