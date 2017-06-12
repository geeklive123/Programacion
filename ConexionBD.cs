using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace IGBJ_Programacion2
{
    class ConexionBD
    #region Conexion a la base de Datos
    {
        private MySqlConnection con1;
        private MySqlConnection con2;
        private MySqlConnection con3;
        public ConexionBD()
        {
            con1 = new MySqlConnection("server=localhost;user id=root;password=irmasdfgh;database=bddcolegio;persistsecurityinfo=True");
            con2 = new MySqlConnection("server=localhost;user id=root;password=irmasdfgh;database=bdprogramacion;persistsecurityinfo=True");
            con3 = new MySqlConnection("server=localhost;user id=root;password=irmasdfgh;database=programacion2;persistsecurityinfo=True");
        }
        public void abrir1()
        {
            con1.Open();
        }
        public void abrir2()
        {
            con2.Open();
        }
        public void abrir3()
        {
            con3.Open();
        }
        public void cerrar1()
        {
            con1.Close();
        }
        public void cerrar2()
        {
            con2.Close();
        }
        public void cerrar3()
        {
            con3.Close();
        }
    #endregion
        #region recuperacion de Pacientes
        public List<Paciente> GetPaciente(string nhclinica)//RECUPERAMOS LOS PACIENTES
        {
            List<Paciente> paciente = new List<Paciente>();
            try
            {
                abrir3();
                string sql = "SELECT p.idPaciente,p.NroCedula,p.Nombre,p.ApPat,p.ApMat,p.Telefono,p.FechaNac,p.edad,p.Sexo,p.idtipopaciente,TP.Nombre AS tipo,p.idcategoria,CA.NombreCat,HProcedencia ";
                sql = sql + "FROM paciente p ";
                sql = sql + "INNER JOIN tipopaciente TP ON p.idtipopaciente = TP.idtipopaciente ";
                sql = sql + "INNER JOIN categoria CA ON P.idCategoria=CA.idCategoria ";
                sql = sql + "WHERE p.NroHistClinica like '%" + nhclinica + "%' ";
                MySqlCommand cmd = new MySqlCommand(sql, con3);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string ced = dr.GetValue(1).ToString();
                    string nom = dr.GetValue(2).ToString();
                    string appat = dr.GetValue(3).ToString();
                    string apmat = dr.GetValue(4).ToString();
                    int telf = (int)dr.GetValue(5);
                    DateTime fec = (DateTime)dr.GetValue(6);
                    int edad = (int)dr.GetValue(7);
                    string sex = dr.GetValue(8).ToString();
                    int idtip = (int)dr.GetValue(9);
                    string nomtp = dr.GetValue(10).ToString();
                    int idcat = (int)dr.GetValue(11);
                    string nomca = dr.GetValue(12).ToString();
                    string hproc = dr.GetValue(13).ToString();
                    Paciente pac = new Paciente(cod, "", ced, nom, appat, apmat, fec, edad, sex, telf, hproc, idtip,nomtp, idcat,nomca);
                    paciente.Add(pac);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar3();
            }
            return paciente;
        }
        #endregion
        #region verificacion del paciente
        public string Existe(string ced)//VERIFICAMOS SI EXISTE EL PACIENTE
        {
            string res = "";
            try
            {
                abrir2();
                string sql = "SELECT 1 FROM paciente WHERE nrocedula=@ced";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                cmd.Parameters.Add("@ced", MySqlDbType.String);
                cmd.Parameters["@ced"].Value = ced;
                object obj = cmd.ExecuteScalar();
                res = obj.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe");
            }
            finally
            {
                cerrar2();
            }
            return res;
        }
        #endregion
        #region recuperamos el id del paciente
        public int getidpaciente(string ced)//RECUPERAMOS EL ID DEL PACIENTE SEGUN LA CEDULA
        {
            int codoc = 0;
            try
            {
                abrir2();
                string sql = "SELECT idPaciente FROM paciente WHERE Nrocedula='" + ced + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                object res = cmd.ExecuteScalar();
                codoc = (int)res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return codoc;
        }
        #endregion
        #region recupera id del Medico
        public int getidmedsolicitante(string nombre)//RECUPERAR EL ID DEL MEDICO SOLICITANTE
        {
            int medsolic = 0;
            try
            {
                abrir2();
                string sql = "SELECT idMedico FROM medico WHERE Nombre ='" + nombre + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                object res = cmd.ExecuteScalar();
                medsolic = (int)res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return medsolic;
        }
        #endregion
        #region Mostrar los tipos de paciente
        public List<Tipopaciente> GetTipo()//RECUPERAMOS LOS TIPOS DE PACIENTES
        {
            List<Tipopaciente> tipo = new List<Tipopaciente>();
            try
            {
                abrir2();
                string sql = "SELECT idTipoPaciente,NombreTipo FROM tipopaciente";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string nom = dr.GetValue(1).ToString();
                    Tipopaciente t = new Tipopaciente(cod,nom);
                    tipo.Add(t);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return tipo;
        }
        #endregion
        #region mostrar los tipos de categoria
        public List<Categoria> GetCategoria()//RECUPERAMOS TODAS LAS CATEGORIAS
        {
            List<Categoria> cat= new List<Categoria>();
            try
            {
                abrir2();
                string sql = "SELECT idCategoria,NombreCat FROM categoria";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string nom = dr.GetValue(1).ToString();
                    Categoria c = new Categoria(cod, nom);
                    cat.Add(c);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return cat;
        }
        #endregion
        #region recuperamos los estudios
        public List<Estudio> GetEstudio()//RECUPERAMOS LOS ESTUDIOS DISPONIBLES
        {
            List<Estudio> estudio = new List<Estudio>();
            try
            {
                abrir2();
                string sql = "SELECT idEstudio,NombEstudio FROM estudio";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string nom = dr.GetValue(1).ToString();
                    Estudio es = new Estudio(cod, nom);
                    estudio.Add(es);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return estudio;
        }
        #endregion
        #region mostrar turnos
        public List<Turno> GetTurno()//RECUPERAMOS LOS TURNOS REGISTRADOS
        {
            List<Turno> turno= new List<Turno>();
            try
            {
                abrir2();
                string sql = "SELECT idTurno,NombreTurno FROM turno";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string nom = dr.GetValue(1).ToString();
                    Turno tur = new Turno(cod, nom);
                    turno.Add(tur);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return turno;
        }
        #endregion
        #region mostrar Procedimientos
        public List<Procedimiento> GetProcedimiento(int estudio)//RECUPERAMOS LOS PROCEDIMIENTOS SEGUN EL ESTUDIO AL QUE PERTENECEN
        {
            List<Procedimiento> procedimiento = new List<Procedimiento>();
            try
            {
                abrir2();
                string sql = "SELECT idProcedimiento,NombProcedimiento FROM procedimiento WHERE idEstudio = @estudio";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                cmd.Parameters.Add("@estudio", MySqlDbType.Int32);
                cmd.Parameters["@estudio"].Value = estudio;
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string nom = dr.GetValue(1).ToString();
                    Procedimiento proc= new Procedimiento(cod, nom,0);
                    procedimiento.Add(proc);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return procedimiento;
        }
        #endregion
        #region registro de Paciente
        public int RegPaciente(Paciente pa)// REGISTRO DE PACIENTE
        {
            int res = 0;
            try
            {
                abrir2();
                string sql = "INSERT INTO paciente (NroHistClinica,NroCedula,Nombre,ApPat,ApMat,FechaNac,Edad,Sexo, Telefono,HProcedencia,idTipoPaciente,idCategoria) VALUES (@nhclinico,@nrocedula, @nombre, @appaterno, @apmaterno, @fecnacimiento, @edad, @sexo, @telefono, @hdprocedencia, @tipopac, @categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                cmd.Parameters.Add("@nhclinico", MySqlDbType.String);
                cmd.Parameters["@nhclinico"].Value = pa.nhclinica;
                cmd.Parameters.Add("@nrocedula", MySqlDbType.String);
                cmd.Parameters["@nrocedula"].Value = pa.cedula;
                cmd.Parameters.Add("@nombre", MySqlDbType.String);
                cmd.Parameters["@nombre"].Value = pa.nombre;
                cmd.Parameters.Add("@appaterno", MySqlDbType.String);
                cmd.Parameters["@appaterno"].Value = pa.appaterno;
                cmd.Parameters.Add("@apmaterno", MySqlDbType.String);
                cmd.Parameters["@apmaterno"].Value = pa.apmaterno;
                cmd.Parameters.Add("@fecnacimiento", MySqlDbType.Date);
                cmd.Parameters["@fecnacimiento"].Value = pa.fecnacimiento;
                cmd.Parameters.Add("@edad", MySqlDbType.Int32);
                cmd.Parameters["@edad"].Value = pa.edad;
                cmd.Parameters.Add("@sexo", MySqlDbType.String);
                cmd.Parameters["@sexo"].Value = pa.sexo;
                cmd.Parameters.Add("@telefono", MySqlDbType.Int32);
                cmd.Parameters["@telefono"].Value = pa.telefono;
                cmd.Parameters.Add("@hdprocedencia", MySqlDbType.String);
                cmd.Parameters["@hdprocedencia"].Value = pa.hdprocedencia;
                cmd.Parameters.Add("@tipopac", MySqlDbType.Int32);
                cmd.Parameters["@tipopac"].Value = pa.tipopaciente;
                cmd.Parameters.Add("@categoria", MySqlDbType.Int32);
                cmd.Parameters["@categoria"].Value = pa.categoria;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }

            return res;
        }
        #endregion
        #region registramos medico
        public int RegMedico(string medico)//REGISTRAMOS EL MEDICO SOLICITANTE
        {
            int res = 0;
            try
            {
                abrir2();
                string sql = "INSERT INTO `bdprogramacion`.`medico` (`Nombre`) VALUES (@nomedico)";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                cmd.Parameters.Add("@nomedico", MySqlDbType.String);
                cmd.Parameters["@nomedico"].Value = medico;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return res;
        }
        #endregion 

        #region registramos programacion
        public int RegProgramacion(Programacion prg)//REGISTRAMOS LA PROGRAMACION 
        {
            int res = 0;
            try
            {
                abrir2();
                string sql = "INSERT INTO programacion (idProgramacion,idPaciente, idProcedimiento, idDoctor, idMedico ,idTurno, fecha, estado,fechaGuardado) VALUES (@idprg,@idpac, @idproced, @idoc,@idmed ,@idtur, @fec, @est,@fr)";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                cmd.Parameters.Add("@idprg", MySqlDbType.Int32);
                cmd.Parameters["@idprg"].Value = prg.idProgramacion;
                cmd.Parameters.Add("@idpac", MySqlDbType.Int32);
                cmd.Parameters["@idpac"].Value = prg.idPaciente;
                cmd.Parameters.Add("@idproced", MySqlDbType.Int32);
                cmd.Parameters["@idproced"].Value = prg.idProcedimiento;
                cmd.Parameters.Add("@idoc", MySqlDbType.Int32);
                cmd.Parameters["@idoc"].Value = prg.idDoctor;
                cmd.Parameters.Add("@idmed", MySqlDbType.Int32);
                cmd.Parameters["@idmed"].Value = prg.idMedico;
                cmd.Parameters.Add("@idtur", MySqlDbType.Int32);
                cmd.Parameters["@idtur"].Value = prg.idTurno;
                cmd.Parameters.Add("@fec", MySqlDbType.Date);
                cmd.Parameters["@fec"].Value = prg.fecha;
                cmd.Parameters.Add("@est", MySqlDbType.Int32);
                cmd.Parameters["@est"].Value = prg.estado;
                cmd.Parameters.Add("@fr", MySqlDbType.String);
                cmd.Parameters["@fr"].Value =prg.fechaRegistro;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return res;
        }
        #endregion
        #region autocompletacion de texbox
        public void autocompletar(TextBox cadena)//METODO PARA AUTOCOMPLETAR LA CAJA DE DOCTORES DE LA BASE DE DATOS COEGIO
        {
            try
            {
                abrir1();
                string sql = "SELECT idDocente,CONCAT(Nombre,' ',primerApellido,' ',segundoApellido)AS Nombre FROM docente ";
                MySqlCommand cmd = new MySqlCommand(sql, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cadena.AutoCompleteCustomSource.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("nose pudo auto completar:" + ex.Message);
            }
            finally
            {
                cerrar1();
            }
        }
        #endregion
        #region recuperar nombre de doctor
        public string GetNomDoctor(int idoctor)//RECUPERAMOS EL NOMBRE DEL DOCTOR
        {
            string codigo = "";
            try
            {
                abrir1();
                string sql = "SELECT CONCAT(Nombre,' ',primerApellido,' ',segundoApellido) ";
                sql = sql + "FROM docente ";
                sql = sql + "WHERE idDocente='"+idoctor+"' ";
                MySqlCommand cmd = new MySqlCommand(sql, con1);
                object obj = cmd.ExecuteScalar();
                codigo = obj.ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cerrar1();
            }
            return codigo;
        }

        #endregion
        #region recuperamos el codigo del doctor
        public int GetCodigo(string nombre)//RECUPERAMOS EL CODIGO DEL DOCTOR DE LA BASE DE DATOS COLEGIO
        {
            int codigo = 0;
            try
            {
                abrir1();
                string sql = "SELECT idDocente ";
                       sql = sql+ "FROM (SELECT idDocente,CONCAT(Nombre,' ',primerApellido,' ',segundoApellido)AS Nombre FROM docente) AS Docente ";
                       sql = sql + "WHERE Nombre like '%"+nombre+"%' ";
                MySqlCommand cmd = new MySqlCommand(sql, con1);
                object obj = cmd.ExecuteScalar();
                codigo = int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                cerrar1();
            }
            return codigo;
        }
        #endregion
        #region datagriewd de procedimientos
        public DataTable GetProcedimientosFiltro(string cadena) //METODO PARA RECUPERAR LOS PROCEDIMIENTOS FILTRADO POR LA CEDULA DE IDENTIDAD
        {
            DataTable procedimientos = new DataTable();
            try
            {
                abrir2();
                string sql = "SELECT prg.idprocedimiento,p.nombprocedimiento AS Procedimientos,prg.idDoctor,T.NombreTurno,prg.fecha ";
                sql = sql + "FROM programacion prg ";
                sql = sql + "INNER JOIN procedimiento P ON prg.idProcedimiento=p.idprocedimiento ";
                sql = sql + "INNER JOIN turno T ON Prg.idturno=T.idturno ";
                sql = sql + "WHERE idPaciente=(SELECT idpaciente FROM paciente WHERE nrocedula='"+cadena+"')";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(procedimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return procedimientos;
        }
        #endregion
        #region recuperar datos mediante fecha dada
        public DataTable GetProgramacionFiltro() //METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
        {
            DataTable programacion = new DataTable();
            try
            {
                abrir2();
                string sql = "SELECT pr.Nombre,nombprocedimiento AS Procedimientos,T.NombreTurno AS 'Nombre del turno',prg.fecha FROM programacion prg INNER JOIN paciente pr on prg.idPaciente=pr.idPaciente INNER JOIN procedimiento P ON prg.idProcedimiento=p.idprocedimiento  INNER JOIN turno T ON Prg.idTurno=T.idTurno ";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(programacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return programacion;
        }
        #endregion
        #region recuperar fechas
        public DataTable buscarProgramacion(string cadena) //METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
        {
            DataTable programacion1 = new DataTable();
            try
            {
                abrir2();
                string sql = "SELECT prg.idProgramacion,pr.idPaciente,pr.Nombre,p.idProcedimiento,P.nombprocedimiento AS Procedimientos,T.idTurno,T.NombreTurno AS turno,prg.fecha FROM programacion prg  INNER JOIN paciente pr on prg.idPaciente=pr.idPaciente INNER JOIN procedimiento P ON prg.idProcedimiento=p.idprocedimiento  INNER JOIN turno T ON Prg.idTurno=T.idTurno where pr.Nombre like '%" + cadena + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(programacion1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return programacion1;
        }
        #endregion
        #region METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
        public DataTable buscarfecha(string fecha) //METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
        {
            DataTable programacion3 = new DataTable();
            try
            {
                abrir2();
                string sql = "SELECT pr.Nombre,P.nombprocedimiento AS 'Procedimiento Modificado',pr2.nombprocedimiento AS 'procedimiento antes de la modificacion',T.NombreTurno AS 'turno Modificado',t2.NombreTurno AS 'Turno Antes de Modificar',prg.fecha AS 'Fecha Modificada',p2.fecha AS 'fecha antes de la modificacion' FROM programacion prg INNER JOIN paciente pr on prg.idPaciente=pr.idPaciente INNER JOIN procedimiento P ON prg.idProcedimiento=p.idProcedimiento  INNER JOIN turno T ON Prg.idTurno=T.idTurno INNER JOIN programacion2 p2 ON prg.idProgramacion=p2.idProgramacion2 INNER JOIN procedimiento pr2 ON p2.idProcedimiento=pr2.idProcedimiento INNER JOIN turno t2 ON p2.idTurno=t2.idTurno where prg.fecha like '%" + fecha + "%' ";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(programacion3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return programacion3;
        }
        #endregion
        #region recuperar turnos
        public List<string> GetTurno2()//RECUPERAMOS LOS TURNOS REGISTRADOS
        {
            List<string> turno = new List<string>();
            try
            {
                abrir2();
                string sql = "SELECT NombreTurno FROM turno";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    object obj = dr.GetValue(0);
                    turno.Add(obj.ToString());
                    
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return turno;
        }
        #endregion
        #region recuperar fechas
        public List<Procedimiento>buscarProcedimiento(string cadena1) //METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
        {
            List<Procedimiento> procedimientos = new List<Procedimiento>();
            try
            {
                abrir2();
                string sql = "SELECT idProcedimiento,NombProcedimiento FROM procedimiento where NombProcedimiento like '%" + cadena1 + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader da = cmd.ExecuteReader();
                while(da.Read()){
                    int cp = (int)da.GetValue(0);
                    string pro = da.GetValue(1).ToString();
                    Procedimiento x= new Procedimiento(cp,pro,0);
                    procedimientos.Add(x);
                 
              }
                da.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return procedimientos;
        }
        #endregion
        #region modificacion de programacion
        public int actualizarProgramacion(Programacion prg)//REGISTRAMOS LA PROGRAMACION 
        {
            int ress = 0;
            try
            {
                abrir2();
                string sql = " UPDATE programacion SET idProcedimiento=@idproced,idTurno=@idtur,Fecha=@fec,ObsEstado=@obs WHERE idProgramacion=@idprg"; 
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                cmd.Parameters.Add("@idproced", MySqlDbType.Int32);
                cmd.Parameters["@idproced"].Value = prg.idProcedimiento;
                cmd.Parameters.Add("@idtur", MySqlDbType.Int32);
                cmd.Parameters["@idtur"].Value = prg.idTurno;
                cmd.Parameters.Add("@fec", MySqlDbType.Date);
                cmd.Parameters["@fec"].Value = prg.fecha;
                cmd.Parameters.Add("@obs",MySqlDbType.String);
                cmd.Parameters["@obs"].Value = prg.obsestado;
                
                    cmd.Parameters.Add("@idprg", MySqlDbType.Int32);
                cmd.Parameters["@idprg"].Value = prg.idProgramacion;
                ress = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return ress;
        }
        #endregion
        #region insertar medico
        public int RegMedico(Medico b)// REGISTRO DE PACIENTE
        {
            int res = 0;
            try
            {
                abrir1();
                string sql = "INSERT INTO docente (Ci,Nombre,primerApellido,segundoApellido,fechaNacimiento,Sexo,Profecion,Telefono,Correo) VALUES (@ci,@nombre, @appaterno, @apmaterno, @fecnacimiento,@sexo,@profecion, @telefono, @correo)";
                MySqlCommand cmd = new MySqlCommand(sql, con1);
                cmd.Parameters.Add("@ci", MySqlDbType.String);
                cmd.Parameters["@ci"].Value = b.Ci;
                cmd.Parameters.Add("@nombre", MySqlDbType.String);
                cmd.Parameters["@nombre"].Value = b.Nombre;
                cmd.Parameters.Add("@appaterno", MySqlDbType.String);
                cmd.Parameters["@appaterno"].Value = b.primerApellido;
                cmd.Parameters.Add("@apmaterno", MySqlDbType.String);
                cmd.Parameters["@apmaterno"].Value = b.segundoApellido;
                cmd.Parameters.Add("@fecnacimiento", MySqlDbType.Date);
                cmd.Parameters["@fecnacimiento"].Value = b.fechaNacimiento;
                cmd.Parameters.Add("@sexo", MySqlDbType.String);
                cmd.Parameters["@sexo"].Value = b.sexo;
                cmd.Parameters.Add("@profecion", MySqlDbType.String);
                cmd.Parameters["@profecion"].Value = b.profecion;
                cmd.Parameters.Add("@telefono", MySqlDbType.Int32);
                cmd.Parameters["@telefono"].Value = b.telefono;
                cmd.Parameters.Add("@correo", MySqlDbType.String);
                cmd.Parameters["@correo"].Value = b.Correo;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }

            return res;
        }
        #endregion
        #region recuperar estudios
        public List<Estudio>estudioget()//RECUPERAMOS LOS ESTUDIOS
        {
            List<Estudio> tipo = new List<Estudio>();
            try
            {
                abrir2();
                string sql = "SELECT idEstudio,nombEstudio FROM estudio";
                MySqlCommand cmd = new MySqlCommand(sql, con2);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int cod = (int)dr.GetValue(0);
                    string nom = dr.GetValue(1).ToString();
                    Estudio t = new Estudio(cod, nom);
                    tipo.Add(t);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                cerrar2();
            }
            return tipo;
        }
        #endregion
        #region registro de procedimiento
        public int registrarprocedimiento(Procedimiento b)// REGISTRO DE PACIENTE
       {
           int res = 0;
           try
           {
               abrir2();
               string sql = "INSERT INTO procedimiento (NombProcedimiento,idEstudio) VALUES (@nombrepro,@idestudioreo)";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               cmd.Parameters.Add("@nombrepro", MySqlDbType.String);
               cmd.Parameters["@nombrepro"].Value = b.nombprocedimiento;
               cmd.Parameters.Add("@idestudioreo", MySqlDbType.Int32);
               cmd.Parameters["@idestudioreo"].Value = b.idestudio;
               res = cmd.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }

           return res;
       }
        #endregion
        #region mostrar turno
        public List<Turno> turnoget()//RECUPERAMOS LOS ESTUDIOS
       {
           List<Turno> tipo = new List<Turno>();
           try
           {
               abrir2();
               string sql = "SELECT idTurno,NombreTurno FROM turno";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               MySqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   int cod = (int)dr.GetValue(0);
                   string nom = dr.GetValue(1).ToString();
                   Turno t = new Turno(cod, nom);
                   tipo.Add(t); 
               }
               dr.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }
           return tipo;
       }
        #endregion
        #region tabla del paciente
        public DataTable buscarPaciente(string cadena) //METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
       {
           DataTable programacion1 = new DataTable();
           try
           {
               abrir2();
               string sql = "select p.idPaciente,p.NroHistClinica,p.NroCedula,p.Nombre,p.ApPat,p.ApMat,p.FechaNac,p.Edad,p.Sexo,p.Telefono,p.HProcedencia,pr.idTipoPaciente,pr.NombreTipo AS 'tipo de paciente',n.idCategoria,n.NombreCat from paciente p INNER JOIN tipopaciente pr on p.idTipoPaciente=pr.idTipoPaciente INNER JOIN categoria n ON p.idCategoria=n.idCategoria where p.Nombre like '%"+cadena+"%'";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               da.Fill(programacion1);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }
           return programacion1;
       }
        #endregion
        #region modificacion de paciente
        public int modificarPaciente(Paciente pa)// REGISTRO DE PACIENTE
       {
           int res = 0;
           try
           {
               abrir2();
               string sql = "UPDATE paciente SET NroHistClinica=@nhclinico,NroCedula=@nrocedula,Nombre=@nombre,ApPat=@appaterno,ApMat=@apmaterno,FechaNac=@fecnacimiento,Edad=@edad,Sexo=@sexo,Telefono=@telefono,HProcedencia=@hdprocedencia,idTipoPaciente=@tipopac,idCategoria=@categoria WHERE idPaciente= @idpac";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               cmd.Parameters.Add("@idpac", MySqlDbType.Int32);
               cmd.Parameters["@idpac"].Value = pa.idpaciente   ;
               cmd.Parameters.Add("@nhclinico", MySqlDbType.String);
               cmd.Parameters["@nhclinico"].Value = pa.nhclinica;
               cmd.Parameters.Add("@nrocedula", MySqlDbType.String);
               cmd.Parameters["@nrocedula"].Value = pa.cedula;
               cmd.Parameters.Add("@nombre", MySqlDbType.String);
               cmd.Parameters["@nombre"].Value = pa.nombre;
               cmd.Parameters.Add("@appaterno", MySqlDbType.String);
               cmd.Parameters["@appaterno"].Value = pa.appaterno;
               cmd.Parameters.Add("@apmaterno", MySqlDbType.String);
               cmd.Parameters["@apmaterno"].Value = pa.apmaterno;
               cmd.Parameters.Add("@fecnacimiento", MySqlDbType.Date);
               cmd.Parameters["@fecnacimiento"].Value = pa.fecnacimiento;
               cmd.Parameters.Add("@edad", MySqlDbType.Int32);
               cmd.Parameters["@edad"].Value = pa.edad;
               cmd.Parameters.Add("@sexo", MySqlDbType.String);
               cmd.Parameters["@sexo"].Value = pa.sexo;
               cmd.Parameters.Add("@telefono", MySqlDbType.Int32);
               cmd.Parameters["@telefono"].Value = pa.telefono;
               cmd.Parameters.Add("@hdprocedencia", MySqlDbType.String);
               cmd.Parameters["@hdprocedencia"].Value = pa.hdprocedencia;
               cmd.Parameters.Add("@tipopac", MySqlDbType.Int32);
               cmd.Parameters["@tipopac"].Value = pa.tipopaciente;
               cmd.Parameters.Add("@categoria", MySqlDbType.Int32);
               cmd.Parameters["@categoria"].Value = pa.categoria;
               res = cmd.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }

           return res;
       }
        #endregion
        #region tipo paciente
        public List<Tipopaciente> tipopacienteget()//RECUPERAMOS LOS ESTUDIOS
       {
           List<Tipopaciente> tipo = new List<Tipopaciente>();
           try
           {
               abrir2();
               string sql = "SELECT idTipoPaciente,NombreTipo FROM tipopaciente";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               MySqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   int cod = (int)dr.GetValue(0);
                   string nom = dr.GetValue(1).ToString();
                   Tipopaciente t = new Tipopaciente(cod, nom);
                   tipo.Add(t);
               }
               dr.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }
           return tipo;
       }
       #endregion
        #region categoria
       public List<Categoria> categoriaget()
       {
           List<Categoria> tipo = new List<Categoria>();
           try
           {
               abrir2();
               string sql = "SELECT idCategoria,NombreCat FROM categoria";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               MySqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   int cod = (int)dr.GetValue(0);
                   string nom = dr.GetValue(1).ToString();
                   Categoria t = new Categoria(cod, nom);
                   tipo.Add(t);
               }
               dr.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }
           return tipo;
       }
       #endregion
       #region registramos programacion para auditoria
       public int RegProgramacion2(Programacion prg)//REGISTRAMOS LA PROGRAMACION 
       {
           int res = 0;
           try
           {
               abrir2();
               string sql = "INSERT INTO programacion2 (idProgramacion2,idPaciente, idProcedimiento, idDoctor,  idTurno, fecha, estado,fechaGuardado) VALUES (@idprg,@idpac, @idproced, @idoc, @idtur, @fec, 0,@fr)";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               cmd.Parameters.Add("@idprg", MySqlDbType.Int32);
               cmd.Parameters["@idprg"].Value = prg.idProgramacion;
               cmd.Parameters.Add("@idpac", MySqlDbType.Int32);
               cmd.Parameters["@idpac"].Value = prg.idPaciente;
               cmd.Parameters.Add("@idproced", MySqlDbType.Int32);
               cmd.Parameters["@idproced"].Value = prg.idProcedimiento;
               cmd.Parameters.Add("@idoc", MySqlDbType.Int32);
               cmd.Parameters["@idoc"].Value = prg.idDoctor;
               cmd.Parameters.Add("@idtur", MySqlDbType.Int32);
               cmd.Parameters["@idtur"].Value = prg.idTurno;
               cmd.Parameters.Add("@fec", MySqlDbType.Date);
               cmd.Parameters["@fec"].Value = prg.fecha;
               cmd.Parameters.Add("@est", MySqlDbType.Int32);
               cmd.Parameters["@est"].Value = prg.estado;
               cmd.Parameters.Add("@fr", MySqlDbType.String);
               cmd.Parameters["@fr"].Value = prg.fechaRegistro;
               res = cmd.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }
           return res;
       }
       #endregion
       #region tabla del medico
       public DataTable buscarMedico(string cadena) //METODO PARA RECUPERAR LA PROGRAMACION MEDIANTE FECHA
       {
           DataTable programacion1 = new DataTable();
           try
           {
               abrir2();
               string sql = "select idMedico,Nombre FROM medico  where Nombre like '%"+cadena+"%'";
               MySqlCommand cmd = new MySqlCommand(sql, con2);
               MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               da.Fill(programacion1);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error:" + ex.Message);
           }
           finally
           {
               cerrar2();
           }
           return programacion1;
       }
       #endregion
    }
    }



