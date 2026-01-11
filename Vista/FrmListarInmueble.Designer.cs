namespace Visual
{
    partial class FrmListarInmueble
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
            this.dgvInmueble = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNumeroInmueble = new System.Windows.Forms.TextBox();
            this.txtTipoInmueble = new System.Windows.Forms.TextBox();
            this.lbTipoInmueble = new System.Windows.Forms.Label();
            this.lbNumeroInmueble = new System.Windows.Forms.Label();
            this.rbNumeroInmueble = new System.Windows.Forms.RadioButton();
            this.rbTipoInmueble = new System.Windows.Forms.RadioButton();
            this.txtTituloVentana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueble)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInmueble
            // 
            this.dgvInmueble.AllowUserToAddRows = false;
            this.dgvInmueble.AllowUserToDeleteRows = false;
            this.dgvInmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmueble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colNumeroInmueble,
            this.colNombre,
            this.colTipo,
            this.colCantidad,
            this.colPrecio,
            this.colDisponible});
            this.dgvInmueble.Location = new System.Drawing.Point(106, 107);
            this.dgvInmueble.Name = "dgvInmueble";
            this.dgvInmueble.ReadOnly = true;
            this.dgvInmueble.RowHeadersWidth = 51;
            this.dgvInmueble.Size = new System.Drawing.Size(645, 212);
            this.dgvInmueble.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 125;
            // 
            // colNumeroInmueble
            // 
            this.colNumeroInmueble.HeaderText = "Numero de Inmueble";
            this.colNumeroInmueble.MinimumWidth = 6;
            this.colNumeroInmueble.Name = "colNumeroInmueble";
            this.colNumeroInmueble.ReadOnly = true;
            this.colNumeroInmueble.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre de Inmueble";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo de Inmueble";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad Disponible";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 125;
            // 
            // colDisponible
            // 
            this.colDisponible.HeaderText = "Disponibilidad";
            this.colDisponible.MinimumWidth = 6;
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.ReadOnly = true;
            this.colDisponible.Width = 125;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(621, 36);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 58);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNumeroInmueble
            // 
            this.txtNumeroInmueble.Enabled = false;
            this.txtNumeroInmueble.Location = new System.Drawing.Point(444, 36);
            this.txtNumeroInmueble.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroInmueble.Name = "txtNumeroInmueble";
            this.txtNumeroInmueble.Size = new System.Drawing.Size(131, 20);
            this.txtNumeroInmueble.TabIndex = 24;
            // 
            // txtTipoInmueble
            // 
            this.txtTipoInmueble.Enabled = false;
            this.txtTipoInmueble.Location = new System.Drawing.Point(444, 74);
            this.txtTipoInmueble.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoInmueble.Name = "txtTipoInmueble";
            this.txtTipoInmueble.Size = new System.Drawing.Size(131, 20);
            this.txtTipoInmueble.TabIndex = 23;
            // 
            // lbTipoInmueble
            // 
            this.lbTipoInmueble.AutoSize = true;
            this.lbTipoInmueble.Location = new System.Drawing.Point(325, 76);
            this.lbTipoInmueble.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoInmueble.Name = "lbTipoInmueble";
            this.lbTipoInmueble.Size = new System.Drawing.Size(89, 13);
            this.lbTipoInmueble.TabIndex = 22;
            this.lbTipoInmueble.Text = "Tipo de Inmueble";
            // 
            // lbNumeroInmueble
            // 
            this.lbNumeroInmueble.AutoSize = true;
            this.lbNumeroInmueble.Location = new System.Drawing.Point(325, 39);
            this.lbNumeroInmueble.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumeroInmueble.Name = "lbNumeroInmueble";
            this.lbNumeroInmueble.Size = new System.Drawing.Size(105, 13);
            this.lbNumeroInmueble.TabIndex = 21;
            this.lbNumeroInmueble.Text = "Numero de Inmueble";
            // 
            // rbNumeroInmueble
            // 
            this.rbNumeroInmueble.AutoSize = true;
            this.rbNumeroInmueble.Location = new System.Drawing.Point(106, 77);
            this.rbNumeroInmueble.Margin = new System.Windows.Forms.Padding(2);
            this.rbNumeroInmueble.Name = "rbNumeroInmueble";
            this.rbNumeroInmueble.Size = new System.Drawing.Size(123, 17);
            this.rbNumeroInmueble.TabIndex = 26;
            this.rbNumeroInmueble.TabStop = true;
            this.rbNumeroInmueble.Text = "Numero de Inmueble";
            this.rbNumeroInmueble.UseVisualStyleBackColor = true;
            this.rbNumeroInmueble.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // rbTipoInmueble
            // 
            this.rbTipoInmueble.AutoSize = true;
            this.rbTipoInmueble.Location = new System.Drawing.Point(106, 39);
            this.rbTipoInmueble.Margin = new System.Windows.Forms.Padding(2);
            this.rbTipoInmueble.Name = "rbTipoInmueble";
            this.rbTipoInmueble.Size = new System.Drawing.Size(107, 17);
            this.rbTipoInmueble.TabIndex = 25;
            this.rbTipoInmueble.TabStop = true;
            this.rbTipoInmueble.Text = "Tipo de Inmueble";
            this.rbTipoInmueble.UseVisualStyleBackColor = true;
            this.rbTipoInmueble.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // txtTituloVentana
            // 
            this.txtTituloVentana.AutoSize = true;
            this.txtTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloVentana.Location = new System.Drawing.Point(101, 9);
            this.txtTituloVentana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTituloVentana.Name = "txtTituloVentana";
            this.txtTituloVentana.Size = new System.Drawing.Size(188, 25);
            this.txtTituloVentana.TabIndex = 27;
            this.txtTituloVentana.Text = "Opciones de filtro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filtros:";
            // 
            // FrmListarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloVentana);
            this.Controls.Add(this.rbNumeroInmueble);
            this.Controls.Add(this.rbTipoInmueble);
            this.Controls.Add(this.txtNumeroInmueble);
            this.Controls.Add(this.txtTipoInmueble);
            this.Controls.Add(this.lbTipoInmueble);
            this.Controls.Add(this.lbNumeroInmueble);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvInmueble);
            this.Name = "FrmListarInmueble";
            this.Text = "Lista de Inmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponible;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNumeroInmueble;
        private System.Windows.Forms.TextBox txtTipoInmueble;
        private System.Windows.Forms.Label lbTipoInmueble;
        private System.Windows.Forms.Label lbNumeroInmueble;
        private System.Windows.Forms.RadioButton rbNumeroInmueble;
        private System.Windows.Forms.RadioButton rbTipoInmueble;
        private System.Windows.Forms.Label txtTituloVentana;
        private System.Windows.Forms.Label label1;
    }
}