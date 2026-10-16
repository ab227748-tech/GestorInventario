using Funciones;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Inventario_CAM
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        //Parametros que se utilizan para guardar la informacion de la liminacion de forma local
        public int eliminar = 0;
        public int primercantidad = 0;//Cantidad total
        public int segundacantidad = 0;//Cantidad a eliminar
        public int cantidadrestante = 0;
        public int idG = 0;
        public string tabla;
        public string tablagr;
        public string numinventarioG;
        public string descripcionG;
        public string marcaG;
        public string ubicacionG;
        public int conmaestro = 0;
        public string idemaestro;
        public string idemaestroG;

        string edesc = "";
        string emar = "";

        //Variables para obtener el número de inventario
        string numiActual = "";
        string numiO = "";
        //Variables para otener la ubicación
        string ubiActual = "";
        string ubiO = "";
        string ubires = "";
        capaidentidad.insertar_actualizar objIns = new capaidentidad.insertar_actualizar();
        Recolectar.Recolecta rec = new Recolectar.Recolecta();
        string textoubi = "";

        string inventarioActual = "";
        string textoIngresado = "";//"31DML2019K0169"
        int contarUbicaciones = 0;

        private void Eliminar_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Tab && e.Control)
            {
                Application.Exit();
            }*/
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnEliminar.PerformClick();
            }
            if (e.KeyCode == Keys.MediaStop)
            {
                e.Handled = true;
                btnCancelar.PerformClick();
            }
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            limpiardatos();
            //Cargar los componentes con las  celdas de cada registro
            nudCantidad.Value = 1;
            nudCantidad.Enabled = false;
            if (eliminar == 1)
            {
                txtNumInventario.Text = numinventarioG;
                lblDescripcion.Text = descripcionG;
                lblMarca.Text = marcaG;
                //Dividimos la cadena por comas y eliminamos espacios en blanco extra
                string[] listaUbicaciones = ubicacionG.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in listaUbicaciones)
                {
                    //Agregamos cada oración a la lista del ComboBox limpiando espacios al inicio/final
                    comboUbicacion.Items.Add(item.Trim());
                }
                if (comboUbicacion.Items.Count > 0)
                {
                    comboUbicacion.SelectedIndex = 0;
                    if (comboUbicacion.Items.Count == 1)
                    {
                        checkUbicacion.Visible = false;
                        checkUbicacion.Enabled = false;
                    }
                    else
                    {
                        checkUbicacion.Visible = true;
                        checkUbicacion.Enabled = true;
                    }
                }
                edesc = descripcionG;
                emar = marcaG;
            }
            textoubi = ubicacionG;
            //Valida para que sólo quede una ubicación si queda solo una unidad
            //if (primercantidad == 2)
            if (comboUbicacion.Items.Count >= primercantidad)
            {
                checkUbicacion.Checked = true;
                checkUbicacion.Enabled = false;
            }
            else
            {
                checkUbicacion.Checked = false;
            }

            mostrarprofesor();
            if (conmaestro == 0)
            {
                //cbEstatus.SelectedIndex = 0;
            }
            else
            {
                if (conmaestro == 1)
                {
                    CBXPROFESOR.Text= idemaestro;
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
        }
        public void limpiardatos()
        {
            nudCantidad.Value = default;
            txtNumInventario.Text = "";
            lblDescripcion.Text = "";
            lblMarca.Text = "";
            numiO = "";
            numiActual = "";
            comboUbicacion.Items.Clear();

            ubiO = "";
            ubiActual = "";
            ubires = "";
            btnEliminar.Enabled = true;
            btnEliminar.Visible = true;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiardatos();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            limpiardatos();
            this.Close();
        }

        private void txtNumInventario_TextChanged(object sender, EventArgs e)
        {
            numiO = txtNumInventario.Text;
        }
        private void txtNumInventario_Enter(object sender, EventArgs e)
        {
            numiO = txtNumInventario.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //1. OBTENCIÓN DE VALORES Y CÁLCULOS
            segundacantidad = Convert.ToInt32(nudCantidad.Value); // Cantidad a eliminar
            cantidadrestante = primercantidad - segundacantidad;
            //contarUbicaciones = comboUbicacion.Items.Count;

            numiActual = txtNumInventario.Text; // Código individual que se está eliminando
            ubiActual = comboUbicacion.Text;    // Ubicación seleccionada para eliminar

            
            // 4. PROCESO DE ACTUALIZACIÓN DE INVENTARIO
            //Usamos ubiO para guardar el estado final de las ubicaciones
            ubiO = ubicacionG;//ubicacion que se mantendra
            numiO = numinventarioG;
            inventarioActual = numiO;
            textoIngresado = numiActual;

            //Comprobar si el código de inventario existe en la cadena larga
            bool existe = InventarioHelper.ComprobarExistencia(inventarioActual, textoIngresado);
            if (existe)
            {
                // 2. PROCESO DE ELIMINACIÓN DE UBICACIÓN (Si el checkbox está marcado)
                if (checkUbicacion.Checked && !string.IsNullOrEmpty(ubiActual))
                {
                    if (comboUbicacion.SelectedIndex == comboUbicacion.Items.Count - 1)
                    {
                        //Si es el último, eliminamos la coma previa
                        ubires = Regex.Replace(ubicacionG, "," + ubiActual, "", RegexOptions.IgnoreCase).Trim();
                    }
                    else
                    {
                        //Si no es el último, eliminamos la coma posterior
                        ubires = Regex.Replace(ubicacionG, ubiActual + ",", "", RegexOptions.IgnoreCase).Trim();
                    }
                    //Actualizamos la variable global de ubicaciones con el nuevo string
                    ubicacionG = ubires;

                    //Refrescar el ComboBox para mostrar las ubicaciones que quedaron
                    comboUbicacion.Items.Clear();
                    string[] listaUbicaciones = ubicacionG.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string item in listaUbicaciones)
                    {
                        comboUbicacion.Items.Add(item.Trim());
                    }
                    if (comboUbicacion.Items.Count > 0) comboUbicacion.SelectedIndex = 0;
                    //contarUbicaciones = comboUbicacion.Items.Count;
                }
                //Si quedan 3 productos, no puede haber 4 ubicaciones.
                if (contarUbicaciones > cantidadrestante)
                {
                    MessageBox.Show($"Error: Quedarán {cantidadrestante} unidades, pero hay {contarUbicaciones} ubicaciones asignadas. " +
                                    "Debe eliminar una ubicación antes de proceder.", "Validación de Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //contarUbicaciones = 0;
                    return;
                }
                else
                {

                }

                string nuevoInventario = InventarioHelper.EliminarCodigo(inventarioActual, textoIngresado);
                if (cantidadrestante == 1)
                {
                    objIns.Cantidad = Convert.ToInt32(cantidadrestante);
                    objIns.NumInventario = nuevoInventario;
                    objIns.Descripcion = Convert.ToString(edesc);
                    objIns.Marca = Convert.ToString(emar);
                    objIns.Ubicacion = ubicacionG;////ubiO
                    objIns.Estatus = "Activo";
                    rec.insertarinventario(objIns, tabla);
                    if (segundacantidad == 1)
                    {
                        RegistrarInactivo(numiActual, ubiActual);
                    }
                    objIns.Id = idG;
                    rec.elimina(objIns, tablagr);
                    MessageBox.Show("Elemento eliminado, el último elemento se ha movido al inventario individual.");
                    this.Close();
                }
                else if (cantidadrestante > 1)
                {
                    //CASO: Siguen quedando varios elementos (Actualizar tabla grande)
                    objIns.Id = idG;
                    objIns.Cantidad = Convert.ToInt32(cantidadrestante);
                    objIns.NumInventario = nuevoInventario;
                    objIns.Descripcion = Convert.ToString(edesc);
                    objIns.Marca = Convert.ToString(emar);
                    objIns.Ubicacion = ubicacionG;//////ubiO
                    rec.actualizarinventariogrande(objIns, tablagr);

                    if (segundacantidad == 1)
                    {
                        RegistrarInactivo(numiActual, ubiActual);
                    }
                    MessageBox.Show("Elemento eliminado");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"No se encontró el número de inventario {textoIngresado} entre los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //contarUbicaciones = 0;
            }
        }
        // Método auxiliar para no repetir código de inserción inactiva
        private void RegistrarInactivo(string numInv, string ubi)
        {
            objIns.Cantidad = 1;
            objIns.NumInventario = numInv;
            objIns.Ubicacion = ubi;
            objIns.Descripcion = lblDescripcion.Text;
            objIns.Marca = lblMarca.Text;
            objIns.Estatus = "Inactivo";
            rec.insertarinventario(objIns, tabla);
        }
        private void txtNumInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void txtNumInventario_Leave(object sender, EventArgs e)
        {
            var txt = sender as System.Windows.Forms.TextBox;
            // Mientras el último carácter NO sea letra ni número, lo borramos
            string final = txt.Text;
            while (final.Length > 0 && !char.IsLetterOrDigit(final[final.Length - 1]))
            {
                final = final.Substring(0, final.Length - 1);
            }
            txt.Text = final;
        }
        private void checkUbicacion_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class InventarioHelper
    {

        public static bool ComprobarExistencia(string cadenaRegistrada, string codigoABuscar)
        {
            //Dividimos la cadena por comas para obtener los grupos
            string[] grupos = cadenaRegistrada.Split(',');

            //Expresión regular para separar el texto del número final
            //Ejemplo: "31DML2019K0" (Grupo 1) y "169" (Grupo 2)
            Regex regex = new Regex(@"^(.*?)(\d+)$");
            Match matchBuscar = regex.Match(codigoABuscar.Trim());

            if (!matchBuscar.Success) return false;

            string prefijoBuscar = matchBuscar.Groups[1].Value;
            int numBuscar = int.Parse(matchBuscar.Groups[2].Value);

            foreach (var grupo in grupos)
            {
                string elemento = grupo.Trim();

                //CASO A: Es un Rango (contiene " a ")
                if (elemento.Contains(" a ") || elemento.Contains(",") || elemento.Contains(" "))
                {
                    //Definimos todos los posibles separadores
                    string[] separadores = new string[] { " a ", ",", " " };

                    // Split eliminando entradas vacías (por si hay doble espacio o espacio tras coma)
                    string[] limites = elemento.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

                    // Verificamos que al menos tengamos un inicio y un fin
                    if (limites.Length >= 2)
                    {
                        Match matchInicio = regex.Match(limites[0].Trim());
                        Match matchFin = regex.Match(limites[1].Trim());

                        if (matchInicio.Success && matchFin.Success)
                        {
                            if (matchInicio.Groups[1].Value == prefijoBuscar && matchFin.Groups[1].Value == prefijoBuscar)
                            {
                                int numInicio = int.Parse(matchInicio.Groups[2].Value);
                                int numFin = int.Parse(matchFin.Groups[2].Value);

                                if (numBuscar >= numInicio && numBuscar <= numFin)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                //CASO B: Es un elemento individual
                else
                {
                    if (elemento == codigoABuscar.Trim())
                    {
                        return true;// ¡Se encontró coincidencia exacta!
                    }
                }
            }
            return false; // No se encontró en ningún lado
        }
        public static string EliminarCodigo(string cadenaRegistrada, string codigoAEliminar)
        {
            // 1. Limpiamos y preparamos las listas
            string[] grupos = cadenaRegistrada.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> nuevosGrupos = new List<string>();

            // 2. Extraer prefijo y número del código que queremos eliminar
            // Ej: "31DML2019K0166" -> Prefijo: "31DML2019K", Número: "0166"
            Regex regex = new Regex(@"^(.*?)(\d+)$");
            Match matchEliminar = regex.Match(codigoAEliminar.Trim());

            if (!matchEliminar.Success) return cadenaRegistrada; //Si el formato no es válido, devolvemos la cadena intacta

            string prefijo = matchEliminar.Groups[1].Value;
            string numStr = matchEliminar.Groups[2].Value;
            int numEliminar = int.Parse(numStr);
            int cerosPadding = numStr.Length; //Importantísimo para no perder los ceros a la izquierda (ej. "0166")

            //3. Recorrer los grupos existentes
            foreach (var grupoRaw in grupos)
            {
                string grupo = grupoRaw.Trim();

                //CASO A: Es un rango (" a ")
                if (grupo.Contains(" a ") || grupo.Contains(",") || grupo.Contains(" "))
                {
                    //Definimos todos los posibles separadores
                    string[] limites = grupo.Split(new string[] { " a ", ",", " " }, StringSplitOptions.None);
                    Match matchInicio = regex.Match(limites[0].Trim());
                    Match matchFin = regex.Match(limites[1].Trim());

                    if (matchInicio.Groups[1].Value == prefijo && matchFin.Groups[1].Value == prefijo)
                    {
                        int numInicio = int.Parse(matchInicio.Groups[2].Value);
                        int numFin = int.Parse(matchFin.Groups[2].Value);

                        // Si el número a eliminar ESTÁ en este rango, lo reestructuramos
                        if (numEliminar >= numInicio && numEliminar <= numFin)
                        {
                            if (numEliminar == numInicio && numInicio < numFin)
                            {
                                // Escenario 2: Estaba al inicio. Acortamos por abajo.
                                nuevosGrupos.Add(FormatearGrupo(prefijo, numInicio + 1, numFin, cerosPadding));
                            }
                            else if (numEliminar == numFin && numInicio < numFin)
                            {
                                // Escenario 3: Estaba al final. Acortamos por arriba.
                                nuevosGrupos.Add(FormatearGrupo(prefijo, numInicio, numFin - 1, cerosPadding));
                            }
                            else if (numInicio < numEliminar && numEliminar < numFin)
                            {
                                // Escenario 4: Estaba en el medio. Rompemos en dos rangos.
                                nuevosGrupos.Add(FormatearGrupo(prefijo, numInicio, numEliminar - 1, cerosPadding));
                                nuevosGrupos.Add(FormatearGrupo(prefijo, numEliminar + 1, numFin, cerosPadding));
                            }
                            // Si numInicio == numFin == numEliminar, simplemente no lo agregamos (desaparece)
                            continue;
                        }
                    }
                }
                //CASO B: Es un elemento individual
                else
                {
                    //Escenario 1: Si es exactamente el que buscamos, lo ignoramos para que se elimine
                    if (grupo == codigoAEliminar.Trim())
                    {
                        continue;
                    }
                }
                //Si llegamos aquí, significa que este grupo no fue afectado. Lo conservamos igual.
                nuevosGrupos.Add(grupo);
            }

            // 4.Unimos los nuevos grupos con comas y saltos de línea (como en tu ejemplo original)
            return string.Join(",\n", nuevosGrupos);
        }
        //Función auxiliar: Crea el texto correcto (ya sea "A a B" o solo "A" si el rango quedó de 1 solo elemento)
        private static string FormatearGrupo(string prefijo, int inicio, int fin, int padding)
        {
            string strInicio = prefijo + inicio.ToString("D" + padding);
            if (inicio == fin)
            {
                return strInicio; //El rango se redujo a un elemento individual
            }
            else
            {
                string strFin = prefijo + fin.ToString("D" + padding);
                return $"{strInicio} a {strFin}";
            }
        }
    }
}
