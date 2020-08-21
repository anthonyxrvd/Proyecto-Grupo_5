using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entContrato
    {
        public int idContrato { set; get; }
        public entEmpleado EmpleadoID { set; get; }
        public DateTime FechaInicio { set; get; }
        public DateTime FechaFinal { set; get; }
        public entTipoContrato TipoContratoID { set; get; }

    }
}
