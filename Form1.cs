using Microsoft.VisualBasic;

namespace Sistema_De_Asistencias
{
    public partial class Form1 : Form
    {
        Sistema Sistem = new Sistema();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            switch (ck_Presencial.Checked)
            {
                case true:
                    if (!string.IsNullOrEmpty(txt_Legajo.Text))
                    {
                        Presencial newAsistencia = new Presencial(txt_Legajo.Text);
                        newAsistencia.Desde = DateTime.Now;
                        newAsistencia.Hasta = newAsistencia.Hasta.AddHours(8);
                        Sistem.Agregar_Asistencia(newAsistencia);
                        newAsistencia._AgregarID = Sistem.Total_Lista();
                        Mostrar(DGV);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un Legajo");
                    }

                    /// Pedir ayuda al maestro por error CS860

                    break;
                default:
                    if (!string.IsNullOrEmpty(txt_Legajo.Text))
                    {
                        Teletrabajo newTeletrabajo = new Teletrabajo();
                        string _Motivo = Interaction.InputBox(" Ingrese un motivo por Teletrabajo", "Motivo del teletrabajo");
                        newTeletrabajo._Legajo = txt_Legajo.Text;
                        newTeletrabajo.Motivo = _Motivo;
                        newTeletrabajo.TareasRealizadas = Convert.ToInt32(Interaction.InputBox(" Ingrese las tareas realizadas \n Cada una vale 1,5Hs ", "Tareas"));
                        newTeletrabajo._Hora = Convert.ToString(DateTime.Now);

                        Sistem.Agregar_Asistencia(newTeletrabajo);
                        newTeletrabajo._AgregarID = Sistem.Total_Lista();
                        Mostrar(DGV);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un legajo");
                    }
                    break;
            }
        }
        public void SelectRow()
        {
            //if (DGV.Select)


        }
        public void Mostrar(DataGridView DG)
        {
            DG.DataSource = null;
            DG.DataSource = Sistem.lista_();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}