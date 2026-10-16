using Inventario_CAM;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class listar
    {

        Funciones.Utiles util = new Funciones.Utiles();
        ClassConectar.Conexion con=new ClassConectar.Conexion();

        public void listarinventario(capaidentidad.listar lit)
        {
            MySqlCommand cmd = new MySqlCommand("INSERTAALUMNO", con.ConexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public void insertarinventario(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                MySqlCommand cmd;
                cmd = new MySqlCommand("INSERTARINVENTARIO", con.ConexionBD());
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PTABLA", tabla);
                cmd.Parameters["?PTABLA"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PCANTIDAD", objInv.Cantidad);
                cmd.Parameters["?PCANTIDAD"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PNUMINVENTARIO", objInv.NumInventario);
                cmd.Parameters["?PNUMINVENTARIO"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PDESCRIPCION", objInv.Descripcion);
                cmd.Parameters["?PDESCRIPCION"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PMARCA", objInv.Marca);
                cmd.Parameters["?PMARCA"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PUBICACION", objInv.Ubicacion);
                cmd.Parameters["?PUBICACION"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PESTATUS", objInv.Estatus);
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;



                Int64 retval = (Int64)cmd.ExecuteNonQuery();

            }
            catch (Exception )
            {
                //MessageBox.Show("Error: " + ex.Message, "Error en btnGuardar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
