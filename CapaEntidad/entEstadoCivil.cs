using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEstadoCivil
    {
        public int idEstadoCivil { set; get; }
        public string EstadoCivil { set; get; }
        public override string ToString()
        {
            return EstadoCivil;
        }
    }
}
