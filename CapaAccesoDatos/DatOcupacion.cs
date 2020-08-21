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
    public class DatOcupacion
    {
        #region singleton
        private static readonly DatOcupacion _instancia = new DatOcupacion();
        public static DatOcupacion Instancia
        {
            get { return DatOcupacion._instancia; }
        }
        #endregion singleton

        public List<entOcupacion> ListarOcupacion()
        {
            SqlCommand cmd = null;
            List<entOcupacion> lista = new List<entOcupacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarOcupacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOcupacion us = new entOcupacion();
                
                    us.idOcupacion = Convert.ToInt32(dr["OcupacionID"]);
                    us.Ocupacion = dr["Ocupacione"].ToString(); 
                    lista.Add(us);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarOcupacion(entOcupacion us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarOcupacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ocupacion", us.Ocupacion);

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
