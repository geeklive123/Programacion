using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    public class Doctor
    {
        public int idDoctor{ get; set; }
        public string nombrecompleto { get; set; }
        public Doctor(int id, string nc)
        {
            idDoctor = id;
            nombrecompleto = nc;
        }
    }
}
