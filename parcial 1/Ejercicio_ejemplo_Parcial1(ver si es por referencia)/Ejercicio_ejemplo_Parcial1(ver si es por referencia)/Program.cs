class Test
{
    public int valor { get; set; }
}
class Program
{
    private static void Main(string[] args)
    {
        Test maint = new Test();
        maint.valor = 24;
        incrementa(ref maint);
        Console.WriteLine($"El valor es {maint.valor}");
    }
    static void incrementa(ref Test test)
    {
        test = new Test();
        test.valor = test.valor + 1;
    }
}

