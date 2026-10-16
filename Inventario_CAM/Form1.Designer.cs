namespace Inventario_CAM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnEditar1 = new System.Windows.Forms.Button();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.lblInventario1 = new System.Windows.Forms.Label();
            this.dgvInventarioNormal = new System.Windows.Forms.DataGridView();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnEditar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.lblInventario2 = new System.Windows.Forms.Label();
            this.dgvInventarioMayor = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblbtnNumInv = new System.Windows.Forms.Label();
            this.lblEliminados = new System.Windows.Forms.Label();
            this.panelseccion = new System.Windows.Forms.Panel();
            this.btnNuevomaestro = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelbtnNormal = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.lbloo = new System.Windows.Forms.Label();
            this.lblBuscarpor = new System.Windows.Forms.Label();
            this.lblo = new System.Windows.Forms.Label();
            this.lblbtnMaestro = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFiltrarMaestro = new System.Windows.Forms.Button();
            this.CBMPROFESOR = new System.Windows.Forms.ComboBox();
            this.panelbtnMuchos = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMayor)).BeginInit();
            this.panelseccion.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelbtnNormal.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelbtnMuchos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.Location = new System.Drawing.Point(174, 54);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(118, 43);
            this.btnEliminar1.TabIndex = 23;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = false;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar1.Location = new System.Drawing.Point(330, 12);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(118, 43);
            this.btnEditar1.TabIndex = 22;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.UseVisualStyleBackColor = false;
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar1.Location = new System.Drawing.Point(17, 12);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(118, 43);
            this.btnAgregar1.TabIndex = 21;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = false;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // lblInventario1
            // 
            this.lblInventario1.AutoSize = true;
            this.lblInventario1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario1.Location = new System.Drawing.Point(3, 15);
            this.lblInventario1.Name = "lblInventario1";
            this.lblInventario1.Size = new System.Drawing.Size(256, 22);
            this.lblInventario1.TabIndex = 24;
            this.lblInventario1.Text = "Inventario por sólo una unidad";
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
            this.dgvInventarioNormal.Size = new System.Drawing.Size(965, 450);
            this.dgvInventarioNormal.TabIndex = 20;
            this.dgvInventarioNormal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarioNormal_CellClick);
            this.dgvInventarioNormal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarioNormal_CellContentClick);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar2.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar2.Location = new System.Drawing.Point(176, 54);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(118, 43);
            this.btnEliminar2.TabIndex = 27;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnEditar2
            // 
            this.btnEditar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar2.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar2.Location = new System.Drawing.Point(338, 12);
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(118, 43);
            this.btnEditar2.TabIndex = 26;
            this.btnEditar2.Text = "Editar";
            this.btnEditar2.UseVisualStyleBackColor = false;
            this.btnEditar2.Click += new System.EventHandler(this.btnEditar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(118, 43);
            this.btnAgregar2.TabIndex = 25;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // lblInventario2
            // 
            this.lblInventario2.AutoSize = true;
            this.lblInventario2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario2.Location = new System.Drawing.Point(971, 15);
            this.lblInventario2.Name = "lblInventario2";
            this.lblInventario2.Size = new System.Drawing.Size(281, 22);
            this.lblInventario2.TabIndex = 28;
            this.lblInventario2.Text = "Inventario por más de una unidad";
            // 
            // dgvInventarioMayor
            // 
            this.dgvInventarioMayor.AllowUserToAddRows = false;
            this.dgvInventarioMayor.AllowUserToResizeColumns = false;
            this.dgvInventarioMayor.AllowUserToResizeRows = false;
            this.dgvInventarioMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioMayor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventarioMayor.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvInventarioMayor.Location = new System.Drawing.Point(0, 0);
            this.dgvInventarioMayor.MultiSelect = false;
            this.dgvInventarioMayor.Name = "dgvInventarioMayor";
            this.dgvInventarioMayor.ReadOnly = true;
            this.dgvInventarioMayor.RowHeadersVisible = false;
            this.dgvInventarioMayor.RowHeadersWidth = 51;
            this.dgvInventarioMayor.RowTemplate.Height = 24;
            this.dgvInventarioMayor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioMayor.Size = new System.Drawing.Size(963, 450);
            this.dgvInventarioMayor.TabIndex = 29;
            this.dgvInventarioMayor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarioMayor_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(149, 62);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 30);
            this.txtBuscar.TabIndex = 30;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(206, 31);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(86, 25);
            this.lblBuscar.TabIndex = 31;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(496, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 43);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblbtnNumInv
            // 
            this.lblbtnNumInv.AutoSize = true;
            this.lblbtnNumInv.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnNumInv.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblbtnNumInv.Location = new System.Drawing.Point(3, 54);
            this.lblbtnNumInv.Name = "lblbtnNumInv";
            this.lblbtnNumInv.Size = new System.Drawing.Size(169, 29);
            this.lblbtnNumInv.TabIndex = 33;
            this.lblbtnNumInv.Text = "Número de inventario";
            this.lblbtnNumInv.Click += new System.EventHandler(this.lblbtnNumInv_Click);
            // 
            // lblEliminados
            // 
            this.lblEliminados.AutoSize = true;
            this.lblEliminados.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminados.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEliminados.Location = new System.Drawing.Point(103, 101);
            this.lblEliminados.Name = "lblEliminados";
            this.lblEliminados.Size = new System.Drawing.Size(187, 29);
            this.lblEliminados.TabIndex = 41;
            this.lblEliminados.Text = "Ver registros eliminados";
            this.lblEliminados.Click += new System.EventHandler(this.lblEliminados_Click);
            // 
            // panelseccion
            // 
            this.panelseccion.Controls.Add(this.btnNuevomaestro);
            this.panelseccion.Controls.Add(this.btnAyuda);
            this.panelseccion.Controls.Add(this.cbSeccion);
            this.panelseccion.Controls.Add(this.lblSeccion);
            this.panelseccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelseccion.Location = new System.Drawing.Point(0, 0);
            this.panelseccion.Name = "panelseccion";
            this.panelseccion.Size = new System.Drawing.Size(1777, 119);
            this.panelseccion.TabIndex = 42;
            // 
            // btnNuevomaestro
            // 
            this.btnNuevomaestro.BackColor = System.Drawing.Color.Plum;
            this.btnNuevomaestro.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevomaestro.Location = new System.Drawing.Point(1532, 29);
            this.btnNuevomaestro.Name = "btnNuevomaestro";
            this.btnNuevomaestro.Size = new System.Drawing.Size(136, 72);
            this.btnNuevomaestro.TabIndex = 49;
            this.btnNuevomaestro.Text = "Detalle maestro";
            this.btnNuevomaestro.UseVisualStyleBackColor = false;
            this.btnNuevomaestro.Click += new System.EventHandler(this.btnNuevomaestro_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::Inventario_CAM.Properties.Resources.ayuda;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyuda.Location = new System.Drawing.Point(1684, 37);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(62, 56);
            this.btnAyuda.TabIndex = 49;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // cbSeccion
            // 
            this.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeccion.Items.AddRange(new object[] {
            "Computo",
            "Maquinaria",
            "Mobiliario y oficina",
            "Taller y laboratorio"});
            this.cbSeccion.Location = new System.Drawing.Point(290, 83);
            this.cbSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(345, 33);
            this.cbSeccion.TabIndex = 3;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.cbSeccion_SelectedIndexChanged);
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(287, 46);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(113, 25);
            this.lblSeccion.TabIndex = 4;
            this.lblSeccion.Text = "Secciones";
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.Controls.Add(this.lblInventario1);
            this.panelTitulo.Controls.Add(this.lblInventario2);
            this.panelTitulo.Location = new System.Drawing.Point(89, 242);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1416, 45);
            this.panelTitulo.TabIndex = 43;
            // 
            // panelbtnNormal
            // 
            this.panelbtnNormal.Controls.Add(this.btnAgregar1);
            this.panelbtnNormal.Controls.Add(this.btnEditar1);
            this.panelbtnNormal.Controls.Add(this.btnEliminar1);
            this.panelbtnNormal.Location = new System.Drawing.Point(299, 749);
            this.panelbtnNormal.Name = "panelbtnNormal";
            this.panelbtnNormal.Size = new System.Drawing.Size(465, 100);
            this.panelbtnNormal.TabIndex = 44;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.lbloo);
            this.panelBuscar.Controls.Add(this.lblBuscarpor);
            this.panelBuscar.Controls.Add(this.lblo);
            this.panelBuscar.Controls.Add(this.lblbtnMaestro);
            this.panelBuscar.Controls.Add(this.lblbtnNumInv);
            this.panelBuscar.Controls.Add(this.lblEliminados);
            this.panelBuscar.Location = new System.Drawing.Point(848, 749);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(372, 136);
            this.panelBuscar.TabIndex = 45;
            // 
            // lbloo
            // 
            this.lbloo.AutoSize = true;
            this.lbloo.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloo.Location = new System.Drawing.Point(204, 54);
            this.lbloo.Name = "lbloo";
            this.lbloo.Size = new System.Drawing.Size(22, 29);
            this.lbloo.TabIndex = 44;
            this.lbloo.Text = "o";
            // 
            // lblBuscarpor
            // 
            this.lblBuscarpor.AutoSize = true;
            this.lblBuscarpor.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarpor.Location = new System.Drawing.Point(148, 24);
            this.lblBuscarpor.Name = "lblBuscarpor";
            this.lblBuscarpor.Size = new System.Drawing.Size(88, 19);
            this.lblBuscarpor.TabIndex = 29;
            this.lblBuscarpor.Text = "Buscar por:";
            // 
            // lblo
            // 
            this.lblo.AutoSize = true;
            this.lblo.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblo.Location = new System.Drawing.Point(60, 101);
            this.lblo.Name = "lblo";
            this.lblo.Size = new System.Drawing.Size(22, 29);
            this.lblo.TabIndex = 42;
            this.lblo.Text = "o";
            // 
            // lblbtnMaestro
            // 
            this.lblbtnMaestro.AutoSize = true;
            this.lblbtnMaestro.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnMaestro.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblbtnMaestro.Location = new System.Drawing.Point(242, 54);
            this.lblbtnMaestro.Name = "lblbtnMaestro";
            this.lblbtnMaestro.Size = new System.Drawing.Size(72, 29);
            this.lblbtnMaestro.TabIndex = 43;
            this.lblbtnMaestro.Text = "Maestro";
            this.lblbtnMaestro.Click += new System.EventHandler(this.lblbtnMaestro_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFiltrarMaestro);
            this.panel4.Controls.Add(this.lblBuscar);
            this.panel4.Controls.Add(this.CBMPROFESOR);
            this.panel4.Controls.Add(this.txtBuscar);
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Location = new System.Drawing.Point(561, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 111);
            this.panel4.TabIndex = 46;
            // 
            // btnFiltrarMaestro
            // 
            this.btnFiltrarMaestro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFiltrarMaestro.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarMaestro.Location = new System.Drawing.Point(496, 49);
            this.btnFiltrarMaestro.Name = "btnFiltrarMaestro";
            this.btnFiltrarMaestro.Size = new System.Drawing.Size(118, 43);
            this.btnFiltrarMaestro.TabIndex = 33;
            this.btnFiltrarMaestro.Text = "Filtrar";
            this.btnFiltrarMaestro.UseVisualStyleBackColor = false;
            this.btnFiltrarMaestro.Click += new System.EventHandler(this.btnFiltrarMaestro_Click);
            // 
            // CBMPROFESOR
            // 
            this.CBMPROFESOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMPROFESOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMPROFESOR.FormattingEnabled = true;
            this.CBMPROFESOR.Location = new System.Drawing.Point(3, 62);
            this.CBMPROFESOR.Name = "CBMPROFESOR";
            this.CBMPROFESOR.Size = new System.Drawing.Size(482, 28);
            this.CBMPROFESOR.TabIndex = 50;
            // 
            // panelbtnMuchos
            // 
            this.panelbtnMuchos.Controls.Add(this.btnAgregar2);
            this.panelbtnMuchos.Controls.Add(this.btnEditar2);
            this.panelbtnMuchos.Controls.Add(this.btnEliminar2);
            this.panelbtnMuchos.Location = new System.Drawing.Point(1290, 749);
            this.panelbtnMuchos.Name = "panelbtnMuchos";
            this.panelbtnMuchos.Size = new System.Drawing.Size(465, 100);
            this.panelbtnMuchos.TabIndex = 47;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(53, 293);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvInventarioNormal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvInventarioMayor);
            this.splitContainer1.Size = new System.Drawing.Size(1932, 450);
            this.splitContainer1.SplitterDistance = 965;
            this.splitContainer1.TabIndex = 48;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Plum;
            this.btnImprimir.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1344, 164);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 43);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1777, 876);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelbtnMuchos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panelbtnNormal);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelseccion);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioMayor)).EndInit();
            this.panelseccion.ResumeLayout(false);
            this.panelseccion.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelbtnNormal.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelbtnMuchos.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnEditar1;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Label lblInventario1;
        private System.Windows.Forms.DataGridView dgvInventarioNormal;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnEditar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Label lblInventario2;
        private System.Windows.Forms.DataGridView dgvInventarioMayor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblbtnNumInv;
        private System.Windows.Forms.Label lblEliminados;
        private System.Windows.Forms.Panel panelseccion;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelbtnNormal;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelbtnMuchos;
        private System.Windows.Forms.Label lblo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnNuevomaestro;
        private System.Windows.Forms.ComboBox CBMPROFESOR;
        private System.Windows.Forms.Label lblbtnMaestro;
        private System.Windows.Forms.Button btnFiltrarMaestro;
        private System.Windows.Forms.Label lbloo;
        private System.Windows.Forms.Label lblBuscarpor;
    }
}

