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
    public class datAFP
    {
        #region singleton
        private static readonly datAFP _instancia = new datAFP();
        public static datAFP Instancia
        {
            get { return datAFP._instancia; }
        }
        #endregion singleton
        public List<entAFP> ListarAFP()
        {
            SqlCommand cmd = null;
            List<entAFP> lista = new List<entAFP>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarAFP", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAFP us = new entAFP();
                    us.idAfp = Convert.ToInt32(dr["AFPID"]);
                    us.Afp = dr["Nombresafp"].ToString();
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

        public Boolean InsertarAFP(entAFP us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarAFP", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AFP", us.Afp);

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
