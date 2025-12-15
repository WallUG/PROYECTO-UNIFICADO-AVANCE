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
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccionEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvento
            // 
            this.dgvEvento.AllowUserToAddRows = false;
            this.dgvEvento.AllowUserToDeleteRows = false;
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTipoEvento,
            this.colNombreEvento,
            this.colDescripcionEvento,
            this.colNumPersona,
            this.colDireccionEvento,
            this.colEstadoEvento});
            this.dgvEvento.Location = new System.Drawing.Point(65, 52);
            this.dgvEvento.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.ReadOnly = true;
            this.dgvEvento.RowHeadersWidth = 51;
            this.dgvEvento.RowTemplate.Height = 24;
            this.dgvEvento.Size = new System.Drawing.Size(1005, 348);
            this.dgvEvento.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 15;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Width = 80;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.Frozen = true;
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.MinimumWidth = 15;
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            this.colTipoEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTipoEvento.Width = 125;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.Frozen = true;
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.MinimumWidth = 15;
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            this.colNombreEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNombreEvento.Width = 140;
            // 
            // colDescripcionEvento
            // 
            this.colDescripcionEvento.Frozen = true;
            this.colDescripcionEvento.HeaderText = "Descripción del Evento";
            this.colDescripcionEvento.MinimumWidth = 15;
            this.colDescripcionEvento.Name = "colDescripcionEvento";
            this.colDescripcionEvento.ReadOnly = true;
            this.colDescripcionEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDescripcionEvento.Width = 160;
            // 
            // colNumPersona
            // 
            this.colNumPersona.Frozen = true;
            this.colNumPersona.HeaderText = "Número de Personas";
            this.colNumPersona.MinimumWidth = 15;
            this.colNumPersona.Name = "colNumPersona";
            this.colNumPersona.ReadOnly = true;
            this.colNumPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumPersona.Width = 125;
            // 
            // colDireccionEvento
            // 
            this.colDireccionEvento.Frozen = true;
            this.colDireccionEvento.HeaderText = "Dirección/Ubicación";
            this.colDireccionEvento.MinimumWidth = 15;
            this.colDireccionEvento.Name = "colDireccionEvento";
            this.colDireccionEvento.ReadOnly = true;
            this.colDireccionEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDireccionEvento.Width = 200;
            // 
            // colEstadoEvento
            // 
            this.colEstadoEvento.Frozen = true;
            this.colEstadoEvento.HeaderText = "Estado";
            this.colEstadoEvento.MinimumWidth = 15;
            this.colEstadoEvento.Name = "colEstadoEvento";
            this.colEstadoEvento.ReadOnly = true;
            this.colEstadoEvento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEstadoEvento.Width = 125;
            // 
            // FrmListarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1152, 469);
            this.Controls.Add(this.dgvEvento);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Evento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccionEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoEvento;
    }
}