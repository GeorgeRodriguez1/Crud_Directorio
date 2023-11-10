using System;
using MySql.Data.MySqlClient;

/// <summary>Class <c>Conexion</c> to connect with MySQL db
/// </summary>
class Conexion
{
    /// <summary>
    /// Method <c>MySqlConnection</c> creates the MySQL connection object
    /// </summary>
    /// <returns>MySqlConnection object</returns>
    public static MySqlConnection conexion()
    {
        string servidor = "localhost";
        string bd = "directorio";
        string usuario = "root";
        string password = "root123";

        string cadenaConexion = "database=" + bd + ";server=" + servidor +
            ";user id=" + usuario + ";password=" + password;

        try
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            return conexionBD;
        }
        catch (MySqlException ex)
        { 
            Console.WriteLine("Error: "+ex.Message);
            return null; 
        }
    }

}


