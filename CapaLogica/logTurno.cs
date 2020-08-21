using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logTurno
    {
        #region singleton
        private static readonly logTurno _instancia = new logTurno();
        public static logTurno Instancia
        {
            get
            {
                return logTurno._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entTurno> ListarTurno()
        {
            try
            {
                return datTurno.Instancia.ListarTurno();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarTurno(entTurno em)
        {
            try
            {
                datTurno.Instancia.InsertarTurno(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
