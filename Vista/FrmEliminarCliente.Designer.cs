namespace Vista
{
    partial class EliminarCliente
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
            this.dgvEliminarCliente = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumCedular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.lblEliminarCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarCliente
            // 
            this.dgvEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellidos,
            this.colCedula,
            this.colNumCedular,
            this.colCorreo});
            this.dgvEliminarCliente.Location = new System.Drawing.Point(23, 227);
            this.dgvEliminarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEliminarCliente.Name = "dgvEliminarCliente";
            this.dgvEliminarCliente.RowHeadersWidth = 51;
            this.dgvEliminarCliente.RowTemplate.Height = 24;
            this.dgvEliminarCliente.Size = new System.Drawing.Size(1191, 217);
            this.dgvEliminarCliente.TabIndex = 1;
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
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(553, 469);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(142, 40);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "ELIMINAR";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // lblEliminarCliente
            // 
            this.lblEliminarCliente.AutoSize = true;
            this.lblEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCliente.Location = new System.Drawing.Point(492, 34);
            this.lblEliminarCliente.Name = "lblEliminarCliente";
            this.lblEliminarCliente.Size = new System.Drawing.Size(231, 32);
            this.lblEliminarCliente.TabIndex = 3;
            this.lblEliminarCliente.Text = "Eliminar Cliente";
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 541);
            this.Controls.Add(this.lblEliminarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.dgvEliminarCliente);
            this.Name = "EliminarCliente";
            this.Text = "FrmEliminarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCedular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label lblEliminarCliente;
    }
}