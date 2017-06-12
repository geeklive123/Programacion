using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    class Tipopaciente
    {
        public int idtipaciente { get; set; }
        public string nombre { get; set; }
        public Tipopaciente(int tip,string nom)
        {
            idtipaciente = tip;
            nombre = nom;
        }
    }
}
