using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datContrato
    {
        #region singleton
        private static readonly datContrato _instancia = new datContrato();
        public static datContrato Instancia
        {
            get { return datContrato._instancia; }
        }
        #endregion singleton
        public List<entContrato> ListarContrato()
        {
            SqlCommand cmd = null;
            List<entContrato> lista = new List<entContrato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entContrato c = new entContrato();
                    c.idContrato = Convert.ToInt32(dr["ContratoID"]);
                    c.FechaInicio = Convert.ToDateTime(dr["Fechainicio"]);
                    c.FechaFinal = Convert.ToDateTime(dr["Fechafinal"]);
                    entTipoContrato tc = new entTipoContrato();
                    tc.Tipocontrato = dr["TipoDeContratoID"].ToString();
                    c.TipoContratoID = tc;
                    entEmpleado em = new entEmpleado();
                    em.PrimerNombre = dr["EmpleadoID"].ToString();
                    c.EmpleadoID = em;

                    lista.Add(c);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean InsertarContrato(entContrato con)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpleadoID", con.EmpleadoID.idEmpleado);
                cmd.Parameters.AddWithValue("@TipoContrato", con.TipoContratoID.idTipoContrato);
                cmd.Parameters.AddWithValue("@FechaInicio", con.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", con.FechaFinal);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public Boolean EditarContrato(entContrato con)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spEditarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idContrato", con.idContrato);
                cmd.Parameters.AddWithValue("@EmpleadoID", con.EmpleadoID.idEmpleado);
                cmd.Parameters.AddWithValue("@TipoContratoID", con.TipoContratoID.idTipoContrato);
                cmd.Parameters.AddWithValue("@FechaInicio", con.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", con.FechaFinal);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { edita = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //public entContrato buscarContrato(int idContrato)
        //{
        //    //SqlCommand cmd = null; entContrato em = new entContrato();
        //    //try
        //    //{
        //    //    SqlConnection cn = Conexion.Instancia.conectar();
        //    //    cmd = new SqlCommand("spBuscaridEmpleado", cn);
        //    //    cmd.CommandType = CommandType.StoredProcedure;
        //    //    cmd.Parameters.AddWithValue("@idContrato", idContrato);
        //    //    cn.Open(); SqlDataReader dr = cmd.ExecuteReader();
        //    //}
        //    //catch (Exception e)
        //    //{

        //    //    throw e;
        //    //}
        //    //finally { cmd.Connection.Close(); }
        //    //return c;


        //}
    }
}
