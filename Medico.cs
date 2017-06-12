using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    public class Medico
    {
          public int idDoctor { get; set; }
            public string Ci { get; set; }
            public string Nombre { get; set; }
            public string primerApellido { get; set; }
            public string segundoApellido { get; set; }
            public DateTime fechaNacimiento { get; set; }
            public string sexo { get; set; }
             public string profecion{ get; set; }
            public int telefono { get; set; }  
             public string Correo { get; set; }
            public Medico(int id,string ci, string n, string app, string apm, DateTime fecnac, string s, string p ,int t,string cor )
            {
                idDoctor= id;
                Ci = ci;
                Nombre = n;
                primerApellido = app;
                segundoApellido= apm;
                fechaNacimiento= fecnac;
                sexo = s;
                profecion = p;
                telefono = t;
                Correo = cor;
            }
    }
}
