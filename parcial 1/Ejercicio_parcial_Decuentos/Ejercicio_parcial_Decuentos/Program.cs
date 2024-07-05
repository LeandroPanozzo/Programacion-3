/*
 Un comercio de la ciudad cumple su 20º aniversario y desea ofrecer a sus clientes la posibilidad de ganarse premios 
consistentes en distintos descuentos aplicables a futuras compras en el local y de esa manera promocionar su negocio.
El juego consiste en una lotería instantánea que posee 5 números, cada número puede ir de 0 a 50 inclusive y no se pueden repetir.
El cliente debe tratar de adivinar los 5 números, aunque tiene premios menores de acuerdo con la cantidad de aciertos, 
según el siguiente detalle:
• Un acierto 10% de descuento en la próxima compra
• Dos aciertos 20% de descuento en la próxima compra
• Tres aciertos 30% de descuento en la próxima compra
• Cuatro aciertos 50% de descuento en la próxima compra
• Cinco aciertos 100% de descuento en la próxima compra
Al final, el programa le presentará el resultado con la fecha de vencimiento para poder canjear el premio, que son 30 días
a partir de la fecha de juego.
Para poder jugar el cliente deberá introducir el número de ticket de la compra, el monto descontado no podrá superar el 
doble del total comprado.
Consideraciones:
• Elabore una aplicación de consola en C#.
• Podrá hacer uso de los elementos del lenguaje vistos hasta el momento.
• Debe validar las entradas del usuario.
• Además de la funcionalidad del código se valorará su correcto diseño.
• Asegúrese de incluir todos los archivos de la solución en un archivo.zip.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Random ran = new Random();
        int[] valores = new int[5];
        int cont = 0;
        double ticket;
        Console.WriteLine("ingrese el valor del ticket de su compra:");

        while (!double.TryParse(Console.ReadLine(), out ticket) || ticket <= 0)
        {
            Console.WriteLine("Valor inválido. Intente de nuevo:");
        }

        /*
         for (int i = 0; i < 5; i++)
        {
            int eleccion;
            while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 0 || eleccion > 50)
            {
                Console.WriteLine("Valor inválido. Intente de nuevo:");
            }

            if (valores.Contains(eleccion))
            {
                aciertos++;
            }
        }
         */
        while (cont<5)
        {
            int valor = ran.Next(0, 51); //genera numeros entre 0 a 50
            if (!valores.Contains(valor))
            {
                valores[cont] = valor;
                cont++;
            }
        }

        Console.WriteLine("trate de adivinar los 5 valores (pueden ser del 0 al 50)");
        int aciertos=0;
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("ingrese el valor:");
            int.TryParse(Console.ReadLine(), out int eleccion);

            if (valores.Contains(eleccion))
            {
                aciertos++;
            }
        }
        DateTime d = DateTime.Now;
        d = d.AddDays(30);
        double descuento, valorDescuento;
        if (aciertos == 0)
        {
            Console.WriteLine($"No acerto ninguno :(");
        }
        if (aciertos == 1)
        {
            descuento = ticket * 0.10;
            valorDescuento = ticket - descuento;
            Console.WriteLine($"El descuento sera de 10% ${valorDescuento} valido hasta {d.ToLongDateString()}");
        }
        if (aciertos == 2)
        {
            descuento = ticket * 0.20;
            valorDescuento = ticket - descuento;
            Console.WriteLine($"El descuento sera de 20% ${valorDescuento} valido hasta {d.ToLongDateString()}");
        }
        if (aciertos == 3)
        {
            descuento = ticket * 0.30;
            valorDescuento = ticket - descuento;
            Console.WriteLine($"El descuento sera de 30% ${valorDescuento} valido hasta {d.ToLongDateString()}");
        }
        if (aciertos == 4)
        {
            descuento = ticket * 0.50;
            valorDescuento = ticket - descuento;
            Console.WriteLine($"El descuento sera de 50% ${valorDescuento} valido hasta {d.ToLongDateString()}");
        }
        if (aciertos == 5)
        {
            descuento = ticket; //descuento del 100
            valorDescuento = ticket - descuento;
            Console.WriteLine($"El descuento sera de 100% ${valorDescuento} valido hasta {d.ToLongDateString()}");
        }
    }
}