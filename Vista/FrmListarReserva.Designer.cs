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
            this.dgvReservas.Location = new System.Drawing.Point(91, 77);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(839, 150);
            this.dgvReservas.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colNombreEvento
            // 
            this.colNombreEvento.HeaderText = "Nombre del Evento";
            this.colNombreEvento.Name = "colNombreEvento";
            this.colNombreEvento.ReadOnly = true;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.HeaderText = "Tipo de Evento";
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.ReadOnly = true;
            // 
            // colCantPersonas
            // 
            this.colCantPersonas.HeaderText = "Cantidad de Personas";
            this.colCantPersonas.Name = "colCantPersonas";
            this.colCantPersonas.ReadOnly = true;
            // 
            // colFechaReserva
            // 
            this.colFechaReserva.HeaderText = "Fecha Reserva";
            this.colFechaReserva.Name = "colFechaReserva";
            this.colFechaReserva.ReadOnly = true;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.HeaderText = "Hora Inicio";
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            // 
            // colHoraFin
            // 
            this.colHoraFin.HeaderText = "Hora fin";
            this.colHoraFin.Name = "colHoraFin";
            this.colHoraFin.ReadOnly = true;
            // 
            // FrmListarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.dgvReservas);
            this.Name = "FrmListarReserva";
            this.Text = "FrmListarReserva";
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