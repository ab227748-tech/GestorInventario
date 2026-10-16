/*using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;*/

using System;
using System.Data;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Funciones
{
    public class Utiles
    {
       
        //Nuevo
        /*
        public void Mensaje(string mensaje, Page pagina)
        {
            pagina.Response.Write("<script language=javascript>alert('" + mensaje + "');</script>");
        }
        
        public void CargarGrid(GridView grilla, DataSet ds)
        {
            grilla.DataSource = ds;
            grilla.DataBind();
            ds.Dispose();
        }
        */
        public string EstaMarcado(System.Windows.Forms.CheckBox chk, string valorTrue, string valorFalse)
        {
            if (chk.Checked)
                return valorTrue;
            else
                return valorFalse;
        }

        public AutoCompleteStringCollection CargaAutoAcompletar(
                DataTable dt, ComboBox cbo, String valorCampo)
        {
            //            DataTable dt = LoadDataTable();
            //
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row[valorCampo]));
            }

            return stringCol;
        }

        public void LlenarCombo(ComboBox cbo, DataView dv, String texto, String valor)
        {
            try
            {
                cbo.DisplayMember = texto;
                cbo.ValueMember = valor;
                cbo.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poner datos en Combo" +
                        ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        public void Limpiar(System.Windows.Forms.Control objeto)
        {
            foreach (System.Windows.Forms.Control obj in objeto.Controls)
            {
                if (obj is System.Windows.Forms.TextBox)
                    obj.Text = "";
            }
        }
        public void MensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool MensajeConfirmacion(string mensaje)
        {
            if (MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public void SeGrabo(int resultado)
        {
            if (resultado == 1)
                MensajeInformacion("Se grabaron correctamente los datos.");
            else
                if (resultado == 0)
            {
                MensajeError("No se pudo grabar los datos. Verifique.");
            }
        }

        public bool EsNulo(params System.Windows.Forms.Control[] obj)
        {
            Int16 i = 0;
            bool cond = false;
            for (i = 0; i < obj.Length; i++)
            {
                if (obj[i].Text == "")
                {
                    cond = true;
                    break;
                }
            }
            return cond;
        }

        public bool ListadoNulo(params System.Windows.Forms.ListControl[] obj)
        {
            Int16 i = 0;
            bool cond = false;
            for (i = 0; i < obj.Length; i++)
            {
                if (obj[i].SelectedValue.ToString() == "")
                {
                    cond = true;
                    break;
                }
            }
            return cond;
        }
        public bool TieneRegistros(DataGridView dgv)
        {
            return dgv.Rows.Count > 0;
        }

        public object ValorXDefecto(System.Windows.Forms.Control obj)
        {
            if (obj.Text == "")
                return null;
            else
                return obj.Text;
        }

        public string ValorCampo(DataTable dt, string campo)
        {
            if (dt.Rows.Count > 0)
                return dt.Rows[0][campo].ToString();
            else
                return "";
        }

        public void MarcarCheckBox(System.Windows.Forms.CheckBox chk, string valoranalizar, string valorigual)
        {
            if (valoranalizar == valorigual)
                chk.Checked = true;
            else
                chk.Checked = false;
        }

        public void CargarDataGrid(DataGridView grilla, DataTable dt)
        {
            grilla.DataSource = dt.DefaultView;
        }

        public void LimpiarDataGrid(DataGridView grilla)
        {
            grilla.DataSource = null;
        }

        public void ColorearGrid(DataGridView grilla, Color colorPar, Color colorImpar)
        {
            Color colTemp;
            for (int x = 0; x <= grilla.Rows.Count - 1; x++)
            {
                if (x % 2 == 0)
                {
                    colTemp = colorPar;
                }
                else
                {
                    colTemp = colorImpar;
                }

                for (int y = 0; y <= grilla.ColumnCount - 1; y++)
                {
                    grilla.Rows[x].Cells[y].Style.BackColor = colTemp;
                }
            }
        }
    }
}
