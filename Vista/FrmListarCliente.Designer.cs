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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumCedular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListarClientes = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.rbtnBuscarporcedula = new System.Windows.Forms.RadioButton();
            this.rbtBuscarportelefono = new System.Windows.Forms.RadioButton();
            this.tnFiltrar = new System.Windows.Forms.Button();
            this.lblBuscarxcedula = new System.Windows.Forms.Label();
            this.lblBuscarxtelefono = new System.Windows.Forms.Label();
            this.txtBuscarxcedula = new System.Windows.Forms.TextBox();
            this.txtBuscarporTelefono = new System.Windows.Forms.TextBox();
            this.lblFiltros = new System.Windows.Forms.Label();
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
            this.colNumCedular,
            this.colCorreo});
            this.dgvCliente.Location = new System.Drawing.Point(15, 309);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(1191, 217);
            this.dgvCliente.TabIndex = 0;
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
            // colNumCedular
            // 
            this.colNumCedular.FillWeight = 200F;
            this.colNumCedular.HeaderText = "Numero Cel.";
            this.colNumCedular.MinimumWidth = 6;
            this.colNumCedular.Name = "colNumCedular";
            this.colNumCedular.ReadOnly = true;
            this.colNumCedular.Width = 175;
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 200F;
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 250;
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
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(68, 96);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(289, 29);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "OPCIONES DE FILTRO";
            // 
            // rbtnBuscarporcedula
            // 
            this.rbtnBuscarporcedula.AutoSize = true;
            this.rbtnBuscarporcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBuscarporcedula.Location = new System.Drawing.Point(89, 146);
            this.rbtnBuscarporcedula.Name = "rbtnBuscarporcedula";
            this.rbtnBuscarporcedula.Size = new System.Drawing.Size(227, 24);
            this.rbtnBuscarporcedula.TabIndex = 3;
            this.rbtnBuscarporcedula.TabStop = true;
            this.rbtnBuscarporcedula.Text = "BUSCAR POR CEDULA";
            this.rbtnBuscarporcedula.UseVisualStyleBackColor = true;
            // 
            // rbtBuscarportelefono
            // 
            this.rbtBuscarportelefono.AutoSize = true;
            this.rbtBuscarportelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBuscarportelefono.Location = new System.Drawing.Point(89, 191);
            this.rbtBuscarportelefono.Name = "rbtBuscarportelefono";
            this.rbtBuscarportelefono.Size = new System.Drawing.Size(248, 24);
            this.rbtBuscarportelefono.TabIndex = 4;
            this.rbtBuscarportelefono.TabStop = true;
            this.rbtBuscarportelefono.Text = "BUSCAR POR TELEFONO";
            this.rbtBuscarportelefono.UseVisualStyleBackColor = true;
            // 
            // tnFiltrar
            // 
            this.tnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tnFiltrar.Location = new System.Drawing.Point(955, 209);
            this.tnFiltrar.Name = "tnFiltrar";
            this.tnFiltrar.Size = new System.Drawing.Size(134, 52);
            this.tnFiltrar.TabIndex = 5;
            this.tnFiltrar.Text = "FILTRAR";
            this.tnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblBuscarxcedula
            // 
            this.lblBuscarxcedula.AutoSize = true;
            this.lblBuscarxcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarxcedula.Location = new System.Drawing.Point(442, 146);
            this.lblBuscarxcedula.Name = "lblBuscarxcedula";
            this.lblBuscarxcedula.Size = new System.Drawing.Size(207, 20);
            this.lblBuscarxcedula.TabIndex = 6;
            this.lblBuscarxcedula.Text = "BUSCAR POR CEDULA:\r\n";
            // 
            // lblBuscarxtelefono
            // 
            this.lblBuscarxtelefono.AutoSize = true;
            this.lblBuscarxtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarxtelefono.Location = new System.Drawing.Point(421, 191);
            this.lblBuscarxtelefono.Name = "lblBuscarxtelefono";
            this.lblBuscarxtelefono.Size = new System.Drawing.Size(228, 20);
            this.lblBuscarxtelefono.TabIndex = 7;
            this.lblBuscarxtelefono.Text = "BUSCAR POR TELEFONO:\r\n";
            // 
            // txtBuscarxcedula
            // 
            this.txtBuscarxcedula.Location = new System.Drawing.Point(652, 144);
            this.txtBuscarxcedula.Name = "txtBuscarxcedula";
            this.txtBuscarxcedula.Size = new System.Drawing.Size(236, 26);
            this.txtBuscarxcedula.TabIndex = 8;
            // 
            // txtBuscarporTelefono
            // 
            this.txtBuscarporTelefono.Location = new System.Drawing.Point(654, 185);
            this.txtBuscarporTelefono.Name = "txtBuscarporTelefono";
            this.txtBuscarporTelefono.Size = new System.Drawing.Size(234, 26);
            this.txtBuscarporTelefono.TabIndex = 9;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(552, 62);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(112, 29);
            this.lblFiltros.TabIndex = 10;
            this.lblFiltros.Text = "FILTRO:";
            // 
            // FrmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 562);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.txtBuscarporTelefono);
            this.Controls.Add(this.txtBuscarxcedula);
            this.Controls.Add(this.lblBuscarxtelefono);
            this.Controls.Add(this.lblBuscarxcedula);
            this.Controls.Add(this.tnFiltrar);
            this.Controls.Add(this.rbtBuscarportelefono);
            this.Controls.Add(this.rbtnBuscarporcedula);
            this.Controls.Add(this.lblFiltro);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCedular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.Label lblListarClientes;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.RadioButton rbtnBuscarporcedula;
        private System.Windows.Forms.RadioButton rbtBuscarportelefono;
        private System.Windows.Forms.Button tnFiltrar;
        private System.Windows.Forms.Label lblBuscarxcedula;
        private System.Windows.Forms.Label lblBuscarxtelefono;
        private System.Windows.Forms.TextBox txtBuscarxcedula;
        private System.Windows.Forms.TextBox txtBuscarporTelefono;
        private System.Windows.Forms.Label lblFiltros;
    }
}