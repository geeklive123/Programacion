using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    class Estudio
    {
        public int idestudio { get; set; }
        public string nomestudio { get; set; }
        public Estudio(int id,string nomestud)
        {
            idestudio = id;
            nomestudio = nomestud;
        }
    }
}
