namespace Inventario_CAM
{
    partial class Actualizar
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtNumInventario = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cbEstatus = new System.Windows.Forms.ComboBox();
            this.lblNumInventario = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMaestro = new System.Windows.Forms.Label();
            this.CBXPROFESOR = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(483, 332);
            this.txtMarca.MaxLength = 60;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(491, 28);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(483, 276);
            this.txtDescripcion.MaxLength = 300;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(491, 28);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(483, 383);
            this.txtUbicacion.MaxLength = 200;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(491, 28);
            this.txtUbicacion.TabIndex = 4;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            this.txtUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbicacion_KeyPress);
            // 
            // txtNumInventario
            // 
            this.txtNumInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumInventario.Location = new System.Drawing.Point(483, 219);
            this.txtNumInventario.MaxLength = 200;
            this.txtNumInventario.Name = "txtNumInventario";
            this.txtNumInventario.Size = new System.Drawing.Size(491, 28);
            this.txtNumInventario.TabIndex = 1;
            this.txtNumInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumInventario_KeyPress);
            this.txtNumInventario.Leave += new System.EventHandler(this.txtNumInventario_Leave);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(483, 168);
            this.nudCantidad.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(95, 28);
            this.nudCantidad.TabIndex = 0;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbEstatus
            // 
            this.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstatus.Enabled = false;
            this.cbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstatus.Location = new System.Drawing.Point(483, 476);
            this.cbEstatus.MaxLength = 100;
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(254, 30);
            this.cbEstatus.TabIndex = 31;
            // 
            // lblNumInventario
            // 
            this.lblNumInventario.AutoSize = true;
            this.lblNumInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInventario.Location = new System.Drawing.Point(203, 220);
            this.lblNumInventario.Name = "lblNumInventario";
            this.lblNumInventario.Size = new System.Drawing.Size(204, 25);
            this.lblNumInventario.TabIndex = 37;
            this.lblNumInventario.Text = "Número de Inventario:";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(203, 477);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(83, 25);
            this.lblEstatus.TabIndex = 36;
            this.lblEstatus.Text = "Estatus:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(203, 384);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(104, 25);
            this.lblUbicacion.TabIndex = 35;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(203, 168);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 25);
            this.lblCantidad.TabIndex = 34;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(203, 333);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(73, 25);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(203, 277);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(120, 25);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(938, 586);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 47);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(788, 586);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 47);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(788, 586);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 47);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblMaestro
            // 
            this.lblMaestro.AutoSize = true;
            this.lblMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestro.Location = new System.Drawing.Point(203, 430);
            this.lblMaestro.Name = "lblMaestro";
            this.lblMaestro.Size = new System.Drawing.Size(89, 25);
            this.lblMaestro.TabIndex = 39;
            this.lblMaestro.Text = "Maestro:";
            // 
            // CBXPROFESOR
            // 
            this.CBXPROFESOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXPROFESOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXPROFESOR.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBXPROFESOR.Location = new System.Drawing.Point(483, 429);
            this.CBXPROFESOR.MaxLength = 100;
            this.CBXPROFESOR.Name = "CBXPROFESOR";
            this.CBXPROFESOR.Size = new System.Drawing.Size(491, 30);
            this.CBXPROFESOR.TabIndex = 40;
            this.CBXPROFESOR.SelectedIndexChanged += new System.EventHandler(this.cbMaestro_SelectedIndexChanged);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1109, 645);
            this.ControlBox = false;
            this.Controls.Add(this.CBXPROFESOR);
            this.Controls.Add(this.lblMaestro);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNumInventario);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cbEstatus);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtNumInventario);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescripcion);
            this.KeyPreview = true;
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Actualizar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Actualizar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtNumInventario;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cbEstatus;
        private System.Windows.Forms.Label lblNumInventario;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMaestro;
        private System.Windows.Forms.ComboBox CBXPROFESOR;
    }
}