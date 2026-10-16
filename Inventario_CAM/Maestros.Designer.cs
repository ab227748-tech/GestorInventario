namespace Inventario_CAM
{
    partial class Maestros
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
            this.dgvMaestros = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblbtnMaestrosInactivos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaestros
            // 
            this.dgvMaestros.AllowUserToAddRows = false;
            this.dgvMaestros.AllowUserToResizeColumns = false;
            this.dgvMaestros.AllowUserToResizeRows = false;
            this.dgvMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaestros.Location = new System.Drawing.Point(34, 51);
            this.dgvMaestros.MultiSelect = false;
            this.dgvMaestros.Name = "dgvMaestros";
            this.dgvMaestros.ReadOnly = true;
            this.dgvMaestros.RowHeadersVisible = false;
            this.dgvMaestros.RowHeadersWidth = 51;
            this.dgvMaestros.RowTemplate.Height = 24;
            this.dgvMaestros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaestros.Size = new System.Drawing.Size(671, 523);
            this.dgvMaestros.TabIndex = 39;
            this.dgvMaestros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaestros_CellClick);
            this.dgvMaestros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaestros_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(565, 589);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 47);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(415, 589);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 47);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Editar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Noto Sans Lisu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(257, 589);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 47);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblbtnMaestrosInactivos
            // 
            this.lblbtnMaestrosInactivos.AutoSize = true;
            this.lblbtnMaestrosInactivos.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnMaestrosInactivos.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblbtnMaestrosInactivos.Location = new System.Drawing.Point(12, 599);
            this.lblbtnMaestrosInactivos.Name = "lblbtnMaestrosInactivos";
            this.lblbtnMaestrosInactivos.Size = new System.Drawing.Size(176, 29);
            this.lblbtnMaestrosInactivos.TabIndex = 50;
            this.lblbtnMaestrosInactivos.Text = "Ver maestros inactivos";
            this.lblbtnMaestrosInactivos.Click += new System.EventHandler(this.lblbtnMaestrosInactivos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 19);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "Maestros activos";
            // 
            // Maestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(737, 648);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblbtnMaestrosInactivos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvMaestros);
            this.Name = "Maestros";
            this.Text = "Maestros";
            this.Load += new System.EventHandler(this.Maestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMaestros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblbtnMaestrosInactivos;
        private System.Windows.Forms.Label lblTitulo;
    }
}