using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Hecho
{
    //Clase abstracta
    abstract class Cuenta_bancaria
    {
        //no esta puesto como abstrarct asi que no es necesario hacer override en las clases heredadas

        public double Saldo { get; set; } 
        public abstract void Depositar(double deposito);

        public abstract bool Extraccion(double extraer);
    }
}
