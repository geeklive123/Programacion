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
    public partial class Ecogra : Form
    {
        private ConexionBD mibd;
        public Ecogra()
        {
            InitializeComponent();
            mibd = new ConexionBD();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Ecografia1.SetParameterValue("fecha", dtgbuscador.Value);
            Ecografia1.SetParameterValue("turno", cmdTurno.Text);
            crystalReportViewer1.ReportSource = Ecografia1;
            crystalReportViewer1.Refresh();
        }

        private void Ecogra_Load(object sender, EventArgs e)
        {
            List<Turno> tur = mibd.GetTurno();              //INSTANCIAMOS LA LISTA DE TURNO
            foreach (Turno t in tur)
            {
                cmdTurno.Items.Add(t.turno.ToString());     //AÑADIMOS AL COMBOBOX TURNO
            }
        }
    }
}
