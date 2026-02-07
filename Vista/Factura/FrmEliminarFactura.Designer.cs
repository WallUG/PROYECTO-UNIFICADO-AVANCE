namespace Vista
{
    partial class FrmEliminarFactura
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTituloVentana = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbNumeroFactura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNumFactura = new System.Windows.Forms.RadioButton();
            this.rbNumCedula = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumCedula = new System.Windows.Forms.TextBox();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.colNumeroFactura,
            this.colCliente,
            this.colCedulaCliente,
            this.colEvento,
            this.colTipoEvento,
            this.colFechaEmision,
            this.colSubtotal,
            this.colIVA,
            this.colTotal,
            this.colEstado});
            this.dgvFacturas.Location = new System.Drawing.Point(12, 118);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1346, 350);
            this.dgvFacturas.TabIndex = 1;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro";
            this.Nro.MinimumWidth = 6;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // colNumeroFactura
            // 
            this.colNumeroFactura.HeaderText = "Número Factura";
            this.colNumeroFactura.MinimumWidth = 6;
            this.colNumeroFactura.Name = "colNumeroFactura";
            this.colNumeroFactura.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colCedulaCliente
            // 
            this.colCedulaCliente.HeaderText = "Cédula";
            this.colCedulaCliente.MinimumWidth = 6;
            this.colCedulaCliente.Name = "colCedulaCliente";
            this.colCedulaCliente.ReadOnly = true;
            // 
            // colEvento
            // 
            this.colEvento.HeaderText = "Nombre Evento";
            this.colEvento.MinimumWidth = 6;
            this.colEvento.Name = "colEvento";
            this.colEvento.ReadOnly = true;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo Evento";
            this.colTipoEvento.MinimumWidth = 6;
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            // 
            // colFechaEmision
            // 
            this.colFechaEmision.HeaderText = "Fecha Emisión";
            this.colFechaEmision.MinimumWidth = 6;
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // colIVA
            // 
            this.colIVA.HeaderText = "IVA (15%)";
            this.colIVA.MinimumWidth = 6;
            this.colIVA.Name = "colIVA";
            this.colIVA.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // txtTituloVentana
            // 
            this.txtTituloVentana.AutoSize = true;
            this.txtTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloVentana.Location = new System.Drawing.Point(599, 9);
            this.txtTituloVentana.Name = "txtTituloVentana";
            this.txtTituloVentana.Size = new System.Drawing.Size(212, 29);
            this.txtTituloVentana.TabIndex = 4;
            this.txtTituloVentana.Text = "Lista de Facturas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(640, 474);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Eliminar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbNumeroFactura
            // 
            this.lbNumeroFactura.AutoSize = true;
            this.lbNumeroFactura.Location = new System.Drawing.Point(12, 52);
            this.lbNumeroFactura.Name = "lbNumeroFactura";
            this.lbNumeroFactura.Size = new System.Drawing.Size(103, 16);
            this.lbNumeroFactura.TabIndex = 7;
            this.lbNumeroFactura.Text = "Numero Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cedula";
            // 
            // rbNumFactura
            // 
            this.rbNumFactura.AutoSize = true;
            this.rbNumFactura.Location = new System.Drawing.Point(899, 48);
            this.rbNumFactura.Name = "rbNumFactura";
            this.rbNumFactura.Size = new System.Drawing.Size(138, 20);
            this.rbNumFactura.TabIndex = 9;
            this.rbNumFactura.TabStop = true;
            this.rbNumFactura.Text = "Numero de factura";
            this.rbNumFactura.UseVisualStyleBackColor = true;
            this.rbNumFactura.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // rbNumCedula
            // 
            this.rbNumCedula.AutoSize = true;
            this.rbNumCedula.Location = new System.Drawing.Point(899, 92);
            this.rbNumCedula.Name = "rbNumCedula";
            this.rbNumCedula.Size = new System.Drawing.Size(139, 20);
            this.rbNumCedula.TabIndex = 10;
            this.rbNumCedula.TabStop = true;
            this.rbNumCedula.Text = "Numero de cedula";
            this.rbNumCedula.UseVisualStyleBackColor = true;
            this.rbNumCedula.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(926, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtros";
            // 
            // txtNumCedula
            // 
            this.txtNumCedula.Enabled = false;
            this.txtNumCedula.Location = new System.Drawing.Point(576, 46);
            this.txtNumCedula.Name = "txtNumCedula";
            this.txtNumCedula.Size = new System.Drawing.Size(184, 22);
            this.txtNumCedula.TabIndex = 12;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Enabled = false;
            this.txtNumFactura.Location = new System.Drawing.Point(121, 46);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(173, 22);
            this.txtNumFactura.TabIndex = 13;
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(1155, 71);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(78, 23);
            this.btnAplicarFiltro.TabIndex = 14;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // FrmEliminarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 579);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.txtNumCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbNumCedula);
            this.Controls.Add(this.rbNumFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumeroFactura);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtTituloVentana);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "FrmEliminarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label txtTituloVentana;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lbNumeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNumFactura;
        private System.Windows.Forms.RadioButton rbNumCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCedula;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Button btnAplicarFiltro;
    }
}