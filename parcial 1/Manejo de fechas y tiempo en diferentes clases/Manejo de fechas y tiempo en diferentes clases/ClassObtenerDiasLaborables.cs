using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_fechas_y_tiempo_en_diferentes_clases
{
    internal class ClassObtenerDiasLaborables
    {
        public DateTime[] ObtenerDiasLaborables(DateTime fechaInicio, DateTime fechaFinal, DateTime[] feriados)
        {
            DateTime[] guardar = new DateTime[(fechaFinal - fechaInicio).Days + 1];
            int cont = 0;

            for (DateTime fecha = fechaInicio; fecha <= fechaFinal; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(fecha))
                {
                    guardar[cont++] = fecha;
                }
            }

            Array.Resize(ref guardar, cont);
            return guardar;
        }
    }
}
