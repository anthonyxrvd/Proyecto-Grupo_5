using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCargo
    {
        public int idCargo { set; get; }
        public string Cargo { set; get; }

        public override string ToString()
        {
            return Cargo;
        }
    }
}
