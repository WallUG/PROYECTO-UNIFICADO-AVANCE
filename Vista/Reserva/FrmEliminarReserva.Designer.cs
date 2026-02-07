namespace Vista
{
    partial class FrmEliminarReserva
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
            this.txtTituloVentana = new System.Windows.Forms.Label();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpHastaFiltro = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeFiltro = new System.Windows.Forms.DateTimePicker();
            this.rdbFiltrarFecha = new System.Windows.Forms.RadioButton();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.rdbFiltrar = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTituloVentana
            // 
            this.txtTituloVentana.AutoSize = true;
            this.txtTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloVentana.Location = new System.Drawing.Point(515, 26);
            this.txtTituloVentana.Name = "txtTituloVentana";
            this.txtTituloVentana.Size = new System.Drawing.Size(234, 29);
            this.txtTituloVentana.TabIndex = 17;
            this.txtTituloVentana.Text = "Listas de Reservas";
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.lblFechaHasta);
            this.grpFiltro.Controls.Add(this.lblFechaDesde);
            this.grpFiltro.Controls.Add(this.dtpHastaFiltro);
            this.grpFiltro.Controls.Add(this.dtpDesdeFiltro);
            this.grpFiltro.Controls.Add(this.rdbFiltrarFecha);
            this.grpFiltro.Controls.Add(this.cmbHasta);
            this.grpFiltro.Controls.Add(this.cmbDesde);
            this.grpFiltro.Controls.Add(this.lblHasta);
            this.grpFiltro.Controls.Add(this.btnAplicarFiltro);
            this.grpFiltro.Controls.Add(this.lblDesde);
            this.grpFiltro.Controls.Add(this.rdbFiltrar);
            this.grpFiltro.Controls.Add(this.rdbTodos);
            this.grpFiltro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltro.Location = new System.Drawing.Point(268, 82);
            this.grpFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltro.Size = new System.Drawing.Size(695, 207);
            this.grpFiltro.TabIndex = 18;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Lista de Busqueda";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(235, 166);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(65, 25);
            this.lblFechaHasta.TabIndex = 29;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(8, 171);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(70, 25);
            this.lblFechaDesde.TabIndex = 28;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // dtpHastaFiltro
            // 
            this.dtpHastaFiltro.Enabled = false;
            this.dtpHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaFiltro.Location = new System.Drawing.Point(325, 165);
            this.dtpHastaFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHastaFiltro.Name = "dtpHastaFiltro";
            this.dtpHastaFiltro.Size = new System.Drawing.Size(116, 33);
            this.dtpHastaFiltro.TabIndex = 27;
            // 
            // dtpDesdeFiltro
            // 
            this.dtpDesdeFiltro.Enabled = false;
            this.dtpDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeFiltro.Location = new System.Drawing.Point(93, 166);
            this.dtpDesdeFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesdeFiltro.Name = "dtpDesdeFiltro";
            this.dtpDesdeFiltro.Size = new System.Drawing.Size(116, 33);
            this.dtpDesdeFiltro.TabIndex = 26;
            // 
            // rdbFiltrarFecha
            // 
            this.rdbFiltrarFecha.AutoSize = true;
            this.rdbFiltrarFecha.Location = new System.Drawing.Point(9, 89);
            this.rdbFiltrarFecha.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFiltrarFecha.Name = "rdbFiltrarFecha";
            this.rdbFiltrarFecha.Size = new System.Drawing.Size(175, 29);
            this.rdbFiltrarFecha.TabIndex = 25;
            this.rdbFiltrarFecha.Text = "Filtrar por Fecha";
            this.rdbFiltrarFecha.UseVisualStyleBackColor = true;
            this.rdbFiltrarFecha.CheckedChanged += new System.EventHandler(this.rdbFiltrarFecha_CheckedChanged);
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.Enabled = false;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(325, 124);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(116, 33);
            this.cmbHasta.TabIndex = 21;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.Enabled = false;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(93, 126);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(116, 33);
            this.cmbDesde.TabIndex = 20;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(235, 127);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(65, 25);
            this.lblHasta.TabIndex = 19;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltro.Location = new System.Drawing.Point(500, 114);
            this.btnAplicarFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(163, 57);
            this.btnAplicarFiltro.TabIndex = 15;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(9, 130);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(70, 25);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // rdbFiltrar
            // 
            this.rdbFiltrar.AutoSize = true;
            this.rdbFiltrar.Location = new System.Drawing.Point(9, 60);
            this.rdbFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFiltrar.Name = "rdbFiltrar";
            this.rdbFiltrar.Size = new System.Drawing.Size(190, 29);
            this.rdbFiltrar.TabIndex = 1;
            this.rdbFiltrar.TabStop = true;
            this.rdbFiltrar.Text = "Filtrar por Codigo";
            this.rdbFiltrar.UseVisualStyleBackColor = true;
            this.rdbFiltrar.CheckedChanged += new System.EventHandler(this.rdbFiltrar_CheckedChanged);
            this.rdbFiltrar.Enter += new System.EventHandler(this.rdbFiltrar_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(9, 27);
            this.rdbTodos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(110, 29);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Ver todo";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            this.rdbTodos.Enter += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1052, 548);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 39);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colCodigo,
            this.colCliente,
            this.colNombreEvento,
            this.colTipoEvento,
            this.colCantPersonas,
            this.colFechaReserva,
            this.colHoraInicio,
            this.colHoraFin});
            this.dgvReservas.Location = new System.Drawing.Point(79, 343);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(1119, 185);
            this.dgvReservas.TabIndex = 19;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 125;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo Reserva";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 125;
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
            // FrmEliminarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 778);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.txtTituloVentana);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmEliminarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarReserva";
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloVentana;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.RadioButton rdbFiltrar;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHastaFiltro;
        private System.Windows.Forms.DateTimePicker dtpDesdeFiltro;
        private System.Windows.Forms.RadioButton rdbFiltrarFecha;
    }
}