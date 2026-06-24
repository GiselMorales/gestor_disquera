namespace Discografia
{
    partial class Formdisqueraa
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
            this.btAlbumes = new System.Windows.Forms.Button();
            this.lblalbumes = new System.Windows.Forms.Label();
            this.btcerrar = new System.Windows.Forms.Button();
            this.btCanciones = new System.Windows.Forms.Button();
            this.lblcanciones = new System.Windows.Forms.Label();
            this.btArtistas = new System.Windows.Forms.Button();
            this.lblartista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btColaboraciones = new System.Windows.Forms.Button();
            this.lblcolabs = new System.Windows.Forms.Label();
            this.btProductores = new System.Windows.Forms.Button();
            this.lblproductores = new System.Windows.Forms.Label();
            this.btVentas = new System.Windows.Forms.Button();
            this.lblventas = new System.Windows.Forms.Label();
            this.btaggusuario = new System.Windows.Forms.Button();
            this.disqueralizardDataSet1 = new Discografia.disqueralizardDataSet();
            this.usuariosTableAdapter1 = new Discografia.disqueralizardDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlbumes
            // 
            this.btAlbumes.BackColor = System.Drawing.Color.SteelBlue;
            this.btAlbumes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlbumes.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlbumes.Location = new System.Drawing.Point(360, 178);
            this.btAlbumes.Name = "btAlbumes";
            this.btAlbumes.Size = new System.Drawing.Size(281, 53);
            this.btAlbumes.TabIndex = 72;
            this.btAlbumes.Text = "Registro de  albumes";
            this.btAlbumes.UseVisualStyleBackColor = false;
            this.btAlbumes.Click += new System.EventHandler(this.btAlbumes_Click);
            // 
            // lblalbumes
            // 
            this.lblalbumes.AutoSize = true;
            this.lblalbumes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalbumes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblalbumes.Location = new System.Drawing.Point(458, 142);
            this.lblalbumes.Name = "lblalbumes";
            this.lblalbumes.Size = new System.Drawing.Size(98, 23);
            this.lblalbumes.TabIndex = 71;
            this.lblalbumes.Text = "ALBUMES:";
            // 
            // btcerrar
            // 
            this.btcerrar.BackColor = System.Drawing.Color.Gray;
            this.btcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrar.Location = new System.Drawing.Point(27, 501);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(950, 49);
            this.btcerrar.TabIndex = 69;
            this.btcerrar.Text = "Cerrar sesión";
            this.btcerrar.UseVisualStyleBackColor = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // btCanciones
            // 
            this.btCanciones.BackColor = System.Drawing.Color.HotPink;
            this.btCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCanciones.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCanciones.Location = new System.Drawing.Point(27, 180);
            this.btCanciones.Name = "btCanciones";
            this.btCanciones.Size = new System.Drawing.Size(281, 52);
            this.btCanciones.TabIndex = 68;
            this.btCanciones.Text = "Registro de canciones";
            this.btCanciones.UseVisualStyleBackColor = false;
            this.btCanciones.Click += new System.EventHandler(this.btCanciones_Click);
            // 
            // lblcanciones
            // 
            this.lblcanciones.AutoSize = true;
            this.lblcanciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcanciones.ForeColor = System.Drawing.Color.LightPink;
            this.lblcanciones.Location = new System.Drawing.Point(118, 142);
            this.lblcanciones.Name = "lblcanciones";
            this.lblcanciones.Size = new System.Drawing.Size(120, 23);
            this.lblcanciones.TabIndex = 67;
            this.lblcanciones.Text = "CANCIONES:";
            // 
            // btArtistas
            // 
            this.btArtistas.BackColor = System.Drawing.Color.MediumPurple;
            this.btArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btArtistas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArtistas.Location = new System.Drawing.Point(360, 327);
            this.btArtistas.Name = "btArtistas";
            this.btArtistas.Size = new System.Drawing.Size(281, 53);
            this.btArtistas.TabIndex = 66;
            this.btArtistas.Text = "Registro de artistas";
            this.btArtistas.UseVisualStyleBackColor = false;
            this.btArtistas.Click += new System.EventHandler(this.btArtistas_Click);
            // 
            // lblartista
            // 
            this.lblartista.AutoSize = true;
            this.lblartista.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblartista.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblartista.Location = new System.Drawing.Point(440, 287);
            this.lblartista.Name = "lblartista";
            this.lblartista.Size = new System.Drawing.Size(109, 23);
            this.lblartista.TabIndex = 65;
            this.lblartista.Text = "ARTISTAS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(37, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(472, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 63;
            this.label7.Text = "PRINCIPAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(368, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 32);
            this.label8.TabIndex = 62;
            this.label8.Text = "MENÚ";
            // 
            // btColaboraciones
            // 
            this.btColaboraciones.BackColor = System.Drawing.Color.Gold;
            this.btColaboraciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btColaboraciones.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btColaboraciones.Location = new System.Drawing.Point(27, 327);
            this.btColaboraciones.Name = "btColaboraciones";
            this.btColaboraciones.Size = new System.Drawing.Size(281, 53);
            this.btColaboraciones.TabIndex = 74;
            this.btColaboraciones.Text = "Registro de colaboración";
            this.btColaboraciones.UseVisualStyleBackColor = false;
            this.btColaboraciones.Click += new System.EventHandler(this.btColaboraciones_Click);
            // 
            // lblcolabs
            // 
            this.lblcolabs.AutoSize = true;
            this.lblcolabs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolabs.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblcolabs.Location = new System.Drawing.Point(81, 287);
            this.lblcolabs.Name = "lblcolabs";
            this.lblcolabs.Size = new System.Drawing.Size(175, 23);
            this.lblcolabs.TabIndex = 73;
            this.lblcolabs.Text = "COLABORACIONES:";
            // 
            // btProductores
            // 
            this.btProductores.BackColor = System.Drawing.Color.IndianRed;
            this.btProductores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btProductores.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProductores.Location = new System.Drawing.Point(682, 327);
            this.btProductores.Name = "btProductores";
            this.btProductores.Size = new System.Drawing.Size(281, 53);
            this.btProductores.TabIndex = 78;
            this.btProductores.Text = "Registro de productores";
            this.btProductores.UseVisualStyleBackColor = false;
            this.btProductores.Click += new System.EventHandler(this.btProductores_Click);
            // 
            // lblproductores
            // 
            this.lblproductores.AutoSize = true;
            this.lblproductores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductores.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblproductores.Location = new System.Drawing.Point(755, 287);
            this.lblproductores.Name = "lblproductores";
            this.lblproductores.Size = new System.Drawing.Size(142, 23);
            this.lblproductores.TabIndex = 77;
            this.lblproductores.Text = "PRODUCTORES:";
            // 
            // btVentas
            // 
            this.btVentas.BackColor = System.Drawing.Color.LimeGreen;
            this.btVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVentas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentas.Location = new System.Drawing.Point(682, 180);
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(281, 52);
            this.btVentas.TabIndex = 76;
            this.btVentas.Text = "Registro de ventas";
            this.btVentas.UseVisualStyleBackColor = false;
            this.btVentas.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventas.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblventas.Location = new System.Drawing.Point(773, 142);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(87, 23);
            this.lblventas.TabIndex = 75;
            this.lblventas.Text = "VENTAS:";
            // 
            // btaggusuario
            // 
            this.btaggusuario.BackColor = System.Drawing.Color.Snow;
            this.btaggusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btaggusuario.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaggusuario.Location = new System.Drawing.Point(27, 434);
            this.btaggusuario.Name = "btaggusuario";
            this.btaggusuario.Size = new System.Drawing.Size(950, 45);
            this.btaggusuario.TabIndex = 79;
            this.btaggusuario.Text = "Agregar nuevo usuario";
            this.btaggusuario.UseVisualStyleBackColor = false;
            // 
            // disqueralizardDataSet1
            // 
            this.disqueralizardDataSet1.DataSetName = "disqueralizardDataSet";
            this.disqueralizardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // Formdisqueraa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(999, 579);
            this.Controls.Add(this.btaggusuario);
            this.Controls.Add(this.btProductores);
            this.Controls.Add(this.lblproductores);
            this.Controls.Add(this.btVentas);
            this.Controls.Add(this.lblventas);
            this.Controls.Add(this.btColaboraciones);
            this.Controls.Add(this.lblcolabs);
            this.Controls.Add(this.btAlbumes);
            this.Controls.Add(this.lblalbumes);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.btCanciones);
            this.Controls.Add(this.lblcanciones);
            this.Controls.Add(this.btArtistas);
            this.Controls.Add(this.lblartista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "Formdisqueraa";
            this.Text = "DISQUERA LIZARD";
            this.Load += new System.EventHandler(this.Formdisqueraa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAlbumes;
        private System.Windows.Forms.Label lblalbumes;
        private System.Windows.Forms.Button btcerrar;
        private System.Windows.Forms.Button btCanciones;
        private System.Windows.Forms.Label lblcanciones;
        private System.Windows.Forms.Button btArtistas;
        private System.Windows.Forms.Label lblartista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btColaboraciones;
        private System.Windows.Forms.Label lblcolabs;
        private System.Windows.Forms.Button btProductores;
        private System.Windows.Forms.Label lblproductores;
        private System.Windows.Forms.Button btVentas;
        private System.Windows.Forms.Label lblventas;
        private System.Windows.Forms.Button btaggusuario;
        private disqueralizardDataSet disqueralizardDataSet1;
        private disqueralizardDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
    }
}