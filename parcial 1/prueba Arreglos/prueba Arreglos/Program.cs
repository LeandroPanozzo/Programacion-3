using System.Xml.Linq;

internal class Program
{
    static void Main()
    {
        /*
            int[] arr = { 1, 4, 5 };
            
            Console.WriteLine($"Dentro de Main, antes de llamar al método, el primer elemento es: {arr [0]}");
            Cambiar(arr);
            Console.WriteLine($"Dentro de Main, luego de llamar al método, el primer elemento es: {arr [0]}"); // cambiara su valor por 888 pero solo en los array, si quiero que suceda lo mismo en un int uso ref y saldra con el valor asignado por el metodo
        */

        //GetUpperBound
        // Definimos una matriz multidimensional
        int[,] matriz = new int[3, 4];
                                                //o tambien:
        //int[,] matriz1 = { { 1, 2, 3 }, { 3, 2, 1 } }; //2 filas y 3 columnas
        // Llenamos la matriz con algunos valores
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = i * 10 + j;
            }
        }
        
        // Obtenemos el índice máximo permitido en la primera dimensión de la matriz
        int maxIndicePrimeraDimension = matriz.GetUpperBound(0); //para mostrar la cantidad de filas en este caso 2 (0, 1 y 2) 

        // Obtenemos el índice máximo permitido en la segunda dimensión de la matriz
        int maxIndiceSegundaDimension = matriz.GetUpperBound(1); //para mostrar la cantidad de columnas en este caso 3 (0, 1, 2 y 3)

        //Console.WriteLine(matriz1.Length); //mostrara el 6 porque son 6 valores en el arreglo, si fuera [][] hace NxN

        // Mostramos los índices máximos permitidos en ambas dimensiones
        Console.WriteLine("Índice máximo permitido en la primera dimensión: " + maxIndicePrimeraDimension);
        Console.WriteLine("Índice máximo permitido en la segunda dimensión: " + maxIndiceSegundaDimension);
    }
    static void Cambiar(int[] pArray)
    {
        pArray[0] = 888;
        pArray = new int[5] { -3, -1, -2, -3, -4 };
        Console.WriteLine($"Dentro del método, el primer elemento es: {pArray[0]}" );
    }

    
}