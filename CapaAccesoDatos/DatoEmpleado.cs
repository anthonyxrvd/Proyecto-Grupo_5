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
    public class DatoEmpleado
    {
        #region singleton
        private static readonly DatoEmpleado _instancia = new DatoEmpleado();
        public static DatoEmpleado Instancia
        {
            get { return DatoEmpleado._instancia; }
        }
        #endregion singleton

        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado em = new entEmpleado();
                    em.idEmpleado = Convert.ToInt32(dr["EmpleadoID"]);//------------------------ok
                    em.PrimerNombre = dr["Primernombre"].ToString();//-------------------------ok
                    em.SegundoNombre = dr["Segundonombre"].ToString();//-------------------------ok
                    em.PrimerApellido = dr["Primerapellido"].ToString();//-----------------------ok
                    em.SegundoApellido = dr["Segundoapellido"].ToString();//---------------------ok
                    em.DNI = Convert.ToInt32(dr["Dni"]);//--------------------------ok

                    entGenero ge = new entGenero();
                    //ge.idGenero = Convert.ToInt32(dr["GeneroID"]);
                    ge.Genero = dr["Generos"].ToString();//----------------------------ok
                    em.GeneroID = ge;

                    entOcupacion oc = new entOcupacion();
                    //oc.idOcupacion = Convert.ToInt32(dr["OcupacionID"]);
                    oc.Ocupacion = dr["Ocupacione"].ToString();//-------------------------ok
                    em.OcupacionID = oc;

                    entEstadoCivil ec = new entEstadoCivil();
                    //ec.idEstadoCivil = Convert.ToInt32(dr["idEstadocivilID"]);
                    ec.EstadoCivil = dr["Estadocivile"].ToString();//---------------------------------ok
                    em.EstadoCivilID = ec;
                    
                    entAFP af = new entAFP();
                    //af.idAfp = Convert.ToInt32(dr["AFPID"]);
                    af.Afp = dr["Nombresafp"].ToString();//------------------------------ok
                    em.AFPID = af;

                    entAseguradora ase = new entAseguradora();
                    //ase.idAseguradora = Convert.ToInt32(dr["AseguradoraID"]);
                    ase.Aseguradora = dr["Seguromedico"].ToString();//------------------------------ok
                    em.AseguradoraID = ase;

                    em.FechaDeNamiento = Convert.ToDateTime(dr["Fechanacimiento"]);//-----------------------ok
                    em.Edad = Convert.ToInt32(dr["Edad"]);//---------------------------ok
                    em.Domicilio = dr["Domicilio"].ToString();//----------------------ok
                    em.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);//-----------------------ok
                    em.RUC = Convert.ToInt32(dr["RUC"]);

                    entCargo ca = new entCargo();
                    //ca.idCargo = Convert.ToInt32(dr["CargoID"]);
                    ca.Cargo = dr["Cargos"].ToString();//------------------------------ok
                    em.CargoID = ca;

                    em.Jerarquia = dr["Jerarquia"].ToString();//------------------------ok

                    entTurno tu = new entTurno();
                    //tu.idTurno = Convert.ToInt32(dr["TurnoID"]);
                    tu.Turno = dr["Turnos"].ToString();//------------------------ok
                    em.TurnoID = tu;

                    em.Contraseña = Convert.ToInt32(dr["Contraseña"]);//----------------------------ok
                    em.Sueldo = float.Parse(dr["Sueldo"].ToString());
                    em.Estado = dr["Estado"].ToString();
                    lista.Add(em);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarEmpleado(entEmpleado us)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PrimerNombre", us.PrimerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", us.SegundoNombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", us.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", us.SegundoApellido);
                cmd.Parameters.AddWithValue("@Dni", us.DNI);
                cmd.Parameters.AddWithValue("@GeneroID", us.GeneroID.idGenero);
                cmd.Parameters.AddWithValue("@OcupacionID",us.OcupacionID.idOcupacion);
                cmd.Parameters.AddWithValue("@EstadoCivilID", us.EstadoCivilID.idEstadoCivil);
                cmd.Parameters.AddWithValue("@FechaDeNacimiento", us.FechaDeNamiento);
                cmd.Parameters.AddWithValue("@Edad", us.Edad);
                cmd.Parameters.AddWithValue("@Domicilio", us.Domicilio);
                cmd.Parameters.AddWithValue("@Ruc", us.RUC);
                cmd.Parameters.AddWithValue("@AfpID", us.AFPID.idAfp);
                cmd.Parameters.AddWithValue("@FechaRegistro", us.FechaRegistro);
                cmd.Parameters.AddWithValue("@AseguradoraID", us.AseguradoraID.idAseguradora);
                cmd.Parameters.AddWithValue("@CargoID", us.CargoID.idCargo);
                cmd.Parameters.AddWithValue("@Jerarquia", us.Jerarquia);
                cmd.Parameters.AddWithValue("@TurnoID", us.TurnoID.idTurno);
                cmd.Parameters.AddWithValue("@Contrasena", us.Contraseña);
                cmd.Parameters.AddWithValue("@Sueldo", us.Sueldo);
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
        public Boolean EditarEmpleado(entEmpleado us)
        {
            SqlCommand cmd = null; Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spEditarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", us.idEmpleado);
                cmd.Parameters.AddWithValue("@PrimerNombre", us.PrimerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", us.SegundoNombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", us.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", us.SegundoApellido);
                cmd.Parameters.AddWithValue("@Dni", us.DNI);
                cmd.Parameters.AddWithValue("@GeneroID", us.GeneroID.idGenero);
                cmd.Parameters.AddWithValue("@OcupacionID", us.OcupacionID.idOcupacion);
                cmd.Parameters.AddWithValue("@EstadoCivilID", us.EstadoCivilID.idEstadoCivil);
                cmd.Parameters.AddWithValue("@FechaDeNacimiento", us.FechaDeNamiento);
                cmd.Parameters.AddWithValue("@Edad", us.Edad);
                cmd.Parameters.AddWithValue("@Domicilio", us.Domicilio);
                cmd.Parameters.AddWithValue("@Ruc", us.RUC);
                cmd.Parameters.AddWithValue("@AfpID", us.AFPID.idAfp);
                cmd.Parameters.AddWithValue("@FechaRegistro", us.FechaRegistro);
                cmd.Parameters.AddWithValue("@AseguradoraID", us.AseguradoraID.idAseguradora);
                cmd.Parameters.AddWithValue("@CargoID", us.CargoID.idCargo);
                cmd.Parameters.AddWithValue("@Jerarquia", us.Jerarquia);
                cmd.Parameters.AddWithValue("@TurnoID", us.TurnoID.idTurno);
                cmd.Parameters.AddWithValue("@Contrasena", us.Contraseña);
                cmd.Parameters.AddWithValue("@Sueldo", us.Sueldo);
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

        public entEmpleado buscarIdEmpleado(int idEmpleado)
        {
            SqlCommand cmd = null; entEmpleado em = new entEmpleado();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spBuscaridEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open(); SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    em.idEmpleado = Convert.ToInt32(dr["EmpleadoID"]);//------------------------ok
                    em.PrimerNombre = dr["Primernombre"].ToString();//-------------------------ok
                    em.SegundoNombre = dr["Segundonombre"].ToString();//-------------------------ok
                    em.PrimerApellido = dr["Primerapellido"].ToString();//-----------------------ok
                    em.SegundoApellido = dr["Segundoapellido"].ToString();//---------------------ok
                    em.DNI = Convert.ToInt32(dr["Dni"]);//--------------------------ok

                    entGenero ge = new entGenero();
                    //ge.idGenero = Convert.ToInt32(dr["GeneroID"]);
                    ge.Genero = dr["Generos"].ToString();//----------------------------ok
                    em.GeneroID = ge;

                    entOcupacion oc = new entOcupacion();
                    //oc.idOcupacion = Convert.ToInt32(dr["OcupacionID"]);
                    oc.Ocupacion = dr["Ocupacione"].ToString();//-------------------------ok
                    em.OcupacionID = oc;

                    entEstadoCivil ec = new entEstadoCivil();
                    //ec.idEstadoCivil = Convert.ToInt32(dr["idEstadocivilID"]);
                    ec.EstadoCivil = dr["Estadocivile"].ToString();//---------------------------------ok
                    em.EstadoCivilID = ec;

                    entAFP af = new entAFP();
                    //af.idAfp = Convert.ToInt32(dr["AFPID"]);
                    af.Afp = dr["Nombresafp"].ToString();//------------------------------ok
                    em.AFPID = af;

                    entAseguradora ase = new entAseguradora();
                    //ase.idAseguradora = Convert.ToInt32(dr["AseguradoraID"]);
                    ase.Aseguradora = dr["Seguromedico"].ToString();//------------------------------ok
                    em.AseguradoraID = ase;

                    em.FechaDeNamiento = Convert.ToDateTime(dr["Fechanacimiento"]);//-----------------------ok
                    em.Edad = Convert.ToInt32(dr["Edad"]);//---------------------------ok
                    em.Domicilio = dr["Domicilio"].ToString();//----------------------ok
                    em.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);//-----------------------ok
                    em.RUC = Convert.ToInt32(dr["RUC"]);

                    entCargo ca = new entCargo();
                    //ca.idCargo = Convert.ToInt32(dr["CargoID"]);
                    ca.Cargo = dr["Cargos"].ToString();//------------------------------ok
                    em.CargoID = ca;

                    em.Jerarquia = dr["Jerarquia"].ToString();//------------------------ok

                    entTurno tu = new entTurno();
                    //tu.idTurno = Convert.ToInt32(dr["TurnoID"]);
                    tu.Turno = dr["Turnos"].ToString();//------------------------ok
                    em.TurnoID = tu;

                    em.Contraseña = Convert.ToInt32(dr["Contraseña"]);//----------------------------ok
                    em.Sueldo = float.Parse(dr["Sueldo"].ToString());
                    em.Estado = dr["Estado"].ToString();

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return em;
        }
        public entEmpleado Login(int DNI, int contraseña)
        {
            SqlCommand cmd = null; entEmpleado em = new entEmpleado();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spLogin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", DNI);
                cmd.Parameters.AddWithValue("@Contrasena", contraseña);
                cn.Open(); SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    em.PrimerNombre = dr["Primernombre"].ToString();//-------------------------ok
                    em.SegundoNombre = dr["Segundonombre"].ToString();//-------------------------ok
                    em.PrimerApellido = dr["Primerapellido"].ToString();//-----------------------ok
                    em.SegundoApellido = dr["Segundoapellido"].ToString();//---------------------ok
                    em.DNI = Convert.ToInt32(dr["Dni"]);//--------------------------ok

                    entGenero ge = new entGenero();
                    //ge.idGenero = Convert.ToInt32(dr["GeneroID"]);
                    ge.Genero = dr["Generos"].ToString();//----------------------------ok
                    em.GeneroID = ge;

                    entOcupacion oc = new entOcupacion();
                    //oc.idOcupacion = Convert.ToInt32(dr["OcupacionID"]);
                    oc.Ocupacion = dr["Ocupacione"].ToString();//-------------------------ok
                    em.OcupacionID = oc;

                    entEstadoCivil ec = new entEstadoCivil();
                    //ec.idEstadoCivil = Convert.ToInt32(dr["idEstadocivilID"]);
                    ec.EstadoCivil = dr["Estadocivile"].ToString();//---------------------------------ok
                    em.EstadoCivilID = ec;

                    entAFP af = new entAFP();
                    //af.idAfp = Convert.ToInt32(dr["AFPID"]);
                    af.Afp = dr["Nombresafp"].ToString();//------------------------------ok
                    em.AFPID = af;

                    entAseguradora ase = new entAseguradora();
                    //ase.idAseguradora = Convert.ToInt32(dr["AseguradoraID"]);
                    ase.Aseguradora = dr["Seguromedico"].ToString();//------------------------------ok
                    em.AseguradoraID = ase;

                    em.FechaDeNamiento = Convert.ToDateTime(dr["Fechanacimiento"]);//-----------------------ok
                    em.Edad = Convert.ToInt32(dr["Edad"]);//---------------------------ok
                    em.Domicilio = dr["Domicilio"].ToString();//----------------------ok
                    em.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);//-----------------------ok
                    em.RUC = Convert.ToInt32(dr["RUC"]);

                    entCargo ca = new entCargo();
                    //ca.idCargo = Convert.ToInt32(dr["CargoID"]);
                    ca.Cargo = dr["Cargos"].ToString();//------------------------------ok
                    em.CargoID = ca;

                    em.Jerarquia = dr["Jerarquia"].ToString();//------------------------ok

                    entTurno tu = new entTurno();
                    //tu.idTurno = Convert.ToInt32(dr["TurnoID"]);
                    tu.Turno = dr["Turnos"].ToString();//------------------------ok
                    em.TurnoID = tu;

                    em.Contraseña = Convert.ToInt32(dr["Contraseña"]);//----------------------------ok
                    em.Sueldo = float.Parse(dr["Sueldo"].ToString());
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return em;
        }

        public entEmpleado EliminarEmpleado(int idUsuario)
        {
            SqlCommand cmd = null;
            entEmpleado us = new entEmpleado();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spEliminarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idUsuario);
                cn.Open(); SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmd.Parameters.AddWithValue("@PrimerNombre", us.PrimerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", us.SegundoNombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", us.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", us.SegundoApellido);
                    cmd.Parameters.AddWithValue("@Dni", us.DNI);
                    cmd.Parameters.AddWithValue("@GeneroID", us.GeneroID.idGenero);
                    cmd.Parameters.AddWithValue("@OcupacionID", us.OcupacionID.idOcupacion);
                    cmd.Parameters.AddWithValue("@EstadoCivilID", us.EstadoCivilID.idEstadoCivil);
                    cmd.Parameters.AddWithValue("@FechaDeNacimiento", us.FechaDeNamiento);
                    cmd.Parameters.AddWithValue("@Edad", us.Edad);
                    cmd.Parameters.AddWithValue("@Domicilio", us.Domicilio);
                    cmd.Parameters.AddWithValue("@Ruc", us.RUC);
                    cmd.Parameters.AddWithValue("@AfpID", us.AFPID.idAfp);
                    cmd.Parameters.AddWithValue("@FechaRegistro", us.FechaRegistro);
                    cmd.Parameters.AddWithValue("@AseguradoraID", us.AseguradoraID.idAseguradora);
                    cmd.Parameters.AddWithValue("@CargoID", us.CargoID.idCargo);
                    cmd.Parameters.AddWithValue("@Jerarquia", us.Jerarquia);
                    cmd.Parameters.AddWithValue("@TurnoID", us.TurnoID.idTurno);
                    cmd.Parameters.AddWithValue("@Contrasena", us.Contraseña);
                    cmd.Parameters.AddWithValue("@Sueldo", us.Sueldo);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return us;
        }
        public Boolean EditarEstadoEmpleado(entEmpleado us)
        {
            SqlCommand cmd = null; Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spEditarEstadoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", us.idEmpleado);
                cmd.Parameters.AddWithValue("@Estado", us.Estado);

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


    }
}
