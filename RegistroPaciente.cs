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
    public partial class RegistroPaciente : Form
    {
        private ConexionBD mibd;
        public RegistroPaciente()
        {
            InitializeComponent();
            mibd = new ConexionBD();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string ced = txtNroCedula.Text;
                string valor = mibd.Existe(ced); //VERIFICAMOS SI EXISTE EL PACIENTE
                if (valor == "1")//SI EXISTE RETORNA 1 Y YA NO SE REGISTRA DE NUEVO EL PACIENTE
                {
                    MessageBox.Show("ya existe paciente");
                    Programaciones frm = new Programaciones();
                    frm.Show();
                }
                else {
                    Paciente pa = registrar();//EN CASO QUE RETORNE 0 SIGNIFICA QUE NO EXISTE EL PACIENTE
                    int res = mibd.RegPaciente(pa); // Y REGISTRAMOS EL PACIENTE
                    if (res > 0)//VERIFICAMOS EL REGISTRO CORRECTO
                            {
                            MessageBox.Show("Registro correcto Paciente");
                            Programaciones frm = new Programaciones();
                            frm.Show();//
                            }
                      }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroPaciente_Load(object sender, EventArgs e)
        {
            List<Tipopaciente> tipo = mibd.GetTipo();       //INSTANCIAMOS LA LISTA DE TIPOS
            foreach (Tipopaciente t in tipo)
            {
                comTipoPaciente.Items.Add(t.nombre.ToString()); //AÑADIMOS AL COMBOBOX LOS TIPOS DE PACIENTES
                comCodTipoPac.Items.Add(t.idtipaciente.ToString()); //AÑADIMOS AL COMBOBOX 
            }
            List<Categoria> cat = mibd.GetCategoria();       //INSTANCIAMOS LA LISTA DE CATEGORIAS
            foreach (Categoria c in cat)
            {
                comCategoria.Items.Add(c.nombrecat.ToString()); //AÑADIMOS AL COMBOBOX DE CATEGORIA
                comCodCategoria.Items.Add(c.idcategoria.ToString()); //
            }
        }
        public Paciente registrar()     //METODO REGISTRAR PACIENTE
        {
            string nhclinica = txtNumPaciente.Text;//
            string ci = txtNroCedula.Text;///
            string nombre = txtNombre.Text;//
            string appaterno = txtAppaterno.Text;//
            string apmaterno = txtApMaterno.Text;//
            int telefono = int.Parse(txtTelefono.Text);//
            DateTime fecnacimiento = dtpFecNacimiento.Value;//
            int edad = int.Parse(txtEdad.Text);//
            string sexo = txtsexo.Text;//
            int tipopac = int.Parse(txtCodTipoPac.Text);    //
            int categoria = int.Parse(txtCodCategoria.Text);    //
            string hprocedencia = txtHospPrecedencia.Text;  //
            Paciente pa = new Paciente(0, nhclinica, ci, nombre, appaterno, apmaterno, fecnacimiento, edad, sexo, telefono, hprocedencia, tipopac, "", categoria, ""); //INSTANCIAMOS LA CLASE PACIENTE
            return pa;  //RETORNAMOS EL OBJETO
        }

        private void comTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comTipoPaciente.SelectedIndex;//RECUPERAMOS EL INDICE SELECCIONADO
            txtCodTipoPac.Text = comCodTipoPac.Items[i].ToString();//
        }

        private void comCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comCategoria.SelectedIndex;//RECUPERAMOS LA CATEGORIA SELECCIONADA
            txtCodCategoria.Text = comCodCategoria.Items[i].ToString();//
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificarPaciente frm = new modificarPaciente();
            frm.Show();
        }

        private void btnRegistroMedico_Click(object sender, EventArgs e)
        {
            string medico = txtmedicosolicitante.Text;//CAPTURAMOS EL MEDICO SOLICITANTE
            int rmed = mibd.RegMedico(medico);//REGISTRAMOS EL MEDICO SOLICITANTE
            if (rmed > 0)
            {
                MessageBox.Show("Registro correcto doctor solicitante");//VERIFICAMOS EL REGISTRO DEL MEDICO SOLICITANTE
            }
        }
    }
}
