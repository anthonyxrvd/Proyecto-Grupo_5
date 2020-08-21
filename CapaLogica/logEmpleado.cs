using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class logEmpleado
    {
        #region singleton
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entEmpleado> ListarEmpleado()
        {
            try
            {
                return DatoEmpleado.Instancia.ListarEmpleado();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertarEmpleado(entEmpleado em)
        {
            try
            {
                DatoEmpleado.Instancia.InsertarEmpleado(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public entEmpleado BuscarEmpleadoID(int idEmpleado)
        {

            try
            {
                return DatoEmpleado.Instancia.buscarIdEmpleado(idEmpleado);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public entEmpleado Login(int DNI, int contraseña)
        {

            try
            {
                return DatoEmpleado.Instancia.Login(DNI, contraseña);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void EditaEmpleado(entEmpleado em)
        {

            try
            {
               DatoEmpleado.Instancia.EditarEmpleado(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void EditaEstadoEmpleado(entEmpleado em)
        {

            try
            {
                DatoEmpleado.Instancia.EditarEstadoEmpleado(em);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion metodos
    }
}
