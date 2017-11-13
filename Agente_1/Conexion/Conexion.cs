using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Agente_1
{
    public class Conexion
    {
        private static MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLCONX"].ConnectionString);

        private static MySqlConnection conectar()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return conexion;
        }

        private static void desconectar()
        {
            conexion.Close();
        }

        public static bool EjecutarOperacion(string sentencia)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(sentencia, conectar());

                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    desconectar();
                    return true;
                }

                desconectar();

                throw new Exception("No se realizó ninguna operación en la Base de Datos.");
            }
            catch (Exception)
            
            {
                throw new Exception("No se realizó ninguna operación de Registro en la Base de Datos.");
            }
        }

        public static DataTable EjecutarConsulta(string Select)
        
        {
            DataTable dt = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(Select);

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(Select, conectar());
                da.Fill(dt);
                desconectar();
                return dt;
            }
            catch
            {
                desconectar();
                throw new Exception("Sentencia SQL de consulta invalida.");

            }
        }
    }
}
