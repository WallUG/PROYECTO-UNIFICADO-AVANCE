namespace Vista
{
    partial class FrmRegistrarEvento
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarEvento = new System.Windows.Forms.Button();
            this.cmbEstadoEvento = new System.Windows.Forms.ComboBox();
            this.gbCreacionEvento = new System.Windows.Forms.GroupBox();
            this.txtNumPersonasEvento = new System.Windows.Forms.TextBox();
            this.txtbDireccionUbicacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCiRucCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbAsignarInmuebles = new System.Windows.Forms.GroupBox();
            this.dgvInmuebles = new System.Windows.Forms.DataGridView();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNumInmuebles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaAsignacionInmueble = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoInmueble = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCantidadInmueble = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gbBuscarCliente = new System.Windows.Forms.GroupBox();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gbListaInmueblesSele = new System.Windows.Forms.GroupBox();
            this.dgvInmueblesActual = new System.Windows.Forms.DataGridView();
            this.colNumInmueblesAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponibleAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantDispAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAsignacionAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCreacionEvento.SuspendLayout();
            this.gbAsignarInmuebles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInmueble)).BeginInit();
            this.gbBuscarCliente.SuspendLayout();
            this.gbInformacionCliente.SuspendLayout();
            this.gbListaInmueblesSele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueblesActual)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Evento:";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(198, 50);
            this.cmbTipoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(309, 27);
            this.cmbTipoEvento.TabIndex = 6;
            this.cmbTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEvento_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvento.Location = new System.Drawing.Point(198, 131);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEvento.MaxLength = 100;
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(309, 27);
            this.txtNombreEvento.TabIndex = 9;
            this.txtNombreEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEvento_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descripción:";
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEvento.Location = new System.Drawing.Point(200, 179);
            this.txtDescripcionEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionEvento.MaxLength = 100;
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(307, 66);
            this.txtDescripcionEvento.TabIndex = 11;
            this.txtDescripcionEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEvento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Número de personas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado:";
            // 
            // btnGuardarEvento
            // 
            this.btnGuardarEvento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEvento.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEvento.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardarEvento.Location = new System.Drawing.Point(866, 765);
            this.btnGuardarEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarEvento.Name = "btnGuardarEvento";
            this.btnGuardarEvento.Size = new System.Drawing.Size(195, 40);
            this.btnGuardarEvento.TabIndex = 16;
            this.btnGuardarEvento.Text = "Guardar";
            this.btnGuardarEvento.UseVisualStyleBackColor = false;
            this.btnGuardarEvento.Click += new System.EventHandler(this.btnGuardarEvento_Click);
            // 
            // cmbEstadoEvento
            // 
            this.cmbEstadoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoEvento.FormattingEnabled = true;
            this.cmbEstadoEvento.Location = new System.Drawing.Point(198, 432);
            this.cmbEstadoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstadoEvento.Name = "cmbEstadoEvento";
            this.cmbEstadoEvento.Size = new System.Drawing.Size(309, 27);
            this.cmbEstadoEvento.TabIndex = 18;
            this.cmbEstadoEvento.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoEvento_SelectedIndexChanged);
            // 
            // gbCreacionEvento
            // 
            this.gbCreacionEvento.Controls.Add(this.txtNumPersonasEvento);
            this.gbCreacionEvento.Controls.Add(this.txtbDireccionUbicacion);
            this.gbCreacionEvento.Controls.Add(this.label16);
            this.gbCreacionEvento.Controls.Add(this.label4);
            this.gbCreacionEvento.Controls.Add(this.cmbTipoEvento);
            this.gbCreacionEvento.Controls.Add(this.cmbEstadoEvento);
            this.gbCreacionEvento.Controls.Add(this.label7);
            this.gbCreacionEvento.Controls.Add(this.label8);
            this.gbCreacionEvento.Controls.Add(this.label5);
            this.gbCreacionEvento.Controls.Add(this.txtDescripcionEvento);
            this.gbCreacionEvento.Controls.Add(this.txtNombreEvento);
            this.gbCreacionEvento.Controls.Add(this.label6);
            this.gbCreacionEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreacionEvento.Location = new System.Drawing.Point(39, 256);
            this.gbCreacionEvento.Name = "gbCreacionEvento";
            this.gbCreacionEvento.Size = new System.Drawing.Size(527, 549);
            this.gbCreacionEvento.TabIndex = 20;
            this.gbCreacionEvento.TabStop = false;
            this.gbCreacionEvento.Text = "Creación del Evento";
            // 
            // txtNumPersonasEvento
            // 
            this.txtNumPersonasEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPersonasEvento.Location = new System.Drawing.Point(200, 261);
            this.txtNumPersonasEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumPersonasEvento.MaxLength = 5000;
            this.txtNumPersonasEvento.Name = "txtNumPersonasEvento";
            this.txtNumPersonasEvento.Size = new System.Drawing.Size(120, 27);
            this.txtNumPersonasEvento.TabIndex = 21;
            this.txtNumPersonasEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPersonasEvento_KeyPress);
            // 
            // txtbDireccionUbicacion
            // 
            this.txtbDireccionUbicacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDireccionUbicacion.Location = new System.Drawing.Point(200, 331);
            this.txtbDireccionUbicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbDireccionUbicacion.MaxLength = 100;
            this.txtbDireccionUbicacion.Multiline = true;
            this.txtbDireccionUbicacion.Name = "txtbDireccionUbicacion";
            this.txtbDireccionUbicacion.Size = new System.Drawing.Size(307, 66);
            this.txtbDireccionUbicacion.TabIndex = 20;
            this.txtbDireccionUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEvento_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(22, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 19);
            this.label16.TabIndex = 19;
            this.label16.Text = "Dirección/Ubicación:";
            // 
            // txtCiRucCliente
            // 
            this.txtCiRucCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiRucCliente.Location = new System.Drawing.Point(188, 41);
            this.txtCiRucCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiRucCliente.MaxLength = 13;
            this.txtCiRucCliente.Name = "txtCiRucCliente";
            this.txtCiRucCliente.Size = new System.Drawing.Size(160, 27);
            this.txtCiRucCliente.TabIndex = 20;
            this.txtCiRucCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(10, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "Cédula o RUC:";
            // 
            // gbAsignarInmuebles
            // 
            this.gbAsignarInmuebles.Controls.Add(this.dgvInmuebles);
            this.gbAsignarInmuebles.Controls.Add(this.dtpFechaAsignacionInmueble);
            this.gbAsignarInmuebles.Controls.Add(this.label13);
            this.gbAsignarInmuebles.Controls.Add(this.cmbTipoInmueble);
            this.gbAsignarInmuebles.Controls.Add(this.label12);
            this.gbAsignarInmuebles.Controls.Add(this.nudCantidadInmueble);
            this.gbAsignarInmuebles.Controls.Add(this.label11);
            this.gbAsignarInmuebles.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignarInmuebles.Location = new System.Drawing.Point(595, 12);
            this.gbAsignarInmuebles.Name = "gbAsignarInmuebles";
            this.gbAsignarInmuebles.Size = new System.Drawing.Size(703, 461);
            this.gbAsignarInmuebles.TabIndex = 22;
            this.gbAsignarInmuebles.TabStop = false;
            this.gbAsignarInmuebles.Text = "Asignar Inmuebles";
            // 
            // dgvInmuebles
            // 
            this.dgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmuebles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeleccionar,
            this.colNumInmuebles,
            this.colNombreInmueble,
            this.colDisponible,
            this.colCantidadDisp});
            this.dgvInmuebles.Location = new System.Drawing.Point(25, 101);
            this.dgvInmuebles.Name = "dgvInmuebles";
            this.dgvInmuebles.RowHeadersWidth = 51;
            this.dgvInmuebles.RowTemplate.Height = 24;
            this.dgvInmuebles.Size = new System.Drawing.Size(661, 274);
            this.dgvInmuebles.TabIndex = 27;
            this.dgvInmuebles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInmuebles_CellClick);
            this.dgvInmuebles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgInmuebles_CellValueChanged);
            this.dgvInmuebles.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvgInmuebles_CurrentCellDirtyStateChanged);
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.Frozen = true;
            this.colSeleccionar.HeaderText = "Selecionar";
            this.colSeleccionar.MinimumWidth = 6;
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSeleccionar.Width = 125;
            // 
            // colNumInmuebles
            // 
            this.colNumInmuebles.Frozen = true;
            this.colNumInmuebles.HeaderText = "Num. Inmuebles";
            this.colNumInmuebles.MinimumWidth = 6;
            this.colNumInmuebles.Name = "colNumInmuebles";
            this.colNumInmuebles.Width = 125;
            // 
            // colNombreInmueble
            // 
            this.colNombreInmueble.Frozen = true;
            this.colNombreInmueble.HeaderText = "Nombre";
            this.colNombreInmueble.MinimumWidth = 6;
            this.colNombreInmueble.Name = "colNombreInmueble";
            this.colNombreInmueble.ReadOnly = true;
            this.colNombreInmueble.Width = 125;
            // 
            // colDisponible
            // 
            this.colDisponible.Frozen = true;
            this.colDisponible.HeaderText = "Disponible";
            this.colDisponible.MinimumWidth = 6;
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.ReadOnly = true;
            this.colDisponible.Width = 125;
            // 
            // colCantidadDisp
            // 
            this.colCantidadDisp.Frozen = true;
            this.colCantidadDisp.HeaderText = "Cant. Disponible";
            this.colCantidadDisp.MinimumWidth = 6;
            this.colCantidadDisp.Name = "colCantidadDisp";
            this.colCantidadDisp.ReadOnly = true;
            this.colCantidadDisp.Width = 125;
            // 
            // dtpFechaAsignacionInmueble
            // 
            this.dtpFechaAsignacionInmueble.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAsignacionInmueble.Location = new System.Drawing.Point(283, 397);
            this.dtpFechaAsignacionInmueble.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpFechaAsignacionInmueble.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAsignacionInmueble.Name = "dtpFechaAsignacionInmueble";
            this.dtpFechaAsignacionInmueble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaAsignacionInmueble.Size = new System.Drawing.Size(339, 27);
            this.dtpFechaAsignacionInmueble.TabIndex = 26;
            this.dtpFechaAsignacionInmueble.Value = new System.DateTime(2025, 12, 5, 23, 33, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(110, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Fecha de asignación:";
            // 
            // cmbTipoInmueble
            // 
            this.cmbTipoInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInmueble.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoInmueble.FormattingEnabled = true;
            this.cmbTipoInmueble.Location = new System.Drawing.Point(172, 49);
            this.cmbTipoInmueble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoInmueble.Name = "cmbTipoInmueble";
            this.cmbTipoInmueble.Size = new System.Drawing.Size(163, 27);
            this.cmbTipoInmueble.TabIndex = 26;
            this.cmbTipoInmueble.SelectedIndexChanged += new System.EventHandler(this.selectTipoInmueble);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(90, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tipo:";
            // 
            // nudCantidadInmueble
            // 
            this.nudCantidadInmueble.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadInmueble.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudCantidadInmueble.Location = new System.Drawing.Point(493, 50);
            this.nudCantidadInmueble.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidadInmueble.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadInmueble.Name = "nudCantidadInmueble";
            this.nudCantidadInmueble.Size = new System.Drawing.Size(77, 27);
            this.nudCantidadInmueble.TabIndex = 19;
            this.nudCantidadInmueble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadInmueble.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadInmueble.ValueChanged += new System.EventHandler(this.nudCantidadInmueble_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(399, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cantidad:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Blue;
            this.btnBuscarCliente.Location = new System.Drawing.Point(383, 32);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(113, 40);
            this.btnBuscarCliente.TabIndex = 26;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // gbBuscarCliente
            // 
            this.gbBuscarCliente.Controls.Add(this.label14);
            this.gbBuscarCliente.Controls.Add(this.btnBuscarCliente);
            this.gbBuscarCliente.Controls.Add(this.txtCiRucCliente);
            this.gbBuscarCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscarCliente.Location = new System.Drawing.Point(39, 12);
            this.gbBuscarCliente.Name = "gbBuscarCliente";
            this.gbBuscarCliente.Size = new System.Drawing.Size(527, 95);
            this.gbBuscarCliente.TabIndex = 23;
            this.gbBuscarCliente.TabStop = false;
            this.gbBuscarCliente.Text = "Buscar Cliente";
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.txtApellidosCliente);
            this.gbInformacionCliente.Controls.Add(this.label17);
            this.gbInformacionCliente.Controls.Add(this.txtNombresCliente);
            this.gbInformacionCliente.Controls.Add(this.label15);
            this.gbInformacionCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionCliente.Location = new System.Drawing.Point(39, 113);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(527, 118);
            this.gbInformacionCliente.TabIndex = 24;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Información del Cliente";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosCliente.Location = new System.Drawing.Point(188, 75);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidosCliente.MaxLength = 13;
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(319, 27);
            this.txtApellidosCliente.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(10, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "Apellidos:";
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCliente.Location = new System.Drawing.Point(188, 40);
            this.txtNombresCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombresCliente.MaxLength = 13;
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(319, 27);
            this.txtNombresCliente.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(10, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 27;
            this.label15.Text = "Nombres:";
            // 
            // gbListaInmueblesSele
            // 
            this.gbListaInmueblesSele.Controls.Add(this.dgvInmueblesActual);
            this.gbListaInmueblesSele.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListaInmueblesSele.Location = new System.Drawing.Point(595, 483);
            this.gbListaInmueblesSele.Name = "gbListaInmueblesSele";
            this.gbListaInmueblesSele.Size = new System.Drawing.Size(703, 272);
            this.gbListaInmueblesSele.TabIndex = 25;
            this.gbListaInmueblesSele.TabStop = false;
            this.gbListaInmueblesSele.Text = "Inmubles Seleccionados";
            // 
            // dgvInmueblesActual
            // 
            this.dgvInmueblesActual.AllowUserToAddRows = false;
            this.dgvInmueblesActual.AllowUserToDeleteRows = false;
            this.dgvInmueblesActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmueblesActual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumInmueblesAct,
            this.colNombreAct,
            this.colDisponibleAct,
            this.colCantDispAct,
            this.colFechaAsignacionAct});
            this.dgvInmueblesActual.Location = new System.Drawing.Point(25, 49);
            this.dgvInmueblesActual.Name = "dgvInmueblesActual";
            this.dgvInmueblesActual.ReadOnly = true;
            this.dgvInmueblesActual.RowHeadersWidth = 51;
            this.dgvInmueblesActual.RowTemplate.Height = 24;
            this.dgvInmueblesActual.Size = new System.Drawing.Size(661, 178);
            this.dgvInmueblesActual.TabIndex = 0;
            // 
            // colNumInmueblesAct
            // 
            this.colNumInmueblesAct.HeaderText = "Num. Inmuebles";
            this.colNumInmueblesAct.MinimumWidth = 6;
            this.colNumInmueblesAct.Name = "colNumInmueblesAct";
            this.colNumInmueblesAct.ReadOnly = true;
            this.colNumInmueblesAct.Width = 125;
            // 
            // colNombreAct
            // 
            this.colNombreAct.HeaderText = "Nombre";
            this.colNombreAct.MinimumWidth = 6;
            this.colNombreAct.Name = "colNombreAct";
            this.colNombreAct.ReadOnly = true;
            this.colNombreAct.Width = 125;
            // 
            // colDisponibleAct
            // 
            this.colDisponibleAct.HeaderText = "Diponible";
            this.colDisponibleAct.MinimumWidth = 6;
            this.colDisponibleAct.Name = "colDisponibleAct";
            this.colDisponibleAct.ReadOnly = true;
            this.colDisponibleAct.Width = 125;
            // 
            // colCantDispAct
            // 
            this.colCantDispAct.HeaderText = "Cant. Disponible";
            this.colCantDispAct.MinimumWidth = 6;
            this.colCantDispAct.Name = "colCantDispAct";
            this.colCantDispAct.ReadOnly = true;
            this.colCantDispAct.Width = 125;
            // 
            // colFechaAsignacionAct
            // 
            this.colFechaAsignacionAct.HeaderText = "Fecha de asignación";
            this.colFechaAsignacionAct.MinimumWidth = 6;
            this.colFechaAsignacionAct.Name = "colFechaAsignacionAct";
            this.colFechaAsignacionAct.ReadOnly = true;
            this.colFechaAsignacionAct.Width = 125;
            // 
            // FrmRegistrarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1310, 869);
            this.Controls.Add(this.gbListaInmueblesSele);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.gbBuscarCliente);
            this.Controls.Add(this.btnGuardarEvento);
            this.Controls.Add(this.gbAsignarInmuebles);
            this.Controls.Add(this.gbCreacionEvento);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistrarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Evento";
            this.gbCreacionEvento.ResumeLayout(false);
            this.gbCreacionEvento.PerformLayout();
            this.gbAsignarInmuebles.ResumeLayout(false);
            this.gbAsignarInmuebles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInmueble)).EndInit();
            this.gbBuscarCliente.ResumeLayout(false);
            this.gbBuscarCliente.PerformLayout();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbListaInmueblesSele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueblesActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarEvento;
        private System.Windows.Forms.ComboBox cmbEstadoEvento;
        private System.Windows.Forms.GroupBox gbCreacionEvento;
        private System.Windows.Forms.GroupBox gbAsignarInmuebles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudCantidadInmueble;
        private System.Windows.Forms.ComboBox cmbTipoInmueble;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignacionInmueble;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCiRucCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox gbBuscarCliente;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbDireccionUbicacion;
        private System.Windows.Forms.TextBox txtNumPersonasEvento;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvInmuebles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumInmuebles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDisp;
        private System.Windows.Forms.GroupBox gbListaInmueblesSele;
        private System.Windows.Forms.DataGridView dgvInmueblesActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumInmueblesAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponibleAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantDispAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAsignacionAct;
    }
}

