using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Asistencias
{
    public class Teletrabajo : Asistencia
    {
        public string? Motivo;
        public int TareasRealizadas { get; set; }
        public void AgregarTarea( string _newT )
        {
            TareasRealizadas = Convert.ToInt32( _newT );
            MessageBox.Show($" [TeleTrabajo] | Tarea Agregada{TareasRealizadas}");
        }
        public override double CalcularHorasTrabajadas()
        {
            double n = 0;
            try
            {
                n = (double)TareasRealizadas * 1.5;
                n = n > 8 ? throw new Exception("[TeleTrabajo] | No puedes trabajar mas de 8 horas ") : n;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return n;
        }
    }
}
