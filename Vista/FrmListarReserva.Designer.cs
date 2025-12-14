namespace Visual
{
    partial class FrmListarReserva
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colCliente,
            this.colNombreEvento,
            this.colTipoEvento,
            this.colCantPersonas,
            this.colFechaReserva,
            this.colHoraInicio,
            this.colHoraFin});
            this.dgvReservas.Location = new System.Drawing.Point(121, 95);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(1119, 185);
            this.dgvReservas.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 125;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 125;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.MinimumWidth = 6;
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            this.colNombreEvento.Width = 125;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.MinimumWidth = 6;
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            this.colTipoEvento.Width = 125;
            // 
            // colCantPersonas
            // 
            this.colCantPersonas.HeaderText = "Cantidad de Personas";
            this.colCantPersonas.MinimumWidth = 6;
            this.colCantPersonas.Name = "colCantPersonas";
            this.colCantPersonas.ReadOnly = true;
            this.colCantPersonas.Width = 125;
            // 
            // colFechaReserva
            // 
            this.colFechaReserva.HeaderText = "Fecha Reserva";
            this.colFechaReserva.MinimumWidth = 6;
            this.colFechaReserva.Name = "colFechaReserva";
            this.colFechaReserva.ReadOnly = true;
            this.colFechaReserva.Width = 125;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.HeaderText = "Hora Inicio";
            this.colHoraInicio.MinimumWidth = 6;
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            this.colHoraInicio.Width = 125;
            // 
            // colHoraFin
            // 
            this.colHoraFin.HeaderText = "Hora fin";
            this.colHoraFin.MinimumWidth = 6;
            this.colHoraFin.Name = "colHoraFin";
            this.colHoraFin.ReadOnly = true;
            this.colHoraFin.Width = 125;
            // 
            // FrmListarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 554);
            this.Controls.Add(this.dgvReservas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListarReserva";
            this.Text = "Lista de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraFin;
    }
}