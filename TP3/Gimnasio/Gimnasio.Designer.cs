namespace Gimnasio
{
    partial class Gimnasio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gimnasio));
            this.picBoxFondo = new System.Windows.Forms.PictureBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnVerPlanes = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVerActividades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFondo
            // 
            this.picBoxFondo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBoxFondo.ErrorImage")));
            this.picBoxFondo.ImageLocation = "200";
            this.picBoxFondo.Location = new System.Drawing.Point(0, 0);
            this.picBoxFondo.Name = "picBoxFondo";
            this.picBoxFondo.Size = new System.Drawing.Size(736, 450);
            this.picBoxFondo.TabIndex = 1;
            this.picBoxFondo.TabStop = false;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.IndianRed;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 130);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(225, 54);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnVerPlanes
            // 
            this.btnVerPlanes.BackColor = System.Drawing.Color.IndianRed;
            this.btnVerPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPlanes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerPlanes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerPlanes.Location = new System.Drawing.Point(12, 250);
            this.btnVerPlanes.Name = "btnVerPlanes";
            this.btnVerPlanes.Size = new System.Drawing.Size(225, 54);
            this.btnVerPlanes.TabIndex = 5;
            this.btnVerPlanes.Text = "Ver Planes";
            this.btnVerPlanes.UseVisualStyleBackColor = false;
            this.btnVerPlanes.Click += new System.EventHandler(this.btnVerPlanes_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.BackColor = System.Drawing.Color.IndianRed;
            this.btnVerClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerClientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerClientes.Location = new System.Drawing.Point(12, 190);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(225, 54);
            this.btnVerClientes.TabIndex = 6;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = false;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.IndianRed;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Image = ((System.Drawing.Image)(resources.GetObject("lblNombre.Image")));
            this.lblNombre.Location = new System.Drawing.Point(39, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(183, 76);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "JUST DO IT\r\nGIMNASIO\r\n";
            // 
            // btnVerActividades
            // 
            this.btnVerActividades.BackColor = System.Drawing.Color.IndianRed;
            this.btnVerActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerActividades.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerActividades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerActividades.Location = new System.Drawing.Point(12, 310);
            this.btnVerActividades.Name = "btnVerActividades";
            this.btnVerActividades.Size = new System.Drawing.Size(225, 54);
            this.btnVerActividades.TabIndex = 8;
            this.btnVerActividades.Text = "Ver Actividades";
            this.btnVerActividades.UseVisualStyleBackColor = false;
            this.btnVerActividades.Click += new System.EventHandler(this.btnVerActividades_Click);
            // 
            // Gimnasio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.btnVerActividades);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVerClientes);
            this.Controls.Add(this.btnVerPlanes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.picBoxFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gimnasio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gimnasio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxFondo;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnVerPlanes;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVerActividades;
    }
}
