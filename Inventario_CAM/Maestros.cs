using iTextSharp.xmp.impl;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario_CAM
{
    public partial class Maestros : Form
    {
        public Maestros()
        {
            InitializeComponent();
        }
        Funciones.Utiles util = new Funciones.Utiles();
        ClassConectar.Conexion con = new ClassConectar.Conexion();
        capaidentidad.insertar_actualizar objIns = new capaidentidad.insertar_actualizar();
        Funciones.Utiles fun = new Funciones.Utiles();
        Recolectar.Recolecta rec = new Recolectar.Recolecta();
        ActualizarMaestro ma = new ActualizarMaestro();

        int idmaestro = 0;
        private void Maestros_Load(object sender, EventArgs e)
        {
            verinventario(dgvMaestros);
            CargaDGV();
        }
        public void verinventario(DataGridView inventario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("ACTUALIZARMAESTRO", con.ConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inventario.DataSource = dt;

                inventario.Columns["estatus"].HeaderText = "Estatus";
                inventario.Columns["NombreCompleto"].HeaderText = "Nombre Completo";

                inventario.Columns["idmaestrocam"].Visible = false;//ID maestro
                inventario.Columns["nombres"].Visible = false;
                inventario.Columns["apellidos"].Visible = false;
                inventario.Columns[3].Width = 400;
            }
            catch (Exception)
            {

            }
        }
        public void vermaestroseliminados(DataGridView inventario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("MAESTROSELIMINADOS", con.ConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inventario.DataSource = dt;

                inventario.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
                inventario.Columns["estatus"].HeaderText = "Estatus";

                inventario.Columns[0].Width = 400;
            }
            catch (Exception)
            {

            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ma.aa = 2;//Actualizar maestro
            ma.idm = idmaestro;
            ma.ShowDialog();
            verinventario(dgvMaestros);
            CargaDGV();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ma.aa = 1;//Agregar nuevo maestro
            ma.ShowDialog();
            verinventario(dgvMaestros);
            CargaDGV();
        }
        private void dgvMaestros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblbtnMaestrosInactivos.Text == "Ver maestros inactivos")
            {
                idmaestro = Convert.ToInt32(dgvMaestros.CurrentRow.Cells["idmaestrocam"].Value.ToString());
                ma.nombresm = dgvMaestros.CurrentRow.Cells["nombres"].Value.ToString();
                ma.apellidosm = dgvMaestros.CurrentRow.Cells["apellidos"].Value.ToString();
                ma.estatusm = dgvMaestros.CurrentRow.Cells["estatus"].Value.ToString();
                ma.idm = idmaestro;
            }
        }
        private void dgvMaestros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CargaDGV()
        {
            if (dgvMaestros.Rows.Count > 0)
            {
                dgvMaestros.CurrentCell = dgvMaestros.Rows[0].Cells[4];
                dgvMaestros_CellClick(dgvMaestros, new DataGridViewCellEventArgs(0, 0));
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = con.ConexionBD())
            {
                using (MySqlCommand cmd = new MySqlCommand("ELIMINAMAESTRO", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PIDMAESTROCAM", idmaestro);
                    try
                    {
                        if (conexion.State != ConnectionState.Open) conexion.Open();
                        object existe = cmd.ExecuteScalar();

                        if (existe != null)
                        {
                            MessageBox.Show("No se puede eliminar porque el maestro tiene activos registrados en el inventario");
                        }
                        else
                        {
                            objIns.Idmaestro = idmaestro;
                            objIns.Nombres = dgvMaestros.CurrentRow.Cells[1].Value.ToString();
                            objIns.Apellidos = dgvMaestros.CurrentRow.Cells[2].Value.ToString();
                            objIns.Estatusm = "Inactivo";

                            rec.editarmaestro(objIns);
                            verinventario(dgvMaestros);
                            CargaDGV();
                        }
                        existe = 0;
                        if (conexion.State == ConnectionState.Open) conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al validar: " + ex.Message);
                    }
                }
            }
        }
        private void lblbtnMaestrosInactivos_Click(object sender, EventArgs e)
        {
            dgvMaestros.DataSource = null;
            if (lblbtnMaestrosInactivos.Text == "Ver maestros inactivos")
            {
                lblbtnMaestrosInactivos.Text = "Ver maestros activos";
                lblTitulo.Text = "Maestros Inactivos";
                vermaestroseliminados(dgvMaestros);
                btnIA(false);
            }
            else
            {
                lblbtnMaestrosInactivos.Text = "Ver maestros inactivos";
                lblTitulo.Text = "Maestros Activos";
                verinventario(dgvMaestros);
                btnIA(true);
            }
        }
        public void btnIA(bool IA)
        {
            btnAgregar.Visible = IA;
            btnActualizar.Visible = IA;
            btnEliminar.Visible = IA;
            btnAgregar.Enabled = IA;
            btnActualizar.Enabled = IA;
            btnEliminar.Enabled = IA;
        }
    }
}
