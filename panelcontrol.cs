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
    public partial class panelcontrol : Form
    {
        public panelcontrol()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void insertasProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  InsertarProcedimiento frm = new InsertarProcedimiento();
            //frm.Show();
           
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void programarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPaciente frm = new RegistroPaciente();
            frm.Show();

        }

        private void verProgramacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verprogra frm = new Verprogra();
            frm.Show();
        }

        private void modificarProgramacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarpacient frm = new modificarpacient();
            frm.Show();
        }

        private void insertarMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InsertarMedico frm = new InsertarMedico();
           // frm.Show();
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarPaciente frm = new modificarPaciente();
            frm.Show();
        }

        private void reportesPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reportes rpm = new reportes();
           // rpm.Show();
        }

        private void reporteDeEcografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ecogra rpm = new Ecogra();
            rpm.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
