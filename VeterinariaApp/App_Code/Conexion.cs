using System;
using System.Data;
using System.Data.OleDb;
using System.Web;
using VeterinariaApp;

namespace mis_conexiones
{
    public class Conexiones
    {
        public String crear_string_conexion_access()
        {
            String obj_stringDeConexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" +
                                   HttpContext.Current.Server.MapPath(@"App_Data\veterinaria.mdb") + ";";
            return obj_stringDeConexion;
        }

        public DataTable LeeBBDDAccess(string tabla)
        {
            // String de conexiÃ³n, especifica la ruta del archivo
            string CadenaConexion = this.crear_string_conexion_access();

            // Se obtienen datos desde archivo de texto             
            string strSQL = "SELECT * FROM " + tabla;

            OleDbConnection conexion = new OleDbConnection(CadenaConexion);
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conexion);
            DataTable dt = new DataTable();

            try
            {
                conexion.Open();
                da.Fill(dt);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

        public DataTable obtenerUsuarioLogeado(string nombreUsuario)
        {
            // String de conexiÃ³n, especifica la ruta del archivo
            string CadenaConexion = this.crear_string_conexion_access();

            // Se obtienen datos desde archivo de texto             
            string strSQL = "SELECT * FROM usuario where usuario = '" + nombreUsuario+"'";
            strSQL = strSQL.Replace("$nombre", nombreUsuario);
            OleDbConnection conexion = new OleDbConnection(CadenaConexion);
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conexion);
            DataTable dt = new DataTable();

            try
            {
                conexion.Open();
                da.Fill(dt);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

        public string insertarMascota(Mascota mascota)
        {
            string CadenaConexion = this.crear_string_conexion_access();

            OleDbConnection connection = new OleDbConnection(CadenaConexion);
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            // Se obtienen datos desde archivo de texto             
            string strSQL = "INSERT INTO  mascota ([Nombre mascota], [Nombre propietario], [edad])";
            strSQL += "values ('" + mascota.Nombre + "', '" + mascota.Propietario + "', '" + mascota.Edad + "')";

            try
            {
                connection.Open();
                oledbAdapter.InsertCommand = connection.CreateCommand();
                oledbAdapter.InsertCommand.CommandText = strSQL;
                oledbAdapter.InsertCommand.ExecuteNonQuery();
                return "Se han registrado los datos";
            }
            catch (Exception e)
            {
                return "No se han podido registrar los datos: " + e.ToString();
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public class Data : Conexiones
    {
        
    }

    public class Persona : Conexiones
    {

        public DataTable getPersonas(ref string resultado, String id)
        {
            // String de conexión, especifica la ruta del archivo
            string CadenaConexion = this.crear_string_conexion_access();

            // Se obtienen datos desde archivo de texto
            string strSQL = null;
            if (id != null)
            {
                strSQL = "SELECT * FROM PERSONA where id_hotel = " + id;
            }
            else
            {
                strSQL = "SELECT * FROM PERSONA ";
            }

            OleDbConnection conexion = new OleDbConnection(CadenaConexion);
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conexion);
            DataTable dt = new DataTable();

            try
            {
                conexion.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }


        public String agregarPersona(string nombre)
        {
            // String de conexión, especifica la ruta del archivo
            string CadenaConexion = this.crear_string_conexion_access();

            OleDbConnection connection = new OleDbConnection(CadenaConexion);
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            // Se obtienen datos desde archivo de texto             
            string strSQL = "INSERT INTO  PERSONA(nombre)";
            strSQL += "values ('" + nombre + "')";

            try
            {
                connection.Open();
                oledbAdapter.InsertCommand = connection.CreateCommand();
                oledbAdapter.InsertCommand.CommandText = strSQL;
                oledbAdapter.InsertCommand.ExecuteNonQuery();
                return "Se han registrado los datos";
            }
            catch (Exception e)
            {
                return "No se han podido registrar los datos: " + e.ToString();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}