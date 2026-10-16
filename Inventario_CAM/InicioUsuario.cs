using ClassConectar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_CAM
{
    public partial class InicioUsuario : Form
    {
        public InicioUsuario()
        {
            InitializeComponent();
        }


        int strActivo = 0;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Length <= 0)
                {
                    MessageBox.Show("Falta ingresar el usuario");
                    txtUsuario.Focus();
                    return;
                }
                else if (txtContraseña.Text.Length <= 0)
                {
                    MessageBox.Show("Falta ingresar la contraseña");
                    txtContraseña.Focus();
                    return;
                }

                Conexion con = new Conexion();

                MySqlCommand cmd = new MySqlCommand("BUSCARUSUARIO", con.ConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("?PUSUARIO", txtUsuario.Text);
                cmd.Parameters["?PUSUARIO"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?PCONTRASENIA", txtContraseña.Text);
                cmd.Parameters["?PCONTRASENIA"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add(new MySqlParameter("?PNOMBRE", MySqlDbType.String));
                cmd.Parameters["?PNOMBRE"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add(new MySqlParameter("?PACTIVO", MySqlDbType.Int32));
                cmd.Parameters["?PACTIVO"].Direction = ParameterDirection.Output;

                Int64 retval = (Int64)cmd.ExecuteNonQuery();
                string strNombre = cmd.Parameters["?PNOMBRE"].Value.ToString();
                if (strNombre == "")
                {

                }
                else
                {
                    strActivo = int.Parse(cmd.Parameters["?PACTIVO"].Value.ToString());
                }
                if (strNombre.Length > 0 && strActivo == 1)
                {
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error en btnAceptar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicioUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnEntrar.PerformClick();
            }
        }
    }
}
