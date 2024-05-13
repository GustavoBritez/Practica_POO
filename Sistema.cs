using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Asistencias
{
    public class Sistema
    {
        public List<Asistencia> lista_asistencia;

        public Sistema()
        {
            lista_asistencia = new List<Asistencia>();
        }
        public List<Asistencia> lista_()
        {
            List<Asistencia> listita = new List<Asistencia> ();

           foreach( Asistencia newAsis in lista_asistencia )
           {
                listita.Add( newAsis );
           }
            return listita;
        }
        public int Total_Lista()
        {
            return lista_().Count; 
        }
        public void Agregar_Asistencia( Asistencia Asi )
        {
            try
            {
                Asistencia n = Asi is null ? throw new Exception ("[Sistema] Vacio "): Asi;

                lista_asistencia.Add(n);

            }
            catch ( Exception ex )
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
