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
    public partial class modificarpacient : Form
    {
        private ConexionBD mibd;
        public modificarpacient()
        {
            InitializeComponent();
            mibd = new ConexionBD();
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
                dataGridView1.DataSource = mibd.buscarProgramacion(txtbuscar.Text);
                dataGridView1.Columns["idProgramacion"].Visible = false;
                dataGridView1.Columns["idPaciente"].Visible = false;
                dataGridView1.Columns["idProcedimiento"].Visible = false;
                dataGridView1.Columns["idTurno"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i>=0)
            {
                int idprogramacion = (int)dataGridView1.Rows[i].Cells["idProgramacion"].Value;
                int cpaciente=(int)dataGridView1.Rows[i].Cells["idPaciente"].Value;
                string nom = dataGridView1.Rows[i].Cells["Nombre"].Value.ToString();
                int cturno = (int)dataGridView1.Rows[i].Cells["idTurno"].Value;
                string turno = dataGridView1.Rows[i].Cells["turno"].Value.ToString();
                int cprocedimiento = (int)dataGridView1.Rows[i].Cells["idProcedimiento"].Value;
                string proce = dataGridView1.Rows[i].Cells["Procedimientos"].Value.ToString();
                txtidprg.Text = idprogramacion.ToString();
                cmdpaciente.Text = cpaciente.ToString() + "-" + nom;
                cmdturno.Text = cturno.ToString() + "-" + turno;
                cmdid.Text = cturno.ToString();
                lisprocedimiento.Items.Clear();
                lisprocedimiento.Items.Add(cprocedimiento.ToString() + "-" + proce);
                liscodigo.Items.Clear();
                liscodigo.Items.Add(cprocedimiento.ToString() );
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[i].Cells["fecha"].Value;
                
         

            }
        }

        private void modificarpacient_Load(object sender, EventArgs e)
        {   
            

            List<Turno> cat = mibd.turnoget();       //INSTANCIAMOS LA LISTA DE CATEGORIAS
            foreach (Turno c in cat)
            {
                cmdturno.Items.Add(c.turno.ToString()); //AÑADIMOS AL COMBOBOX DE CATEGORIA
                cmdid.Items.Add(c.idturno.ToString()); //
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cadena1 = cmdprocedimiento.Text;
            List<Procedimiento> procedimientos = mibd.buscarProcedimiento(cadena1);
            foreach (Procedimiento a in procedimientos) {
                lisprocedimiento.Items.Add(a.idprocedimiento.ToString() + "-" + a.nombprocedimiento);
                liscodigo.Items.Add(a.idprocedimiento.ToString());
            }
        }

        private void lisprocedimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = lisprocedimiento.SelectedIndex;
            if (i >= 0) 
            {
                txtbuscar2.Text = liscodigo.Items[i].ToString();
            }
        }
        private void clearenabletext()
        {
            cmdid.Text = "";

        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
           // UPDATE programacion SET idProcedimiento=@idproced,idTurno=@idtur,Fecha=fec,ObsEstado=@obs WHERE idPaciente=@idpac"
            //idpaciente = idpac;
            //idprocedimiento = idpro;
            //idoctor = idoc;
            //idmedico = idmed;
            //idturno = idtur;
            //fecha = fec;
            //estado = est;
            //obsestado = obsest;
            int idprocedimiento = int.Parse(txtbuscar2.Text);
            int idturno= int.Parse(txtturno.Text);
            DateTime fecha = dateTimePicker1.Value;
            string obsestado = txtobs.Text;
            int est = int.Parse(txtturno.Text);
            int i = dataGridView1.CurrentRow.Index;
            int idprg = (int)dataGridView1.Rows[i].Cells["idProgramacion"].Value;
            Programacion p = new Programacion(idprg,0,idprocedimiento,0,0,idturno,fecha,0,obsestado,"");
            int res = mibd.actualizarProgramacion(p);
            if (res > 0)//VERIFICAMOS EL REGISTRO CORRECTO
            {
                MessageBox.Show("actualizacion Realizada");//
               // clearenabletext();
            }
            else
                MessageBox.Show("fallo actualizacion");
             
        }

        private void cmdturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmdturno.SelectedIndex;//RECUPERAMOS LA CATEGORIA SELECCIONADA
            txtturno.Text = cmdid.Items[i].ToString();//
        }
    }                    
}

   