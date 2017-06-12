using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
   public class Procedimiento
    {
        public int idprocedimiento { get; set; }
        public string nombprocedimiento { get; set; }
        public int idestudio { get; set; }
        public Procedimiento(int id, string npro,int ide)
        {
            idprocedimiento = id;
            nombprocedimiento = npro;
            idestudio = ide;
        }
    }
}
