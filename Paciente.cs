using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
   public class Paciente
    {
            public int idpaciente { get; set; }
            public string nhclinica { get; set; }
            public string cedula { get; set; }
            public string nombre { get; set; }
            public string appaterno { get; set; }
            public string apmaterno { get; set; }
            public DateTime fecnacimiento { get; set; }
            public int edad { get; set; }
            public string sexo { get; set; }
            public int telefono { get; set; }
            public string hdprocedencia { get; set; }
            public int tipopaciente { get; set; }
            public string nomtipo{ get; set; }
            public int categoria { get; set; }
            public string nomcategoria { get; set; }
            //public string nomedico { get; set; }
            public Paciente(int id, string nhc,string ci, string n, string app, string apm, DateTime fecnac, int e, string s, int t, string hdp, int tp,string nomtp, int ca,string nomca)
            {
                idpaciente = id;
                nhclinica = nhc;
                cedula = ci;
                nombre = n;
                appaterno = app;
                apmaterno = apm;
                fecnacimiento = fecnac;
                edad = e;
                sexo = s;
                telefono = t;
                hdprocedencia = hdp;
                tipopaciente = tp;
                nomtipo = nomtp;
                categoria = ca;
                nomcategoria = nomca;
               // nomedico = medc;
            }
    }
}
