namespace Inventario_CAM
{
    partial class Eliminar
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
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblNumInv = new System.Windows.Forms.Label();
            this.lblUbi = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblMarc = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNumInventario = new System.Windows.Forms.TextBox();
            this.comboUbicacion = new System.Windows.Forms.ComboBox();
            this.checkUbicacion = new System.Windows.Forms.CheckBox();
            this.CBXPROFESOR = new System.Windows.Forms.ComboBox();
            this.lblMaestro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(590, 155);
            this.nudCantidad.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(95, 28);
            this.nudCantidad.TabIndex = 31;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumInv
            // 
            this.lblNumInv.AutoSize = true;
            this.lblNumInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInv.Location = new System.Drawing.Point(296, 207);
            this.lblNumInv.Name = "lblNumInv";
            this.lblNumInv.Size = new System.Drawing.Size(204, 25);
            this.lblNumInv.TabIndex = 50;
            this.lblNumInv.Text = "Número de Inventario:";
            // 
            // lblUbi
            // 
            this.lblUbi.AutoSize = true;
            this.lblUbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbi.Location = new System.Drawing.Point(296, 421);
            this.lblUbi.Name = "lblUbi";
            this.lblUbi.Size = new System.Drawing.Size(104, 25);
            this.lblUbi.TabIndex = 49;
            this.lblUbi.Text = "Ubicación:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(296, 155);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(97, 25);
            this.lblCant.TabIndex = 48;
            this.lblCant.Text = "Cantidad:";
            // 
            // lblMarc
            // 
            this.lblMarc.AutoSize = true;
            this.lblMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarc.Location = new System.Drawing.Point(296, 320);
            this.lblMarc.Name = "lblMarc";
            this.lblMarc.Size = new System.Drawing.Size(73, 25);
            this.lblMarc.TabIndex = 47;
            this.lblMarc.Text = "Marca:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(296, 264);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(120, 25);
            this.lblDesc.TabIndex = 46;
            this.lblDesc.Text = "Descripción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1070, 628);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 47);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(920, 628);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 47);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(597, 268);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 20);
            this.lblDescripcion.TabIndex = 54;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(597, 325);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 20);
            this.lblMarca.TabIndex = 55;
            // 
            // txtNumInventario
            // 
            this.txtNumInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumInventario.Location = new System.Drawing.Point(590, 206);
            this.txtNumInventario.MaxLength = 200;
            this.txtNumInventario.Name = "txtNumInventario";
            this.txtNumInventario.Size = new System.Drawing.Size(434, 28);
            this.txtNumInventario.TabIndex = 57;
            this.txtNumInventario.TextChanged += new System.EventHandler(this.txtNumInventario_TextChanged);
            this.txtNumInventario.Enter += new System.EventHandler(this.txtNumInventario_Enter);
            this.txtNumInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumInventario_KeyPress);
            this.txtNumInventario.Leave += new System.EventHandler(this.txtNumInventario_Leave);
            // 
            // comboUbicacion
            // 
            this.comboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUbicacion.FormattingEnabled = true;
            this.comboUbicacion.Location = new System.Drawing.Point(590, 420);
            this.comboUbicacion.Name = "comboUbicacion";
            this.comboUbicacion.Size = new System.Drawing.Size(434, 30);
            this.comboUbicacion.TabIndex = 59;
            // 
            // checkUbicacion
            // 
            this.checkUbicacion.AutoSize = true;
            this.checkUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUbicacion.Location = new System.Drawing.Point(590, 475);
            this.checkUbicacion.Name = "checkUbicacion";
            this.checkUbicacion.Size = new System.Drawing.Size(401, 26);
            this.checkUbicacion.TabIndex = 60;
            this.checkUbicacion.Text = "¿Desea eliminar esta ubicación seleccionada?";
            this.checkUbicacion.UseVisualStyleBackColor = true;
            this.checkUbicacion.CheckedChanged += new System.EventHandler(this.checkUbicacion_CheckedChanged);
            // 
            // CBXPROFESOR
            // 
            this.CBXPROFESOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXPROFESOR.Enabled = false;
            this.CBXPROFESOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXPROFESOR.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBXPROFESOR.Location = new System.Drawing.Point(590, 370);
            this.CBXPROFESOR.MaxLength = 100;
            this.CBXPROFESOR.Name = "CBXPROFESOR";
            this.CBXPROFESOR.Size = new System.Drawing.Size(434, 30);
            this.CBXPROFESOR.TabIndex = 62;
            // 
            // lblMaestro
            // 
            this.lblMaestro.AutoSize = true;
            this.lblMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestro.Location = new System.Drawing.Point(296, 371);
            this.lblMaestro.Name = "lblMaestro";
            this.lblMaestro.Size = new System.Drawing.Size(89, 25);
            this.lblMaestro.TabIndex = 61;
            this.lblMaestro.Text = "Maestro:";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1226, 687);
            this.ControlBox = false;
            this.Controls.Add(this.CBXPROFESOR);
            this.Controls.Add(this.lblMaestro);
            this.Controls.Add(this.checkUbicacion);
            this.Controls.Add(this.comboUbicacion);
            this.Controls.Add(this.txtNumInventario);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNumInv);
            this.Controls.Add(this.lblUbi);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblMarc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.nudCantidad);
            this.KeyPreview = true;
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Eliminar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblNumInv;
        private System.Windows.Forms.Label lblUbi;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblMarc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNumInventario;
        private System.Windows.Forms.ComboBox comboUbicacion;
        private System.Windows.Forms.CheckBox checkUbicacion;
        private System.Windows.Forms.ComboBox CBXPROFESOR;
        private System.Windows.Forms.Label lblMaestro;
    }
}