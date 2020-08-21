using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTurno
    {
        public int idTurno { set; get; }
        public string Turno { set; get; }
        public override string ToString()
        {
            return Turno;
        }
    }
}
