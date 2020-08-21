using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logAseguradora
    {
        #region singleton
        private static readonly logAseguradora _instancia = new logAseguradora();
        public static logAseguradora Instancia
        {
            get
            {
                return logAseguradora._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAseguradora> ListarAseguradora()
        {
            try
            {
                return datAseguradora.Instancia.ListarAseguradora();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarAseguradora(entAseguradora em)
        {
            try
            {
                datAseguradora.Instancia.InsertarAseguradora(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
