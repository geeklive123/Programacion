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
    public partial class Verprogra : Form
    {
        private ConexionBD mibd;
        public Verprogra()

        {
            InitializeComponent();
            mibd = new ConexionBD();//
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dtgprogramacion.DataSource = mibd.buscarfecha(txtfecha.Text);
        }
        private void Verprogra_Load(object sender, EventArgs e)
        {
            DataTable programacion = mibd.GetProgramacionFiltro();
            dtgprogramacion.DataSource = programacion;
        }

        private void dtgprogramacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            
        }
    }
}
