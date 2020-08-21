using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOcupacion
    {
        public int idOcupacion { set; get; }
        public string Ocupacion { set; get; }

        public override string ToString()
        {
            return Ocupacion;
        }

    }
}
