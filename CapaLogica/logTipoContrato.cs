using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logTipoContrato
    {
        #region singleton
        private static readonly logTipoContrato _instancia = new logTipoContrato();
        public static logTipoContrato Instancia
        {
            get
            {
                return logTipoContrato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entTipoContrato> ListarTipoContrato()
        {
            try
            {
                return datTipoContrato.Instancia.ListarTipoContrato();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarTipoContrato(entTipoContrato c)
        {
            try
            {
                datTipoContrato.Instancia.InsertarTipoContrato(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
