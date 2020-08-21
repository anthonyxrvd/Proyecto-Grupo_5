using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logEstadoCivil
    {
        #region singleton
        private static readonly logEstadoCivil _instancia = new logEstadoCivil();
        public static logEstadoCivil Instancia
        {
            get
            {
                return logEstadoCivil._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entEstadoCivil> ListarEstadoCivil()
        {
            try
            {
                return datEstadoCivil.Instancia.ListarEstadoCivil();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarEstadoCivil(entEstadoCivil em)
        {
            try
            {
                datEstadoCivil.Instancia.InsertarEstadoCivil(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
