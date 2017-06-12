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
    public partial class Programaciones : Form
    {
        private ConexionBD mibd;
        public Programaciones()
        {
            InitializeComponent();
            mibd = new ConexionBD();
            timer1.Enabled = true;
        }

        private void Programaciones_Load(object sender, EventArgs e)
        {
            
            mibd.autocompletar(txtDoctor);
            List<Estudio> est = mibd.GetEstudio();          //INSTANCIAMOS LA LISTA DE ESTUDIOS
            foreach (Estudio es in est)
            {
                comEstudio.Items.Add(es.nomestudio.ToString());  //AÑADIMOS AL COMBOBOX DE ESTUDIO
                comCodEstudio.Items.Add(es.idestudio.ToString());  //
            }
            List<Turno> tur = mibd.GetTurno();              //INSTANCIAMOS LA LISTA DE TURNO
            foreach (Turno t in tur)
            {
                comTurno.Items.Add(t.turno.ToString());     //AÑADIMOS AL COMBOBOX TURNO
                comCodTurno.Items.Add(t.idturno.ToString());    //AÑADIMOS LOS ITEMS
            }
        }
        private void comProcedimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comProcedimientos.SelectedIndex;//RECUPERAMOS EL INDICE DE PROCEDIMIENTO
            txtCodProcedimiento.Text = comCodProcedimiento.Items[i].ToString();//PONEMOS EL VALOR DEL INDICE EN LA CAJA DE TEXTO ESPECIFICA
        }

        private void comEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comCodProcedimiento.Items.Clear();//LIMPIAMOS EL COMBO DE CODIGOS DE LOS PROCEDIMIENTOS
            comProcedimientos.Items.Clear();//LIMPIAMOS EL CCOMBO PROCEDIMIENTOS
            int i = comEstudio.SelectedIndex;//RECUPERAMOS EL INDICE DE ESTUDIO SELECCIONADO
            txtCodEstudio.Text = comCodEstudio.Items[i].ToString();
            int est = int.Parse(txtCodEstudio.Text);//RECUPERAMOS EL CODIGO DEL ESTUDIO
            List<Procedimiento> nomb = mibd.GetProcedimiento(est);//LLAMAMOS AL METODO PARA RECUPERAR LOS PROCEDIMIENTOS SEGUN EL ESTUDIO
            foreach (Procedimiento p in nomb) //RECORREMOS LA LISTA DE PROCEDIMIENTOS
            {
                comCodProcedimiento.Items.Add(p.idprocedimiento);//LLENAMOS LOS CODIGOS
                comProcedimientos.Items.Add(p.nombprocedimiento);//LLENAMOS LOS NOMBRES DE LOS PROCEDIMIENTOS
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dtgpaciente.DataSource = mibd.buscarPaciente(txtcarnet.Text);
            dtgpaciente.Columns["idPaciente"].Visible = false;
            dtgpaciente.Columns["idTipoPaciente"].Visible = false;
            dtgpaciente.Columns["idCategoria"].Visible = false;
        }

        private void dtgpaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
                 int i = e.RowIndex;
                 if (i >= 0)
                 {
                     int cpaciente = (int)dtgpaciente.Rows[i].Cells["idPaciente"].Value;
                     string nombre = dtgpaciente.Rows[i].Cells["Nombre"].Value.ToString();
                     txtidpac.Text = cpaciente.ToString();
                     txtpaciente.Text = nombre.ToString();
                 }
        }
        public int obtidmedsolicitante(string nombmed)//METODO RECUPERAR EL ID DEL MEDICO SOLICITANTE DESPUES DE SU REGISTRO
        {
            int medsolic = mibd.getidmedsolicitante(nombmed);   //LLAMAMOS AL METODO
            return medsolic; //RECUPERAMOS EL IDDELMEDICOSOLICITANTE
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Programacion pa = registrarprg();//EN CASO QUE RETORNE 0 SIGNIFICA QUE NO EXISTE EL PACIENTE
            int res = mibd.RegProgramacion(pa); // Y REGISTRAMOS EL PACIENTE
            if (res > 0)//VERIFICAMOS EL REGISTRO CORRECTO
            {
                MessageBox.Show("Registro correcto Programacion");
            }
                int res2=mibd.RegProgramacion2(pa);
                 if (res2> 0)
                 {
                 MessageBox.Show(".........");
                  }
            else
                MessageBox.Show("registro fallido");
        }
        public Programacion registrarprg()  //METODO REGISTRAR LA PROGRAMACION
        {
            int idpac = int.Parse(txtidpac.Text);
            int idpro = int.Parse(txtCodProcedimiento.Text);    //
            int idoc = int.Parse(txtCodDocente.Text);
            int idmed = int.Parse(txtidmedico.Text);
            int idtur = int.Parse(txtCodTurno.Text);    //
            DateTime fec = dtpFecProgramada.Value;  //
            int estado = 1; //
            string obsestado = "";//
            string fg = label3.Text;
            Programacion prg = new Programacion(0, idpac, idpro, idoc,idmed, idtur, fec, estado, obsestado,fg); //INSTANCIAMOS EL OBJETO PROGRAMACION 
            return prg; //RETORNAMOS EL OBJETO
        }

        private void comTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comTurno.SelectedIndex; //RECUPERAMOS EL INDICE DEL TURNO SELECCIONADO
            txtCodTurno.Text = comCodTurno.Items[i].ToString();//ASIGNAMOS LA POSICION SELECCIONADA Y LOS PONEMOS EL TEXTBOX
        }

        private void txtDoctor_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txtDoctor.Text == "")//VERIFICAMOS NULO
            {
                txtCodDocente.Clear();//LIMPIAMOS
            }
            else
            {
                string cadena = txtDoctor.Text;//CASO CONTRARIO
                int codigo = mibd.GetCodigo(cadena);///RECUPERAMOS EL CODIGO
                txtCodDocente.Text = codigo.ToString();//LO PONEMOS EN LA CAJA DE TEXTO
            }
        }

        private void btnverprg_Click(object sender, EventArgs e)
        {
            Verprogra frm = new Verprogra();
            frm.Show();
        }

        private void btnmdf_Click(object sender, EventArgs e)
        {
            modificarpacient frm = new modificarpacient();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            Verprogra frm = new Verprogra();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mibd.buscarMedico(txtmedicoS.Text);
            dataGridView1.Columns["idMedico"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                int cpmedico = (int)dataGridView1.Rows[i].Cells["idMedico"].Value;
                string nombre = dataGridView1.Rows[i].Cells["Nombre"].Value.ToString();
                txtidmedico.Text = cpmedico.ToString();
                txtmedico.Text = nombre.ToString();
            }
        }
    }
}
