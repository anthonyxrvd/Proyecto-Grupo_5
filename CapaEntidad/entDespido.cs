using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDespido
    {
        public int idDespido { set; get; }
        public string motivo { set; get; }
        public DateTime FechaDeDespido { set; get; }
        public entEmpleado EmpleadoID { set; get; }
    }
}
