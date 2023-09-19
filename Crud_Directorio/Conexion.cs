using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

class Conexion
{
    public static MySqlConnection conexion()
    {
        string servidor = "localhost";
        string bd = "directorio";
        string usuario = "root";
        //string password = "";
        //+ "+ Passoword=''" + password + ""

        string cadenaConexion = "Database=" + bd + "; " + "; DataSource=" +
            servidor + "; User Id=" + usuario;

        try
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            return conexionBD;
        }
        catch (MySqlException ex)
        { 
           Console.WriteLine("Error: "+ex.Message);
            return null; }
    }

}


