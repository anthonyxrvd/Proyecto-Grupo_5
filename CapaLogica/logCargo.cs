using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logCargo
    {
        #region singleton
        private static readonly logCargo _instancia = new logCargo();
        public static logCargo Instancia
        {
            get
            {
                return logCargo._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entCargo> ListarCargo()
        {
            try
            {
                return datCargo.Instancia.ListarCargo();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarCargo(entCargo em)
        {
            try
            {
                datCargo.Instancia.InsertarCargo(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
