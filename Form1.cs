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
    public partial class FrmProgramacion : Form
    {
        private ConexionBD mibd;//INSTANCIAMOS LA CONECCION ALA CLASE DE CONEXION
        public FrmProgramacion()
        {
            InitializeComponent();
            mibd = new ConexionBD();//
        }
        private void FrmProgramacion_Load(object sender, EventArgs e)
        {
                mibd.autocompletar(txtDoctor);                  //EN ESTA LINEA ESTAMOS AUTOCOMPLETANDO LA TXTDOCTORES
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
        void Nomostrar1()
        {
            dtgProcedimientos.Columns["idprocedimiento"].Visible = false; //OCULTAMOS LAS COLUMNAS QUE NO NECESITAMOS VISUALIZAR
            dtgProcedimientos.Columns["idDoctor"].Visible = false;//
            dtgProcedimientos.Columns["nombre"].Visible = false;//
            dtgProcedimientos.Columns["fecha"].Visible = false;//
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
            Paciente pa = new Paciente(0,nhclinica,ci,nombre,appaterno,apmaterno,fecnacimiento,edad,sexo,telefono,hprocedencia,tipopac,"",categoria,""); //INSTANCIAMOS LA CLASE PACIENTE
               return pa;  //RETORNAMOS EL OBJETO
        }
        public Programacion registrarprg()  //METODO REGISTRAR LA PROGRAMACION
        {
            string ci = txtNroCedula.Text;  //RECUPERAMOS LOS DATOS DE LA PROGRAMACION
            int idpac = idpaciente(ci); //
            int idpro = int.Parse(txtCodProcedimiento.Text);    //
            int idoc = int.Parse(txtCodDocente.Text);   //
            string nombmed = txtMedSolicitante.Text;    //
            int idmed = obtidmedsolicitante(nombmed);   //
            int idtur = int.Parse(txtCodTurno.Text);    //
            DateTime fec = dtpFecProgramada.Value;  //
            int estado = 1; //
            string obsestado = "";//
            Programacion prg = new Programacion(0,idpac, idpro, idoc, idmed, idtur, fec, estado, obsestado,""); //INSTANCIAMOS EL OBJETO PROGRAMACION 
            return prg; //RETORNAMOS EL OBJETO
        }
        public int idpaciente(string cedula)    //METODO RECUPERAR EL ID DEL PACIENTE DESPUES DE SU REGISTRO
        {
            int idpac=mibd.getidpaciente(cedula);//LLAMAMOS AL METODO DE LA BASE DE DATOS RECUPERAR IDPACIENTE
            return idpac;//RETORNAMOS LA VARIABLE IDPACIENTE
        }
        public int obtidmedsolicitante(string nombmed)//METODO RECUPERAR EL ID DEL MEDICO SOLICITANTE DESPUES DE SU REGISTRO
        {
            int medsolic = mibd.getidmedsolicitante(nombmed);   //LLAMAMOS AL METODO
            return medsolic; //RECUPERAMOS EL IDDELMEDICOSOLICITANTE
        }
        void programar()//METODO REGISTRAR PROGRAMACION
        {
            Programacion prg = registrarprg();//
            int rprg = mibd.RegProgramacion(prg);//
            if (rprg > 0)//
            {
                MessageBox.Show("Registro correcto del procedimiento");//
            }
            string cadena = txtNroCedula.Text;//
            DataTable procedimiento = mibd.GetProcedimientosFiltro(cadena);//
            dtgProcedimientos.DataSource = procedimiento;//VOLVEMOS A ASIGNAR AL DTGPROCEDIMIENTOS PARA REFRESCAR LA VISTA
        }
        private void btnConfirmar_Click(object sender, EventArgs e)//EVENTO CLICK PARA CONFIRMAR LOS REGISTROS
        {
            DialogResult r = MessageBox.Show("Se Registrara el Actual Procedimiento", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //PREGUNTAMOS SI DESEA REGISTRAR EL PROCEDIMIENTO
            if(r==DialogResult.Yes) //SI ES YES
            {
                string ced = txtNroCedula.Text;
                string valor = mibd.Existe(ced); //VERIFICAMOS SI EXISTE EL PACIENTE
                if(valor == "1")//SI EXISTE RETORNA 1 Y YA NO SE REGISTRA DE NUEVO EL PACIENTE
                {
                    programar(); //ACA DIRECTAMENTE LE REGISTRAMOS SU PROGRAMACION
                }else
                    {
                        Paciente pa = registrar();//EN CASO QUE RETORNE 0 SIGNIFICA QUE NO EXISTE EL PACIENTE
                        int res = mibd.RegPaciente(pa); // Y REGISTRAMOS EL PACIENTE
                        if (res > 0)//VERIFICAMOS EL REGISTRO CORRECTO
                        {
                            MessageBox.Show("Registro correcto Paciente");//
                        }
                        string medico = txtMedSolicitante.Text;//CAPTURAMOS EL MEDICO SOLICITANTE
                        int rmed = mibd.RegMedico(medico);//REGISTRAMOS EL MEDICO SOLICITANTE
                        if (rmed > 0)
                        {
                            MessageBox.Show("Registro correcto doctor solicitante");//VERIFICAMOS EL REGISTRO DEL MEDICO SOLICITANTE
                        }
                        programar();//LLAMAMOS AL METODO PROGRAMAR PARA REGISTRAR LA PROGRAMACION DEL PROCEDIMIENTO
                    }
            }
        }
        private void comTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)//EVENTO PARA RECUPERAR EL TIPO DE PACIENTE
        {
            int i = comTipoPaciente.SelectedIndex;//RECUPERAMOS EL INDICE SELECCIONADO
            txtCodTipoPac.Text=comCodTipoPac.Items[i].ToString();//
        }
        private void comCategoria_SelectedIndexChanged(object sender, EventArgs e)//EVENTO PARA RECUPERAR LA CATEGORIA
        {
            int i = comCategoria.SelectedIndex;//RECUPERAMOS LA CATEGORIA SELECCIONADA
            txtCodCategoria.Text = comCodCategoria.Items[i].ToString();//
        }
        private void comEstudio_SelectedIndexChanged(object sender, EventArgs e)//EVENTO PARA RECUPERAR EL ESTUDIO SELECCIONADO
        {
            comCodProcedimiento.Items.Clear();//LIMPIAMOS EL COMBO DE CODIGOS DE LOS PROCEDIMIENTOS
            comProcedimientos.Items.Clear();//LIMPIAMOS EL CCOMBO PROCEDIMIENTOS
            int i = comEstudio.SelectedIndex;//RECUPERAMOS EL INDICE DE ESTUDIO SELECCIONADO
            txtCodEstudio.Text = comCodEstudio.Items[i].ToString();
            int est = int.Parse(txtCodEstudio.Text);//RECUPERAMOS EL CODIGO DEL ESTUDIO
            List<Procedimiento> nomb = mibd.GetProcedimiento(est);//LLAMAMOS AL METODO PARA RECUPERAR LOS PROCEDIMIENTOS SEGUN EL ESTUDIO
            foreach(Procedimiento p in nomb) //RECORREMOS LA LISTA DE PROCEDIMIENTOS
            {
                comCodProcedimiento.Items.Add(p.idprocedimiento);//LLENAMOS LOS CODIGOS
                comProcedimientos.Items.Add(p.nombprocedimiento);//LLENAMOS LOS NOMBRES DE LOS PROCEDIMIENTOS
            }
        }
        private void comTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comTurno.SelectedIndex; //RECUPERAMOS EL INDICE DEL TURNO SELECCIONADO
            txtCodTurno.Text = comCodTurno.Items[i].ToString();//ASIGNAMOS LA POSICION SELECCIONADA Y LOS PONEMOS EL TEXTBOX
        }
        private void txtDoctor_KeyUp(object sender, KeyEventArgs e)//EVENTO KEYUP PARA RECUPERAR EL CODIGO DEL DOCTOR ASIGNADO A UN PROCEDIMIENTO
        {
            
            if(txtDoctor.Text=="")//VERIFICAMOS NULO
            {
                txtCodDocente.Clear();//LIMPIAMOS
            }else
                {
                    string cadena = txtDoctor.Text;//CASO CONTRARIO
                    int codigo = mibd.GetCodigo(cadena);///RECUPERAMOS EL CODIGO
                    txtCodDocente.Text = codigo.ToString();//LO PONEMOS EN LA CAJA DE TEXTO
                }
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
        }
        private void comProcedimientos_SelectedIndexChanged(object sender, EventArgs e)//EVENTO PARA SELECCIONAR EL PROCEDIMENTO
        {
            int i = comProcedimientos.SelectedIndex;//RECUPERAMOS EL INDICE DE PROCEDIMIENTO
            txtCodProcedimiento.Text = comCodProcedimiento.Items[i].ToString();//PONEMOS EL VALOR DEL INDICE EN LA CAJA DE TEXTO ESPECIFICA
        }

        private void txtNroCedula_KeyUp(object sender, KeyEventArgs e)//EVENTO PARA BUSCAR LOS PROCEDIMIENTOS SEGUN LA CEDULA SIN HISTORIA CLINICO
        {
            string cadena = txtNroCedula.Text;//RECUPERAMOS EL NUMERO DE CARNET
            DataTable procedimiento = mibd.GetProcedimientosFiltro(cadena);//LLAMAMOS AL METODO DE LA BASE DE DATOS 
            dtgProcedimientos.DataSource = procedimiento;//LLENAMOS EL DATA GRIDD VIEWW
            Nomostrar1();//LLAMAMOS AL METODO PARA OCULTAR LAS COLUMNAS NO NECESARIAS
        }

        private void btnTerminar_Click(object sender, EventArgs e)//EVENTO LIMPIAR AL TERMINAR DE REGISTRAR LOS PROCEDIMIENTOS
        {
            txtNumPaciente.Clear();//
            txtNroCedula.Clear();//
            txtNombre.Clear();//
            txtAppaterno.Clear();//
            txtApMaterno.Clear();//
            txtTelefono.Clear();//
            txtEdad.Clear();//
            txtHospPrecedencia.Clear();//
            txtMedSolicitante.Clear();//
            txtDoctor.Clear();//
            dtgProcedimientos.DataSource = null;//
        }
        private void dtgProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)//EVENTO PARA RECUPERAR DATOS DE LA TABLA DE PROCEDIMIENTOS
        {
            int i = e.RowIndex;//
            if (i >= 0)//
            {
                int idoctor = (int)dtgProcedimientos.Rows[i].Cells["idDoctor"].Value;//
                string turno = dtgProcedimientos.Rows[i].Cells["Nombre"].Value.ToString();//
                string fecha = dtgProcedimientos.Rows[i].Cells["fecha"].Value.ToString();//
                lblNomTurno.Text= turno;//
                lblFecTexto.Text= fecha;//
                string nombre1 = mibd.GetNomDoctor(idoctor);//
                lblNomDoctor.Text = nombre1;//
            }
        }
        private void txtNumPaciente_KeyDown(object sender, KeyEventArgs e)//EVENTO PARA RECUPERAR LOS DATOS DEL PACIENTE DESDE LA BASE DE DATOS PROGRAMACION2
        {
            string nhclinico = txtNumPaciente.Text;//
            List<Paciente> paciente = mibd.GetPaciente(nhclinico);//
            foreach (Paciente p in paciente)//LEEMOS LA LISTA DE RESULTADOS
            {
                txtNroCedula.Text = p.cedula;//COLOCAMOS EN LOS CAMPOS CORRESPONDIENTES
                txtNombre.Text = p.nombre;//
                txtAppaterno.Text = p.appaterno;//
                txtApMaterno.Text = p.apmaterno;//
                txtTelefono.Text = p.telefono.ToString();//
                dtpFecNacimiento.Value = p.fecnacimiento;//
                txtEdad.Text = p.edad.ToString();//
                txtsexo.Text = p.sexo.ToString();
                comTipoPaciente.Text = p.nomtipo;//
                comCategoria.Text = p.nomcategoria;//
                txtHospPrecedencia.Text = p.hdprocedencia;//
            }
        }

        private void txtDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comCodCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedSolicitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodMedSolicitante_TextChanged(object sender, EventArgs e)
        {

        }
    }
}