namespace Vista
{
    partial class FrmAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutores));
            this.lblAutor01 = new System.Windows.Forms.Label();
            this.lblAutor02 = new System.Windows.Forms.Label();
            this.lblAutor03 = new System.Windows.Forms.Label();
            this.lblAutor04 = new System.Windows.Forms.Label();
            this.lblAutor05 = new System.Windows.Forms.Label();
            this.pbAutor03 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutor03)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor01
            // 
            this.lblAutor01.AutoSize = true;
            this.lblAutor01.Location = new System.Drawing.Point(23, 258);
            this.lblAutor01.Name = "lblAutor01";
            this.lblAutor01.Size = new System.Drawing.Size(111, 16);
            this.lblAutor01.TabIndex = 0;
            this.lblAutor01.Text = "Chichanda Josue";
            this.lblAutor01.UseWaitCursor = true;
            this.lblAutor01.Click += new System.EventHandler(this.lblAutor01_Click);
            // 
            // lblAutor02
            // 
            this.lblAutor02.AutoSize = true;
            this.lblAutor02.Location = new System.Drawing.Point(188, 258);
            this.lblAutor02.Name = "lblAutor02";
            this.lblAutor02.Size = new System.Drawing.Size(93, 16);
            this.lblAutor02.TabIndex = 1;
            this.lblAutor02.Text = "Castillo Daniel";
            this.lblAutor02.Click += new System.EventHandler(this.lblAutor02_Click);
            // 
            // lblAutor03
            // 
            this.lblAutor03.AutoSize = true;
            this.lblAutor03.Location = new System.Drawing.Point(350, 258);
            this.lblAutor03.Name = "lblAutor03";
            this.lblAutor03.Size = new System.Drawing.Size(100, 16);
            this.lblAutor03.TabIndex = 2;
            this.lblAutor03.Text = "Garcia Gustavo";
            this.lblAutor03.Click += new System.EventHandler(this.lblAutor03_Click);
            // 
            // lblAutor04
            // 
            this.lblAutor04.AutoSize = true;
            this.lblAutor04.Location = new System.Drawing.Point(505, 258);
            this.lblAutor04.Name = "lblAutor04";
            this.lblAutor04.Size = new System.Drawing.Size(102, 16);
            this.lblAutor04.TabIndex = 3;
            this.lblAutor04.Text = "Pluas Leonardo";
            this.lblAutor04.Click += new System.EventHandler(this.lblAutor04_Click);
            // 
            // lblAutor05
            // 
            this.lblAutor05.AutoSize = true;
            this.lblAutor05.Location = new System.Drawing.Point(667, 258);
            this.lblAutor05.Name = "lblAutor05";
            this.lblAutor05.Size = new System.Drawing.Size(99, 16);
            this.lblAutor05.TabIndex = 4;
            this.lblAutor05.Text = "Zambrano Nick";
            this.lblAutor05.Click += new System.EventHandler(this.lblAutor05_Click);
            // 
            // pbAutor03
            // 
            this.pbAutor03.Image = ((System.Drawing.Image)(resources.GetObject("pbAutor03.Image")));
            this.pbAutor03.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAutor03.InitialImage")));
            this.pbAutor03.Location = new System.Drawing.Point(350, 90);
            this.pbAutor03.Name = "pbAutor03";
            this.pbAutor03.Size = new System.Drawing.Size(100, 149);
            this.pbAutor03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAutor03.TabIndex = 5;
            this.pbAutor03.TabStop = false;
            this.pbAutor03.Click += new System.EventHandler(this.lblAutor03_Click);
            // 
            // FrmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAutor03);
            this.Controls.Add(this.lblAutor05);
            this.Controls.Add(this.lblAutor04);
            this.Controls.Add(this.lblAutor03);
            this.Controls.Add(this.lblAutor02);
            this.Controls.Add(this.lblAutor01);
            this.Name = "FrmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores del Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutores_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbAutor03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutor01;
        private System.Windows.Forms.Label lblAutor02;
        private System.Windows.Forms.Label lblAutor03;
        private System.Windows.Forms.Label lblAutor04;
        private System.Windows.Forms.Label lblAutor05;
        private System.Windows.Forms.PictureBox pbAutor03;
    }
}