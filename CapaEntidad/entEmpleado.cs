using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaEntidad
{
    public class entEmpleado
    {
        public int idEmpleado { set; get; }
        public string PrimerNombre { set; get; }
        public string SegundoNombre { set; get; }
        public string PrimerApellido { set; get; }
        public string SegundoApellido { set; get; }
        public int DNI { set; get; }
        public string Domicilio { set; get; }
        public entGenero GeneroID { set; get; }
        public entOcupacion OcupacionID { set; get; }
        public entEstadoCivil EstadoCivilID { set; get; }
        public entCargo  CargoID { set; get; }
        public string Jerarquia { set; get; }
        public entTurno TurnoID { set; get; }
        public int Contraseña { set; get; }
        public DateTime FechaDeNamiento { set; get; }
        public entAFP AFPID { set; get; }
        public entAseguradora AseguradoraID { set; get; }
        public int Edad { set; get; }
        public DateTime FechaRegistro { set; get; }
        public int RUC { set; get; }
        public float Sueldo { set; get; }
        public string Estado { set; get; }

        public override string ToString()
        {
            return PrimerNombre;
        }
        //---------------------------------------------------
        public Byte Foto { set; get; }

    }
}
