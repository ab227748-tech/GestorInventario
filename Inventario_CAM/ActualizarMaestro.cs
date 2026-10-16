using Org.BouncyCastle.Ocsp;
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
    public partial class ActualizarMaestro : Form
    {
        public ActualizarMaestro()
        {
            InitializeComponent();
        }
        Funciones.Utiles util = new Funciones.Utiles();
        ClassConectar.Conexion con = new ClassConectar.Conexion();
        capaidentidad.insertar_actualizar objIns = new capaidentidad.insertar_actualizar();
        Funciones.Utiles fun = new Funciones.Utiles();
        Recolectar.Recolecta rec = new Recolectar.Recolecta();

        public int aa = 0;
        public int idm = 0;
        public string nombresm;
        public string apellidosm;
        public string estatusm;
        public void VaciarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (fun.EsNulo(txtNombre, txtApellido))
            {
                MessageBox.Show("Llene todos los campos", "Sistema");
            }
            else
            {
                objIns.Nombres = txtNombre.Text.ToUpper();
                objIns.Apellidos = txtApellido.Text.ToUpper();
                objIns.Estatusm = cbEstatus.Text;
                rec.insertarmaestro(objIns);
                VaciarDatos();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarMaestro_Load(object sender, EventArgs e)
        {
            cbEstatus.SelectedIndex = 0;
            if (aa == 1)
            {
                VaciarDatos();
                btnActualizar.Enabled = false;
                btnActualizar.Visible = false;
                btnGuardar.Enabled = true;
                btnGuardar.Visible = true;
            }
            else if (aa == 2)
            {
                btnActualizar.Enabled= true;
                btnActualizar.Visible = true;
                btnGuardar.Enabled= false;
                btnGuardar.Visible = false;
                txtNombre.Text = nombresm;
                txtApellido.Text = apellidosm;
                cbEstatus.Text = estatusm;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (fun.EsNulo(txtNombre,txtApellido,cbEstatus))
            {
                MessageBox.Show("Llene todos los campos", "Sistema");
            }
            else
            {
                objIns.Idmaestro = idm;
                objIns.Nombres = txtNombre.Text.ToUpper();
                objIns.Apellidos = txtApellido.Text.ToUpper();
                objIns.Estatusm = cbEstatus.Text;
                rec.editarmaestro(objIns);
                aa = 0;
                VaciarDatos();
                this.Close();
            }
        }
    }
}
