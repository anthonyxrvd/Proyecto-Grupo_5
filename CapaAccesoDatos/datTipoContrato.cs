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
    public class datTipoContrato
    {
        #region singleton
        private static readonly datTipoContrato _instancia = new datTipoContrato();
        public static datTipoContrato Instancia
        {
            get { return datTipoContrato._instancia; }
        }
        #endregion singleton
        public List<entTipoContrato> ListarTipoContrato()
        {
            SqlCommand cmd = null;
            List<entTipoContrato> lista = new List<entTipoContrato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarTipoContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoContrato  tc = new entTipoContrato();
                    tc.idTipoContrato = Convert.ToInt32(dr["TipoDeContratoID"]);
                    tc.Tipocontrato = dr["Tipocontrato"].ToString();
                    lista.Add(tc);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean InsertarTipoContrato(entTipoContrato tc)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarTipoContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoContrato", tc.Tipocontrato);
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


    }
}
