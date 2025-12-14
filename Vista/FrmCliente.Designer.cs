namespace Visual
{
    partial class FrmCliente
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
            this.lllbNombres = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.llbCedula = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lllbNombres
            // 
            this.lllbNombres.AutoSize = true;
            this.lllbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lllbNombres.Location = new System.Drawing.Point(83, 26);
            this.lllbNombres.Name = "lllbNombres";
            this.lllbNombres.Size = new System.Drawing.Size(113, 25);
            this.lllbNombres.TabIndex = 0;
            this.lllbNombres.Text = "NOMBRE*";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(88, 173);
            this.TxtApellidos.MaxLength = 100;
            this.TxtApellidos.Multiline = true;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(497, 46);
            this.TxtApellidos.TabIndex = 3;
            this.TxtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidos_KeyPress);
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(83, 128);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(126, 25);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "APELLIDO*";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(99, 285);
            this.txtCedula.MaxLength = 12;
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(336, 41);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // llbCedula
            // 
            this.llbCedula.AutoSize = true;
            this.llbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCedula.Location = new System.Drawing.Point(83, 242);
            this.llbCedula.Name = "llbCedula";
            this.llbCedula.Size = new System.Drawing.Size(182, 25);
            this.llbCedula.TabIndex = 4;
            this.llbCedula.Text = "CEDULA O RUC*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(93, 414);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(336, 41);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(88, 362);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(137, 25);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "TELEFONO*";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(93, 535);
            this.txtCorreoElectronico.Multiline = true;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(437, 41);
            this.txtCorreoElectronico.TabIndex = 9;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(88, 496);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(274, 25);
            this.lblCorreoElectronico.TabIndex = 8;
            this.lblCorreoElectronico.Text = "CORREO ELECTRONICO*";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(667, 436);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(510, 140);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(679, 376);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(140, 25);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "DIRECCION*";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(516, 644);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 58);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 65);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(497, 46);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 908);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.llbCedula);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.lllbNombres);
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lllbNombres;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label llbCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}