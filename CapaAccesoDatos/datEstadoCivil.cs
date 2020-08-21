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
    public class datEstadoCivil
    {
        #region singleton
        private static readonly datEstadoCivil _instancia = new datEstadoCivil();
        public static datEstadoCivil Instancia
        {
            get { return datEstadoCivil._instancia; }
        }
        #endregion singleton

        public List<entEstadoCivil> ListarEstadoCivil()
        {
            SqlCommand cmd = null;
            List<entEstadoCivil> lista = new List<entEstadoCivil>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarEstadoCivil", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEstadoCivil us = new entEstadoCivil();
                    us.idEstadoCivil = Convert.ToInt32(dr["EstadoCivilID"]);
                    us.EstadoCivil = dr["Estadocivile"].ToString();
                    
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
        public Boolean InsertarEstadoCivil(entEstadoCivil us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarEstadoCivil", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EstadoCivil", us.EstadoCivil);

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

