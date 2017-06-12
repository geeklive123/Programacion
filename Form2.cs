using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGBJ_Programacion2
{
    public partial class Form2 : Form
    {
        private ConexionBD mibd;
        public Form2()
        {
            InitializeComponent();
            mibd = new ConexionBD();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Programacion11.SetParameterValue("fecha",dtgbuscador.Value);
            Programacion11.SetParameterValue("estudio",cmdEstudio.Text);
            Programacion11.SetParameterValue("turno",cmdTurno.Text);
            crystalReportViewer1.ReportSource = Programacion11;
            crystalReportViewer1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            List<Estudio> est = mibd.GetEstudio();          //INSTANCIAMOS LA LISTA DE ESTUDIOS
            foreach (Estudio es in est)
            {
                cmdEstudio.Items.Add(es.nomestudio.ToString());  //AÑADIMOS AL COMBOBOX DE ESTUDIO
            }
            List<Turno> tur = mibd.GetTurno();              //INSTANCIAMOS LA LISTA DE TURNO
            foreach (Turno t in tur)
            {
                cmdTurno.Items.Add(t.turno.ToString());     //AÑADIMOS AL COMBOBOX TURNO
            }
        }

        private void cmdTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmdTurno.SelectedIndex;
        }

        private void cmdEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmdEstudio.SelectedIndex;

        }
    }
}
