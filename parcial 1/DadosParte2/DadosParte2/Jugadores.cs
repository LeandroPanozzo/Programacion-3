using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosParte2
{
    internal class Jugadores
    {
        public int saldo { get; set; }
        public string nombre { get; set; }

        public Jugadores(int sal, string nom)
        {
            saldo = sal;
            nombre = nom;
        }
    }
}
