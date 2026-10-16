using iTextSharp.text; // Librería iTextSharp
using iTextSharp.text.pdf; // Librería iTextSharp PDF
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario_CAM
{
    public partial class Eliminados : Form
    {
        public Eliminados()
        {
            InitializeComponent();
        }
        string tabla;
        public int posseccion2 = 0;
        ClassConectar.Conexion con = new ClassConectar.Conexion();
        Funciones.Utiles util = new Funciones.Utiles();
        private void Eliminados_Load(object sender, EventArgs e)
        {
            cbSeccion.SelectedIndex = posseccion2;
            if (dgvInventarioNormal.Rows.Count > 0)
            {
                dgvInventarioNormal.CurrentCell = dgvInventarioNormal.Rows[0].Cells[1];
                dgvInventarioNormal_CellClick(dgvInventarioNormal, new DataGridViewCellEventArgs(0, 0));
            }
        }
        public void vereliminados(DataGridView inventario, string tabla)
        {
            if (util.EsNulo(cbSeccion) == false)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("MOSTRARELIMINADOS", con.ConexionBD());
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

                    if (tabla == "inventariocomputo")
                    {
                        if (inventario.Columns.Contains("idinventariocomputo"))
                        {
                            inventario.Columns[0].Visible = false;
                            inventario.Columns[6].Visible = false;
                        }
                    }
                    else if (tabla == "inventariomaquinaria")
                    {
                        if (inventario.Columns.Contains("idinventariomaquinaria"))
                        {
                            inventario.Columns[0].Visible = false;
                            inventario.Columns[6].Visible = false;
                        }
                    }
                    else if (tabla == "inventariomobilariooficina")
                    {
                        if (inventario.Columns.Contains("idinventariomobilariooficina"))
                        {
                            inventario.Columns[0].Visible = false;
                            inventario.Columns[6].Visible = false;
                        }
                    }
                    else if (tabla == "inventariotallerlaboratorio")
                    {
                        if (inventario.Columns.Contains("idinventariotallerlaboratorio"))
                        {
                            inventario.Columns[0].Visible = false;
                            inventario.Columns[6].Visible = false;
                        }
                    }
                    inventario.Columns[1].Width = 75;
                    inventario.Columns[2].Width = 150;
                    inventario.Columns[3].Width = 232;
                    inventario.Columns[4].Width = 140;
                    inventario.Columns[5].Width = 200;
                    inventario.Columns[8].Width = 260;
                    inventario.Columns["idmaestrocam"].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay ningún registro de eliminados en el sistema");
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInventarioNormal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeccion.SelectedIndex == 0)
            {
                tabla = "inventariocomputo";
            }
            if (cbSeccion.SelectedIndex == 1)
            {
                tabla = "inventariomaquinaria";
            }
            if (cbSeccion.SelectedIndex == 2)
            {
                tabla = "inventariomobilariooficina";
            }
            if (cbSeccion.SelectedIndex == 3)
            {
                tabla = "inventariotallerlaboratorio";
            }
            vereliminados(dgvInventarioNormal, tabla);
        }

        private void Eliminados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                Application.Exit();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // 1. Validar si hay datos
            if (dgvInventarioNormal.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Reporte_Bienes_Inactivos_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Definición de fuentes (Asegúrate de tener estas variables)
                    iTextSharp.text.Font fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    iTextSharp.text.Font fontBoldMini = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);

                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // --- 1. ENCABEZADO (Logos y Títulos) ---
                        PdfPTable headerTable = new PdfPTable(2);
                        headerTable.WidthPercentage = 100;
                        headerTable.SetWidths(new float[] { 30f, 70f });

                        string imagePath = Path.Combine(Application.StartupPath, "yucatansegey.png");
                        PdfPCell leftHeader = new PdfPCell();

                        if (File.Exists(imagePath))
                        {
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                            logo.ScaleToFit(180f, 80f); // Ajustado para que no robe tanto espacio
                            leftHeader.AddElement(logo);
                        }
                        leftHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        leftHeader.VerticalAlignment = Element.ALIGN_MIDDLE;
                        headerTable.AddCell(leftHeader);

                        PdfPCell rightHeader = new PdfPCell();
                        rightHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        rightHeader.HorizontalAlignment = Element.ALIGN_RIGHT;
                        rightHeader.AddElement(new Paragraph("DIRECCIÓN DE ADMINISTRACIÓN Y FINANZAS", fontTitle));
                        rightHeader.AddElement(new Paragraph("CONTROL PATRIMONIAL", fontTitle));
                        rightHeader.AddElement(new Paragraph("RESGUARDO DE BIENES EN CENTRO DE TRABAJO", fontTitle));
                        rightHeader.AddElement(new Paragraph($"RUBRO: {cbSeccion.Text.ToUpper()}", fontTitle));
                        headerTable.AddCell(rightHeader);

                        pdfDoc.Add(headerTable);

                        // --- 2. TÍTULO CENTRAL ---
                        Paragraph title = new Paragraph("\nINVENTARIO DE MATERIALES Y BIENES INACTIVOS (ELIMINADOS)\n\n", fontTitle);
                        title.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(title);

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
                        pdfDoc.Add(new Paragraph("\n")); // Espacio antes de la tabla

                        //LA TABLA DE DATOS (Ahora sí, al final del encabezado) ---
                        pdfDoc.Add(ExportDataGridViewToPdfTable(dgvInventarioNormal));

                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        iTextSharp.text.Font fontMini;
        iTextSharp.text.Font fontBoldMini;
        iTextSharp.text.Font fontTitle;
        iTextSharp.text.Font fontRow;
        private void ConfigurarFuentes()
        {
            // Se usa FontFactory para crear las fuentes de iTextSharp
            fontMini = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.BLACK);
            fontBoldMini = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, iTextSharp.text.BaseColor.BLACK);
            fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.BLACK);
            fontRow = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.BLACK);
        }
        // --- MÉTODO AUXILIAR PARA CELDAS DE METADATOS ---
        private PdfPCell CreateMetaCell(string text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.PaddingBottom = 5f;
            return cell;
        }
        public PdfPTable ExportDataGridViewToPdfTable(DataGridView dgv)
        {
            // Filtro mejorado: Solo ignora si el nombre es exactamente "ID"
            var columnasVisibles = dgv.Columns.Cast<DataGridViewColumn>()
                .Where(c => c.Visible && c.Name.ToUpper() != "ID")
                .ToList();

            PdfPTable table = new PdfPTable(columnasVisibles.Count);
            table.WidthPercentage = 100;

            // Fuentes (Basadas en image_2a60f8.png)
            iTextSharp.text.Font fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, iTextSharp.text.BaseColor.WHITE);
            iTextSharp.text.Font fontRow = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font fontFooter = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.WHITE);

            // --- ENCABEZADOS ---
            foreach (var column in columnasVisibles)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText.ToUpper(), fontHeader));
                cell.BackgroundColor = new BaseColor(64, 64, 64);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5;
                table.AddCell(cell);
            }

            // --- DATOS ---
            int totalSuma = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (var column in columnasVisibles)
                    {
                        string cellValue = row.Cells[column.Index].Value?.ToString() ?? "";
                        table.AddCell(new PdfPCell(new Phrase(cellValue, fontRow)) { Padding = 4 });

                        // Ahora "CANTIDAD" pasará el filtro y se sumará correctamente
                        if (column.HeaderText.ToUpper() == "CANTIDAD")
                        {
                            int.TryParse(cellValue, out int cant);
                            totalSuma += cant;
                        }
                    }
                }
            }

            // --- FILA NEGRA DE TOTAL ---
            PdfPCell footerLabel = new PdfPCell(new Phrase($"Total de Mobiliarios por Rubro: {cbSeccion.Text}", fontFooter));
            footerLabel.BackgroundColor = BaseColor.BLACK;
            footerLabel.Colspan = columnasVisibles.Count - 1;
            footerLabel.Padding = 6;
            table.AddCell(footerLabel);

            PdfPCell footerValue = new PdfPCell(new Phrase(totalSuma.ToString(), fontFooter));
            footerValue.BackgroundColor = BaseColor.BLACK;
            footerValue.HorizontalAlignment = Element.ALIGN_CENTER;
            footerValue.Padding = 6;
            table.AddCell(footerValue);

            return table;
        }
    }
}
