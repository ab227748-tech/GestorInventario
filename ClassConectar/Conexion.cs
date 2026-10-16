using MySql.Data.MySqlClient;
using System;
using System.IO; // Necesario para leer archivos
using static System.Net.Mime.MediaTypeNames;

namespace ClassConectar
{
    public class Conexion
    {
        MySqlConnection conex = new MySqlConnection();

        // Variables estáticas para los datos de conexión
        public static string servidor = "";
        public static string bd = "";
        public static string usuario = "";
        public static string password = "";
        public static string puerto = "";

        // Método para cargar los datos desde el archivo .txt
        public void LeerDatos()
        {
            try
            {
                // Busca el archivo en la carpeta del ejecutable (bin/Debug)
                string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = Path.Combine(rutaBase, "datos.txt");

                if (File.Exists(ruta))
                {
                    string[] lineas = File.ReadAllLines(ruta);

                    // Asignación basada en el orden de tu imagen
                    if (lineas.Length >= 4)
                    {
                        servidor = lineas[0].Trim(); // localhost
                        bd = lineas[1].Trim();       // cam
                        usuario = lineas[2].Trim();  // root
                        puerto = lineas[3].Trim();   // 3306
                        // Si tuvieras contraseña en la línea 5:
                        // password = lineas[4].Trim(); 
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        public MySqlConnection ConexionBD()
        {
            try
            {
                LeerDatos();

                string cadenaConexion = "server=" + servidor +
                                        ";port=" + puerto +
                                        ";user id=" + usuario +
                                        ";password=" + password +
                                        ";database=" + bd + ";";
                if (conex.State == System.Data.ConnectionState.Open)
                {
                    conex.Close();
                }
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (MySqlException ex)
            {

            }
            return conex;
        }
    }
}
