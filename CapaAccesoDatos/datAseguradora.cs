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
    public class datAseguradora
    {
        #region singleton
        private static readonly datAseguradora _instancia = new datAseguradora();
        public static datAseguradora Instancia
        {
            get { return datAseguradora._instancia; }
        }
        #endregion singleton
        public List<entAseguradora> ListarAseguradora()
        {
            SqlCommand cmd = null;
            List<entAseguradora> lista = new List<entAseguradora>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarAseguradora", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAseguradora us = new entAseguradora();
                    us.idAseguradora = Convert.ToInt32(dr["AseguradoraID"]);
                    us.Aseguradora = dr["Seguromedico"].ToString();
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

        public Boolean InsertarAseguradora(entAseguradora us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarAseguradora", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Aseguradora", us.Aseguradora);

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
