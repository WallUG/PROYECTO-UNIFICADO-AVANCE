namespace Vista
{
    partial class FrmEditarEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumEventos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarPor = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblNumEventos = new System.Windows.Forms.Label();
            this.txtNumEventos = new System.Windows.Forms.TextBox();
            this.txtCiRucCliente = new System.Windows.Forms.TextBox();
            this.lblCedulaORuc = new System.Windows.Forms.Label();
            this.gbFiltrarPor = new System.Windows.Forms.GroupBox();
            this.rdbNumEventos = new System.Windows.Forms.RadioButton();
            this.rdbCedulaORuc = new System.Windows.Forms.RadioButton();
            this.btnActualizarListaEvento = new System.Windows.Forms.Button();
            this.gbEditarEvento = new System.Windows.Forms.GroupBox();
            this.gbTablaEvento = new System.Windows.Forms.GroupBox();
            this.btnEditarEvento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.txtNumPersonasEvento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbDireccionUbicacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbEstadoEvento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.gbBuscarPor.SuspendLayout();
            this.gbFiltrarPor.SuspendLayout();
            this.gbEditarEvento.SuspendLayout();
            this.gbTablaEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editar Eventos";
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colNumEventos,
            this.colTipoEvento,
            this.colNombreEvento,
            this.colDescripcionEvento,
            this.colNumPersonas,
            this.colDireccionEvento,
            this.colEstadoEvento});
            this.dgvEventos.Location = new System.Drawing.Point(20, 59);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.Size = new System.Drawing.Size(1113, 242);
            this.dgvEventos.TabIndex = 2;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro.";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNro.Width = 80;
            // 
            // colNumEventos
            // 
            this.colNumEventos.HeaderText = "Número Eventos";
            this.colNumEventos.MinimumWidth = 15;
            this.colNumEventos.Name = "colNumEventos";
            this.colNumEventos.ReadOnly = true;
            this.colNumEventos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumEventos.Width = 125;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.MinimumWidth = 15;
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            this.colTipoEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTipoEvento.Width = 125;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.MinimumWidth = 15;
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            this.colNombreEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNombreEvento.Width = 140;
            // 
            // colDescripcionEvento
            // 
            this.colDescripcionEvento.HeaderText = "Descripción del Evento";
            this.colDescripcionEvento.MinimumWidth = 15;
            this.colDescripcionEvento.Name = "colDescripcionEvento";
            this.colDescripcionEvento.ReadOnly = true;
            this.colDescripcionEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescripcionEvento.Width = 160;
            // 
            // colNumPersonas
            // 
            this.colNumPersonas.HeaderText = "Número de Personas";
            this.colNumPersonas.MinimumWidth = 15;
            this.colNumPersonas.Name = "colNumPersonas";
            this.colNumPersonas.ReadOnly = true;
            this.colNumPersonas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumPersonas.Width = 125;
            // 
            // colDireccionEvento
            // 
            this.colDireccionEvento.HeaderText = "Dirección/Ubicación";
            this.colDireccionEvento.MinimumWidth = 15;
            this.colDireccionEvento.Name = "colDireccionEvento";
            this.colDireccionEvento.ReadOnly = true;
            this.colDireccionEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDireccionEvento.Width = 200;
            // 
            // colEstadoEvento
            // 
            this.colEstadoEvento.HeaderText = "Estado";
            this.colEstadoEvento.MinimumWidth = 15;
            this.colEstadoEvento.Name = "colEstadoEvento";
            this.colEstadoEvento.ReadOnly = true;
            this.colEstadoEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEstadoEvento.Width = 125;
            // 
            // gbBuscarPor
            // 
            this.gbBuscarPor.Controls.Add(this.btnFiltrar);
            this.gbBuscarPor.Controls.Add(this.lblNumEventos);
            this.gbBuscarPor.Controls.Add(this.txtNumEventos);
            this.gbBuscarPor.Controls.Add(this.txtCiRucCliente);
            this.gbBuscarPor.Controls.Add(this.lblCedulaORuc);
            this.gbBuscarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarPor.Location = new System.Drawing.Point(535, 68);
            this.gbBuscarPor.Name = "gbBuscarPor";
            this.gbBuscarPor.Size = new System.Drawing.Size(442, 198);
            this.gbBuscarPor.TabIndex = 31;
            this.gbBuscarPor.TabStop = false;
            this.gbBuscarPor.Text = "Buscar por:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Blue;
            this.btnFiltrar.Location = new System.Drawing.Point(163, 129);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(139, 46);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblNumEventos
            // 
            this.lblNumEventos.AutoSize = true;
            this.lblNumEventos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEventos.Location = new System.Drawing.Point(20, 43);
            this.lblNumEventos.Name = "lblNumEventos";
            this.lblNumEventos.Size = new System.Drawing.Size(189, 23);
            this.lblNumEventos.TabIndex = 6;
            this.lblNumEventos.Text = "Número de Eventos:";
            // 
            // txtNumEventos
            // 
            this.txtNumEventos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEventos.Location = new System.Drawing.Point(253, 36);
            this.txtNumEventos.Name = "txtNumEventos";
            this.txtNumEventos.Size = new System.Drawing.Size(88, 30);
            this.txtNumEventos.TabIndex = 7;
            // 
            // txtCiRucCliente
            // 
            this.txtCiRucCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiRucCliente.Location = new System.Drawing.Point(253, 81);
            this.txtCiRucCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiRucCliente.MaxLength = 13;
            this.txtCiRucCliente.Name = "txtCiRucCliente";
            this.txtCiRucCliente.Size = new System.Drawing.Size(160, 30);
            this.txtCiRucCliente.TabIndex = 22;
            // 
            // lblCedulaORuc
            // 
            this.lblCedulaORuc.AutoSize = true;
            this.lblCedulaORuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaORuc.ForeColor = System.Drawing.Color.Black;
            this.lblCedulaORuc.Location = new System.Drawing.Point(20, 84);
            this.lblCedulaORuc.Name = "lblCedulaORuc";
            this.lblCedulaORuc.Size = new System.Drawing.Size(141, 23);
            this.lblCedulaORuc.TabIndex = 21;
            this.lblCedulaORuc.Text = "Cédula o RUC:";
            // 
            // gbFiltrarPor
            // 
            this.gbFiltrarPor.Controls.Add(this.rdbNumEventos);
            this.gbFiltrarPor.Controls.Add(this.rdbCedulaORuc);
            this.gbFiltrarPor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrarPor.Location = new System.Drawing.Point(238, 68);
            this.gbFiltrarPor.Name = "gbFiltrarPor";
            this.gbFiltrarPor.Size = new System.Drawing.Size(263, 127);
            this.gbFiltrarPor.TabIndex = 30;
            this.gbFiltrarPor.TabStop = false;
            this.gbFiltrarPor.Text = "Filtrar por:";
            // 
            // rdbNumEventos
            // 
            this.rdbNumEventos.AutoSize = true;
            this.rdbNumEventos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNumEventos.Location = new System.Drawing.Point(16, 41);
            this.rdbNumEventos.Name = "rdbNumEventos";
            this.rdbNumEventos.Size = new System.Drawing.Size(204, 27);
            this.rdbNumEventos.TabIndex = 24;
            this.rdbNumEventos.TabStop = true;
            this.rdbNumEventos.Text = "Número de Eventos";
            this.rdbNumEventos.UseVisualStyleBackColor = true;
            this.rdbNumEventos.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // rdbCedulaORuc
            // 
            this.rdbCedulaORuc.AutoSize = true;
            this.rdbCedulaORuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCedulaORuc.Location = new System.Drawing.Point(16, 74);
            this.rdbCedulaORuc.Name = "rdbCedulaORuc";
            this.rdbCedulaORuc.Size = new System.Drawing.Size(156, 27);
            this.rdbCedulaORuc.TabIndex = 25;
            this.rdbCedulaORuc.TabStop = true;
            this.rdbCedulaORuc.Text = "Cédula o RUC";
            this.rdbCedulaORuc.UseVisualStyleBackColor = true;
            this.rdbCedulaORuc.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // btnActualizarListaEvento
            // 
            this.btnActualizarListaEvento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarListaEvento.ForeColor = System.Drawing.Color.Blue;
            this.btnActualizarListaEvento.Location = new System.Drawing.Point(20, 323);
            this.btnActualizarListaEvento.Name = "btnActualizarListaEvento";
            this.btnActualizarListaEvento.Size = new System.Drawing.Size(139, 46);
            this.btnActualizarListaEvento.TabIndex = 33;
            this.btnActualizarListaEvento.Text = "Actualizar";
            this.btnActualizarListaEvento.UseVisualStyleBackColor = true;
            this.btnActualizarListaEvento.Click += new System.EventHandler(this.btnActualizarListaEvento_Click);
            // 
            // gbEditarEvento
            // 
            this.gbEditarEvento.Controls.Add(this.btnGuardar);
            this.gbEditarEvento.Controls.Add(this.txtbDireccionUbicacion);
            this.gbEditarEvento.Controls.Add(this.label16);
            this.gbEditarEvento.Controls.Add(this.cmbEstadoEvento);
            this.gbEditarEvento.Controls.Add(this.label8);
            this.gbEditarEvento.Controls.Add(this.txtNumPersonasEvento);
            this.gbEditarEvento.Controls.Add(this.label7);
            this.gbEditarEvento.Controls.Add(this.txtDescripcionEvento);
            this.gbEditarEvento.Controls.Add(this.label6);
            this.gbEditarEvento.Controls.Add(this.label4);
            this.gbEditarEvento.Controls.Add(this.cmbTipoEvento);
            this.gbEditarEvento.Controls.Add(this.label5);
            this.gbEditarEvento.Controls.Add(this.txtNombreEvento);
            this.gbEditarEvento.Location = new System.Drawing.Point(27, 693);
            this.gbEditarEvento.Name = "gbEditarEvento";
            this.gbEditarEvento.Size = new System.Drawing.Size(1176, 308);
            this.gbEditarEvento.TabIndex = 34;
            this.gbEditarEvento.TabStop = false;
            this.gbEditarEvento.Text = "Editar Evento";
            // 
            // gbTablaEvento
            // 
            this.gbTablaEvento.Controls.Add(this.btnEditarEvento);
            this.gbTablaEvento.Controls.Add(this.dgvEventos);
            this.gbTablaEvento.Controls.Add(this.btnActualizarListaEvento);
            this.gbTablaEvento.Location = new System.Drawing.Point(27, 287);
            this.gbTablaEvento.Name = "gbTablaEvento";
            this.gbTablaEvento.Size = new System.Drawing.Size(1176, 391);
            this.gbTablaEvento.TabIndex = 35;
            this.gbTablaEvento.TabStop = false;
            this.gbTablaEvento.Text = "Tabla Evento";
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvento.ForeColor = System.Drawing.Color.Blue;
            this.btnEditarEvento.Location = new System.Drawing.Point(521, 323);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(139, 46);
            this.btnEditarEvento.TabIndex = 34;
            this.btnEditarEvento.Text = "Editar";
            this.btnEditarEvento.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de Evento:";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(192, 49);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(309, 27);
            this.cmbTipoEvento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre:";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvento.Location = new System.Drawing.Point(192, 130);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEvento.MaxLength = 100;
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(309, 27);
            this.txtNombreEvento.TabIndex = 13;
            // 
            // txtNumPersonasEvento
            // 
            this.txtNumPersonasEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPersonasEvento.Location = new System.Drawing.Point(744, 49);
            this.txtNumPersonasEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumPersonasEvento.MaxLength = 5000;
            this.txtNumPersonasEvento.Name = "txtNumPersonasEvento";
            this.txtNumPersonasEvento.Size = new System.Drawing.Size(120, 27);
            this.txtNumPersonasEvento.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(566, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Número de personas:";
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEvento.Location = new System.Drawing.Point(194, 171);
            this.txtDescripcionEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionEvento.MaxLength = 100;
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(307, 66);
            this.txtDescripcionEvento.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descripción:";
            // 
            // txtbDireccionUbicacion
            // 
            this.txtbDireccionUbicacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDireccionUbicacion.Location = new System.Drawing.Point(744, 97);
            this.txtbDireccionUbicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbDireccionUbicacion.MaxLength = 100;
            this.txtbDireccionUbicacion.Multiline = true;
            this.txtbDireccionUbicacion.Name = "txtbDireccionUbicacion";
            this.txtbDireccionUbicacion.Size = new System.Drawing.Size(307, 66);
            this.txtbDireccionUbicacion.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(566, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "Dirección/Ubicación:";
            // 
            // cmbEstadoEvento
            // 
            this.cmbEstadoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoEvento.FormattingEnabled = true;
            this.cmbEstadoEvento.Location = new System.Drawing.Point(742, 198);
            this.cmbEstadoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstadoEvento.Name = "cmbEstadoEvento";
            this.cmbEstadoEvento.Size = new System.Drawing.Size(309, 27);
            this.cmbEstadoEvento.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(566, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Estado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(521, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 46);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmEditarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1233, 1055);
            this.Controls.Add(this.gbTablaEvento);
            this.Controls.Add(this.gbEditarEvento);
            this.Controls.Add(this.gbBuscarPor);
            this.Controls.Add(this.gbFiltrarPor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmEditarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.gbBuscarPor.ResumeLayout(false);
            this.gbBuscarPor.PerformLayout();
            this.gbFiltrarPor.ResumeLayout(false);
            this.gbFiltrarPor.PerformLayout();
            this.gbEditarEvento.ResumeLayout(false);
            this.gbEditarEvento.PerformLayout();
            this.gbTablaEvento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoEvento;
        private System.Windows.Forms.GroupBox gbBuscarPor;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblNumEventos;
        private System.Windows.Forms.TextBox txtNumEventos;
        private System.Windows.Forms.TextBox txtCiRucCliente;
        private System.Windows.Forms.Label lblCedulaORuc;
        private System.Windows.Forms.GroupBox gbFiltrarPor;
        private System.Windows.Forms.RadioButton rdbNumEventos;
        private System.Windows.Forms.RadioButton rdbCedulaORuc;
        private System.Windows.Forms.Button btnActualizarListaEvento;
        private System.Windows.Forms.GroupBox gbEditarEvento;
        private System.Windows.Forms.GroupBox gbTablaEvento;
        private System.Windows.Forms.Button btnEditarEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.TextBox txtNumPersonasEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbDireccionUbicacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbEstadoEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
    }
}