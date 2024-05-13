using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Asistencias
{
     public abstract class Asistencia
    {
        private int IdAsistencia;
        private DateTime Timer;
        private string ?Legajo;
        #region " Set y Get "
        public int _AgregarID
        {
            get => IdAsistencia;
            set => IdAsistencia = value;
        }
        public string _Hora
        {
            get => Timer.ToString();
            set => Timer = DateTime.Parse(value); /// Ingresar formato "2024-05-08 12:30:00"
        }
        public string _Legajo
        {
            get => Legajo ?? "";
            set => Legajo = value;
        }
        #endregion
        #region " Metodos "
        public abstract double CalcularHorasTrabajadas();

        #endregion
    }
}
