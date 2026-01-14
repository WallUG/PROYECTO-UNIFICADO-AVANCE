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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoEdicion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFechReserva = new System.Windows.Forms.Label();
            this.dtpFechRerservaEdicion = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicioEdicion = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFinEdicion = new System.Windows.Forms.DateTimePicker();
            this.lblTipoSolicitud = new System.Windows.Forms.Label();
            this.cmbTipoSolicitudEdicion = new System.Windows.Forms.ComboBox();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(593, 182);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 52);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Guardar cambios";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.cmbHasta);
            this.grpFiltro.Controls.Add(this.cmbDesde);
            this.grpFiltro.Controls.Add(this.lblHasta);
            this.grpFiltro.Controls.Add(this.btnAplicarFiltro);
            this.grpFiltro.Controls.Add(this.lblDesde);
            this.grpFiltro.Controls.Add(this.rdbFiltrar);
            this.grpFiltro.Controls.Add(this.rdbTodos);
            this.grpFiltro.Location = new System.Drawing.Point(256, 12);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(454, 168);
            this.grpFiltro.TabIndex = 44;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Lista de Busqueda";
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.Enabled = false;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(198, 101);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(88, 21);
            this.cmbHasta.TabIndex = 21;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.Enabled = false;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(51, 104);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(88, 21);
            this.cmbDesde.TabIndex = 20;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(154, 103);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 19;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(324, 100);
            this.btnAplicarFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(97, 25);
            this.btnAplicarFiltro.TabIndex = 15;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(7, 106);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // rdbFiltrar
            // 
            this.rdbFiltrar.AutoSize = true;
            this.rdbFiltrar.Location = new System.Drawing.Point(7, 64);
            this.rdbFiltrar.Name = "rdbFiltrar";
            this.rdbFiltrar.Size = new System.Drawing.Size(104, 17);
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
            this.rdbTodos.Location = new System.Drawing.Point(7, 22);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(65, 17);
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
            this.dgvReservas.Location = new System.Drawing.Point(94, 199);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(839, 150);
            this.dgvReservas.TabIndex = 22;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo Reserva";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            // 
            // colCantPersonas
            // 
            this.colCantPersonas.HeaderText = "Cantidad de Personas";
            this.colCantPersonas.Name = "colCantPersonas";
            this.colCantPersonas.ReadOnly = true;
            // 
            // colFechaReserva
            // 
            this.colFechaReserva.HeaderText = "Fecha Reserva";
            this.colFechaReserva.Name = "colFechaReserva";
            this.colFechaReserva.ReadOnly = true;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.HeaderText = "Hora Inicio";
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            // 
            // colHoraFin
            // 
            this.colHoraFin.HeaderText = "Hora fin";
            this.colHoraFin.Name = "colHoraFin";
            this.colHoraFin.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechReserva);
            this.groupBox1.Controls.Add(this.dtpFechRerservaEdicion);
            this.groupBox1.Controls.Add(this.lblHoraInicio);
            this.groupBox1.Controls.Add(this.dtpHoraInicioEdicion);
            this.groupBox1.Controls.Add(this.lblHoraFin);
            this.groupBox1.Controls.Add(this.dtpHoraFinEdicion);
            this.groupBox1.Controls.Add(this.lblTipoSolicitud);
            this.groupBox1.Controls.Add(this.cmbTipoSolicitudEdicion);
            this.groupBox1.Controls.Add(this.txtCodigoEdicion);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(137, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 259);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA RESERVA SELECCIONADA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCodigoEdicion
            // 
            this.txtCodigoEdicion.Location = new System.Drawing.Point(166, 30);
            this.txtCodigoEdicion.Name = "txtCodigoEdicion";
            this.txtCodigoEdicion.ReadOnly = true;
            this.txtCodigoEdicion.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoEdicion.TabIndex = 45;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(139, 19);
            this.lblCodigo.TabIndex = 44;
            this.lblCodigo.Text = "Codigo Reserva:";
            // 
            // lblFechReserva
            // 
            this.lblFechReserva.AutoSize = true;
            this.lblFechReserva.Location = new System.Drawing.Point(17, 84);
            this.lblFechReserva.Name = "lblFechReserva";
            this.lblFechReserva.Size = new System.Drawing.Size(98, 13);
            this.lblFechReserva.TabIndex = 46;
            this.lblFechReserva.Text = "Fecha de Reserva:";
            // 
            // dtpFechRerservaEdicion
            // 
            this.dtpFechRerservaEdicion.Location = new System.Drawing.Point(122, 81);
            this.dtpFechRerservaEdicion.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpFechRerservaEdicion.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechRerservaEdicion.Name = "dtpFechRerservaEdicion";
            this.dtpFechRerservaEdicion.Size = new System.Drawing.Size(301, 20);
            this.dtpFechRerservaEdicion.TabIndex = 51;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(17, 111);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(76, 13);
            this.lblHoraInicio.TabIndex = 48;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // dtpHoraInicioEdicion
            // 
            this.dtpHoraInicioEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioEdicion.Location = new System.Drawing.Point(122, 109);
            this.dtpHoraInicioEdicion.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraInicioEdicion.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicioEdicion.Name = "dtpHoraInicioEdicion";
            this.dtpHoraInicioEdicion.Size = new System.Drawing.Size(121, 20);
            this.dtpHoraInicioEdicion.TabIndex = 52;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(17, 139);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(65, 13);
            this.lblHoraFin.TabIndex = 47;
            this.lblHoraFin.Text = "Hora de Fin:";
            // 
            // dtpHoraFinEdicion
            // 
            this.dtpHoraFinEdicion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinEdicion.Location = new System.Drawing.Point(122, 137);
            this.dtpHoraFinEdicion.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFinEdicion.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFinEdicion.Name = "dtpHoraFinEdicion";
            this.dtpHoraFinEdicion.Size = new System.Drawing.Size(121, 20);
            this.dtpHoraFinEdicion.TabIndex = 53;
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Location = new System.Drawing.Point(17, 167);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(89, 13);
            this.lblTipoSolicitud.TabIndex = 49;
            this.lblTipoSolicitud.Text = "Tipo de Solicitud:";
            // 
            // cmbTipoSolicitudEdicion
            // 
            this.cmbTipoSolicitudEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitudEdicion.FormattingEnabled = true;
            this.cmbTipoSolicitudEdicion.Location = new System.Drawing.Point(122, 164);
            this.cmbTipoSolicitudEdicion.Name = "cmbTipoSolicitudEdicion";
            this.cmbTipoSolicitudEdicion.Size = new System.Drawing.Size(301, 21);
            this.cmbTipoSolicitudEdicion.TabIndex = 50;
            // 
            // FrmEditarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.grpFiltro);
            this.MaximizeBox = false;
            this.Name = "FrmEditarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarReserva";
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoEdicion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFechReserva;
        private System.Windows.Forms.DateTimePicker dtpFechRerservaEdicion;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioEdicion;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFinEdicion;
        private System.Windows.Forms.Label lblTipoSolicitud;
        private System.Windows.Forms.ComboBox cmbTipoSolicitudEdicion;
    }
}