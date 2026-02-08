namespace Vista
{
    partial class FrmEditarDetallesFactura
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.groupBoxEvento = new System.Windows.Forms.GroupBox();
            this.txtEstadoEvento = new System.Windows.Forms.TextBox();
            this.txtNumPersonasEvento = new System.Windows.Forms.TextBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.txtTipoEvento = new System.Windows.Forms.TextBox();
            this.txtNumeroEvento = new System.Windows.Forms.TextBox();
            this.lblEstadoEvento = new System.Windows.Forms.Label();
            this.lblNumPersonasEvento = new System.Windows.Forms.Label();
            this.lblDescripcionEvento = new System.Windows.Forms.Label();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblNumeroEvento = new System.Windows.Forms.Label();
            this.groupBoxFactura = new System.Windows.Forms.GroupBox();
            this.txtEstadoFactura = new System.Windows.Forms.TextBox();
            this.btnRecalcular = new System.Windows.Forms.Button();
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
            this.colNumDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfoEdicion = new System.Windows.Forms.Label();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxEvento.SuspendLayout();
            this.groupBoxFactura.SuspendLayout();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(420, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Editar Factura Pendiente";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.txtDireccionCliente);
            this.groupBoxCliente.Controls.Add(this.txtCorreoCliente);
            this.groupBoxCliente.Controls.Add(this.txtTelefonoCliente);
            this.groupBoxCliente.Controls.Add(this.txtApellidoCliente);
            this.groupBoxCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxCliente.Controls.Add(this.txtCedula);
            this.groupBoxCliente.Controls.Add(this.txtNumeroCliente);
            this.groupBoxCliente.Controls.Add(this.lblDireccionCliente);
            this.groupBoxCliente.Controls.Add(this.lblCorreoCliente);
            this.groupBoxCliente.Controls.Add(this.lblTelefonoCliente);
            this.groupBoxCliente.Controls.Add(this.lblApellidoCliente);
            this.groupBoxCliente.Controls.Add(this.lblNombreCliente);
            this.groupBoxCliente.Controls.Add(this.lblCedula);
            this.groupBoxCliente.Controls.Add(this.lblIdCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(16, 80);
            this.groupBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCliente.Size = new System.Drawing.Size(520, 220);
            this.groupBoxCliente.TabIndex = 2;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Información del Cliente (Solo lectura)";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccionCliente.Location = new System.Drawing.Point(120, 175);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(380, 22);
            this.txtDireccionCliente.TabIndex = 12;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreoCliente.Location = new System.Drawing.Point(300, 145);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(200, 22);
            this.txtCorreoCliente.TabIndex = 10;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(120, 145);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(150, 22);
            this.txtTelefonoCliente.TabIndex = 8;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellidoCliente.Location = new System.Drawing.Point(120, 115);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(380, 22);
            this.txtApellidoCliente.TabIndex = 6;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreCliente.Location = new System.Drawing.Point(120, 85);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(380, 22);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.Control;
            this.txtCedula.Location = new System.Drawing.Point(120, 55);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(150, 22);
            this.txtCedula.TabIndex = 2;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumeroCliente.Location = new System.Drawing.Point(120, 25);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.ReadOnly = true;
            this.txtNumeroCliente.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroCliente.TabIndex = 0;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(20, 178);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(67, 16);
            this.lblDireccionCliente.TabIndex = 13;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.Location = new System.Drawing.Point(285, 148);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(0, 16);
            this.lblCorreoCliente.TabIndex = 11;
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(20, 148);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoCliente.TabIndex = 9;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(20, 118);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(60, 16);
            this.lblApellidoCliente.TabIndex = 7;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 88);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCliente.TabIndex = 5;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(20, 58);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(53, 16);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(20, 28);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(102, 16);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Numero Cliente:";
            // 
            // groupBoxEvento
            // 
            this.groupBoxEvento.Controls.Add(this.txtEstadoEvento);
            this.groupBoxEvento.Controls.Add(this.txtNumPersonasEvento);
            this.groupBoxEvento.Controls.Add(this.txtDescripcionEvento);
            this.groupBoxEvento.Controls.Add(this.txtNombreEvento);
            this.groupBoxEvento.Controls.Add(this.txtTipoEvento);
            this.groupBoxEvento.Controls.Add(this.txtNumeroEvento);
            this.groupBoxEvento.Controls.Add(this.lblEstadoEvento);
            this.groupBoxEvento.Controls.Add(this.lblNumPersonasEvento);
            this.groupBoxEvento.Controls.Add(this.lblDescripcionEvento);
            this.groupBoxEvento.Controls.Add(this.lblNombreEvento);
            this.groupBoxEvento.Controls.Add(this.lblTipoEvento);
            this.groupBoxEvento.Controls.Add(this.lblNumeroEvento);
            this.groupBoxEvento.Location = new System.Drawing.Point(550, 80);
            this.groupBoxEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEvento.Name = "groupBoxEvento";
            this.groupBoxEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEvento.Size = new System.Drawing.Size(520, 220);
            this.groupBoxEvento.TabIndex = 3;
            this.groupBoxEvento.TabStop = false;
            this.groupBoxEvento.Text = "Información del Evento (Solo lectura)";
            // 
            // txtEstadoEvento
            // 
            this.txtEstadoEvento.BackColor = System.Drawing.SystemColors.Control;
            this.txtEstadoEvento.Location = new System.Drawing.Point(310, 170);
            this.txtEstadoEvento.Name = "txtEstadoEvento";
            this.txtEstadoEvento.ReadOnly = true;
            this.txtEstadoEvento.Size = new System.Drawing.Size(190, 22);
            this.txtEstadoEvento.TabIndex = 10;
            // 
            // txtNumPersonasEvento
            // 
            this.txtNumPersonasEvento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumPersonasEvento.Location = new System.Drawing.Point(130, 170);
            this.txtNumPersonasEvento.Name = "txtNumPersonasEvento";
            this.txtNumPersonasEvento.ReadOnly = true;
            this.txtNumPersonasEvento.Size = new System.Drawing.Size(100, 22);
            this.txtNumPersonasEvento.TabIndex = 8;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcionEvento.Location = new System.Drawing.Point(130, 115);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.ReadOnly = true;
            this.txtDescripcionEvento.Size = new System.Drawing.Size(370, 45);
            this.txtDescripcionEvento.TabIndex = 6;
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreEvento.Location = new System.Drawing.Point(130, 85);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.ReadOnly = true;
            this.txtNombreEvento.Size = new System.Drawing.Size(370, 22);
            this.txtNombreEvento.TabIndex = 4;
            // 
            // txtTipoEvento
            // 
            this.txtTipoEvento.BackColor = System.Drawing.SystemColors.Control;
            this.txtTipoEvento.Location = new System.Drawing.Point(130, 55);
            this.txtTipoEvento.Name = "txtTipoEvento";
            this.txtTipoEvento.ReadOnly = true;
            this.txtTipoEvento.Size = new System.Drawing.Size(370, 22);
            this.txtTipoEvento.TabIndex = 2;
            // 
            // txtNumeroEvento
            // 
            this.txtNumeroEvento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumeroEvento.Location = new System.Drawing.Point(130, 25);
            this.txtNumeroEvento.Name = "txtNumeroEvento";
            this.txtNumeroEvento.ReadOnly = true;
            this.txtNumeroEvento.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroEvento.TabIndex = 0;
            // 
            // lblEstadoEvento
            // 
            this.lblEstadoEvento.AutoSize = true;
            this.lblEstadoEvento.Location = new System.Drawing.Point(250, 173);
            this.lblEstadoEvento.Name = "lblEstadoEvento";
            this.lblEstadoEvento.Size = new System.Drawing.Size(53, 16);
            this.lblEstadoEvento.TabIndex = 11;
            this.lblEstadoEvento.Text = "Estado:";
            // 
            // lblNumPersonasEvento
            // 
            this.lblNumPersonasEvento.AutoSize = true;
            this.lblNumPersonasEvento.Location = new System.Drawing.Point(20, 173);
            this.lblNumPersonasEvento.Name = "lblNumPersonasEvento";
            this.lblNumPersonasEvento.Size = new System.Drawing.Size(68, 16);
            this.lblNumPersonasEvento.TabIndex = 9;
            this.lblNumPersonasEvento.Text = "Personas:";
            // 
            // lblDescripcionEvento
            // 
            this.lblDescripcionEvento.AutoSize = true;
            this.lblDescripcionEvento.Location = new System.Drawing.Point(20, 118);
            this.lblDescripcionEvento.Name = "lblDescripcionEvento";
            this.lblDescripcionEvento.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionEvento.TabIndex = 7;
            this.lblDescripcionEvento.Text = "Descripción:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Location = new System.Drawing.Point(20, 88);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEvento.TabIndex = 5;
            this.lblNombreEvento.Text = "Nombre:";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(20, 58);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(83, 16);
            this.lblTipoEvento.TabIndex = 3;
            this.lblTipoEvento.Text = "Tipo Evento:";
            // 
            // lblNumeroEvento
            // 
            this.lblNumeroEvento.AutoSize = true;
            this.lblNumeroEvento.Location = new System.Drawing.Point(20, 28);
            this.lblNumeroEvento.Name = "lblNumeroEvento";
            this.lblNumeroEvento.Size = new System.Drawing.Size(103, 16);
            this.lblNumeroEvento.TabIndex = 1;
            this.lblNumeroEvento.Text = "Número Evento:";
            // 
            // groupBoxFactura
            // 
            this.groupBoxFactura.Controls.Add(this.btnGenerarPDF);
            this.groupBoxFactura.Controls.Add(this.txtEstadoFactura);
            this.groupBoxFactura.Controls.Add(this.btnRecalcular);
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
            this.groupBoxFactura.Location = new System.Drawing.Point(16, 310);
            this.groupBoxFactura.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFactura.Name = "groupBoxFactura";
            this.groupBoxFactura.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFactura.Size = new System.Drawing.Size(520, 320);
            this.groupBoxFactura.TabIndex = 4;
            this.groupBoxFactura.TabStop = false;
            this.groupBoxFactura.Text = "Información de la Factura";
            // 
            // txtEstadoFactura
            // 
            this.txtEstadoFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtEstadoFactura.Location = new System.Drawing.Point(130, 115);
            this.txtEstadoFactura.Name = "txtEstadoFactura";
            this.txtEstadoFactura.ReadOnly = true;
            this.txtEstadoFactura.Size = new System.Drawing.Size(120, 22);
            this.txtEstadoFactura.TabIndex = 6;
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Location = new System.Drawing.Point(260, 152);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(100, 28);
            this.btnRecalcular.TabIndex = 12;
            this.btnRecalcular.Text = "Recalcular";
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.BackColor = System.Drawing.Color.LightGreen;
            this.btnEmitirFactura.Location = new System.Drawing.Point(140, 270);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(110, 35);
            this.btnEmitirFactura.TabIndex = 18;
            this.btnEmitirFactura.Text = "Emitir Factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = false;
            this.btnEmitirFactura.Click += new System.EventHandler(this.btnEmitirFactura_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnular.Location = new System.Drawing.Point(260, 270);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(110, 35);
            this.btnAnular.TabIndex = 19;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(390, 270);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Location = new System.Drawing.Point(20, 118);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(53, 16);
            this.lblEstadoFactura.TabIndex = 7;
            this.lblEstadoFactura.Text = "Estado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardar.Location = new System.Drawing.Point(20, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 35);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.LightGreen;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(380, 190);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 30);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(130, 155);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(120, 22);
            this.txtDescuento.TabIndex = 10;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubtotal.Location = new System.Drawing.Point(380, 115);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(120, 22);
            this.txtSubtotal.TabIndex = 8;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.BackColor = System.Drawing.SystemColors.Control;
            this.txtImpuestos.Location = new System.Drawing.Point(380, 155);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(120, 22);
            this.txtImpuestos.TabIndex = 13;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CustomFormat = "dddd, d \'de\' MMMM \'de\' yyyy HH:mm:ss";
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmision.Location = new System.Drawing.Point(130, 85);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.ShowUpDown = true;
            this.dtpFechaEmision.Size = new System.Drawing.Size(280, 22);
            this.dtpFechaEmision.TabIndex = 4;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumeroFactura.Location = new System.Drawing.Point(130, 55);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(200, 22);
            this.txtNumeroFactura.TabIndex = 2;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdFactura.Location = new System.Drawing.Point(130, 25);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.ReadOnly = true;
            this.txtIdFactura.Size = new System.Drawing.Size(100, 22);
            this.txtIdFactura.TabIndex = 0;
            this.txtIdFactura.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(300, 195);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 25);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(20, 158);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(98, 16);
            this.lblDescuento.TabIndex = 11;
            this.lblDescuento.Text = "Descuento (%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(300, 118);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(300, 158);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(68, 16);
            this.lblImpuestos.TabIndex = 14;
            this.lblImpuestos.Text = "IVA (15%):";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(20, 88);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(99, 16);
            this.lblFechaEmision.TabIndex = 5;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(20, 58);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(106, 16);
            this.lblNumeroFactura.TabIndex = 3;
            this.lblNumeroFactura.Text = "Número Factura:";
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Location = new System.Drawing.Point(20, 28);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(71, 16);
            this.lblIdFactura.TabIndex = 1;
            this.lblIdFactura.Text = "ID Factura:";
            this.lblIdFactura.Visible = false;
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.dgvDetallesFactura);
            this.groupBoxDetalles.Location = new System.Drawing.Point(550, 310);
            this.groupBoxDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalles.Size = new System.Drawing.Size(520, 320);
            this.groupBoxDetalles.TabIndex = 5;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles de la Factura (Solo lectura)";
            // 
            // dgvDetallesFactura
            // 
            this.dgvDetallesFactura.AllowUserToAddRows = false;
            this.dgvDetallesFactura.AllowUserToDeleteRows = false;
            this.dgvDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumDetalle,
            this.colNombre,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.dgvDetallesFactura.Location = new System.Drawing.Point(15, 25);
            this.dgvDetallesFactura.Name = "dgvDetallesFactura";
            this.dgvDetallesFactura.ReadOnly = true;
            this.dgvDetallesFactura.RowHeadersWidth = 51;
            this.dgvDetallesFactura.Size = new System.Drawing.Size(490, 280);
            this.dgvDetallesFactura.TabIndex = 0;
            // 
            // colNumDetalle
            // 
            this.colNumDetalle.HeaderText = "Num";
            this.colNumDetalle.MinimumWidth = 6;
            this.colNumDetalle.Name = "colNumDetalle";
            this.colNumDetalle.ReadOnly = true;
            this.colNumDetalle.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 70;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "Precio Unit.";
            this.colPrecioUnitario.MinimumWidth = 6;
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 80;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 80;
            // 
            // lblInfoEdicion
            // 
            this.lblInfoEdicion.AutoSize = true;
            this.lblInfoEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEdicion.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoEdicion.Location = new System.Drawing.Point(380, 50);
            this.lblInfoEdicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoEdicion.Name = "lblInfoEdicion";
            this.lblInfoEdicion.Size = new System.Drawing.Size(388, 18);
            this.lblInfoEdicion.TabIndex = 1;
            this.lblInfoEdicion.Text = "Solo puede modificar el descuento en facturas pendientes";
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Location = new System.Drawing.Point(23, 222);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(107, 28);
            this.btnGenerarPDF.TabIndex = 21;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // FrmEditarDetallesFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInfoEdicion);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxEvento);
            this.Controls.Add(this.groupBoxFactura);
            this.Controls.Add(this.groupBoxDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarDetallesFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Factura - Sistema de Facturación";
            this.Load += new System.EventHandler(this.FrmEditarDetallesFactura_Load);
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

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfoEdicion;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.GroupBox groupBoxEvento;
        private System.Windows.Forms.TextBox txtEstadoEvento;
        private System.Windows.Forms.TextBox txtNumPersonasEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.TextBox txtTipoEvento;
        private System.Windows.Forms.TextBox txtNumeroEvento;
        private System.Windows.Forms.Label lblEstadoEvento;
        private System.Windows.Forms.Label lblNumPersonasEvento;
        private System.Windows.Forms.Label lblDescripcionEvento;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblNumeroEvento;
        private System.Windows.Forms.GroupBox groupBoxFactura;
        private System.Windows.Forms.TextBox txtEstadoFactura;
        private System.Windows.Forms.Button btnRecalcular;
        private System.Windows.Forms.Button btnEmitirFactura;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.Button btnGuardar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Button btnGenerarPDF;
    }
}