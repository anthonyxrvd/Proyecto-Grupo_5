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
    public class datDespido
    {
        #region singleton
        private static readonly datDespido _instancia = new datDespido();
        public static datDespido Instancia
        {
            get { return datDespido._instancia; }
        }
        #endregion singleton

        public List<entDespido> ListarDespidos()
        {
            SqlCommand cmd = null;
            List<entDespido> lista = new List<entDespido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarDespidos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDespido des = new entDespido();
                    des.idDespido = Convert.ToInt32(dr["DespidoID"]);
                    entEmpleado em = new entEmpleado();
                    em.PrimerNombre = dr["Primernombre"].ToString();
                    des.EmpleadoID = em;

                    des.FechaDeDespido = Convert.ToDateTime(dr["FechaDespido"]);
                    des.motivo = dr["Motivo"].ToString();

                    lista.Add(des);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean InsertarDespido(entDespido des)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarDespidos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", des.EmpleadoID.idEmpleado);
                cmd.Parameters.AddWithValue("@FechaDespido", des.FechaDeDespido);
                cmd.Parameters.AddWithValue("@Motivo", des.motivo);
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
