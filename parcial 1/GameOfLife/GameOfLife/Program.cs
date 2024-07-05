using System;

class GameOfLife
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int columnas = 10;
        int filas = 10;

        int[,] arreglo = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                arreglo[i, j] = random.Next(0, 2); //puede asignar o 0 o 1 (excluye al 2)
            }
        }
        Console.WriteLine("Presiona cualquier tecla para ver la siguiente generación (o 'q' para salir)...");
        while (Console.ReadKey().Key != ConsoleKey.Q)
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (arreglo[i, j] == 1)
                    {
                        Console.Write(" ■ ");
                    }
                    else
                    {
                        Console.Write(" ∆ ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int CantidadVivos = ContarVivos(arreglo, i, j, columnas, filas);
                    if (arreglo[i, j] == 1)
                    {
                        if (CantidadVivos < 2 || CantidadVivos > 3)
                        {
                            arreglo[i, j] = 0;
                        }
                        else
                        {
                            if (CantidadVivos == 3)
                            {
                                arreglo[i, j] = 1;
                            }
                        }
                    }
                    else
                    {
                        if (CantidadVivos == 3)
                        {
                            arreglo[i, j] = 1;
                        }
                    }
                }
            }

        }


    }

    public static int ContarVivos(int[,] arreglo, int valorX, int valorY, int columna, int fila)
    {
        //Se crea una nueva matriz para evitar modificar la matriz original. Se hace con int[,] nuevoArray = (int[,])arreglo.Clone();
        //esto significa que se crea una nueva matriz con las mismas dimensiones que la matriz original arreglo, pero los
        //elementos de la matriz nueva son copias de los elementos de la matriz original.Clone() crea una nueva matriz,
        //pero los elementos de ambas matrices (la original y la copiada) apuntan a las mismas ubicaciones en la memoria.
        //si modificas los elementos de la matriz copiada, también en la matriz original
        int[,] nuevoArray = (int[,])arreglo.Clone();
        int cont = 0;
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                //se calculan las coordenadas de los vecinos adyacentes sumando y restando valores de desplazamiento de la
                //matriz (i y j) a las coordenadas x e y de la célula dada
                int VecinoX = valorX + i;
                int VecinoY = valorY + j;
                //Se verifica si el vecino actual no es la misma célula dada actualmente, lo cual se hace con la condición
                //if (i == 0 && j == 0). Si es la misma célula, se omite el conteo y se pasa al siguiente vecino.
                if (j == 0 && i == 0)
                {
                    continue;
                }
                // se verifica si las coordenadas del vecino calculado están dentro de los límites del tablero 
                if (VecinoX >= 0 && VecinoX < fila && VecinoY >= 0 && VecinoY < columna)
                {
                    //se obtiene el estado de la célula en esa posición. Si el valor es 1, significa que la célula está
                    //viva, y si el valor es 0, entonces ira contando
                    cont += nuevoArray[VecinoX, VecinoY];
                }
            }
        }
        return cont;
    }
}
