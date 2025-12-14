namespace Visual
{
    partial class FrmRegistroReserva
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblCantPersonas = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechReserva = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblTipoSolicitud = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.cmbTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.dtpFechRerserva = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.nudCantPersonas = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.cmbNombEvento = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblIdEvento = new System.Windows.Forms.Label();
            this.cmbIdEvento = new System.Windows.Forms.ComboBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBoxEvento = new System.Windows.Forms.GroupBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.groupBoxFechaHora = new System.Windows.Forms.GroupBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.groupBoxEvento.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxDetalles.SuspendLayout();
            this.groupBoxFechaHora.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 35);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Cliente:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Location = new System.Drawing.Point(20, 35);
            this.lblNombreEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(104, 16);
            this.lblNombreEvento.TabIndex = 2;
            this.lblNombreEvento.Text = "Nombre Evento:";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(20, 103);
            this.lblTipoEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(83, 16);
            this.lblTipoEvento.TabIndex = 3;
            this.lblTipoEvento.Text = "Tipo Evento:";
            // 
            // lblCantPersonas
            // 
            this.lblCantPersonas.AutoSize = true;
            this.lblCantPersonas.Location = new System.Drawing.Point(20, 35);
            this.lblCantPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantPersonas.Name = "lblCantPersonas";
            this.lblCantPersonas.Size = new System.Drawing.Size(144, 16);
            this.lblCantPersonas.TabIndex = 4;
            this.lblCantPersonas.Text = "Cantidad de Personas:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 71);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(182, 16);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción Evento (opcional):";
            // 
            // lblFechReserva
            // 
            this.lblFechReserva.AutoSize = true;
            this.lblFechReserva.Location = new System.Drawing.Point(20, 38);
            this.lblFechReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechReserva.Name = "lblFechReserva";
            this.lblFechReserva.Size = new System.Drawing.Size(122, 16);
            this.lblFechReserva.TabIndex = 6;
            this.lblFechReserva.Text = "Fecha de Reserva:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(20, 106);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(80, 16);
            this.lblHoraFin.TabIndex = 7;
            this.lblHoraFin.Text = "Hora de Fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(20, 72);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(93, 16);
            this.lblHoraInicio.TabIndex = 8;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Location = new System.Drawing.Point(20, 140);
            this.lblTipoSolicitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(111, 16);
            this.lblTipoSolicitud.TabIndex = 9;
            this.lblTipoSolicitud.Text = "Tipo de Solicitud:";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(160, 100);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(400, 24);
            this.cmbTipoEvento.TabIndex = 13;
            // 
            // cmbTipoSolicitud
            // 
            this.cmbTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitud.FormattingEnabled = true;
            this.cmbTipoSolicitud.Location = new System.Drawing.Point(160, 137);
            this.cmbTipoSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            this.cmbTipoSolicitud.Size = new System.Drawing.Size(400, 24);
            this.cmbTipoSolicitud.TabIndex = 14;
            // 
            // dtpFechRerserva
            // 
            this.dtpFechRerserva.Location = new System.Drawing.Point(160, 35);
            this.dtpFechRerserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechRerserva.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpFechRerserva.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechRerserva.Name = "dtpFechRerserva";
            this.dtpFechRerserva.Size = new System.Drawing.Size(400, 22);
            this.dtpFechRerserva.TabIndex = 15;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(160, 69);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraInicio.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraInicio.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(160, 22);
            this.dtpHoraInicio.TabIndex = 16;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(160, 103);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraFin.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFin.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(160, 22);
            this.dtpHoraFin.TabIndex = 17;
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(230, 33);
            this.nudCantPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(90, 22);
            this.nudCantPersonas.TabIndex = 18;
            this.nudCantPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(426, 580);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 40);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar Reserva";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(438, 31);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Módulo de Registro de Reservas";
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(20, 31);
            this.txtcontenido.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontenido.Multiline = true;
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.ReadOnly = true;
            this.txtcontenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcontenido.Size = new System.Drawing.Size(920, 120);
            this.txtcontenido.TabIndex = 21;
            // 
            // cmbNombEvento
            // 
            this.cmbNombEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombEvento.FormattingEnabled = true;
            this.cmbNombEvento.Location = new System.Drawing.Point(160, 32);
            this.cmbNombEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombEvento.Name = "cmbNombEvento";
            this.cmbNombEvento.Size = new System.Drawing.Size(250, 24);
            this.cmbNombEvento.TabIndex = 22;
            this.cmbNombEvento.SelectedIndexChanged += new System.EventHandler(this.cmbNombreEvento_SelectedIndexChanged);
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(160, 32);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(400, 24);
            this.cmbClientes.TabIndex = 23;
            // 
            // lblIdEvento
            // 
            this.lblIdEvento.AutoSize = true;
            this.lblIdEvento.Location = new System.Drawing.Point(20, 69);
            this.lblIdEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdEvento.Name = "lblIdEvento";
            this.lblIdEvento.Size = new System.Drawing.Size(68, 16);
            this.lblIdEvento.TabIndex = 25;
            this.lblIdEvento.Text = "ID Evento:";
            // 
            // cmbIdEvento
            // 
            this.cmbIdEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdEvento.Enabled = false;
            this.cmbIdEvento.FormattingEnabled = true;
            this.cmbIdEvento.Location = new System.Drawing.Point(160, 66);
            this.cmbIdEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdEvento.Name = "cmbIdEvento";
            this.cmbIdEvento.Size = new System.Drawing.Size(250, 24);
            this.cmbIdEvento.TabIndex = 26;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(230, 68);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.ReadOnly = true;
            this.txtDescripcionEvento.Size = new System.Drawing.Size(330, 60);
            this.txtDescripcionEvento.TabIndex = 27;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(430, 30);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(130, 28);
            this.btnSeleccionar.TabIndex = 28;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_click);
            // 
            // groupBoxEvento
            // 
            this.groupBoxEvento.Controls.Add(this.lblNombreEvento);
            this.groupBoxEvento.Controls.Add(this.cmbNombEvento);
            this.groupBoxEvento.Controls.Add(this.btnSeleccionar);
            this.groupBoxEvento.Controls.Add(this.lblIdEvento);
            this.groupBoxEvento.Controls.Add(this.cmbIdEvento);
            this.groupBoxEvento.Controls.Add(this.lblTipoEvento);
            this.groupBoxEvento.Controls.Add(this.cmbTipoEvento);
            this.groupBoxEvento.Location = new System.Drawing.Point(206, 74);
            this.groupBoxEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEvento.Name = "groupBoxEvento";
            this.groupBoxEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEvento.Size = new System.Drawing.Size(580, 145);
            this.groupBoxEvento.TabIndex = 29;
            this.groupBoxEvento.TabStop = false;
            this.groupBoxEvento.Text = "Información del Evento";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.lblNombre);
            this.groupBoxCliente.Controls.Add(this.cmbClientes);
            this.groupBoxCliente.Location = new System.Drawing.Point(206, 227);
            this.groupBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCliente.Size = new System.Drawing.Size(580, 80);
            this.groupBoxCliente.TabIndex = 30;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Información del Cliente";
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.lblCantPersonas);
            this.groupBoxDetalles.Controls.Add(this.nudCantPersonas);
            this.groupBoxDetalles.Location = new System.Drawing.Point(206, 315);
            this.groupBoxDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Size = new System.Drawing.Size(580, 75);
            this.groupBoxDetalles.TabIndex = 31;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles Adicionales";
            // 
            // groupBoxFechaHora
            // 
            this.groupBoxFechaHora.Controls.Add(this.lblFechReserva);
            this.groupBoxFechaHora.Controls.Add(this.dtpFechRerserva);
            this.groupBoxFechaHora.Controls.Add(this.lblHoraInicio);
            this.groupBoxFechaHora.Controls.Add(this.dtpHoraInicio);
            this.groupBoxFechaHora.Controls.Add(this.lblHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.dtpHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.lblTipoSolicitud);
            this.groupBoxFechaHora.Controls.Add(this.cmbTipoSolicitud);
            this.groupBoxFechaHora.Location = new System.Drawing.Point(206, 398);
            this.groupBoxFechaHora.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFechaHora.Name = "groupBoxFechaHora";
            this.groupBoxFechaHora.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFechaHora.Size = new System.Drawing.Size(580, 175);
            this.groupBoxFechaHora.TabIndex = 32;
            this.groupBoxFechaHora.TabStop = false;
            this.groupBoxFechaHora.Text = "Fecha, Hora y Tipo de Solicitud";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.txtcontenido);
            this.groupBoxResultado.Location = new System.Drawing.Point(16, 630);
            this.groupBoxResultado.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResultado.Size = new System.Drawing.Size(960, 165);
            this.groupBoxResultado.TabIndex = 33;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado del Registro";
            // 
            // FrmRegistroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 811);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBoxFechaHora);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxEvento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegistroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
            this.groupBoxEvento.ResumeLayout(false);
            this.groupBoxEvento.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxDetalles.ResumeLayout(false);
            this.groupBoxDetalles.PerformLayout();
            this.groupBoxFechaHora.ResumeLayout(false);
            this.groupBoxFechaHora.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblCantPersonas;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechReserva;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblTipoSolicitud;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.ComboBox cmbTipoSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechRerserva;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.NumericUpDown nudCantPersonas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtcontenido;
        private System.Windows.Forms.ComboBox cmbNombEvento;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblIdEvento;
        private System.Windows.Forms.ComboBox cmbIdEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBoxEvento;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.GroupBox groupBoxFechaHora;
        private System.Windows.Forms.GroupBox groupBoxResultado;
    }
}

