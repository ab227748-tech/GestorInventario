using iTextSharp.text; // Librería iTextSharp
using iTextSharp.text.pdf; // Librería iTextSharp PDF
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario_CAM
{
    public partial class Form1 : Form
    {
        Funciones.Utiles util = new Funciones.Utiles();
        public Form1()
        {
            InitializeComponent();
            DeshabilitaBuscar();
        }
        public string tabla;
        public string tablagrande;
        public int idSeleccionado = 0;
        public int idseleccioonadoG = 0;
        int posseccion = 0;

        ClassConectar.Conexion con = new ClassConectar.Conexion();
        Actualizar actu = new Actualizar();
        capaidentidad.insertar_actualizar objIns = new capaidentidad.insertar_actualizar();
        Recolectar.Recolecta rec = new Recolectar.Recolecta();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private bool IsKeyDown(Keys key)
        {
            return (GetAsyncKeyState((int)key) & 0x8000) != 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga el cbSeccion y los datagridviews
            cbSeccion.SelectedIndex = 0;
            CargaDGV();
        }
        //Carga y selecciona el primer registro del datagridview
        public void CargaDGV()
        {
            if (dgvInventarioNormal.Rows.Count > 0)
            {
                dgvInventarioNormal.CurrentCell = dgvInventarioNormal.Rows[0].Cells[1];
                dgvInventarioNormal_CellClick(dgvInventarioNormal, new DataGridViewCellEventArgs(0, 0));
            }
            if (dgvInventarioMayor.Rows.Count > 0)
            {
                dgvInventarioMayor.CurrentCell = dgvInventarioMayor.Rows[0].Cells[1];
                dgvInventarioMayor_CellClick(dgvInventarioMayor, new DataGridViewCellEventArgs(0, 0));
            }
        }
        public void CargarMaestro()
        {
            if (CBMPROFESOR.SelectedValue != null && CBMPROFESOR.SelectedValue is int)
            {
                int Idmaestro = Convert.ToInt32(CBMPROFESOR.SelectedValue);
                verfiltromaestro(dgvInventarioNormal, tabla, Idmaestro);
                verfiltromaestro(dgvInventarioMayor, tablagrande, Idmaestro);
                ChecaRegistros();
            }
        }
        //Habilita grupo para filtrar
        public void HabilitaBuscar()
        {
            btnBuscar.Enabled = true;
            lblBuscar.Enabled = true;
            txtBuscar.Enabled = true;
            btnBuscar.Visible = true;
            lblBuscar.Visible = true;
            txtBuscar.Visible = true;
            btnFiltrarMaestro.Visible = true;
            CBMPROFESOR.Visible = true;
        }
        //Deshabilita grupo para filtrar
        public void DeshabilitaBuscar()
        {
            btnBuscar.Enabled = false;
            lblBuscar.Enabled = false;
            txtBuscar.Enabled = false;
            btnBuscar.Visible = false;
            lblBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnFiltrarMaestro.Visible = false;
            CBMPROFESOR.Visible = false;
            txtBuscar.Text = "";
        }
        //Funciones de teclado para acciones rapidas
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                Application.Exit();
            }
        }
        //Listar los registros en las tablas de la DB
        public void verinventario(DataGridView inventario, string tabla)
        {
            if (util.EsNulo(cbSeccion) == false)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("MOSTRARINVENTARIO", con.ConexionBD());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("PTABLA", tabla);
                    cmd.Parameters["PTABLA"].Direction = ParameterDirection.Input;

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    inventario.DataSource = dt;

                    inventario.Columns["cantidad"].HeaderText = "Cantidad";
                    inventario.Columns["numinventario"].HeaderText = "Número de inventario";
                    inventario.Columns["descripcion"].HeaderText = "Descripción";
                    inventario.Columns["marca"].HeaderText = "Marca";
                    inventario.Columns["ubicacion"].HeaderText = "Ubicación";
                    inventario.Columns["estatus"].HeaderText = "Estatus";


                    if (tabla == "inventariocomputo" || tabla == "inventariograndecomputo")
                    {
                        if (inventario.Columns.Contains("idinventariocomputo") || inventario.Columns.Contains("idinventariograndecomputo"))
                        {
                            inventario.Columns[0].Visible = false;
                        }
                    }
                    else if (tabla == "inventariomaquinaria" || tabla == "inventariograndemaquinaria")
                    {
                        if (inventario.Columns.Contains("idinventariomaquinaria") || inventario.Columns.Contains("idinventariograndemaquinaria"))
                        {
                            inventario.Columns[0].Visible = false;
                        }
                    }
                    else if (tabla == "inventariomobilariooficina" || tabla == "inventariograndemobilariooficina")
                    {
                        if (inventario.Columns.Contains("idinventariomobilariooficina") || inventario.Columns.Contains("idinventariograndemobilariooficina"))
                        {
                            inventario.Columns[0].Visible = false;
                        }
                    }
                    else if (tabla == "inventariotallerlaboratorio" || tabla == "inventariograndetallerlaboratorio")
                    {
                        if (inventario.Columns.Contains("idinventariotallerlaboratorio") || inventario.Columns.Contains("idinventariograndetallerlaboratorio"))
                        {
                            inventario.Columns[0].Visible = false;
                        }
                    }
                    inventario.Columns[1].Width = 65;
                    inventario.Columns[2].Width = 140;
                    inventario.Columns[3].Width = 330;
                    inventario.Columns[4].Width = 110;
                    inventario.Columns[5].Width = 190;
                    inventario.Columns[6].Width = 70;
                    inventario.Columns[8].Width = 260;

                    inventario.Columns["idmaestrocam"].Visible = false;
                    CargaDGV();
                }
                catch (Exception)
                {

                }
            }
        }
        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            actu.agregar = 1;
            actu.tablaf = tabla;
            actu.FormClosed += (s, args) => { cbSeccion_SelectedIndexChanged(cbSeccion, EventArgs.Empty); };
            actu.ShowDialog();
            CargaDGV();
            ChecaRegistros();
            DeshabilitaBuscar();
            actu.agregar = 0;
        }
        int labelindicador = 0;

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            actu.actualizar = 3;
            actu.tablaf = tabla;
            objIns.Id = idSeleccionado;
            objIns.Cantidad = 1;
            objIns.NumInventario = dgvInventarioNormal.CurrentRow.Cells[2].Value.ToString();
            objIns.Descripcion = dgvInventarioNormal.CurrentRow.Cells[3].Value.ToString();
            objIns.Marca = dgvInventarioNormal.CurrentRow.Cells[4].Value.ToString();
            objIns.Ubicacion = dgvInventarioNormal.CurrentRow.Cells[5].Value.ToString();
            objIns.Idmaestro = Convert.ToInt32(dgvInventarioNormal.CurrentRow.Cells["idmaestrocam"].Value.ToString());
            objIns.Estatus = "Inactivo";
            actu.agregar = 0;
            rec.eliminarinventario(objIns, tabla);
            verinventario(dgvInventarioNormal, tabla);
            verinventario(dgvInventarioMayor, tablagrande);
            CargaDGV();
            ChecaRegistros();
            DeshabilitaBuscar();
            actu.actualizar = 0;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            actu.agregar = 2;
            actu.tablagr = tablagrande;
            actu.FormClosed += (s, args) => { cbSeccion_SelectedIndexChanged(cbSeccion, EventArgs.Empty); };
            actu.ShowDialog();
            CargaDGV();
            ChecaRegistros();
            DeshabilitaBuscar();
            actu.agregar = 0;
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            actu.actualizar = 2;
            actu.conmaestro = 2;
            actu.tablagr = tablagrande;
            actu.id = idseleccioonadoG;
            actu.FormClosed += (s, args) => { cbSeccion_SelectedIndexChanged(cbSeccion, EventArgs.Empty); };
            actu.ShowDialog();
            CargaDGV();
            ChecaRegistros();
            actu.actualizar = 0;
            if (labelindicador == 1)
            {
                lblbtnMaestro_Click(null, EventArgs.Empty);
                desactiva3b(true);
            }
            else if (labelindicador == 2)
            {
                lblbtnNumInv_Click(null, EventArgs.Empty);
                desactiva3b(true);
            }
            labelindicador = 0;
        }
        Eliminar eli = new Eliminar();
        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            eli.eliminar = 1;
            eli.tabla = tabla;
            eli.tablagr = tablagrande;
            eli.idG = idseleccioonadoG;
            eli.conmaestro = 2;
            eli.primercantidad = Convert.ToInt32(dgvInventarioMayor.CurrentRow.Cells[1].Value.ToString());
            eli.FormClosed += (s, args) => { cbSeccion_SelectedIndexChanged(cbSeccion, EventArgs.Empty); };
            eli.ShowDialog();
            CargaDGV();
            ChecaRegistros();
            DeshabilitaBuscar();
            eli.eliminar = 0;
        }
        //Obtener los registros de cada celda del datagridview mediante un clic
        private void dgvInventarioNormal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(dgvInventarioNormal.CurrentRow.Cells[0].Value.ToString());
            actu.cantidad = Convert.ToInt32(dgvInventarioNormal.CurrentRow.Cells[1].Value.ToString());
            actu.numinventario = dgvInventarioNormal.CurrentRow.Cells[2].Value.ToString();
            actu.descripcion = dgvInventarioNormal.CurrentRow.Cells[3].Value.ToString();
            actu.marca = dgvInventarioNormal.CurrentRow.Cells[4].Value.ToString();
            actu.ubicacion = dgvInventarioNormal.CurrentRow.Cells[5].Value.ToString();
            actu.estatus = dgvInventarioNormal.CurrentRow.Cells[6].Value.ToString();
            actu.idemaestro = dgvInventarioNormal.CurrentRow.Cells[8].Value.ToString();
            actu.id = idSeleccionado;
        }
        private void dgvInventarioMayor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idseleccioonadoG = Convert.ToInt32(dgvInventarioMayor.CurrentRow.Cells[0].Value.ToString());
            actu.cantidadG = Convert.ToInt32(dgvInventarioMayor.CurrentRow.Cells[1].Value.ToString());
            actu.numinventarioG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[2].Value.ToString());
            actu.descripcionG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[3].Value.ToString());
            actu.marcaG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[4].Value.ToString());
            actu.ubicacionG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[5].Value.ToString());
            actu.estatusG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[6].Value.ToString());
            actu.idemaestroG = dgvInventarioMayor.CurrentRow.Cells[8].Value.ToString();

            eli.numinventarioG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[2].Value.ToString());
            eli.descripcionG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[3].Value.ToString());
            eli.marcaG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[4].Value.ToString());
            eli.ubicacionG = Convert.ToString(dgvInventarioMayor.CurrentRow.Cells[5].Value.ToString());
            eli.idemaestroG = dgvInventarioMayor.CurrentRow.Cells[8].Value.ToString();
        }
        //Filtrar desde la descripcion de los registros y mostrar en el datagridview
        public void verfiltro(DataGridView inventario, string tabla, string descripcion)//descripcion sera numinventario
        {
            if (util.EsNulo(cbSeccion) == false)
            {
                MySqlCommand cmd = new MySqlCommand("FILTRACIONACTIVOS", con.ConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("PTABLA", tabla);
                cmd.Parameters["PTABLA"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("PNUMINVENTARIO", "%" + descripcion + "%");
                cmd.Parameters["PNUMINVENTARIO"].Direction = ParameterDirection.Input;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inventario.DataSource = dt;

                inventario.Columns["cantidad"].HeaderText = "Cantidad";
                inventario.Columns["numinventario"].HeaderText = "Número de inventario";
                inventario.Columns["descripcion"].HeaderText = "Descripción";
                inventario.Columns["marca"].HeaderText = "Marca";
                inventario.Columns["ubicacion"].HeaderText = "Ubicación";
                inventario.Columns["idmaestrocam"].HeaderText = "Maestro";
                inventario.Columns["estatus"].HeaderText = "Estatus";

                if (tabla == "inventariocomputo" || tabla == "inventariograndecomputo")
                {
                    if (inventario.Columns.Contains("idinventariocomputo") || inventario.Columns.Contains("idinventariograndecomputo"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                else if (tabla == "inventariomaquinaria" || tabla == "inventariograndemaquinaria")
                {
                    if (inventario.Columns.Contains("idinventariomaquinaria") || inventario.Columns.Contains("idinventariograndemaquinaria"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                else if (tabla == "inventariomobilariooficina" || tabla == "inventariograndemobilariooficina")
                {
                    if (inventario.Columns.Contains("idinventariomobilariooficina") || inventario.Columns.Contains("idinventariograndemobilariooficina"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                else if (tabla == "inventariotallerlaboratorio" || tabla == "inventariograndetallerlaboratorio")
                {
                    if (inventario.Columns.Contains("idinventariotallerlaboratorio") || inventario.Columns.Contains("idinventariograndetallerlaboratorio"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                inventario.Columns[1].Width = 65;
                inventario.Columns[2].Width = 140;
                inventario.Columns[3].Width = 330;
                inventario.Columns[4].Width = 110;
                inventario.Columns[5].Width = 190;
                inventario.Columns[6].Width = 70;
                inventario.Columns[8].Width = 260;
            }
        }
        public void verfiltromaestro(DataGridView inventario, string tabla, int descripcion)//descripcion sera numinventario
        {
            if (util.EsNulo(cbSeccion) == false)
            {
                MySqlCommand cmd = new MySqlCommand("FILTRARMAESTRO", con.ConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("PTABLA", tabla);
                cmd.Parameters["PTABLA"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("PIDMAESTROCAM", +descripcion);
                cmd.Parameters["PIDMAESTROCAM"].Direction = ParameterDirection.Input;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inventario.DataSource = dt;

                inventario.Columns["cantidad"].HeaderText = "Cantidad";
                inventario.Columns["numinventario"].HeaderText = "Número de inventario";
                inventario.Columns["descripcion"].HeaderText = "Descripción";
                inventario.Columns["marca"].HeaderText = "Marca";
                inventario.Columns["ubicacion"].HeaderText = "Ubicación";
                inventario.Columns["idmaestrocam"].HeaderText = "Maestro";
                inventario.Columns["estatus"].HeaderText = "Estatus";

                if (tabla == "inventariocomputo" || tabla == "inventariograndecomputo")
                {
                    if (inventario.Columns.Contains("idinventariocomputo") || inventario.Columns.Contains("idinventariograndecomputo"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                else if (tabla == "inventariomaquinaria" || tabla == "inventariograndemaquinaria")
                {
                    if (inventario.Columns.Contains("idinventariomaquinaria") || inventario.Columns.Contains("idinventariograndemaquinaria"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                else if (tabla == "inventariomobilariooficina" || tabla == "inventariograndemobilariooficina")
                {
                    if (inventario.Columns.Contains("idinventariomobilariooficina") || inventario.Columns.Contains("idinventariograndemobilariooficina"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                else if (tabla == "inventariotallerlaboratorio" || tabla == "inventariograndetallerlaboratorio")
                {
                    if (inventario.Columns.Contains("idinventariotallerlaboratorio") || inventario.Columns.Contains("idinventariograndetallerlaboratorio"))
                    {
                        inventario.Columns[0].Visible = false;
                    }
                }
                inventario.Columns[1].Width = 65;
                inventario.Columns[2].Width = 140;
                inventario.Columns[3].Width = 330;
                inventario.Columns[4].Width = 110;
                inventario.Columns[5].Width = 190;
                inventario.Columns[7].Width = 235;
                inventario.Columns[8].Width = 260; 
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtrar = txtBuscar.Text;
            verfiltro(dgvInventarioNormal, tabla, filtrar);
            verfiltro(dgvInventarioMayor, tablagrande, filtrar);
            if (dgvInventarioNormal.Rows.Count > 0)
            {
                dgvInventarioNormal_CellClick(dgvInventarioNormal, new DataGridViewCellEventArgs(0, 0));
            }
            if (dgvInventarioMayor.Rows.Count > 0)
            {
                dgvInventarioMayor_CellClick(dgvInventarioMayor, new DataGridViewCellEventArgs(0, 0));
            }
            ChecaRegistros();
        }

        private void lblEliminados_Click(object sender, EventArgs e)
        {
            Eliminados eliminados = new Eliminados();
            eliminados.posseccion2 = posseccion;
            eliminados.ShowDialog();
        }
        //Obtener el nombre de cada tabla mediante el cbSeccion
        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeccion.SelectedIndex == 0)
            {
                tabla = "inventariocomputo";
                tablagrande = "inventariograndecomputo";
                eli.tabla = tabla;
            }
            if (cbSeccion.SelectedIndex == 1)
            {
                tabla = "inventariomaquinaria";
                tablagrande = "inventariograndemaquinaria";
                eli.tabla = tabla;
            }
            if (cbSeccion.SelectedIndex == 2)
            {
                tabla = "inventariomobilariooficina";
                tablagrande = "inventariograndemobilariooficina";
                eli.tabla = tabla;
            }
            if (cbSeccion.SelectedIndex == 3)
            {
                tabla = "inventariotallerlaboratorio";
                tablagrande = "inventariograndetallerlaboratorio";
                eli.tabla = tabla;
            }
            posseccion = cbSeccion.SelectedIndex;
            verinventario(dgvInventarioNormal, tabla);
            verinventario(dgvInventarioMayor, tablagrande);
            DeshabilitaBuscar();
            ChecaRegistros();
        }
        public void ChecaRegistros()
        {
            //Para verificar si hay registros en las tablas
            if (util.TieneRegistros(dgvInventarioNormal) == true)
            {
                btnEditar1.Enabled = true;
                btnEditar1.Visible = true;
                btnEliminar1.Enabled = true;
                btnEliminar1.Visible = true;
            }
            if (util.TieneRegistros(dgvInventarioMayor) == true)
            {
                btnEditar2.Enabled = true;
                btnEditar2.Visible = true;
                btnEliminar2.Enabled = true;
                btnEliminar2.Visible = true;
            }
            if (util.TieneRegistros(dgvInventarioNormal) == false)
            {
                btnEditar1.Enabled = false;
                btnEditar1.Visible = false;
                btnEliminar1.Enabled = false;
                btnEliminar1.Visible = false;
            }
            if (util.TieneRegistros(dgvInventarioMayor) == false)
            {
                btnEditar2.Enabled = false;
                btnEditar2.Visible = false;
                btnEliminar2.Enabled = false;
                btnEliminar2.Visible = false;
            }
        }
        iTextSharp.text.Font fontMini;
        iTextSharp.text.Font fontBoldMini;
        iTextSharp.text.Font fontTitle;
        iTextSharp.text.Font fontRow;
        private void ConfigurarFuentes()
        {
            //Se usa FontFactory para crear las fuentes de iTextSharp
            fontMini = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.BLACK);
            fontBoldMini = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.BaseColor.BLACK);
            fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.BLACK);
            fontRow = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.BLACK);
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ConfigurarFuentes();
            //Validar si hay datos en alguna de las dos tablas
            if (dgvInventarioNormal.Rows.Count == 0 && dgvInventarioMayor.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar en ninguna de las tablas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Reporte_BienesMateriales_CAM_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        // Configuración del documento (A4 Horizontal)
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        //ENCABEZADO OFICIAL (Logos y Títulos) ---
                        PdfPTable headerTable = new PdfPTable(2);
                        headerTable.WidthPercentage = 100;
                        headerTable.SetWidths(new float[] { 30f, 70f });

                        //Obtener la ruta de la imagen (asumiendo que está en la raíz del bin)
                        string imagePath = Path.Combine(Application.StartupPath, "yucatansegey.png");

                        PdfPCell leftHeader = new PdfPCell();

                        if (File.Exists(imagePath))
                        {
                            //Crear el objeto imagen
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                            //Ajustar el tamaño de la imagen (opcional, escala porcentual)
                            logo.ScaleToFit(230f, 150f);
                            //Crear la celda con la imagen
                            leftHeader = new PdfPCell(logo);
                        }

                        //Quitar bordes y alinear
                        leftHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        leftHeader.VerticalAlignment = Element.ALIGN_MIDDLE;
                        leftHeader.HorizontalAlignment = Element.ALIGN_LEFT;

                        headerTable.AddCell(leftHeader);

                        PdfPCell rightHeader = new PdfPCell();
                        rightHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        rightHeader.AddElement(new Paragraph("DIRECCIÓN DE ADMINISTRACIÓN Y FINANZAS", fontTitle));
                        rightHeader.AddElement(new Paragraph("CONTROL PATRIMONIAL", fontTitle));
                        rightHeader.AddElement(new Paragraph("RESGUARDO DE BIENES EN CENTRO DE TRABAJO", fontTitle));
                        rightHeader.AddElement(new Paragraph($"RUBRO: {cbSeccion.Text.ToUpper()}", fontTitle));
                        headerTable.AddCell(rightHeader);

                        pdfDoc.Add(headerTable);
                        pdfDoc.Add(new Paragraph("\n"));

                        PdfPTable infoTable = new PdfPTable(2);
                        infoTable.WidthPercentage = 100;

                        string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");

                        infoTable.AddCell(CreateMetaCell("AREA O PLANTEL: CENTRO DE ATENCIÓN MULTIPLE OXKUTZCAB", fontBoldMini));
                        infoTable.AddCell(CreateMetaCell("TURNO: MATUTINO", fontBoldMini));
                        infoTable.AddCell(CreateMetaCell("DOMICILIO: CALLE 38", fontBoldMini));
                        infoTable.AddCell(CreateMetaCell("ZONA: 012", fontBoldMini));
                        infoTable.AddCell(CreateMetaCell("CLAVE: 31DML2019K", fontBoldMini));
                        infoTable.AddCell(CreateMetaCell("MUNICIPIO / LOCALIDAD: OXKUTZCAB", fontBoldMini));

                        infoTable.AddCell(CreateMetaCell("Fecha de impresión: " + fechaActual, fontBoldMini));
                        infoTable.AddCell(CreateMetaCell("", fontBoldMini));

                        pdfDoc.Add(infoTable);
                        pdfDoc.Add(new Paragraph("\n"));

                        //TABLA 1: INVENTARIO NORMAL ---
                        if (dgvInventarioNormal.Rows.Count > 0)
                        {
                            Paragraph pNormal = new Paragraph("INVENTARIO CON UNA UNIDAD", fontTitle);
                            pNormal.SpacingAfter = 5f;
                            pdfDoc.Add(pNormal);
                            pdfDoc.Add(ExportDataGridViewToPdfTable(dgvInventarioNormal));
                        }

                        //Espacio entre tablas
                        pdfDoc.Add(new Paragraph("\n\n"));

                        //TABLA 2: INVENTARIO MAYOR ---
                        if (dgvInventarioMayor.Rows.Count > 0)
                        {
                            Paragraph pMayor = new Paragraph("INVENTARIO CON MAS DE UNA UNIDAD", fontTitle);
                            pMayor.SpacingAfter = 5f;
                            pdfDoc.Add(pMayor);
                            pdfDoc.Add(ExportDataGridViewToPdfTable(dgvInventarioMayor));
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private PdfPCell CreateMetaCell(string text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER; // También corregimos el Rectangle aquí
            cell.PaddingBottom = 5f; // Un poquito de espacio entre líneas
            return cell;
        }
        //MÉTODO AUXILIAR PARA REUTILIZAR LÓGICA
        private PdfPTable ExportDataGridViewToPdfTable(DataGridView dgv)
        {
            // 1. Restamos 2 al total de columnas: 
            // Una por la columna 0 (que ya saltabas) y otra por la columna 6.
            int totalColumnasVisibles = dgv.Columns.Count - 2;
            PdfPTable pdfTable = new PdfPTable(totalColumnasVisibles);
            pdfTable.WidthPercentage = 100;

            int sumaCantidades = 0;
            // --- ENCABEZADOS ---
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                //Saltamos la columna 6
                if (i == 7) continue;

                PdfPCell cell = new PdfPCell(new Phrase(dgv.Columns[i].HeaderText.ToUpper(), fontBoldMini));
                cell.BackgroundColor = new BaseColor(80, 80, 80);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 4;
                pdfTable.AddCell(cell);
            }
            // --- FILAS DE DATOS ---
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                // Sumar la cantidad (Columna índice 1)
                if (row.Cells[1].Value != null)
                {
                    int cant;
                    if (int.TryParse(row.Cells[1].Value.ToString(), out cant))
                    {
                        sumaCantidades += cant;
                    }
                }
                for (int j = 1; j < row.Cells.Count; j++)
                {
                    //Saltamos el contenido de la columna 6
                    if (j == 7) continue;

                    PdfPCell cell = new PdfPCell(new Phrase(row.Cells[j].Value?.ToString() ?? "", fontRow));
                    cell.HorizontalAlignment = Element.ALIGN_LEFT;
                    cell.Padding = 3;
                    pdfTable.AddCell(cell);
                }
            }
            // --- FILA DE TOTALES ---
            PdfPCell cellTotalLabel = new PdfPCell(new Phrase("Total de Mobiliarios por Rubro: " + cbSeccion.Text, fontBoldMini));
            cellTotalLabel.BackgroundColor = BaseColor.BLACK;
            cellTotalLabel.Phrase.Font.Color = BaseColor.WHITE;
            cellTotalLabel.Colspan = totalColumnasVisibles - 1;
            cellTotalLabel.Padding = 5;
            pdfTable.AddCell(cellTotalLabel);

            PdfPCell cellTotalValue = new PdfPCell(new Phrase(sumaCantidades.ToString(), fontBoldMini));
            cellTotalValue.BackgroundColor = BaseColor.BLACK;
            cellTotalValue.Phrase.Font.Color = BaseColor.WHITE;
            cellTotalValue.HorizontalAlignment = Element.ALIGN_CENTER;
            cellTotalValue.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellTotalValue.Padding = 5;
            pdfTable.AddCell(cellTotalValue);

            return pdfTable;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda ayud = new Ayuda();
            ayud.ShowDialog();
        }

        private void btnNuevomaestro_Click(object sender, EventArgs e)
        {
            Maestros ma = new Maestros();
            ma.ShowDialog();
        }

        private void dgvInventarioNormal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                CBMPROFESOR.DataSource = dt;
                CBMPROFESOR.DisplayMember = "NombreCompleto";//Lo que se muestra
                CBMPROFESOR.ValueMember = "idmaestrocam";//Lo que se guarda internamente
            }
            catch (Exception)
            {
                MessageBox.Show("No hay nigun profesor registrado en el sistema porfavor agregue uno ");
            }
        }

        private void lblbtnNumInv_Click(object sender, EventArgs e)
        {
            if (lblbtnNumInv.Text == "Número de inventario")
            {
                HabilitaBuscar();
                btnImprimir.Visible=false;
                btnImprimir.Enabled=false;
                lblbtnNumInv.Text = "Mostrar todos los registros";
                lblBuscarpor.Visible = false;
                lbloo.Visible = false;
                lblbtnMaestro.Visible = false;
                desactiva3b(false);
                lblbtnNumInv.Location = new Point(44, 44);
                labelindicador = 2;
            }
            else
            {
                lblbtnNumInv.Text = "Número de inventario";
                lblBuscarpor.Visible = true;
                lbloo.Visible = true;
                lblbtnMaestro.Visible = true;
                lblbtnNumInv.Location = new Point(3, 44);
                DeshabilitaBuscar();
                desactiva3b(true);
                btnImprimir.Visible = true;
                btnImprimir.Enabled = true;
                verinventario(dgvInventarioNormal, tabla);
                verinventario(dgvInventarioMayor, tablagrande);
                labelindicador = 0;
            }
            CBMPROFESOR.Visible = false;
            btnFiltrarMaestro.Visible = false;
           
        }

        private void lblbtnMaestro_Click(object sender, EventArgs e)
        {
            if (lblbtnMaestro.Text == "Maestro")
            {
                HabilitaBuscar();
                lblBuscarpor.Visible = false;
                lbloo.Visible = false;
                lblbtnNumInv.Visible = false;
                desactiva3b(false);
                btnImprimir.Visible = false;
                btnImprimir.Enabled=false;
                lblbtnMaestro.Location = new Point(44, 44);
                mostrarprofesor();
                lblbtnMaestro.Text = "Mostrar todos los registros"; 
                labelindicador = 1;
            }
            else
            {
                dgvInventarioNormal.DataSource = null;
                dgvInventarioMayor.DataSource = null;
                lblBuscarpor.Visible = true;
                lbloo.Visible = true;
                lblbtnNumInv.Visible = true;
                lblbtnMaestro.Location = new Point(179, 44);
                DeshabilitaBuscar();
                desactiva3b(true);
                btnImprimir.Visible = true;
                btnImprimir.Enabled = true;
                verinventario(dgvInventarioNormal, tabla);
                verinventario(dgvInventarioMayor, tablagrande);
                lblbtnMaestro.Text = "Maestro";
                labelindicador = 0;
            }
            lblBuscar.Visible = false;
            txtBuscar.Visible = false;
            btnBuscar.Visible = false;
            
        }

        private void btnFiltrarMaestro_Click(object sender, EventArgs e)
        {
            CargarMaestro();
            //CBMPROFESOR.SelectedIndex = 1;
            if (dgvInventarioNormal.Rows.Count > 0)
            {
                dgvInventarioNormal_CellClick(dgvInventarioNormal, new DataGridViewCellEventArgs(0, 0));
                btnImprimir.Enabled = true;
                btnImprimir.Visible = true;
            }
            else {
                btnImprimir.Enabled = false;
                btnImprimir.Visible = false;
            }
            if (dgvInventarioMayor.Rows.Count > 0)
            {
                dgvInventarioMayor_CellClick(dgvInventarioMayor, new DataGridViewCellEventArgs(0, 0));
                btnImprimir.Enabled = true;
                btnImprimir.Visible = true;
            }
            else {
                btnImprimir.Enabled = false;
                btnImprimir.Visible = false;
            }
        }
        public void desactiva3b(bool vf)
        {
            cbSeccion.Enabled = vf;
            btnAgregar1.Enabled = vf;
            btnEditar1.Enabled = vf;
            btnEliminar1.Enabled = vf;
            btnAgregar1.Visible = vf;
            btnEditar1.Visible = vf;
            btnEliminar1.Visible = vf;

            btnAgregar2.Enabled = vf;
            btnEditar2.Enabled = vf;
            btnEliminar2.Enabled = vf;
            btnAgregar2.Visible = vf;
            btnEditar2.Visible = vf;
            btnEliminar2.Visible = vf;

            btnNuevomaestro.Enabled = vf;
            btnNuevomaestro.Visible = vf;
            lblo.Enabled = vf;
            lblEliminados.Enabled = vf;
            lblo.Visible = vf;
            lblEliminados.Visible = vf;
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            actu.actualizar = 1;
            actu.conmaestro = 1;
            actu.tablaf = tabla;
            actu.id = idSeleccionado;
            actu.FormClosed += (s, args) => { cbSeccion_SelectedIndexChanged(cbSeccion, EventArgs.Empty); };
            actu.ShowDialog();
            CargaDGV();
            ChecaRegistros();
            if (labelindicador == 1)
            {
                lblbtnMaestro_Click(null, EventArgs.Empty);
                desactiva3b(true);
            }
            else if (labelindicador == 2)
            {
                lblbtnNumInv_Click(null, EventArgs.Empty);
                desactiva3b(true);
            }
            labelindicador = 0;
        }
    }
}
