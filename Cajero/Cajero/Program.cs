using System;
/*
jerarquia de herencia dond hay 2 tipos (caja ahorro o cuenta corriente) caja de ahorro: su limite es 0
caja corriente: puede tener saldo negativo y me cobra intereses dia a dia, tambien tiene un tope en negativo
tenemos un arreglo de 5 posiciones y dentro cargamos una instancia de la caja de ahorro, otra de cuenta corriente y asi. 
para cargar de ambos tipos tienen que ser de una clase superior de la que heredan ambas es decir una clase cuenta bancaria
tomamos ese arreglo en un bucle que haga 100 iteraciones y sobre la cuenta decidimos si hago un deposito o extraccion 
(la cuenta debe elegirse de forma aleatoria) . al final de la iteracion muestro un resumen de lo que tendria el saldo de 
cada cuenta. tambien el monto de deposito y extraccion debe ser aleatorio como tambien la eleccion de la cuenta que esta 
en el arreglo en la que iteraremos 100 veces. de interes podemos cobrar un 1% diario
 */
abstract class CuentaBancaria
{
    public double Saldo { get; protected set; }

    public abstract void Depositar(double monto);
    public abstract bool Extraer(double monto);
}

class CajaAhorro : CuentaBancaria
{
    public override void Depositar(double monto)
    {
        Saldo += monto;
    }

    public override bool Extraer(double monto)
    {
        if (Saldo >= monto)
        {
            Saldo -= monto;
            return true;
        }
        else
        {
            return false;
        }
    }
}

class CuentaCorriente : CuentaBancaria
{
    private double limiteNegatico;
    private double interes = 0.01; // 1% de interés diario
    public double LimiteNegatico { get => limiteNegatico; set => limiteNegatico = value; }
    public double Interes { get => interes; set => interes = value; }
    public CuentaCorriente(double limiteNegatico)
    {
        this.LimiteNegatico = limiteNegatico;
    }


    public override void Depositar(double monto)
    {
        Saldo += monto;
    }

    public override bool Extraer(double monto)
    {
        if (Saldo - monto >= -LimiteNegatico)
        {
            Saldo -= monto;
            if (Saldo < 0)
            {
                Saldo -= Saldo * Interes; // Aplicar interés
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria[] cuentas = new CuentaBancaria[5];
        Random random = new Random();

        // Inicializar cuentas
        for (int i = 0; i < cuentas.Length; i++)
        {
            if (random.Next(2) == 0) //Esto significa que el método generará un número aleatorio entre 0 y 1 (incluyendo 0 pero excluyendo 2).
            {
                cuentas[i] = new CajaAhorro();
            }
            else
            {
                cuentas[i] = new CuentaCorriente(-1000); // Límite negativo de 1000
            }
        }

        // Realizar 100 iteraciones
        for (int i = 0; i < 100; i++)
        {
            int indiceCuenta = random.Next(cuentas.Length);
            double monto = random.Next(1000); // Monto aleatorio entre 0 y 999
            bool esDeposito = random.Next(2) == 0; // Deposito o extracción aleatoria

            if (esDeposito)
            {
                cuentas[indiceCuenta].Depositar(monto);
                Console.WriteLine($"Depositado {monto} en la cuenta {indiceCuenta}. Nuevo saldo: {cuentas[indiceCuenta].Saldo}");
            }
            else
            {
                bool exitoExtraccion = cuentas[indiceCuenta].Extraer(monto);
                if (exitoExtraccion)
                {
                    Console.WriteLine($"Extraído {monto} de la cuenta {indiceCuenta}. Nuevo saldo: {cuentas[indiceCuenta].Saldo}");
                }
                else
                {
                    Console.WriteLine($"No se pudo extraer {monto} de la cuenta {indiceCuenta}. Saldo insuficiente.");
                }
            }
        }

        // Mostrar resumen final
        Console.WriteLine("\nResumen final:");
        for (int i = 0; i < cuentas.Length; i++)
        {
            Console.WriteLine($"Cuenta {i}: {cuentas[i].Saldo}");
        }
    }
}