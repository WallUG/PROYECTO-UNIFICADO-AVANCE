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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.cmbNombEvento = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdEvento = new System.Windows.Forms.ComboBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(55, 127);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Cliente:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(53, 68);
            this.lblNombreEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(203, 24);
            this.lblNombreEvento.TabIndex = 2;
            this.lblNombreEvento.Text = "Nombre del Evento:";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento.Location = new System.Drawing.Point(53, 192);
            this.lblTipoEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(162, 24);
            this.lblTipoEvento.TabIndex = 3;
            this.lblTipoEvento.Text = "Tipo de Evento:";
            // 
            // lblCantPersonas
            // 
            this.lblCantPersonas.AutoSize = true;
            this.lblCantPersonas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPersonas.Location = new System.Drawing.Point(600, 68);
            this.lblCantPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantPersonas.Name = "lblCantPersonas";
            this.lblCantPersonas.Size = new System.Drawing.Size(233, 24);
            this.lblCantPersonas.TabIndex = 4;
            this.lblCantPersonas.Text = "Cantidad de Personas:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(600, 127);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(347, 24);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion del Evento (opcional):";
            // 
            // lblFechReserva
            // 
            this.lblFechReserva.AutoSize = true;
            this.lblFechReserva.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechReserva.Location = new System.Drawing.Point(53, 268);
            this.lblFechReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechReserva.Name = "lblFechReserva";
            this.lblFechReserva.Size = new System.Drawing.Size(208, 24);
            this.lblFechReserva.TabIndex = 6;
            this.lblFechReserva.Text = "Fecha de la reserva:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(53, 356);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(125, 24);
            this.lblHoraFin.TabIndex = 7;
            this.lblHoraFin.Text = "Hora de fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(53, 318);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(154, 24);
            this.lblHoraInicio.TabIndex = 8;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSolicitud.Location = new System.Drawing.Point(590, 278);
            this.lblTipoSolicitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(183, 24);
            this.lblTipoSolicitud.TabIndex = 9;
            this.lblTipoSolicitud.Text = "Tipo de Solicitud:";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(276, 190);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoEvento.TabIndex = 13;
            // 
            // cmbTipoSolicitud
            // 
            this.cmbTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitud.FormattingEnabled = true;
            this.cmbTipoSolicitud.Location = new System.Drawing.Point(775, 278);
            this.cmbTipoSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            this.cmbTipoSolicitud.Size = new System.Drawing.Size(199, 24);
            this.cmbTipoSolicitud.TabIndex = 14;
            // 
            // dtpFechRerserva
            // 
            this.dtpFechRerserva.Location = new System.Drawing.Point(276, 268);
            this.dtpFechRerserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechRerserva.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpFechRerserva.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechRerserva.Name = "dtpFechRerserva";
            this.dtpFechRerserva.Size = new System.Drawing.Size(265, 22);
            this.dtpFechRerserva.TabIndex = 15;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(276, 315);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraInicio.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraInicio.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(84, 22);
            this.dtpHoraInicio.TabIndex = 16;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(276, 354);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraFin.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFin.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(84, 22);
            this.dtpHoraFin.TabIndex = 17;
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(856, 66);
            this.nudCantPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(55, 22);
            this.nudCantPersonas.TabIndex = 18;
            this.nudCantPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(441, 414);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 37);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "REGISTRO DE RESERVA PARA EVENTOS";
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(59, 513);
            this.txtcontenido.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontenido.Multiline = true;
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(935, 212);
            this.txtcontenido.TabIndex = 21;
            // 
            // cmbNombEvento
            // 
            this.cmbNombEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombEvento.FormattingEnabled = true;
            this.cmbNombEvento.Location = new System.Drawing.Point(283, 68);
            this.cmbNombEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombEvento.Name = "cmbNombEvento";
            this.cmbNombEvento.Size = new System.Drawing.Size(163, 24);
            this.cmbNombEvento.TabIndex = 22;
            this.cmbNombEvento.SelectedIndexChanged += new System.EventHandler(this.cmbNombreEvento_SelectedIndexChanged);
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(278, 127);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(265, 24);
            this.cmbClientes.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Id Evento:";
            // 
            // cmbIdEvento
            // 
            this.cmbIdEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdEvento.Enabled = false;
            this.cmbIdEvento.FormattingEnabled = true;
            this.cmbIdEvento.Location = new System.Drawing.Point(709, 223);
            this.cmbIdEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdEvento.Name = "cmbIdEvento";
            this.cmbIdEvento.Size = new System.Drawing.Size(265, 24);
            this.cmbIdEvento.TabIndex = 26;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(604, 163);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(368, 22);
            this.txtDescripcionEvento.TabIndex = 27;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Location = new System.Drawing.Point(454, 58);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(125, 37);
            this.btnSeleccionar.TabIndex = 28;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_click);
            // 
            // FrmRegistroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 782);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.cmbIdEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.cmbNombEvento);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudCantPersonas);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFechRerserva);
            this.Controls.Add(this.cmbTipoSolicitud);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.lblTipoSolicitud);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblFechReserva);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantPersonas);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.lblNombreEvento);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegistroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Reserva de Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontenido;
        private System.Windows.Forms.ComboBox cmbNombEvento;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}

