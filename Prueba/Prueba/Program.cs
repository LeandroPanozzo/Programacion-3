public class Prueba
{
    public void procedimiento<M>(M m)
    {
        Console.WriteLine(m);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Prueba prueba = new Prueba();
        prueba.procedimiento<string>("Prog3");
        prueba.procedimiento<int>(3);
    }
}