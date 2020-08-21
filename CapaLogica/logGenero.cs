using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logGenero
    {
        #region singleton
        private static readonly logGenero _instancia = new logGenero();
        public static logGenero Instancia
        {
            get
            {
                return logGenero._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entGenero> ListarGenero()
        {
            try
            {
                return datGenero.Instancia.ListarGenero();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarGenero(entGenero em)
        {
            try
            {
                datGenero.Instancia.InsertarGenero(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
