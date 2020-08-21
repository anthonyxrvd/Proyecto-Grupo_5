using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entGenero
    {
        public int idGenero{ set; get; }
        public string Genero { set; get; }
        public override string ToString()
        {
            return Genero;
        }
    }
}
