using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Hecho
{
    internal class Cuenta_Corriente: Cuenta_bancaria
    {
        private double descuento = 0.1; //descuento de 10% diario
        private double limiteNeg = 1000; //limite de saldo negativo de 1000 pesos
        private double verificacion = 0;
        public double Descuento
        {
            get => descuento;
            set
            {
                //que asegura que solo se asigne un valor entre 0 y 1 a la propiedad descuentoporcentaje debe estar en el
                //rango de 0 (0%) a 1
                if (value >= 0 && value <= 1)  
                {
                    descuento = value;
                }
            }
        }
        public double LimiteNeg
        {
            //asegura que solo se asigne un valor mayor o igual a 0 a la propiedad valor debe ser 0 o positivo, ya que un
            //límite negativo no tendría sentido
            get => limiteNeg;
            set
            {
                if (value >= 0)
                    limiteNeg = value;
            }
        }
        public double Verificacion { get => verificacion; set => verificacion = value; }

        public Cuenta_Corriente()
        {
        }

        public override void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public override bool Extraccion(double extraer)
        {
            verificacion = Saldo;
            verificacion -=extraer;
            if (verificacion <= -LimiteNeg)
            {
                return false;
            }
            else
            {
                Saldo-= extraer;
                if (Saldo < 0)
                {
                    // Aplicar el descuento solo a la porción negativa del saldo.Math.Abs se utiliza para obtener el valor
                    // absoluto de un número. Se utiliza para calcular el valor absoluto del saldo negativo, de manera que
                    // el descuento se aplique correctamente solo a la porción negativa.
                    double porcionNegativa = Math.Abs(Saldo);
                    double descuentoAplicado = porcionNegativa * Descuento;
                    Saldo -= descuentoAplicado;
                }
                return true;
            }
        }

    }
}
