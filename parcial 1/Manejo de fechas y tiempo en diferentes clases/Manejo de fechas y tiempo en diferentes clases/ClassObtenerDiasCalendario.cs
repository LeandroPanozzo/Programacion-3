using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_fechas_y_tiempo_en_diferentes_clases
{
    internal class ClassObtenerDiasCalendario
    {
        public void ObtenerDiasCalendario(DateTime fechaInicio, DateTime fechaFinal)
        {
            //obtiene los días entre dos fechas
            TimeSpan fechaDias = fechaFinal - fechaInicio;
            Console.WriteLine($"Los dias entre dos fechas sera: {fechaDias.Days}");
        }
    }
}
