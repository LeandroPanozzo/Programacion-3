internal class Program
{
    private static void Main(string[] args)
    {
        //Enum.GetValues obtiene una matriz de todos los valores del enum DiasDeLaSemana.
        //typeof(DiasDeLaSemana) obtiene el tipo del enum
        foreach(DiasSemana d in Enum.GetValues(typeof(DiasSemana)))
        {
            Console.WriteLine(d);
        }

        //recorrer los valores del enum junto con sus valores enteros
        foreach (DiasSemana d in Enum.GetValues(typeof(DiasSemana)))
        {
            Console.WriteLine($"dias {d} = {(int)d}");
        }
    }
}

public enum DiasSemana
{
    lunes, martes, miercoles, jueves, viernes, sabado, domingo
}