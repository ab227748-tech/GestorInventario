using capaidentidad;
using ClassConectar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Inventario_CAM
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
            txtNumInventario.Leave += txtNumInventario_Leave;
            txtDescripcion.Leave += txtNumInventario_Leave;
            txtMarca.Leave += txtNumInventario_Leave;
            txtUbicacion.Leave += txtNumInventario_Leave;
        }
        //Parametros que se utilizan para guardar la informacion de la liminacion de forma local
        public string tablaf;
        public string tablagr;
        public int id;
        public string numinventario;
        public string descripcion;
        public string marca;
        public string ubicacion;
        public string idemaestro;
        public string estatus;

        public int cantidadG;
        public string numinventarioG;
        public string descripcionG;
        public string marcaG;
        public string ubicacionG;
        public string idemaestroG;
        public string estatusG;

        public int actualizar = 0;
        public int agregar = 0;
        public int cantidad = 0;
        public int conmaestro = 0;

        public int resultadoResta;
        int total = 0;
        int sumaCasoEspecial = 0;
        int contarUbicaciones = 0;

        capaidentidad.insertar_actualizar objIns = new capaidentidad.insertar_actualizar();
        Funciones.Utiles fun = new Funciones.Utiles();
        Recolectar.Recolecta rec = new Recolectar.Recolecta();

        private void Actualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                //Application.Exit();
            }
        }
        //Limpiar los componentes 
        public void VaciarDatos()
        {
            nudCantidad.Text = "1";
            txtNumInventario.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtUbicacion.Text = "";
            cbEstatus.SelectedIndex = 0;
            contarUbicaciones = 0;
            resultadoResta = 0;
            sumaCasoEspecial = 0;
        }
        private void Actualizar_Load(object sender, EventArgs e)
        {
            mostrarprofesor();
            if (conmaestro == 0)
            {
                cbEstatus.SelectedIndex = 0;
            }
            else
            {
                if (conmaestro == 1)
                {
                    CBXPROFESOR.Text = idemaestro;
                }
                else
                {
                    if (conmaestro == 2)
                    {
                        CBXPROFESOR.Text = idemaestroG;
                    }
                }
            }

            if (CBXPROFESOR.SelectedValue != null && CBXPROFESOR.SelectedValue is int)
            {
                objIns.Idmaestro = Convert.ToInt32(CBXPROFESOR.SelectedValue);
            }
            //Editar para el dgvNormal
            if (actualizar == 1)
            {
                nudCantidad.Enabled = false;
                btnActualizar.Enabled = true;
                btnActualizar.Visible = true;
                btnGuardar.Enabled = false;
                btnGuardar.Visible = false;
                nudCantidad.Minimum = 1;

                nudCantidad.Value = 1;

                txtNumInventario.Text = numinventario;
                txtDescripcion.Text = descripcion;
                txtMarca.Text = marca;
                txtUbicacion.Text = ubicacion;
                cbEstatus.Text = estatus;
            }
            //Editar para el dgvMayor
            else if (actualizar == 2)
            {
                nudCantidad.Enabled = true;
                btnActualizar.Enabled = true;
                btnActualizar.Visible = true;
                btnGuardar.Enabled = false;
                btnGuardar.Visible = false;
                nudCantidad.Minimum = 2;

                nudCantidad.Value = cantidadG;
                txtNumInventario.Text = numinventarioG;
                txtDescripcion.Text = descripcionG;
                txtMarca.Text = marcaG;
                txtUbicacion.Text = ubicacionG;
                cbEstatus.Text = estatusG;
            }
            //Eliminar Inactivos para el dgvNormal
            if (actualizar == 3)
            {
                btnActualizar.Enabled = true;
                btnActualizar.Visible = true;
                btnGuardar.Enabled = false;
                btnGuardar.Visible = false;
                nudCantidad.Minimum = 1;

                nudCantidad.Value = 1;
                cbEstatus.Text = "Inactivo";

                cbEstatus.Text = estatus;
            }
            //Agregar para el dgvNormal
            if (agregar == 1)
            {
                nudCantidad.Enabled = false;
                btnActualizar.Enabled = false;
                btnActualizar.Visible = false;
                btnGuardar.Enabled = true;
                btnGuardar.Visible = true;
                nudCantidad.Minimum = 1;

                nudCantidad.Text = "1";
                txtNumInventario.Text = "";
                txtDescripcion.Text = "";
                txtMarca.Text = "NC";
                txtUbicacion.Text = "COCINA";
                cbEstatus.SelectedIndex = 0;
                CBXPROFESOR.SelectedIndex = 11;  
            }
            //Agregar para el dgvMayor
            else if (agregar == 2)
            {
                nudCantidad.Enabled = true;
                btnActualizar.Enabled = false;
                btnActualizar.Visible = false;
                btnGuardar.Enabled = true;
                btnGuardar.Visible = true;
                nudCantidad.Minimum = 2;

                nudCantidad.Text = "2";
                txtNumInventario.Text = "";
                txtDescripcion.Text = "";
                txtMarca.Text = "NC";
                txtUbicacion.Text = "COCINA";
                cbEstatus.SelectedIndex = 0;
                CBXPROFESOR.SelectedIndex = 11;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciarDatos();
            agregar = 0;
            this.Close();
        }
        private void txtNumInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nudCantidad.Enabled == false)
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
                {
                    e.Handled = true;
                    return;
                }
                //Usando el espacio de nombres explícito para evitar la ambigüedad
                var txt = sender as System.Windows.Forms.TextBox;
                if (txt != null && (e.KeyChar == ' ' || e.KeyChar == ','))
                {
                    //Validar si es el primer carácter o si el anterior es espacio/coma
                    if (txt.SelectionStart == 0 || ", ".Contains(txt.Text[txt.SelectionStart - 1]))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }
            var txt = sender as System.Windows.Forms.TextBox;
            //Usando el espacio de nombres explícito para evitar la ambigüedad
            if (txt != null && (e.KeyChar == ' ' || e.KeyChar == ','))
            {
                //Validar si es el primer carácter o si el anterior es espacio/coma
                if (txt.SelectionStart == 0 || ", ".Contains(txt.Text[txt.SelectionStart - 1]))
                {
                    e.Handled = true;
                }
            }
        }
        private void txtNumInventario_Leave(object sender, EventArgs e)
        {
            var txt = sender as System.Windows.Forms.TextBox;
            //Mientras el último carácter NO sea letra ni número, lo borramos
            string final = txt.Text;
            while (final.Length > 0 && !char.IsLetterOrDigit(final[final.Length - 1]))
            {
                final = final.Substring(0, final.Length - 1);
            }
            txt.Text = final;
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as System.Windows.Forms.TextBox;
            if (txt == null) return;
            //Permitir siempre la tecla de borrar (Backspace)
            if (char.IsControl(e.KeyChar)) return;
            //Si el TextBox está vacío, el primer carácter DEBE ser letra o número
            if (txt.SelectionStart == 0)
            {
                if (!char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                //Si ya hay texto, revisamos el carácter anterior al cursor
                char anterior = txt.Text[txt.SelectionStart - 1];
                //Si el usuario intenta escribir algo que NO es letra ni número...
                if (!char.IsLetterOrDigit(e.KeyChar))
                {
                    //El anterior TAMPOCO era letra ni número, lo bloqueamos
                    if (!char.IsLetterOrDigit(anterior))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as System.Windows.Forms.TextBox;
            if (txt == null) return;
            //Permitir siempre la tecla de borrar (Backspace)
            if (char.IsControl(e.KeyChar)) return;
            //Si el TextBox está vacío, el primer carácter DEBE ser letra o número
            if (txt.SelectionStart == 0)
            {
                if (!char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                //Si ya hay texto, revisamos el carácter anterior al cursor
                char anterior = txt.Text[txt.SelectionStart - 1];
                //Si el usuario intenta escribir algo que NO es letra ni número
                if (!char.IsLetterOrDigit(e.KeyChar))
                {
                    //El anterior TAMPOCO era letra ni número, lo bloqueamos
                    if (!char.IsLetterOrDigit(anterior))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (fun.EsNulo(nudCantidad, txtNumInventario, txtDescripcion, txtMarca, txtUbicacion, cbEstatus))
            {
                MessageBox.Show("Llene todos los campos", "Sistema");
            }
            else
            {
                objIns.Cantidad = Convert.ToInt32(nudCantidad.Text);
                objIns.NumInventario = txtNumInventario.Text.Replace("A", "a");
                objIns.Descripcion = txtDescripcion.Text.ToUpper();
                objIns.Marca = txtMarca.Text.ToUpper();
                objIns.Ubicacion = txtUbicacion.Text.ToUpper();   
                objIns.Estatus = cbEstatus.Text;
                string cadena = txtNumInventario.Text.Replace("A", "a"); 
                total = Convert.ToInt32(nudCantidad.Text);

                string[] letras = txtUbicacion.Text.Split(',');
                contarUbicaciones = letras.Length;

                if (contarUbicaciones <= objIns.Cantidad)
                {
                    //Procesamos la cadena (Valida formatos de comas, rangos y únicos)
                    ProcesarRango(cadena);
                    //Validación de consistencia: ¿Lo que escribió coincide con la cantidad?
                    if (total == sumaCasoEspecial)
                    {
                        if (agregar == 1)
                        {
                            //Guardar en dgvNormal
                            rec.insertarinventario(objIns, tablaf);
                        }
                        else if (agregar == 2)
                        {
                            //Guardar en dgvMayor
                            rec.insertarinventario(objIns, tablagr);
                        }
                        //Finalización exitosa
                        VaciarDatos();
                        this.Close();
                    }
                    else
                    {
                        //Si no coincide, avisamos al usuario
                        MessageBox.Show($"La cantidad ({total}) no coincide con el total de inventarios detectados ({sumaCasoEspecial})", "Sistema");
                    }
                }
                else
                {
                    MessageBox.Show($"La cantidad de número de inventario ({total}) no coincide con el número de ubicaciones ({contarUbicaciones})", "Sistema");
                    contarUbicaciones = 0;
                }
            }
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (fun.EsNulo(nudCantidad, txtNumInventario, txtDescripcion, txtMarca, txtUbicacion, cbEstatus))
            {
                MessageBox.Show("Llene todos los campos", "Sistema");
            }
            else
            {
                String cadena = txtNumInventario.Text.Replace("A", "a");
                total = Convert.ToInt32(nudCantidad.Text);
                objIns.Id = id;
                objIns.Cantidad = Convert.ToInt32(nudCantidad.Text);
                objIns.NumInventario = txtNumInventario.Text.Replace("A", "a"); ;
                objIns.Descripcion = txtDescripcion.Text.ToUpper();
                objIns.Marca = txtMarca.Text.ToUpper();
                objIns.Ubicacion = txtUbicacion.Text.ToUpper();
                //objIns.Ubicacion = "METODOLOGÍAS Y PSICOLOGÍA";
                objIns.Estatus = cbEstatus.Text;
                agregar = 0;
                ProcesarRango(cadena);
                string[] letras = txtUbicacion.Text.Split(',');
                foreach (string str in letras)
                {
                    contarUbicaciones++;
                }
                if (contarUbicaciones <= objIns.Cantidad)
                {
                    //Validación de Cantidad vs. Items detectados
                    if (total == sumaCasoEspecial)
                    {
                        if (actualizar == 1)
                        {
                            //Actualización para tabla normal
                            rec.actualizarinventario(objIns, tablaf);
                        }
                        else if (actualizar == 2)
                        {
                            //Actualización para tabla grande
                            rec.actualizarinventariogrande(objIns, tablagr);
                        }
                        //Limpieza y cierre si fue exitoso
                        CBXPROFESOR.Text = "";
                        VaciarDatos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"La cantidad ({total}) no coincide con el total de inventarios detectados ({sumaCasoEspecial}).", "Sistema");
                    }
                }
                else
                {
                    MessageBox.Show($"La cantidad de número de inventario ({total}) no coincide con el número de ubicaciones ({contarUbicaciones})", "Sistema");
                    contarUbicaciones = 0;
                }
            }
        }
        public void ProcesarRango(string entrada)
        {
            try
            {
                //Reiniciamos contadores (asumiendo que son variables globales/de clase)
                sumaCasoEspecial = 0;
                Regex regex = new Regex(@"^(.*?)(\d{4,})$"); // Asegura al menos 4 dígitos al final

                // 1. Separamos por comas para obtener cada "bloque"
                string[] bloques = entrada.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string bloqueRaw in bloques)
                {
                    string bloque = bloqueRaw.Trim();
                    if (string.IsNullOrEmpty(bloque)) continue;

                    // CASO A: Es un rango (ej: "S001 a S010")
                    if (bloque.Contains(" a "))
                    {
                        string[] partes = bloque.Split(new[] { " a " }, StringSplitOptions.RemoveEmptyEntries);
                        if (partes.Length != 2) continue;

                        Match m1 = regex.Match(partes[0].Trim());
                        Match m2 = regex.Match(partes[1].Trim());

                        if (m1.Success && m2.Success)
                        {
                            // Validar que los prefijos sean iguales
                            if (m1.Groups[1].Value != m2.Groups[1].Value)
                            {
                                MessageBox.Show($"Los prefijos no coinciden en el rango: {bloque}");
                                continue;
                            }

                            // Extraer los últimos 4 dígitos y convertir a int
                            int inicio = int.Parse(m1.Groups[2].Value.Substring(m1.Groups[2].Value.Length - 4));
                            int fin = int.Parse(m2.Groups[2].Value.Substring(m2.Groups[2].Value.Length - 4));

                            sumaCasoEspecial += (fin - inicio) + 1;
                        }
                    }
                    // CASO B: Es un valor individual (ej: "S001")
                    else
                    {
                        Match m = regex.Match(bloque);
                        if (m.Success)
                        {
                            // Solo validamos que tenga la estructura, sumamos 1 al total
                            sumaCasoEspecial += 1;
                        }
                        else
                        {
                            MessageBox.Show($"El formato del elemento '{bloque}' no es válido (debe terminar en 4 números).");
                        }
                    }
                }
                // Al final, resultadoResta o lo que necesites mostrar
                resultadoResta = sumaCasoEspecial;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXPROFESOR.SelectedValue != null && CBXPROFESOR.SelectedValue is int)
            {
                objIns.Idmaestro = Convert.ToInt32(CBXPROFESOR.SelectedValue);
            }
        }
        public void mostrarprofesor()
        {
            try
            {
                ClassConectar.Conexion cone = new ClassConectar.Conexion();

                MySqlCommand cmd = new MySqlCommand("MOSTRARMAESTROS", cone.ConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CBXPROFESOR.DataSource = dt;
                CBXPROFESOR.DisplayMember = "NombreCompleto";    //Lo que se muestra
                CBXPROFESOR.ValueMember = "idmaestrocam";   //Lo que se guarda internamente


            }
            catch (Exception)
            {
                MessageBox.Show("No hay nigun profesor registrado en el sistema porfavor agregue uno ");
            }
        }
        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
