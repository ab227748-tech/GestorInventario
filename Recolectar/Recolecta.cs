using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Recolectar
{
    public class Recolecta
    {
        public void insertarinventario(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
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

                cmd.Parameters.AddWithValue("?PIDMAESTROCAM", objInv.Idmaestro);
                cmd.Parameters["?PIDMAESTROCAM"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception )
            {

            }
        }
        public void actualizarinventario(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("ACTUALIZARINVENTARIO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PID", objInv.Id);
                cmd.Parameters["?PID"].Direction = ParameterDirection.Input;

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

                cmd.Parameters.AddWithValue("?PESTATUS", "Activo");
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PIDMAESTROCAM", objInv.Idmaestro);
                cmd.Parameters["?PIDMAESTROCAM"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void actualizarinventariogrande(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("ACTUALIZARINVENTARIO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PID", objInv.Id);
                cmd.Parameters["?PID"].Direction = ParameterDirection.Input;

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

                cmd.Parameters.AddWithValue("?PESTATUS", "Activo");
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PIDMAESTROCAM", objInv.Idmaestro);
                cmd.Parameters["?PIDMAESTROCAM"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception )
            {

            }
        }
        public void eliminarinventario(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("ACTUALIZARINVENTARIO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PID", objInv.Id);
                cmd.Parameters["?PID"].Direction = ParameterDirection.Input;

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

                cmd.Parameters.AddWithValue("?PIDMAESTROCAM", objInv.Idmaestro);
                cmd.Parameters["?PIDMAESTROCAM"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();

            }
            catch (Exception )
            {

            }
        }
        //Agrega inactivos desde la tabla grande a tabla normal 
        public void insertarunidadeliminado(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("INVENTARIOCOMPUTO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PID", objInv.Id);
                cmd.Parameters["?PID"].Direction = ParameterDirection.Input;

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

                cmd.Parameters.AddWithValue("?PESTATUS", "Inactivo");
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PPIDMAESTROCAM", objInv.Idmaestro);
                cmd.Parameters["?PPIDMAESTROCAM"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void elimina(capaidentidad.insertar_actualizar objInv, string tabla)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("ELIMINA", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PTABLA", tabla);
                cmd.Parameters["?PTABLA"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PID", objInv.Id);
                cmd.Parameters["?PID"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void insertarmaestro(capaidentidad.insertar_actualizar objInv)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("INSERTARMAESTRO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PNOMBRES", objInv.Nombres);
                cmd.Parameters["?PNOMBRES"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PAPELLIDOS", objInv.Apellidos);
                cmd.Parameters["?PAPELLIDOS"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PESTATUS", objInv.Estatusm);
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void actualizarmaestro(capaidentidad.insertar_actualizar objInv)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("ACTUALIZARMAESTRO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PNOMBRES", objInv.Nombres);
                cmd.Parameters["?PNOMBRES"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PAPELLIDOS", objInv.Apellidos);
                cmd.Parameters["?PAPELLIDOS"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PESTATUS", objInv.Estatusm);
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
        //Editar maestro
        public void editarmaestro(capaidentidad.insertar_actualizar objInv)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("EDITARMAESTRO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PIDM", objInv.Idmaestro);
                cmd.Parameters["?PIDM"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PNOMBRES", objInv.Nombres);
                cmd.Parameters["?PNOMBRES"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PAPELLIDOS", objInv.Apellidos);
                cmd.Parameters["?PAPELLIDOS"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PESTATUS", objInv.Estatusm);
                cmd.Parameters["?PESTATUS"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void iniciarsesion(capaidentidad.insertar_actualizar objInv)
        {
            try
            {
                ClassConectar.Conexion con = new ClassConectar.Conexion();
                MySqlCommand cmd;
                cmd = new MySqlCommand("BUSCARUSUARIO", con.ConexionBD());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PUSUARIO", objInv.Usuario);
                cmd.Parameters["?PUSUARIO"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PCONTRASENIA", objInv.Contraseña);
                cmd.Parameters["?PCONTRASENIA"].Direction = ParameterDirection.Input;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                con.ConexionBD().Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
