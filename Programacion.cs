using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    public class Programacion
    {
        public int idProgramacion{get;set;}
        public int idPaciente { get; set; }
        public int idProcedimiento { get; set; }
        public int idDoctor { get; set; }
        public int idMedico { get; set; }
        public int idTurno { get; set; }
        public DateTime fecha { get; set; }
        public int estado { get; set; }
        public string obsestado { get; set; }
      public string fechaRegistro { get; set; }
        public Programacion(int idprg,int idpac,int idpro, int idoc, int idmed, int idtur, DateTime fec, int est, string obsest,string fr)
        {
            idProgramacion = idprg;
            idPaciente = idpac;
            idProcedimiento = idpro;
            idDoctor = idoc;
            idMedico = idmed;
            idTurno = idtur;
            fecha = fec;
            estado = est;
            obsestado = obsest;
            fechaRegistro = fr;
           
        }
    }
}
