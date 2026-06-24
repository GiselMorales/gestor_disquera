namespace Discografia
{
    partial class Formbase
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
            this.ctBuscar = new System.Windows.Forms.TextBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btborrar = new System.Windows.Forms.Button();
            this.btañadir = new System.Windows.Forms.Button();
            this.btUltimo = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btPrimero = new System.Windows.Forms.Button();
            this.etPosicion = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctBuscar
            // 
            this.ctBuscar.Location = new System.Drawing.Point(442, 93);
            this.ctBuscar.Multiline = true;
            this.ctBuscar.Name = "ctBuscar";
            this.ctBuscar.Size = new System.Drawing.Size(124, 34);
            this.ctBuscar.TabIndex = 96;
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbuscar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscar.Location = new System.Drawing.Point(341, 97);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(95, 32);
            this.btbuscar.TabIndex = 95;
            this.btbuscar.Text = "BUSCAR";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btborrar
            // 
            this.btborrar.BackColor = System.Drawing.Color.CadetBlue;
            this.btborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btborrar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btborrar.Location = new System.Drawing.Point(471, 268);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(95, 32);
            this.btborrar.TabIndex = 94;
            this.btborrar.Text = "BORRAR";
            this.btborrar.UseVisualStyleBackColor = false;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // btañadir
            // 
            this.btañadir.BackColor = System.Drawing.Color.CadetBlue;
            this.btañadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btañadir.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btañadir.Location = new System.Drawing.Point(471, 187);
            this.btañadir.Name = "btañadir";
            this.btañadir.Size = new System.Drawing.Size(95, 32);
            this.btañadir.TabIndex = 93;
            this.btañadir.Text = "AÑADIR";
            this.btañadir.UseVisualStyleBackColor = false;
            this.btañadir.Click += new System.EventHandler(this.btañadir_Click);
            // 
            // btUltimo
            // 
            this.btUltimo.BackColor = System.Drawing.Color.LimeGreen;
            this.btUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUltimo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUltimo.Location = new System.Drawing.Point(497, 528);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(91, 32);
            this.btUltimo.TabIndex = 92;
            this.btUltimo.Text = "ULTIMO";
            this.btUltimo.UseVisualStyleBackColor = false;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.BackColor = System.Drawing.Color.LimeGreen;
            this.btSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSiguiente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSiguiente.Location = new System.Drawing.Point(375, 528);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(116, 32);
            this.btSiguiente.TabIndex = 91;
            this.btSiguiente.Text = "SIGUIENTE";
            this.btSiguiente.UseVisualStyleBackColor = false;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.BackColor = System.Drawing.Color.LimeGreen;
            this.btAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnterior.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnterior.Location = new System.Drawing.Point(130, 529);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(93, 32);
            this.btAnterior.TabIndex = 90;
            this.btAnterior.Text = "ANTERIOR";
            this.btAnterior.UseVisualStyleBackColor = false;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btPrimero
            // 
            this.btPrimero.BackColor = System.Drawing.Color.LimeGreen;
            this.btPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPrimero.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrimero.Location = new System.Drawing.Point(32, 529);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(83, 32);
            this.btPrimero.TabIndex = 82;
            this.btPrimero.Text = "PRIMERO";
            this.btPrimero.UseVisualStyleBackColor = false;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // etPosicion
            // 
            this.etPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPosicion.Location = new System.Drawing.Point(229, 528);
            this.etPosicion.Name = "etPosicion";
            this.etPosicion.Size = new System.Drawing.Size(140, 32);
            this.etPosicion.TabIndex = 101;
            this.etPosicion.Text = "No registros";
            // 
            // btRegresar
            // 
            this.btRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(208)))), ((int)(((byte)(30)))));
            this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRegresar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(210, 583);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(171, 32);
            this.btRegresar.TabIndex = 102;
            this.btRegresar.Text = "REGRESAR A MENÚ";
            this.btRegresar.UseVisualStyleBackColor = false;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // Formbase
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(621, 627);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.etPosicion);
            this.Controls.Add(this.ctBuscar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.btañadir);
            this.Controls.Add(this.btUltimo);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.btPrimero);
            this.Name = "Formbase";
            this.Text = "DISCOGRAFIA LIZARD";
            this.Load += new System.EventHandler(this.Formbase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox ctBuscar;
        protected System.Windows.Forms.Button btbuscar;
        protected System.Windows.Forms.Button btborrar;
        protected System.Windows.Forms.Button btañadir;
        protected System.Windows.Forms.Button btUltimo;
        protected System.Windows.Forms.Button btSiguiente;
        protected System.Windows.Forms.Button btAnterior;
        protected System.Windows.Forms.Button btPrimero;
        protected System.Windows.Forms.Label etPosicion;
        protected System.Windows.Forms.Button btRegresar;
    }
}