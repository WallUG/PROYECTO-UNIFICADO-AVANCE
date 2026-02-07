namespace Vista
{
    partial class FrmListarCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.txtBuscarxcedula = new System.Windows.Forms.TextBox();
            this.lblBuscarxcedula = new System.Windows.Forms.Label();
            this.tnFiltrar = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellidos,
            this.colCedula,
            this.colTelefono,
            this.colCorreo});
            this.dgvCliente.Location = new System.Drawing.Point(15, 309);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(1191, 217);
            this.dgvCliente.TabIndex = 0;
            // 
            // lblListarClientes
            // 
            this.lblListarClientes.AutoSize = true;
            this.lblListarClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarClientes.Location = new System.Drawing.Point(437, 9);
            this.lblListarClientes.Name = "lblListarClientes";
            this.lblListarClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblListarClientes.Size = new System.Drawing.Size(279, 32);
            this.lblListarClientes.TabIndex = 1;
            this.lblListarClientes.Text = "LISTAR CLIENTES ";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(294, 88);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(112, 29);
            this.lblFiltros.TabIndex = 23;
            this.lblFiltros.Text = "FILTRO:";
           
            // 
            // txtBuscarxcedula
            // 
            this.txtBuscarxcedula.Location = new System.Drawing.Point(574, 154);
            this.txtBuscarxcedula.MaxLength = 12;
            this.txtBuscarxcedula.Name = "txtBuscarxcedula";
            this.txtBuscarxcedula.Size = new System.Drawing.Size(236, 26);
            this.txtBuscarxcedula.TabIndex = 22;
           
            // 
            // lblBuscarxcedula
            // 
            this.lblBuscarxcedula.AutoSize = true;
            this.lblBuscarxcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarxcedula.Location = new System.Drawing.Point(304, 160);
            this.lblBuscarxcedula.Name = "lblBuscarxcedula";
            this.lblBuscarxcedula.Size = new System.Drawing.Size(207, 20);
            this.lblBuscarxcedula.TabIndex = 21;
            this.lblBuscarxcedula.Text = "BUSCAR POR CEDULA:\r\n";
           
            // 
            // tnFiltrar
            // 
            this.tnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tnFiltrar.Location = new System.Drawing.Point(590, 218);
            this.tnFiltrar.Name = "tnFiltrar";
            this.tnFiltrar.Size = new System.Drawing.Size(134, 52);
            this.tnFiltrar.TabIndex = 20;
            this.tnFiltrar.Text = "FILTRAR";
            this.tnFiltrar.UseVisualStyleBackColor = true;
            this.tnFiltrar.Click += new System.EventHandler(this.tnFiltrar_Click);
            // 
            // colId
            // 
            this.colId.FillWeight = 200F;
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 150;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 200F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 250;
            // 
            // colApellidos
            // 
            this.colApellidos.FillWeight = 200F;
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.MinimumWidth = 6;
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.ReadOnly = true;
            this.colApellidos.Width = 200;
            // 
            // colCedula
            // 
            this.colCedula.FillWeight = 200F;
            this.colCedula.HeaderText = "Cedula";
            this.colCedula.MinimumWidth = 6;
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            this.colCedula.Width = 200;
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 200F;
            this.colTelefono.HeaderText = "Telefono cel";
            this.colTelefono.MinimumWidth = 6;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            this.colTelefono.Width = 250;
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 200F;
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 175;
            // 
            // FrmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 562);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.txtBuscarxcedula);
            this.Controls.Add(this.lblBuscarxcedula);
            this.Controls.Add(this.tnFiltrar);
            this.Controls.Add(this.lblListarClientes);
            this.Controls.Add(this.dgvCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.TextBox txtBuscarxcedula;
        private System.Windows.Forms.Label lblBuscarxcedula;
        private System.Windows.Forms.Button tnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
    }
}