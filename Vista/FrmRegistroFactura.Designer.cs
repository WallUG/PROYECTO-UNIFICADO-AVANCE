namespace Vista
{
    partial class FrmRegistroFactura
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
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.groupBoxEvento = new System.Windows.Forms.GroupBox();
            this.txtReservaFecha = new System.Windows.Forms.TextBox();
            this.lblReservaFecha = new System.Windows.Forms.Label();
            this.txtEstadoEvento = new System.Windows.Forms.TextBox();
            this.cmbNumeroEvento = new System.Windows.Forms.ComboBox();
            this.btnBuscarEvento = new System.Windows.Forms.Button();
            this.txtNumPersonasEvento = new System.Windows.Forms.TextBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.txtTipoEvento = new System.Windows.Forms.TextBox();
            this.lblEstadoEvento = new System.Windows.Forms.Label();
            this.lblNumPersonasEvento = new System.Windows.Forms.Label();
            this.lblDescripcionEvento = new System.Windows.Forms.Label();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblIdEvento = new System.Windows.Forms.Label();
            this.groupBoxFactura = new System.Windows.Forms.GroupBox();
            this.txtEstadoFactura = new System.Windows.Forms.TextBox();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetallesFactura = new System.Windows.Forms.DataGridView();
            this.colIdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescuentoAplicado = new System.Windows.Forms.TextBox();
            this.lblDescuentoAplicado = new System.Windows.Forms.Label();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxEvento.SuspendLayout();
            this.groupBoxFactura.SuspendLayout();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.btnBuscarCliente);
            this.groupBoxCliente.Controls.Add(this.txtDireccionCliente);
            this.groupBoxCliente.Controls.Add(this.txtCorreoCliente);
            this.groupBoxCliente.Controls.Add(this.txtTelefonoCliente);
            this.groupBoxCliente.Controls.Add(this.txtApellidoCliente);
            this.groupBoxCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxCliente.Controls.Add(this.txtRuc);
            this.groupBoxCliente.Controls.Add(this.txtCedula);
            this.groupBoxCliente.Controls.Add(this.txtNumeroCliente);
            this.groupBoxCliente.Controls.Add(this.lblDireccionCliente);
            this.groupBoxCliente.Controls.Add(this.lblCorreoCliente);
            this.groupBoxCliente.Controls.Add(this.lblTelefonoCliente);
            this.groupBoxCliente.Controls.Add(this.lblApellidoCliente);
            this.groupBoxCliente.Controls.Add(this.lblNombreCliente);
            this.groupBoxCliente.Controls.Add(this.lblRuc);
            this.groupBoxCliente.Controls.Add(this.lblCedula);
            this.groupBoxCliente.Controls.Add(this.lblNumeroCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(16, 74);
            this.groupBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCliente.Size = new System.Drawing.Size(640, 271);
            this.groupBoxCliente.TabIndex = 0;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Información del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(333, 30);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(133, 28);
            this.btnBuscarCliente.TabIndex = 16;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(160, 224);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(452, 22);
            this.txtDireccionCliente.TabIndex = 15;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(160, 164);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtCorreoCliente.TabIndex = 14;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(160, 192);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(452, 22);
            this.txtTelefonoCliente.TabIndex = 13;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(160, 128);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(452, 22);
            this.txtApellidoCliente.TabIndex = 12;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(160, 96);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(452, 22);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(467, 64);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(145, 22);
            this.txtRuc.TabIndex = 10;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(160, 64);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(145, 22);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(160, 32);
            this.txtNumeroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.ReadOnly = true;
            this.txtNumeroCliente.Size = new System.Drawing.Size(145, 22);
            this.txtNumeroCliente.TabIndex = 8;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(20, 228);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionCliente.TabIndex = 7;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.Location = new System.Drawing.Point(20, 196);
            this.lblCorreoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(121, 16);
            this.lblCorreoCliente.TabIndex = 6;
            this.lblCorreoCliente.Text = "Correo Electrónico:";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(20, 164);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoCliente.TabIndex = 5;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(20, 132);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(60, 16);
            this.lblApellidoCliente.TabIndex = 4;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 100);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(333, 68);
            this.lblRuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(39, 16);
            this.lblRuc.TabIndex = 2;
            this.lblRuc.Text = "RUC:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(20, 68);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(53, 16);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(20, 36);
            this.lblNumeroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(102, 16);
            this.lblNumeroCliente.TabIndex = 0;
            this.lblNumeroCliente.Text = "Numero Cliente:";
            // 
            // groupBoxEvento
            // 
            this.groupBoxEvento.Controls.Add(this.txtReservaFecha);
            this.groupBoxEvento.Controls.Add(this.lblReservaFecha);
            this.groupBoxEvento.Controls.Add(this.txtEstadoEvento);
            this.groupBoxEvento.Controls.Add(this.cmbNumeroEvento);
            this.groupBoxEvento.Controls.Add(this.btnBuscarEvento);
            this.groupBoxEvento.Controls.Add(this.txtNumPersonasEvento);
            this.groupBoxEvento.Controls.Add(this.txtDescripcionEvento);
            this.groupBoxEvento.Controls.Add(this.txtNombreEvento);
            this.groupBoxEvento.Controls.Add(this.txtTipoEvento);
            this.groupBoxEvento.Controls.Add(this.lblEstadoEvento);
            this.groupBoxEvento.Controls.Add(this.lblNumPersonasEvento);
            this.groupBoxEvento.Controls.Add(this.lblDescripcionEvento);
            this.groupBoxEvento.Controls.Add(this.lblNombreEvento);
            this.groupBoxEvento.Controls.Add(this.lblTipoEvento);
            this.groupBoxEvento.Controls.Add(this.lblIdEvento);
            this.groupBoxEvento.Location = new System.Drawing.Point(680, 74);
            this.groupBoxEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEvento.Name = "groupBoxEvento";
            this.groupBoxEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEvento.Size = new System.Drawing.Size(640, 271);
            this.groupBoxEvento.TabIndex = 1;
            this.groupBoxEvento.TabStop = false;
            this.groupBoxEvento.Text = "Información del Evento";
            // 
            // txtReservaFecha
            // 
            this.txtReservaFecha.Location = new System.Drawing.Point(410, 231);
            this.txtReservaFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservaFecha.Name = "txtReservaFecha";
            this.txtReservaFecha.ReadOnly = true;
            this.txtReservaFecha.Size = new System.Drawing.Size(202, 22);
            this.txtReservaFecha.TabIndex = 16;
            // 
            // lblReservaFecha
            // 
            this.lblReservaFecha.AutoSize = true;
            this.lblReservaFecha.Location = new System.Drawing.Point(330, 234);
            this.lblReservaFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservaFecha.Name = "lblReservaFecha";
            this.lblReservaFecha.Size = new System.Drawing.Size(62, 16);
            this.lblReservaFecha.TabIndex = 15;
            this.lblReservaFecha.Text = "Reserva:";
            // 
            // txtEstadoEvento
            // 
            this.txtEstadoEvento.Location = new System.Drawing.Point(160, 228);
            this.txtEstadoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoEvento.Name = "txtEstadoEvento";
            this.txtEstadoEvento.ReadOnly = true;
            this.txtEstadoEvento.Size = new System.Drawing.Size(132, 22);
            this.txtEstadoEvento.TabIndex = 14;
            // 
            // cmbNumeroEvento
            // 
            this.cmbNumeroEvento.FormattingEnabled = true;
            this.cmbNumeroEvento.Location = new System.Drawing.Point(160, 29);
            this.cmbNumeroEvento.Name = "cmbNumeroEvento";
            this.cmbNumeroEvento.Size = new System.Drawing.Size(121, 24);
            this.cmbNumeroEvento.TabIndex = 13;
            // 
            // btnBuscarEvento
            // 
            this.btnBuscarEvento.Location = new System.Drawing.Point(333, 30);
            this.btnBuscarEvento.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEvento.Name = "btnBuscarEvento";
            this.btnBuscarEvento.Size = new System.Drawing.Size(133, 28);
            this.btnBuscarEvento.TabIndex = 12;
            this.btnBuscarEvento.Text = "Buscar Evento";
            this.btnBuscarEvento.UseVisualStyleBackColor = true;
            this.btnBuscarEvento.Click += new System.EventHandler(this.btnBuscarEvento_Click);
            // 
            // txtNumPersonasEvento
            // 
            this.txtNumPersonasEvento.Location = new System.Drawing.Point(160, 192);
            this.txtNumPersonasEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumPersonasEvento.Name = "txtNumPersonasEvento";
            this.txtNumPersonasEvento.ReadOnly = true;
            this.txtNumPersonasEvento.Size = new System.Drawing.Size(132, 22);
            this.txtNumPersonasEvento.TabIndex = 10;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(160, 128);
            this.txtDescripcionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.ReadOnly = true;
            this.txtDescripcionEvento.Size = new System.Drawing.Size(452, 56);
            this.txtDescripcionEvento.TabIndex = 9;
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(160, 96);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.ReadOnly = true;
            this.txtNombreEvento.Size = new System.Drawing.Size(452, 22);
            this.txtNombreEvento.TabIndex = 8;
            // 
            // txtTipoEvento
            // 
            this.txtTipoEvento.Location = new System.Drawing.Point(160, 64);
            this.txtTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoEvento.Name = "txtTipoEvento";
            this.txtTipoEvento.ReadOnly = true;
            this.txtTipoEvento.Size = new System.Drawing.Size(452, 22);
            this.txtTipoEvento.TabIndex = 7;
            // 
            // lblEstadoEvento
            // 
            this.lblEstadoEvento.AutoSize = true;
            this.lblEstadoEvento.Location = new System.Drawing.Point(20, 228);
            this.lblEstadoEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoEvento.Name = "lblEstadoEvento";
            this.lblEstadoEvento.Size = new System.Drawing.Size(53, 16);
            this.lblEstadoEvento.TabIndex = 5;
            this.lblEstadoEvento.Text = "Estado:";
            // 
            // lblNumPersonasEvento
            // 
            this.lblNumPersonasEvento.AutoSize = true;
            this.lblNumPersonasEvento.Location = new System.Drawing.Point(20, 196);
            this.lblNumPersonasEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPersonasEvento.Name = "lblNumPersonasEvento";
            this.lblNumPersonasEvento.Size = new System.Drawing.Size(119, 16);
            this.lblNumPersonasEvento.TabIndex = 4;
            this.lblNumPersonasEvento.Text = "Número Personas:";
            // 
            // lblDescripcionEvento
            // 
            this.lblDescripcionEvento.AutoSize = true;
            this.lblDescripcionEvento.Location = new System.Drawing.Point(20, 132);
            this.lblDescripcionEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionEvento.Name = "lblDescripcionEvento";
            this.lblDescripcionEvento.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionEvento.TabIndex = 3;
            this.lblDescripcionEvento.Text = "Descripción:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Location = new System.Drawing.Point(20, 100);
            this.lblNombreEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEvento.TabIndex = 2;
            this.lblNombreEvento.Text = "Nombre:";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(20, 68);
            this.lblTipoEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(83, 16);
            this.lblTipoEvento.TabIndex = 1;
            this.lblTipoEvento.Text = "Tipo Evento:";
            // 
            // lblIdEvento
            // 
            this.lblIdEvento.AutoSize = true;
            this.lblIdEvento.Location = new System.Drawing.Point(20, 36);
            this.lblIdEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdEvento.Name = "lblIdEvento";
            this.lblIdEvento.Size = new System.Drawing.Size(103, 16);
            this.lblIdEvento.TabIndex = 0;
            this.lblIdEvento.Text = "Numero Evento:";
            // 
            // groupBoxFactura
            // 
            this.groupBoxFactura.Controls.Add(this.txtDescuentoAplicado);
            this.groupBoxFactura.Controls.Add(this.lblDescuentoAplicado);
            this.groupBoxFactura.Controls.Add(this.txtEstadoFactura);
            this.groupBoxFactura.Controls.Add(this.btnEmitirFactura);
            this.groupBoxFactura.Controls.Add(this.btnAnular);
            this.groupBoxFactura.Controls.Add(this.btnCerrar);
            this.groupBoxFactura.Controls.Add(this.lblEstadoFactura);
            this.groupBoxFactura.Controls.Add(this.btnGuardar);
            this.groupBoxFactura.Controls.Add(this.txtTotal);
            this.groupBoxFactura.Controls.Add(this.txtDescuento);
            this.groupBoxFactura.Controls.Add(this.txtSubtotal);
            this.groupBoxFactura.Controls.Add(this.txtImpuestos);
            this.groupBoxFactura.Controls.Add(this.dtpFechaEmision);
            this.groupBoxFactura.Controls.Add(this.txtNumeroFactura);
            this.groupBoxFactura.Controls.Add(this.txtIdFactura);
            this.groupBoxFactura.Controls.Add(this.lblTotal);
            this.groupBoxFactura.Controls.Add(this.lblDescuento);
            this.groupBoxFactura.Controls.Add(this.lblSubtotal);
            this.groupBoxFactura.Controls.Add(this.lblImpuestos);
            this.groupBoxFactura.Controls.Add(this.lblFechaEmision);
            this.groupBoxFactura.Controls.Add(this.lblNumeroFactura);
            this.groupBoxFactura.Controls.Add(this.lblIdFactura);
            this.groupBoxFactura.Location = new System.Drawing.Point(16, 357);
            this.groupBoxFactura.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFactura.Name = "groupBoxFactura";
            this.groupBoxFactura.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFactura.Size = new System.Drawing.Size(656, 357);
            this.groupBoxFactura.TabIndex = 2;
            this.groupBoxFactura.TabStop = false;
            this.groupBoxFactura.Text = "Información de la Factura";
            // 
            // txtEstadoFactura
            // 
            this.txtEstadoFactura.Location = new System.Drawing.Point(160, 126);
            this.txtEstadoFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoFactura.Name = "txtEstadoFactura";
            this.txtEstadoFactura.ReadOnly = true;
            this.txtEstadoFactura.Size = new System.Drawing.Size(132, 22);
            this.txtEstadoFactura.TabIndex = 17;
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(353, 305);
            this.btnEmitirFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(120, 37);
            this.btnEmitirFactura.TabIndex = 7;
            this.btnEmitirFactura.Text = "Emitir Factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            this.btnEmitirFactura.Click += new System.EventHandler(this.btnEmitirFactura_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(198, 305);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(120, 37);
            this.btnAnular.TabIndex = 8;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(512, 305);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 37);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Location = new System.Drawing.Point(20, 132);
            this.lblEstadoFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(53, 16);
            this.lblEstadoFactura.TabIndex = 16;
            this.lblEstadoFactura.Text = "Estado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(36, 305);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Generar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(440, 252);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(172, 26);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(440, 192);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(172, 22);
            this.txtDescuento.TabIndex = 13;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(440, 128);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(172, 22);
            this.txtSubtotal.TabIndex = 12;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(440, 160);
            this.txtImpuestos.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(172, 22);
            this.txtImpuestos.TabIndex = 11;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CustomFormat = "dddd, d \'de\' MMMM \'de\' yyyy HH:mm:ss";
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmision.Location = new System.Drawing.Point(160, 96);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.ShowUpDown = true;
            this.dtpFechaEmision.Size = new System.Drawing.Size(280, 22);
            this.dtpFechaEmision.TabIndex = 10;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(160, 64);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(265, 22);
            this.txtNumeroFactura.TabIndex = 9;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(160, 32);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.ReadOnly = true;
            this.txtIdFactura.Size = new System.Drawing.Size(145, 22);
            this.txtIdFactura.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(313, 256);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(313, 196);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(90, 16);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento %:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(313, 132);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(313, 164);
            this.lblImpuestos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(72, 16);
            this.lblImpuestos.TabIndex = 4;
            this.lblImpuestos.Text = "Impuestos:";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(20, 100);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(99, 16);
            this.lblFechaEmision.TabIndex = 2;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(20, 68);
            this.lblNumeroFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(106, 16);
            this.lblNumeroFactura.TabIndex = 1;
            this.lblNumeroFactura.Text = "Número Factura:";
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Location = new System.Drawing.Point(20, 36);
            this.lblIdFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(71, 16);
            this.lblIdFactura.TabIndex = 0;
            this.lblIdFactura.Text = "ID Factura:";
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.dgvDetallesFactura);
            this.groupBoxDetalles.Location = new System.Drawing.Point(680, 357);
            this.groupBoxDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Size = new System.Drawing.Size(640, 357);
            this.groupBoxDetalles.TabIndex = 3;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles de la Factura";
            // 
            // dgvDetallesFactura
            // 
            this.dgvDetallesFactura.AllowUserToAddRows = false;
            this.dgvDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdDetalle,
            this.colNombre,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.dgvDetallesFactura.Location = new System.Drawing.Point(20, 31);
            this.dgvDetallesFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetallesFactura.Name = "dgvDetallesFactura";
            this.dgvDetallesFactura.RowHeadersWidth = 51;
            this.dgvDetallesFactura.Size = new System.Drawing.Size(600, 271);
            this.dgvDetallesFactura.TabIndex = 0;
            // 
            // colIdDetalle
            // 
            this.colIdDetalle.Frozen = true;
            this.colIdDetalle.HeaderText = "ID";
            this.colIdDetalle.MinimumWidth = 6;
            this.colIdDetalle.Name = "colIdDetalle";
            this.colIdDetalle.ReadOnly = true;
            this.colIdDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdDetalle.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNombre.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.Frozen = true;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCantidad.Width = 70;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.Frozen = true;
            this.colPrecioUnitario.HeaderText = "Precio Unit.";
            this.colPrecioUnitario.MinimumWidth = 6;
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrecioUnitario.Width = 80;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Frozen = true;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSubtotal.Width = 80;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(520, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 31);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Módulo de Facturación";
            // 
            // txtDescuentoAplicado
            // 
            this.txtDescuentoAplicado.Location = new System.Drawing.Point(453, 222);
            this.txtDescuentoAplicado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuentoAplicado.Name = "txtDescuentoAplicado";
            this.txtDescuentoAplicado.ReadOnly = true;
            this.txtDescuentoAplicado.Size = new System.Drawing.Size(159, 22);
            this.txtDescuentoAplicado.TabIndex = 19;
            this.txtDescuentoAplicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuentoAplicado
            // 
            this.lblDescuentoAplicado.AutoSize = true;
            this.lblDescuentoAplicado.Location = new System.Drawing.Point(313, 226);
            this.lblDescuentoAplicado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            this.lblDescuentoAplicado.Size = new System.Drawing.Size(132, 16);
            this.lblDescuentoAplicado.TabIndex = 18;
            this.lblDescuentoAplicado.Text = "Descuento Aplicado:";
            // 
            // FrmRegistroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 740);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.groupBoxFactura);
            this.Controls.Add(this.groupBoxEvento);
            this.Controls.Add(this.groupBoxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegistroFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación - Gestión de Facturas";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxEvento.ResumeLayout(false);
            this.groupBoxEvento.PerformLayout();
            this.groupBoxFactura.ResumeLayout(false);
            this.groupBoxFactura.PerformLayout();
            this.groupBoxDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBoxEvento;
        private System.Windows.Forms.TextBox txtNumPersonasEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.TextBox txtTipoEvento;
        private System.Windows.Forms.Label lblEstadoEvento;
        private System.Windows.Forms.Label lblNumPersonasEvento;
        private System.Windows.Forms.Label lblDescripcionEvento;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblIdEvento;
        private System.Windows.Forms.Button btnBuscarEvento;
        private System.Windows.Forms.GroupBox groupBoxFactura;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.DataGridView dgvDetallesFactura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEmitirFactura;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbNumeroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.TextBox txtEstadoEvento;
        private System.Windows.Forms.TextBox txtEstadoFactura;
        private System.Windows.Forms.TextBox txtReservaFecha;
        private System.Windows.Forms.Label lblReservaFecha;
        private System.Windows.Forms.TextBox txtDescuentoAplicado;
        private System.Windows.Forms.Label lblDescuentoAplicado;
    }
}

