namespace Gimnasio
{
    partial class NuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoCliente));
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.cmbMembresia = new System.Windows.Forms.ComboBox();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblMembresia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(64, 195);
            this.txbDni.Name = "txbDni";
            this.txbDni.PlaceholderText = "DNI";
            this.txbDni.Size = new System.Drawing.Size(249, 23);
            this.txbDni.TabIndex = 0;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(64, 224);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PlaceholderText = "Teléfono";
            this.txbTelefono.Size = new System.Drawing.Size(249, 23);
            this.txbTelefono.TabIndex = 2;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(64, 153);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.PlaceholderText = "Apellido";
            this.txbApellido.Size = new System.Drawing.Size(249, 23);
            this.txbApellido.TabIndex = 4;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(64, 124);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Nombre";
            this.txbNombre.Size = new System.Drawing.Size(249, 23);
            this.txbNombre.TabIndex = 5;
            // 
            // cmbMembresia
            // 
            this.cmbMembresia.FormattingEnabled = true;
            this.cmbMembresia.Location = new System.Drawing.Point(64, 335);
            this.cmbMembresia.Name = "cmbMembresia";
            this.cmbMembresia.Size = new System.Drawing.Size(249, 23);
            this.cmbMembresia.TabIndex = 6;
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNuevoCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("lblNuevoCliente.Image")));
            this.lblNuevoCliente.Location = new System.Drawing.Point(52, 37);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(277, 41);
            this.lblNuevoCliente.TabIndex = 7;
            this.lblNuevoCliente.Text = "NUEVO CLIENTE";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Image = global::Gimnasio.Properties.Resources.gim2;
            this.btnAgregar.Location = new System.Drawing.Point(202, 391);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 48);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(64, 279);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(249, 23);
            this.cmbGenero.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Image = global::Gimnasio.Properties.Resources.gim2;
            this.btnCancelar.Location = new System.Drawing.Point(64, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 48);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGenero.Image = global::Gimnasio.Properties.Resources.gim2;
            this.lblGenero.Location = new System.Drawing.Point(64, 257);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 19);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // lblMembresia
            // 
            this.lblMembresia.AutoSize = true;
            this.lblMembresia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMembresia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMembresia.Image = global::Gimnasio.Properties.Resources.gim2;
            this.lblMembresia.Location = new System.Drawing.Point(64, 313);
            this.lblMembresia.Name = "lblMembresia";
            this.lblMembresia.Size = new System.Drawing.Size(96, 19);
            this.lblMembresia.TabIndex = 12;
            this.lblMembresia.Text = "Membresia";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gimnasio.Properties.Resources.fondo_gim;
            this.ClientSize = new System.Drawing.Size(401, 469);
            this.Controls.Add(this.lblMembresia);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNuevoCliente);
            this.Controls.Add(this.cmbMembresia);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cmbMembresia;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblMembresia;
    }
}