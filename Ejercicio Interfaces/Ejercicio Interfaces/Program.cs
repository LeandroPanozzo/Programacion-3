using Ejercicio_Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro[] catalogos = new Libro[5];

        catalogos[0] = new Libro("Jose", "J");
        catalogos[1] = new Libro("pepe", "D");
        catalogos[2] = new Libro("dsfsdf", "M");
        catalogos[3] = new Libro("lfgl", "A");
        catalogos[4] = new Libro("kdfk", "B");


        //Cuando llamas a Array.Sort, la clase de los elementos de la matriz debe implementar la interfaz IComparable o
        //debe proporcionar un comparador externo para la ordenación personalizada. Si los elementos de la matriz
        //implementan IComparable, Array.Sort utiliza el método CompareTo definido en esa clase para comparar los
        //elementos y determinar su orden relativo.
        Array.Sort(catalogos);

        for(int i=0; i<catalogos.Length; i++)
        {
            catalogos[i].Descripcion();
        }
        foreach(Libro l in  catalogos)
        {
            Console.WriteLine(l);
        }

    }
}