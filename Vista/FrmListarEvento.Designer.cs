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
            this.dgvEventos.Location = new System.Drawing.Point(59, 100);
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
            // FrmListarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1233, 518);
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
    }
}