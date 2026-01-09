namespace Vista
{
    partial class FrmListarEvento
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumEventos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarListaEvento = new System.Windows.Forms.Button();
            this.lblNumEventos = new System.Windows.Forms.Label();
            this.txtNumEventos = new System.Windows.Forms.TextBox();
            this.lblCedulaORuc = new System.Windows.Forms.Label();
            this.txtCiRucCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbNumEventos = new System.Windows.Forms.RadioButton();
            this.rdbCedulaORuc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colNumEventos,
            this.colTipoEvento,
            this.colNombreEvento,
            this.colDescripcionEvento,
            this.colNumPersonas,
            this.colDireccionEvento,
            this.colEstadoEvento});
            this.dgvEventos.Location = new System.Drawing.Point(53, 195);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.Size = new System.Drawing.Size(1113, 348);
            this.dgvEventos.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro.";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNro.Width = 80;
            // 
            // colNumEventos
            // 
            this.colNumEventos.HeaderText = "Número Eventos";
            this.colNumEventos.MinimumWidth = 15;
            this.colNumEventos.Name = "colNumEventos";
            this.colNumEventos.ReadOnly = true;
            this.colNumEventos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumEventos.Width = 125;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.MinimumWidth = 15;
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            this.colTipoEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTipoEvento.Width = 125;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.MinimumWidth = 15;
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            this.colNombreEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNombreEvento.Width = 140;
            // 
            // colDescripcionEvento
            // 
            this.colDescripcionEvento.HeaderText = "Descripción del Evento";
            this.colDescripcionEvento.MinimumWidth = 15;
            this.colDescripcionEvento.Name = "colDescripcionEvento";
            this.colDescripcionEvento.ReadOnly = true;
            this.colDescripcionEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescripcionEvento.Width = 160;
            // 
            // colNumPersonas
            // 
            this.colNumPersonas.HeaderText = "Número de Personas";
            this.colNumPersonas.MinimumWidth = 15;
            this.colNumPersonas.Name = "colNumPersonas";
            this.colNumPersonas.ReadOnly = true;
            this.colNumPersonas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumPersonas.Width = 125;
            // 
            // colDireccionEvento
            // 
            this.colDireccionEvento.HeaderText = "Dirección/Ubicación";
            this.colDireccionEvento.MinimumWidth = 15;
            this.colDireccionEvento.Name = "colDireccionEvento";
            this.colDireccionEvento.ReadOnly = true;
            this.colDireccionEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDireccionEvento.Width = 200;
            // 
            // colEstadoEvento
            // 
            this.colEstadoEvento.HeaderText = "Estado";
            this.colEstadoEvento.MinimumWidth = 15;
            this.colEstadoEvento.Name = "colEstadoEvento";
            this.colEstadoEvento.ReadOnly = true;
            this.colEstadoEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEstadoEvento.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listar Eventos";
            // 
            // btnActualizarListaEvento
            // 
            this.btnActualizarListaEvento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarListaEvento.ForeColor = System.Drawing.Color.Blue;
            this.btnActualizarListaEvento.Location = new System.Drawing.Point(542, 572);
            this.btnActualizarListaEvento.Name = "btnActualizarListaEvento";
            this.btnActualizarListaEvento.Size = new System.Drawing.Size(139, 46);
            this.btnActualizarListaEvento.TabIndex = 5;
            this.btnActualizarListaEvento.Text = "Actualizar";
            this.btnActualizarListaEvento.UseVisualStyleBackColor = true;
            this.btnActualizarListaEvento.Click += new System.EventHandler(this.btnActualizarListaEvento_Click);
            // 
            // lblNumEventos
            // 
            this.lblNumEventos.AutoSize = true;
            this.lblNumEventos.Location = new System.Drawing.Point(53, 99);
            this.lblNumEventos.Name = "lblNumEventos";
            this.lblNumEventos.Size = new System.Drawing.Size(189, 23);
            this.lblNumEventos.TabIndex = 6;
            this.lblNumEventos.Text = "Número de Eventos:";
            // 
            // txtNumEventos
            // 
            this.txtNumEventos.Location = new System.Drawing.Point(248, 96);
            this.txtNumEventos.Name = "txtNumEventos";
            this.txtNumEventos.Size = new System.Drawing.Size(204, 30);
            this.txtNumEventos.TabIndex = 7;
            // 
            // lblCedulaORuc
            // 
            this.lblCedulaORuc.AutoSize = true;
            this.lblCedulaORuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaORuc.ForeColor = System.Drawing.Color.Black;
            this.lblCedulaORuc.Location = new System.Drawing.Point(502, 103);
            this.lblCedulaORuc.Name = "lblCedulaORuc";
            this.lblCedulaORuc.Size = new System.Drawing.Size(141, 23);
            this.lblCedulaORuc.TabIndex = 21;
            this.lblCedulaORuc.Text = "Cédula o RUC:";
            // 
            // txtCiRucCliente
            // 
            this.txtCiRucCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiRucCliente.Location = new System.Drawing.Point(649, 100);
            this.txtCiRucCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiRucCliente.MaxLength = 13;
            this.txtCiRucCliente.Name = "txtCiRucCliente";
            this.txtCiRucCliente.Size = new System.Drawing.Size(160, 30);
            this.txtCiRucCliente.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filtros:";
            // 
            // rdbNumEventos
            // 
            this.rdbNumEventos.AutoSize = true;
            this.rdbNumEventos.Location = new System.Drawing.Point(914, 101);
            this.rdbNumEventos.Name = "rdbNumEventos";
            this.rdbNumEventos.Size = new System.Drawing.Size(204, 27);
            this.rdbNumEventos.TabIndex = 24;
            this.rdbNumEventos.TabStop = true;
            this.rdbNumEventos.Text = "Número de Eventos";
            this.rdbNumEventos.UseVisualStyleBackColor = true;
            this.rdbNumEventos.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // rdbCedulaORuc
            // 
            this.rdbCedulaORuc.AutoSize = true;
            this.rdbCedulaORuc.Location = new System.Drawing.Point(914, 134);
            this.rdbCedulaORuc.Name = "rdbCedulaORuc";
            this.rdbCedulaORuc.Size = new System.Drawing.Size(156, 27);
            this.rdbCedulaORuc.TabIndex = 25;
            this.rdbCedulaORuc.TabStop = true;
            this.rdbCedulaORuc.Text = "Cédula o RUC";
            this.rdbCedulaORuc.UseVisualStyleBackColor = true;
            this.rdbCedulaORuc.CheckedChanged += new System.EventHandler(this.selectradionButton_CheckedChanged);
            // 
            // FrmListarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1233, 641);
            this.Controls.Add(this.rdbCedulaORuc);
            this.Controls.Add(this.rdbNumEventos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCedulaORuc);
            this.Controls.Add(this.txtCiRucCliente);
            this.Controls.Add(this.txtNumEventos);
            this.Controls.Add(this.lblNumEventos);
            this.Controls.Add(this.btnActualizarListaEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Evento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoEvento;
        private System.Windows.Forms.Button btnActualizarListaEvento;
        private System.Windows.Forms.Label lblNumEventos;
        private System.Windows.Forms.TextBox txtNumEventos;
        private System.Windows.Forms.Label lblCedulaORuc;
        private System.Windows.Forms.TextBox txtCiRucCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbNumEventos;
        private System.Windows.Forms.RadioButton rdbCedulaORuc;
    }
}