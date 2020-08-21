using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logAFP
    {
        #region singleton
        private static readonly logAFP _instancia = new logAFP();
        public static logAFP Instancia
        {
            get
            {
                return logAFP._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entAFP> ListarAFP()
        {
            try
            {
                return datAFP.Instancia.ListarAFP();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarAFP(entAFP em)
        {
            try
            {
                datAFP.Instancia.InsertarAFP(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
