using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Asistencias
{
    public class Presencial : Asistencia
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        #region " METODOS "
        public override double CalcularHorasTrabajadas()
        {
            TimeSpan diferencia = Hasta - Desde;
            return diferencia.TotalHours;
        }
        #endregion
        public Presencial(string legajo)
        {
            _Hora = Convert.ToString(DateTime.Now);
            _Legajo = legajo;
        }

    }
}
