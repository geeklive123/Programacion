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
    public partial class modificarPaciente : Form
    {
        private ConexionBD mibd;
        public modificarPaciente()
        {
            InitializeComponent();
            mibd = new ConexionBD();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mibd.buscarPaciente(txtpaciente.Text);
            dataGridView1.Columns["idPaciente"].Visible = false;
            dataGridView1.Columns["idTipoPaciente"].Visible = false;
            dataGridView1.Columns["idCategoria"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                int cpaciente = (int)dataGridView1.Rows[i].Cells["idPaciente"].Value;
                string historial= dataGridView1.Rows[i].Cells["NroHistClinica"].Value.ToString();
                string ci = dataGridView1.Rows[i].Cells["NroCedula"].Value.ToString();
                string nombre = dataGridView1.Rows[i].Cells["Nombre"].Value.ToString();
                string ap1 = dataGridView1.Rows[i].Cells["ApPat"].Value.ToString();
                string ap2 = dataGridView1.Rows[i].Cells["ApMat"].Value.ToString();
                
                int edad = (int)dataGridView1.Rows[i].Cells["Edad"].Value;
                int telefono = (int)dataGridView1.Rows[i].Cells["Telefono"].Value;
                string hospital= dataGridView1.Rows[i].Cells["HProcedencia"].Value.ToString();
                string sexo = dataGridView1.Rows[i].Cells["Sexo"].Value.ToString();
                int ctipo = (int)dataGridView1.Rows[i].Cells["idTipoPaciente"].Value;
                string tipo = dataGridView1.Rows[i].Cells["tipo de paciente"].Value.ToString();
                int idcat = (int)dataGridView1.Rows[i].Cells["idCategoria"].Value;
                string categori = dataGridView1.Rows[i].Cells["NombreCat"].Value.ToString();
                txtid.Text = cpaciente.ToString();
                txthistorial.Text = historial.ToString();
                txtnro.Text = ci.ToString();
                txtnombre.Text = nombre.ToString();
                txtapellido.Text = ap1.ToString();
                txtapellidoM.Text = ap2.ToString();
                txtedad.Text = edad.ToString();
                txttelefono.Text = telefono.ToString();
                txthospital.Text = hospital.ToString();
                txtsexo.Text = sexo.ToString();
                cmdidtipo.Text = ctipo.ToString();
                cmdpaciente.Text = tipo.ToString();
                cmdcat.Text = idcat.ToString();
                cmdcategoria.Text = categori.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[i].Cells["FechaNac"].Value;
            }
        }

        private void modificarPaciente_Load(object sender, EventArgs e)
        {
            List<Categoria> cat = mibd.categoriaget();       //INSTANCIAMOS LA LISTA DE CATEGORIAS
            foreach (Categoria c in cat)
            {
                cmdcategoria.Items.Add(c.nombrecat.ToString()); //AÑADIMOS AL COMBOBOX DE CATEGORIA
                cmdcat.Items.Add(c.idcategoria.ToString()); //
            }
            List<Tipopaciente> cats = mibd.tipopacienteget();       //INSTANCIAMOS LA LISTA DE CATEGORIAS
            foreach (Tipopaciente c in cats)
            {
                cmdpaciente.Items.Add(c.nombre.ToString()); //AÑADIMOS AL COMBOBOX DE CATEGORIA
                cmdidtipo.Items.Add(c.idtipaciente.ToString()); //
            }
        }

        private void cmdidtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdpaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmdpaciente.SelectedIndex;//RECUPERAMOS LA CATEGORIA SELECCIONADA
            txtid1.Text = cmdidtipo.Items[i].ToString();//
        }

        private void cmdcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmdcategoria.SelectedIndex;//RECUPERAMOS LA CATEGORIA SELECCIONADA
            txtid2.Text = cmdcat.Items[i].ToString();//
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nrocedula = txtnro.Text;
            string nombre = txtnombre.Text;
            string nhclinico = txthistorial.Text;
            string appaterno = txtapellido.Text;
            string apmaterno = txtapellidoM.Text;
            DateTime fecnacimiento = dateTimePicker1.Value;
            int edad = int.Parse(txtedad.Text);
            string sexo = txtsexo.Text;
            int telefono = int.Parse(txttelefono.Text);
            string hdprocedencia = txthospital.Text;
            int tipopac = int.Parse(txtid1.Text);
            int categoria = int.Parse(txtid2.Text);
            int i = dataGridView1.CurrentRow.Index;
            int idpac = (int)dataGridView1.Rows[i].Cells["idPaciente"].Value;
            Paciente p = new Paciente(idpac,nhclinico, nombre, appaterno, apmaterno, nrocedula,  fecnacimiento, edad, sexo, telefono, hdprocedencia, tipopac, "",categoria,"");
            int res = mibd.modificarPaciente(p);
             if (res > 0)//VERIFICAMOS EL REGISTRO CORRECTO
                        {
                            MessageBox.Show("Registro correcto Paciente");//
                        }
                       else
                            MessageBox.Show("registro fallido");
         }
        }
    }
    