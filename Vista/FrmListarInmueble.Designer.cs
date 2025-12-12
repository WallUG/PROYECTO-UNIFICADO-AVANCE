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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colID,
            this.colNombre,
            this.colTipo,
            this.colCantidad,
            this.colPrecio,
            this.colDisponible});
            this.dgvInmueble.Location = new System.Drawing.Point(30, 12);
            this.dgvInmueble.Name = "dgvInmueble";
            this.dgvInmueble.ReadOnly = true;
            this.dgvInmueble.Size = new System.Drawing.Size(645, 212);
            this.dgvInmueble.TabIndex = 0;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre de Inmueble";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo de Inmueble";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad Disponible";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colDisponible
            // 
            this.colDisponible.HeaderText = "Disponibilidad";
            this.colDisponible.Name = "colDisponible";
            this.colDisponible.ReadOnly = true;
            // 
            // FrmListarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 236);
            this.Controls.Add(this.dgvInmueble);
            this.Name = "FrmListarInmueble";
            this.Text = "FrmListarInmueble";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmueble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponible;
    }
}