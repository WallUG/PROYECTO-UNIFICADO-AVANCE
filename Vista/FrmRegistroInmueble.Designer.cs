namespace Visual
{
    partial class FrmRegistroInmueble
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.Precio = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.Disponibilidad = new System.Windows.Forms.Label();
            this.chkDisponibilidad = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(321, 49);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(406, 45);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 26);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(406, 106);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(321, 111);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 20);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(321, 174);
            this.Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(39, 20);
            this.Tipo.TabIndex = 4;
            this.Tipo.Text = "Tipo";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(321, 235);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(73, 20);
            this.Cantidad.TabIndex = 6;
            this.Cantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(406, 232);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(150, 26);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(406, 298);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(150, 26);
            this.nudPrecio.TabIndex = 9;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(321, 302);
            this.Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(53, 20);
            this.Precio.TabIndex = 8;
            this.Precio.Text = "Precio";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(406, 169);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(148, 28);
            this.cmbTipo.TabIndex = 10;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.AutoSize = true;
            this.Disponibilidad.Location = new System.Drawing.Point(321, 365);
            this.Disponibilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.Size = new System.Drawing.Size(107, 20);
            this.Disponibilidad.TabIndex = 11;
            this.Disponibilidad.Text = "Disponibilidad";
            // 
            // chkDisponibilidad
            // 
            this.chkDisponibilidad.AutoSize = true;
            this.chkDisponibilidad.Checked = true;
            this.chkDisponibilidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisponibilidad.Location = new System.Drawing.Point(476, 365);
            this.chkDisponibilidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDisponibilidad.Name = "chkDisponibilidad";
            this.chkDisponibilidad.Size = new System.Drawing.Size(22, 21);
            this.chkDisponibilidad.TabIndex = 14;
            this.chkDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(386, 431);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(74, 475);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(730, 264);
            this.txtContenido.TabIndex = 13;
            // 
            // FrmRegistroInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 760);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Disponibilidad);
            this.Controls.Add(this.chkDisponibilidad);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRegistroInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INMUEBLE";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label Disponibilidad;
        private System.Windows.Forms.CheckBox chkDisponibilidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContenido;
    }
}

