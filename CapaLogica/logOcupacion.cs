using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logOcupacion
    {
        #region singleton
        private static readonly logOcupacion _instancia = new logOcupacion();
        public static logOcupacion Instancia
        {
            get
            {
                return logOcupacion._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entOcupacion> ListarOcupacion()
        {
            try
            {
                return DatOcupacion.Instancia.ListarOcupacion();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarOcupacion(entOcupacion em)
        {
            try
            {
                DatOcupacion.Instancia.InsertarOcupacion(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
