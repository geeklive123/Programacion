using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    class Turno
    {
        public int idturno { get; set; }
        public string turno { get; set; }
        public Turno(int id,string tur)
        {
            idturno = id;
            turno = tur;
        }
    }
}
