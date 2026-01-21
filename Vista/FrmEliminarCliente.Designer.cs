namespace Vista
{
    partial class FrmEliminarCliente
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
            this.lblEliminarClientesClientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.txtBuscarxcedula = new System.Windows.Forms.TextBox();
            this.lblBuscarxcedula = new System.Windows.Forms.Label();
            this.tnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEliminarClientesClientes
            // 
            this.lblEliminarClientesClientes.AutoSize = true;
            this.lblEliminarClientesClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEliminarClientesClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarClientesClientes.Location = new System.Drawing.Point(576, 25);
            this.lblEliminarClientesClientes.Name = "lblEliminarClientesClientes";
            this.lblEliminarClientesClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEliminarClientesClientes.Size = new System.Drawing.Size(314, 32);
            this.lblEliminarClientesClientes.TabIndex = 3;
            this.lblEliminarClientesClientes.Text = "ELIMINAR CLIENTES ";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellidos,
            this.colCedula,
            this.colTelefono,
            this.colCorreo});
            this.dgvClientes.Location = new System.Drawing.Point(83, 311);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(1191, 217);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(627, 550);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 52);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(347, 101);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(112, 29);
            this.lblFiltros.TabIndex = 19;
            this.lblFiltros.Text = "FILTRO:";
            // 
            // txtBuscarxcedula
            // 
            this.txtBuscarxcedula.Location = new System.Drawing.Point(627, 167);
            this.txtBuscarxcedula.MaxLength = 12;
            this.txtBuscarxcedula.Name = "txtBuscarxcedula";
            this.txtBuscarxcedula.Size = new System.Drawing.Size(236, 26);
            this.txtBuscarxcedula.TabIndex = 17;
            // 
            // lblBuscarxcedula
            // 
            this.lblBuscarxcedula.AutoSize = true;
            this.lblBuscarxcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarxcedula.Location = new System.Drawing.Point(357, 173);
            this.lblBuscarxcedula.Name = "lblBuscarxcedula";
            this.lblBuscarxcedula.Size = new System.Drawing.Size(207, 20);
            this.lblBuscarxcedula.TabIndex = 15;
            this.lblBuscarxcedula.Text = "BUSCAR POR CEDULA:\r\n";
            // 
            // tnFiltrar
            // 
            this.tnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tnFiltrar.Location = new System.Drawing.Point(643, 231);
            this.tnFiltrar.Name = "tnFiltrar";
            this.tnFiltrar.Size = new System.Drawing.Size(134, 52);
            this.tnFiltrar.TabIndex = 14;
            this.tnFiltrar.Text = "FILTRAR";
            this.tnFiltrar.UseVisualStyleBackColor = true;
            this.tnFiltrar.Click += new System.EventHandler(this.tnFiltrar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(282, 138);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(0, 29);
            this.lblFiltro.TabIndex = 11;
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
            // FrmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 659);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.txtBuscarxcedula);
            this.Controls.Add(this.lblBuscarxcedula);
            this.Controls.Add(this.tnFiltrar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblEliminarClientesClientes);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmEliminarCliente";
            this.Text = "FrmEliminarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarClientesClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.TextBox txtBuscarxcedula;
        private System.Windows.Forms.Label lblBuscarxcedula;
        private System.Windows.Forms.Button tnFiltrar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
    }
}