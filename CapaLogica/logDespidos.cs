using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logDespidos
    {
        #region singleton
        private static readonly logDespidos _instancia = new logDespidos();
        public static logDespidos Instancia
        {
            get
            {
                return logDespidos._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entDespido> ListarDespidos()
        {
            try
            {
                return datDespido.Instancia.ListarDespidos();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarDespidos(entDespido des)
        {
            try
            {
                datDespido.Instancia.InsertarDespido(des);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
