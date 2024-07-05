using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Hecho
{
    internal class Cuenta_Ahorro: Cuenta_bancaria
    {
        private double saldoNeg = 0;


        public override void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public override bool Extraccion(double extraer)
        {
            if(Saldo-extraer >= 0)
            {
                Saldo -= extraer;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
