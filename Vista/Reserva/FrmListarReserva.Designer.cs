namespace Visual
{
    partial class FrmListarReserva
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtTituloVentana = new System.Windows.Forms.Label();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpHastaFiltro = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeFiltro = new System.Windows.Forms.DateTimePicker();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.rdbFiltrarFecha = new System.Windows.Forms.RadioButton();
            this.rdbFiltrar = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvReservas.Location = new System.Drawing.Point(82, 272);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(839, 150);
            this.dgvReservas.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo de Reserva";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
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
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(433, 440);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtTituloVentana
            // 
            this.txtTituloVentana.AutoSize = true;
            this.txtTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloVentana.Location = new System.Drawing.Point(429, 27);
            this.txtTituloVentana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTituloVentana.Name = "txtTituloVentana";
            this.txtTituloVentana.Size = new System.Drawing.Size(174, 24);
            this.txtTituloVentana.TabIndex = 17;
            this.txtTituloVentana.Text = "Lista de Reservas";
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.lblFechaHasta);
            this.grpFiltro.Controls.Add(this.lblFechaDesde);
            this.grpFiltro.Controls.Add(this.dtpHastaFiltro);
            this.grpFiltro.Controls.Add(this.dtpDesdeFiltro);
            this.grpFiltro.Controls.Add(this.cmbHasta);
            this.grpFiltro.Controls.Add(this.cmbDesde);
            this.grpFiltro.Controls.Add(this.lblHasta);
            this.grpFiltro.Controls.Add(this.btnAplicarFiltro);
            this.grpFiltro.Controls.Add(this.lblDesde);
            this.grpFiltro.Controls.Add(this.rdbFiltrarFecha);
            this.grpFiltro.Controls.Add(this.rdbFiltrar);
            this.grpFiltro.Controls.Add(this.rdbTodos);
            this.grpFiltro.Location = new System.Drawing.Point(257, 79);
            this.grpFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltro.Size = new System.Drawing.Size(461, 170);
            this.grpFiltro.TabIndex = 18;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtros de Búsqueda";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(154, 143);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 24;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(7, 143);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 23;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // dtpHastaFiltro
            // 
            this.dtpHastaFiltro.Enabled = false;
            this.dtpHastaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaFiltro.Location = new System.Drawing.Point(198, 139);
            this.dtpHastaFiltro.Name = "dtpHastaFiltro";
            this.dtpHastaFiltro.Size = new System.Drawing.Size(88, 20);
            this.dtpHastaFiltro.TabIndex = 22;
            // 
            // dtpDesdeFiltro
            // 
            this.dtpDesdeFiltro.Enabled = false;
            this.dtpDesdeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeFiltro.Location = new System.Drawing.Point(51, 139);
            this.dtpDesdeFiltro.Name = "dtpDesdeFiltro";
            this.dtpDesdeFiltro.Size = new System.Drawing.Size(88, 20);
            this.dtpDesdeFiltro.TabIndex = 21;
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
            // rdbFiltrarFecha
            // 
            this.rdbFiltrarFecha.AutoSize = true;
            this.rdbFiltrarFecha.Location = new System.Drawing.Point(7, 83);
            this.rdbFiltrarFecha.Name = "rdbFiltrarFecha";
            this.rdbFiltrarFecha.Size = new System.Drawing.Size(101, 17);
            this.rdbFiltrarFecha.TabIndex = 3;
            this.rdbFiltrarFecha.Text = "Filtrar por Fecha";
            this.rdbFiltrarFecha.UseVisualStyleBackColor = true;
            this.rdbFiltrarFecha.CheckedChanged += new System.EventHandler(this.rdbFiltrarFecha_CheckedChanged);
            // 
            // rdbFiltrar
            // 
            this.rdbFiltrar.AutoSize = true;
            this.rdbFiltrar.Location = new System.Drawing.Point(7, 54);
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
            // FrmListarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 537);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.txtTituloVentana);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvReservas);
            this.Name = "FrmListarReserva";
            this.Text = "Lista de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin;
        private System.Windows.Forms.Label txtTituloVentana;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHastaFiltro;
        private System.Windows.Forms.DateTimePicker dtpDesdeFiltro;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.RadioButton rdbFiltrarFecha;
        private System.Windows.Forms.RadioButton rdbFiltrar;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}