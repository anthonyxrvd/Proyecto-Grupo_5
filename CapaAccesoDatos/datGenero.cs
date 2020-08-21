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
    public class datGenero
    {
        #region singleton
        private static readonly datGenero _instancia = new datGenero();
        public static datGenero Instancia
        {
            get { return datGenero._instancia; }
        }
        #endregion singleton

        public List<entGenero> ListarGenero()
        {
            SqlCommand cmd = null;
            List<entGenero> lista = new List<entGenero>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarGenero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entGenero us = new entGenero();
                    us.idGenero = Convert.ToInt32(dr["GeneroID"]);
                    us.Genero =dr["Generos"].ToString();
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
        public Boolean InsertarGenero(entGenero us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarGenero", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Genero", us.Genero);

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

