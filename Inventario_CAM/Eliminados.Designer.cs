namespace Inventario_CAM
{
    partial class Eliminados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.lblInventario1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInventarioNormal = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSalir.BackgroundImage = global::Inventario_CAM.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("OpenSymbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1713, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 61);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbSeccion
            // 
            this.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeccion.Items.AddRange(new object[] {
            "Computo",
            "Maquinaria",
            "Mobiliario y oficina",
            "Taller y laboratorio"});
            this.cbSeccion.Location = new System.Drawing.Point(30, 56);
            this.cbSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(345, 30);
            this.cbSeccion.TabIndex = 10;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.cbSeccion_SelectedIndexChanged);
            // 
            // lblInventario1
            // 
            this.lblInventario1.AutoSize = true;
            this.lblInventario1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario1.Location = new System.Drawing.Point(296, 318);
            this.lblInventario1.Name = "lblInventario1";
            this.lblInventario1.Size = new System.Drawing.Size(256, 22);
            this.lblInventario1.TabIndex = 31;
            this.lblInventario1.Text = "Inventario por sólo una unidad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSeccion);
            this.panel1.Controls.Add(this.cbSeccion);
            this.panel1.Location = new System.Drawing.Point(548, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 100);
            this.panel1.TabIndex = 35;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(17, 18);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(113, 25);
            this.lblSeccion.TabIndex = 36;
            this.lblSeccion.Text = "Secciones";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Plum;
            this.btnImprimir.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1210, 138);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 43);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvInventarioNormal);
            this.panel2.Location = new System.Drawing.Point(220, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1413, 445);
            this.panel2.TabIndex = 37;
            // 
            // dgvInventarioNormal
            // 
            this.dgvInventarioNormal.AllowUserToAddRows = false;
            this.dgvInventarioNormal.AllowUserToResizeColumns = false;
            this.dgvInventarioNormal.AllowUserToResizeRows = false;
            this.dgvInventarioNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventarioNormal.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvInventarioNormal.Location = new System.Drawing.Point(0, 0);
            this.dgvInventarioNormal.MultiSelect = false;
            this.dgvInventarioNormal.Name = "dgvInventarioNormal";
            this.dgvInventarioNormal.ReadOnly = true;
            this.dgvInventarioNormal.RowHeadersVisible = false;
            this.dgvInventarioNormal.RowHeadersWidth = 51;
            this.dgvInventarioNormal.RowTemplate.Height = 24;
            this.dgvInventarioNormal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioNormal.Size = new System.Drawing.Size(1413, 445);
            this.dgvInventarioNormal.TabIndex = 31;
            // 
            // Eliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1777, 812);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInventario1);
            this.Controls.Add(this.btnSalir);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eliminados";
            this.Text = "Eliminados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Eliminados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Eliminados_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.Label lblInventario1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInventarioNormal;
    }
}