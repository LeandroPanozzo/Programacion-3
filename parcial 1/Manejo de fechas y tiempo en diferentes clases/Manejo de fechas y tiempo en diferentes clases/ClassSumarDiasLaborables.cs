using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_fechas_y_tiempo_en_diferentes_clases
{
    internal class ClassSumarDiasLaborables
    {
        public DateTime[] SumarDiasLaborables(DateTime fechaInicio, DateTime nuevaFecha, DateTime[] feriados)
        {
            DateTime[] guardar = new DateTime[(nuevaFecha - fechaInicio).Days + 1];
            int cont = 0;

            for (DateTime fecha = fechaInicio; fecha <= nuevaFecha; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(fecha))
                {
                    guardar[cont++] = fecha;
                }
            }

            Array.Resize(ref guardar, cont);
            //estamos redimensionando el arreglo guardar para que tenga exactamente index elementos.
            //El modificador ref se utiliza aquí para pasar el arreglo por referencia, lo que significa que los cambios
            //realizados dentro del método afectarán al arreglo original que se pasó como argumento.
            return guardar; //Finalmente, el método devuelve el arreglo guardar con el tamaño ajustado
        }
    }
}
