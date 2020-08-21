using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logContrato
    {
        #region singleton
        private static readonly logContrato _instancia = new logContrato();
        public static logContrato Instancia
        {
            get
            {
                return logContrato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entContrato> ListarContrato()
        {
            try
            {
                return datContrato.Instancia.ListarContrato();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarContrato(entContrato c)
        {
            try
            {
                datContrato.Instancia.InsertarContrato(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void editarContrato(entContrato c)
        {
            try
            {
                datContrato.Instancia.EditarContrato(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
