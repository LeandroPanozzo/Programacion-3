using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        CallPorValor();

        CallPorRef();

        CallDeSalida(); //tambien son por referenacia pero recibo valores desde el metodo y no y no hacia el

        CallPorParams();

        CallPorIn();

        CallPorParametrosNombrados();
    }

    //LLAMADA POR VALOR
    public static void CallPorValor()
    {
        int x = 9; int y = 10;
        Console.WriteLine($"Antes de la llamada x: {x} y y {y}");
        Console.WriteLine($"El resultado: {SumarValor(x)}");
        Console.WriteLine($"Despues de la llamada: x {x} Y: {y}");
    }

    static int SumarValor(int x,int y=0) //poniendo =0 se vuelve parametro opcional
    {
        int z = x + y;
        x = 10000; y = 8888;
        //si vuelvo a sumar entonces el valor de z sera la suma de los valores x e y reasignados y
        //al llamar a la funcion z tendra ese valor
        return z;
    }

    //LLAMADA POR REFERENCIA
    static void CallPorRef() //estamos pasando tipos por valor como referencia
    {
        int x = 9; int y = 10;
        Console.WriteLine($"Antes de la llamada x: {x} y y {y}");
        Console.WriteLine($"El resultado: {SumarPorRef(ref x, ref y)}");//pongo ref para que sea por refrencia
        Console.WriteLine($"Despues de la llamada: x {x} Y: {y}"); //los valores de x e y seran X=10000 e y=8888
    }

    static int SumarPorRef(ref int x, ref int y) //pongo ref para que sea por refrencia
    {
        int z = x + y;
        x = 10000; y = 8888;
        return z;
    }

    //LLAMADA DE SALIDA
    public static void CallDeSalida() //utilizo procedimiento (void), no funcion
    {
        int x = 9; int y = 10;
        Console.WriteLine($"Antes de la llamada x: {x} y y {y}");
        SumarPorSalida(x, y, out int z); //debo poner out
        Console.WriteLine($"El resultado: {z}");
        Console.WriteLine($"Despues de la llamada: x {x} Y: {y}");
    }

    static void SumarPorSalida( int x,  int y, out int z) //son de tipo void con out
    {
         z = x + y;
        x = 10000; y = 8888;
        
    }


    //LLAMADA CON PARAMS
    static void CallPorParams()
    {
        int x = 9; int y = 10;
        Console.WriteLine($"Antes de la llamada x: {x} y y {y}");
        Console.WriteLine($"El resultado es {CalcularPromedio(x,y)}"); //es como el pasaje por valor
        Console.WriteLine($"Despues de la llamada: x {x} Y: {y}");
    }

    //pongo objects en lugar de int para que sean de diferentes tipos, object empaqueta a un tipo especifico
    static double CalcularPromedio(params int[] values) //acepta una cantidad indeterminada de valores, esta hecho solo como parametro de entrada
    {
        Console.WriteLine($"Enviaste {values.Length} valores ");
        double sum = 0;

        if (values.Length == 0)
        
            return sum;
        
        for (int i = 0; i < values.Length; i++)
        
            sum += values[i];
            return (sum/values.Length);
        
    }


    // LLAMADA POR IN
    static void CallPorIn()
    {
        int x = 9;
        int y = 10;
        Console.WriteLine($"Antes de la llamada x: {x} y y: {y}");
        SumarPorIn(in x, in y, out int z);
        Console.WriteLine($"El resultado: {z}");
        Console.WriteLine($"Después de la llamada: x {x} y: {y}");
    }

    static void SumarPorIn(in int x, in int y, out int z)
    {
        z = x + y;
        // x = 10000; // Esto causaría un error, ya que 'x' es de solo lectura debido al modificador 'in'
        // y = 8888; // Esto también causaría un error, ya que 'y' es de solo lectura debido al modificador 'in'
    }


    // LLAMADA CON PARÁMETROS NOMBRADOS
    static void CallPorParametrosNombrados()
    {
        int x = 9;
        int y = 10;
        Console.WriteLine($"Antes de la llamada x: {x} y y: {y}");
        Console.WriteLine($"El resultado es {CalcularPromedio(values: new int[] { x, y, z: 15 })}"); // Parámetro 'values' nombrado
        Console.WriteLine($"Después de la llamada: x {x} y: {y}");
    }
}