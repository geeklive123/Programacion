using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGBJ_Programacion2
{
    class Categoria
    {
#region constructores
        public Categoria(int id, string nom)
        {
            idcategoria = id;
            nombrecat = nom;
        }
#endregion
        #region atributos
        public int idcategoria { get; set; }
        public string nombrecat { get; set; }
        #endregion
    }
}
