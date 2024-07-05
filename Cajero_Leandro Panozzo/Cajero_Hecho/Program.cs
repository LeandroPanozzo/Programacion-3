using Cajero_Hecho;

internal class Program
{
    private static void Main(string[] args)
    {
        Cuenta_bancaria[] b = new Cuenta_bancaria[5];
        Random r = new Random();

        for(int i=0; i<b.Length; i++)
        {
            if(r.Next(0,2) == 0)
            {
                //se crea una nueva instancia de Cuenta_Ahorro y se asigna a la posición i del arreglo b
                b[i] = new Cuenta_Ahorro();
            }
            else
            {
                b[i] = new Cuenta_Corriente();
            }
        }
         
        for(int i=0; i<100; i++)
        {
            int indiceDeCuentas = r.Next(b.Length);
            double monto = r.Next(1000); //monto aleatorio de 0 a 1000
            bool esDeposito = r.Next(2)==0; //deposito o extraccion aleatoria
            if (esDeposito)
            {
                b[indiceDeCuentas].Depositar(monto); 
                Console.WriteLine($"Deposito {monto} en la cuenta {indiceDeCuentas}, Saldo luego de la operacion {b[indiceDeCuentas].Saldo}");
            }
            else
            {
                bool extraccion = b[indiceDeCuentas].Extraccion(monto);
                if (extraccion)
                {
                    Console.WriteLine($"Extraccion {monto} en la cuenta {indiceDeCuentas}, saldo luego de la operacion {b[indiceDeCuentas].Saldo}");
                }
                else
                {
                    Console.WriteLine("No se pudo extraer el dinero de la creunta porque supera el limite permitido");
                }
                
                
            }

        }

        Console.WriteLine("Resumen final");
        for(int i= 0; i < b.Length; i++)
        {
            Console.WriteLine($"Cuenta {i}: {b[i].Saldo}");
        }
    }
}