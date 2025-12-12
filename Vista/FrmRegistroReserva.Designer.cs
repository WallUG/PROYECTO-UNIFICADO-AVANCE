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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Cliente:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(40, 106);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(166, 19);
            this.lblNombreEvento.TabIndex = 2;
            this.lblNombreEvento.Text = "Nombre del Evento:";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento.Location = new System.Drawing.Point(40, 156);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(132, 19);
            this.lblTipoEvento.TabIndex = 3;
            this.lblTipoEvento.Text = "Tipo de Evento:";
            // 
            // lblCantPersonas
            // 
            this.lblCantPersonas.AutoSize = true;
            this.lblCantPersonas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPersonas.Location = new System.Drawing.Point(450, 55);
            this.lblCantPersonas.Name = "lblCantPersonas";
            this.lblCantPersonas.Size = new System.Drawing.Size(186, 19);
            this.lblCantPersonas.TabIndex = 4;
            this.lblCantPersonas.Text = "Cantidad de Personas:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(450, 103);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(282, 19);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion del Evento (opcional):";
            // 
            // lblFechReserva
            // 
            this.lblFechReserva.AutoSize = true;
            this.lblFechReserva.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechReserva.Location = new System.Drawing.Point(40, 218);
            this.lblFechReserva.Name = "lblFechReserva";
            this.lblFechReserva.Size = new System.Drawing.Size(166, 19);
            this.lblFechReserva.TabIndex = 6;
            this.lblFechReserva.Text = "Fecha de la reserva:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(40, 289);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(101, 19);
            this.lblHoraFin.TabIndex = 7;
            this.lblHoraFin.Text = "Hora de fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(40, 258);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(125, 19);
            this.lblHoraInicio.TabIndex = 8;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSolicitud.Location = new System.Drawing.Point(450, 218);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(149, 19);
            this.lblTipoSolicitud.TabIndex = 9;
            this.lblTipoSolicitud.Text = "Tipo de Solicitud:";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(207, 154);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoEvento.TabIndex = 13;
            // 
            // cmbTipoSolicitud
            // 
            this.cmbTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSolicitud.FormattingEnabled = true;
            this.cmbTipoSolicitud.Location = new System.Drawing.Point(454, 240);
            this.cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            this.cmbTipoSolicitud.Size = new System.Drawing.Size(216, 21);
            this.cmbTipoSolicitud.TabIndex = 14;
            // 
            // dtpFechRerserva
            // 
            this.dtpFechRerserva.Location = new System.Drawing.Point(207, 218);
            this.dtpFechRerserva.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpFechRerserva.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFechRerserva.Name = "dtpFechRerserva";
            this.dtpFechRerserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechRerserva.TabIndex = 15;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(207, 256);
            this.dtpHoraInicio.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraInicio.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(64, 20);
            this.dtpHoraInicio.TabIndex = 16;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(207, 288);
            this.dtpHoraFin.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFin.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(64, 20);
            this.dtpHoraFin.TabIndex = 17;
            // 
            // nudCantPersonas
            // 
            this.nudCantPersonas.Location = new System.Drawing.Point(642, 54);
            this.nudCantPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantPersonas.Name = "nudCantPersonas";
            this.nudCantPersonas.Size = new System.Drawing.Size(41, 20);
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
            this.btnGuardar.Location = new System.Drawing.Point(331, 336);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 30);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "REGISTRO DE RESERVA PARA EVENTOS";
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(44, 417);
            this.txtcontenido.Multiline = true;
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(702, 173);
            this.txtcontenido.TabIndex = 21;
            // 
            // cmbNombEvento
            // 
            this.cmbNombEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombEvento.FormattingEnabled = true;
            this.cmbNombEvento.Location = new System.Drawing.Point(212, 106);
            this.cmbNombEvento.Name = "cmbNombEvento";
            this.cmbNombEvento.Size = new System.Drawing.Size(200, 21);
            this.cmbNombEvento.TabIndex = 22;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(207, 43);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(200, 21);
            this.cmbClientes.TabIndex = 23;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(454, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(278, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // FrmRegistroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.comboBox3);
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
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

