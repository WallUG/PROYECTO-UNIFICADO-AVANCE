namespace Visual
{
    partial class FrmEditarReserva
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
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.rdbFiltrarFecha = new System.Windows.Forms.RadioButton();
            this.lblFechaHastaFiltro = new System.Windows.Forms.Label();
            this.lblFechaDesdeFiltro = new System.Windows.Forms.Label();
            this.dtpHastaFiltroEdit = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeFiltroEdit = new System.Windows.Forms.DateTimePicker();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.rdbFiltrar = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbTipoSolicitudEdicion = new System.Windows.Forms.ComboBox();
            this.lblTipoSolicitud = new System.Windows.Forms.Label();
            this.dtpFechRerservaEdicion = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicioEdicion = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFinEdicion = new System.Windows.Forms.DateTimePicker();
            this.lblFechReserva = new System.Windows.Forms.Label();
            this.nudCantPersonasEdicion = new System.Windows.Forms.NumericUpDown();
            this.lblCantPersonas = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoEdicion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonasEdicion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.rdbFiltrarFecha);
            this.grpFiltro.Controls.Add(this.lblFechaHastaFiltro);
            this.grpFiltro.Controls.Add(this.lblFechaDesdeFiltro);
            this.grpFiltro.Controls.Add(this.dtpHastaFiltroEdit);
            this.grpFiltro.Controls.Add(this.dtpDesdeFiltroEdit);
            this.grpFiltro.Controls.Add(this.cmbHasta);
            this.grpFiltro.Controls.Add(this.cmbDesde);
            this.grpFiltro.Controls.Add(this.lblHasta);
            this.grpFiltro.Controls.Add(this.btnAplicarFiltro);
            this.grpFiltro.Controls.Add(this.lblDesde);
            this.grpFiltro.Controls.Add(this.rdbFiltrar);
            this.grpFiltro.Controls.Add(this.rdbTodos);
            this.grpFiltro.Location = new System.Drawing.Point(341, 15);
            this.grpFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltro.Size = new System.Drawing.Size(605, 207);
            this.grpFiltro.TabIndex = 44;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Lista de Busqueda";
            // 
            // rdbFiltrarFecha
            // 
            this.rdbFiltrarFecha.AutoSize = true;
            this.rdbFiltrarFecha.Location = new System.Drawing.Point(9, 83);
            this.rdbFiltrarFecha.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFiltrarFecha.Name = "rdbFiltrarFecha";
            this.rdbFiltrarFecha.Size = new System.Drawing.Size(125, 20);
            this.rdbFiltrarFecha.TabIndex = 33;
            this.rdbFiltrarFecha.Text = "Filtrar por Fecha";
            this.rdbFiltrarFecha.UseVisualStyleBackColor = true;
            this.rdbFiltrarFecha.CheckedChanged += new System.EventHandler(this.rdbFiltrarFecha_CheckedChanged);
            // 
            // lblFechaHastaFiltro
            // 
            this.lblFechaHastaFiltro.AutoSize = true;
            this.lblFechaHastaFiltro.Location = new System.Drawing.Point(205, 165);
            this.lblFechaHastaFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaFiltro.Name = "lblFechaHastaFiltro";
            this.lblFechaHastaFiltro.Size = new System.Drawing.Size(46, 16);
            this.lblFechaHastaFiltro.TabIndex = 32;
            this.lblFechaHastaFiltro.Text = "Hasta:";
            // 
            // lblFechaDesdeFiltro
            // 
            this.lblFechaDesdeFiltro.AutoSize = true;
            this.lblFechaDesdeFiltro.Location = new System.Drawing.Point(9, 165);
            this.lblFechaDesdeFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeFiltro.Name = "lblFechaDesdeFiltro";
            this.lblFechaDesdeFiltro.Size = new System.Drawing.Size(51, 16);
            this.lblFechaDesdeFiltro.TabIndex = 31;
            this.lblFechaDesdeFiltro.Text = "Desde:";
            // 
            // dtpHastaFiltroEdit
            // 
            this.dtpHastaFiltroEdit.Enabled = false;
            this.dtpHastaFiltroEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaFiltroEdit.Location = new System.Drawing.Point(264, 160);
            this.dtpHastaFiltroEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHastaFiltroEdit.Name = "dtpHastaFiltroEdit";
            this.dtpHastaFiltroEdit.Size = new System.Drawing.Size(116, 22);
            this.dtpHastaFiltroEdit.TabIndex = 30;
            // 
            // dtpDesdeFiltroEdit
            // 
            this.dtpDesdeFiltroEdit.Enabled = false;
            this.dtpDesdeFiltroEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeFiltroEdit.Location = new System.Drawing.Point(68, 160);
            this.dtpDesdeFiltroEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesdeFiltroEdit.Name = "dtpDesdeFiltroEdit";
            this.dtpDesdeFiltroEdit.Size = new System.Drawing.Size(116, 22);
            this.dtpDesdeFiltroEdit.TabIndex = 29;
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.Enabled = false;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(264, 124);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(116, 24);
            this.cmbHasta.TabIndex = 21;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.Enabled = false;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(68, 128);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(116, 24);
            this.cmbDesde.TabIndex = 20;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(205, 127);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 19;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(432, 123);
            this.btnAplicarFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(129, 31);
            this.btnAplicarFiltro.TabIndex = 15;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(9, 130);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // rdbFiltrar
            // 
            this.rdbFiltrar.AutoSize = true;
            this.rdbFiltrar.Location = new System.Drawing.Point(9, 55);
            this.rdbFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFiltrar.Name = "rdbFiltrar";
            this.rdbFiltrar.Size = new System.Drawing.Size(131, 20);
            this.rdbFiltrar.TabIndex = 1;
            this.rdbFiltrar.TabStop = true;
            this.rdbFiltrar.Text = "Filtrar por Codigo";
            this.rdbFiltrar.UseVisualStyleBackColor = true;
            this.rdbFiltrar.CheckedChanged += new System.EventHandler(this.rdbFiltrar_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(9, 27);
            this.rdbTodos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(79, 20);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Ver todo";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNro,
            this.colCliente,
            this.colNombreEvento,
            this.colTipoEvento,
            this.colCantPersonas,
            this.colFechaReserva,
            this.colHoraInicio,
            this.colHoraFin});
            this.dgvReservas.Location = new System.Drawing.Point(125, 245);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(1119, 185);
            this.dgvReservas.TabIndex = 22;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo Reserva";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 125;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 125;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 125;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.MinimumWidth = 6;
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            this.colNombreEvento.Width = 125;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.MinimumWidth = 6;
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            this.colTipoEvento.Width = 125;
            // 
            // colCantPersonas
            // 
            this.colCantPersonas.HeaderText = "Cantidad de Personas";
            this.colCantPersonas.MinimumWidth = 6;
            this.colCantPersonas.Name = "colCantPersonas";
            this.colCantPersonas.ReadOnly = true;
            this.colCantPersonas.Width = 125;
            // 
            // colFechaReserva
            // 
            this.colFechaReserva.HeaderText = "Fecha Reserva";
            this.colFechaReserva.MinimumWidth = 6;
            this.colFechaReserva.Name = "colFechaReserva";
            this.colFechaReserva.ReadOnly = true;
            this.colFechaReserva.Width = 125;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.HeaderText = "Hora Inicio";
            this.colHoraInicio.MinimumWidth = 6;
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            this.colHoraInicio.Width = 125;
            // 
            // colHoraFin
            // 
            this.colHoraFin.HeaderText = "Hora fin";
            this.colHoraFin.MinimumWidth = 6;
            this.colHoraFin.Name = "colHoraFin";
            this.colHoraFin.ReadOnly = true;
            this.colHoraFin.Width = 125;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(570, 438);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 31);
            this.btnImprimir.TabIndex = 46;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbTipoSolicitudEdicion
            // 
            this.cmbTipoSolicitudEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitudEdicion.FormattingEnabled = true;
            this.cmbTipoSolicitudEdicion.Location = new System.Drawing.Point(617, 87);
            this.cmbTipoSolicitudEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoSolicitudEdicion.Name = "cmbTipoSolicitudEdicion";
            this.cmbTipoSolicitudEdicion.Size = new System.Drawing.Size(287, 24);
            this.cmbTipoSolicitudEdicion.TabIndex = 35;
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSolicitud.Location = new System.Drawing.Point(612, 60);
            this.lblTipoSolicitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(183, 24);
            this.lblTipoSolicitud.TabIndex = 33;
            this.lblTipoSolicitud.Text = "Tipo de Solicitud:";
            // 
            // dtpFechRerservaEdicion
            // 
            this.dtpFechRerservaEdicion.Location = new System.Drawing.Point(225, 97);
            this.dtpFechRerservaEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechRerservaEdicion.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpFechRerservaEdicion.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechRerservaEdicion.Name = "dtpFechRerservaEdicion";
            this.dtpFechRerservaEdicion.Size = new System.Drawing.Size(265, 22);
            this.dtpFechRerservaEdicion.TabIndex = 36;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(8, 146);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(154, 24);
            this.lblHoraInicio.TabIndex = 32;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // dtpHoraInicioEdicion
            // 
            this.dtpHoraInicioEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioEdicion.Location = new System.Drawing.Point(231, 144);
            this.dtpHoraInicioEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraInicioEdicion.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraInicioEdicion.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicioEdicion.Name = "dtpHoraInicioEdicion";
            this.dtpHoraInicioEdicion.Size = new System.Drawing.Size(84, 22);
            this.dtpHoraInicioEdicion.TabIndex = 37;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(8, 185);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(125, 24);
            this.lblHoraFin.TabIndex = 31;
            this.lblHoraFin.Text = "Hora de fin:";
            // 
            // dtpHoraFinEdicion
            // 
            this.dtpHoraFinEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinEdicion.Location = new System.Drawing.Point(231, 183);
            this.dtpHoraFinEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraFinEdicion.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFinEdicion.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFinEdicion.Name = "dtpHoraFinEdicion";
            this.dtpHoraFinEdicion.Size = new System.Drawing.Size(84, 22);
            this.dtpHoraFinEdicion.TabIndex = 38;
            // 
            // lblFechReserva
            // 
            this.lblFechReserva.AutoSize = true;
            this.lblFechReserva.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechReserva.Location = new System.Drawing.Point(4, 97);
            this.lblFechReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechReserva.Name = "lblFechReserva";
            this.lblFechReserva.Size = new System.Drawing.Size(208, 24);
            this.lblFechReserva.TabIndex = 30;
            this.lblFechReserva.Text = "Fecha de la reserva:";
            // 
            // nudCantPersonasEdicion
            // 
            this.nudCantPersonasEdicion.Location = new System.Drawing.Point(868, 18);
            this.nudCantPersonasEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantPersonasEdicion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantPersonasEdicion.Name = "nudCantPersonasEdicion";
            this.nudCantPersonasEdicion.Size = new System.Drawing.Size(55, 22);
            this.nudCantPersonasEdicion.TabIndex = 39;
            this.nudCantPersonasEdicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantPersonas
            // 
            this.lblCantPersonas.AutoSize = true;
            this.lblCantPersonas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPersonas.Location = new System.Drawing.Point(612, 20);
            this.lblCantPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantPersonas.Name = "lblCantPersonas";
            this.lblCantPersonas.Size = new System.Drawing.Size(233, 24);
            this.lblCantPersonas.TabIndex = 28;
            this.lblCantPersonas.Text = "Cantidad de Personas:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(693, 162);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(152, 64);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Guardar cambios";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 37);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(172, 24);
            this.lblCodigo.TabIndex = 44;
            this.lblCodigo.Text = "Codigo Reserva:";
            // 
            // txtCodigoEdicion
            // 
            this.txtCodigoEdicion.Location = new System.Drawing.Point(221, 37);
            this.txtCodigoEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEdicion.Name = "txtCodigoEdicion";
            this.txtCodigoEdicion.ReadOnly = true;
            this.txtCodigoEdicion.Size = new System.Drawing.Size(265, 22);
            this.txtCodigoEdicion.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoEdicion);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.lblCantPersonas);
            this.groupBox1.Controls.Add(this.nudCantPersonasEdicion);
            this.groupBox1.Controls.Add(this.lblFechReserva);
            this.groupBox1.Controls.Add(this.dtpHoraFinEdicion);
            this.groupBox1.Controls.Add(this.lblHoraFin);
            this.groupBox1.Controls.Add(this.dtpHoraInicioEdicion);
            this.groupBox1.Controls.Add(this.lblHoraInicio);
            this.groupBox1.Controls.Add(this.dtpFechRerservaEdicion);
            this.groupBox1.Controls.Add(this.lblTipoSolicitud);
            this.groupBox1.Controls.Add(this.cmbTipoSolicitudEdicion);
            this.groupBox1.Location = new System.Drawing.Point(135, 495);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1065, 265);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA RESERVA SELECCIONADA";
            // 
            // FrmEditarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 943);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.grpFiltro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmEditarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarReserva";
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonasEdicion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.RadioButton rdbFiltrar;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin;
        private System.Windows.Forms.Label lblFechaHastaFiltro;
        private System.Windows.Forms.Label lblFechaDesdeFiltro;
        private System.Windows.Forms.DateTimePicker dtpHastaFiltroEdit;
        private System.Windows.Forms.DateTimePicker dtpDesdeFiltroEdit;
        private System.Windows.Forms.RadioButton rdbFiltrarFecha;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbTipoSolicitudEdicion;
        private System.Windows.Forms.Label lblTipoSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechRerservaEdicion;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioEdicion;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFinEdicion;
        private System.Windows.Forms.Label lblFechReserva;
        private System.Windows.Forms.NumericUpDown nudCantPersonasEdicion;
        private System.Windows.Forms.Label lblCantPersonas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoEdicion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}