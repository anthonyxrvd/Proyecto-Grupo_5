using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAseguradora
    {
        public int idAseguradora { set; get; }
        public string Aseguradora { set; get; }
        public override string ToString()
        {
            return Aseguradora;
        }
    }
}
