namespace Discografia
{
    partial class FormArtistas
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctIDArtista = new System.Windows.Forms.TextBox();
            this.artistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disqueralizardDataSet = new Discografia.disqueralizardDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctNacionalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctFechanac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.artistasTableAdapter = new Discografia.disqueralizardDataSetTableAdapters.ArtistasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 103;
            this.label3.Text = "ID ARTISTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(142, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 104;
            this.label1.Text = "REGISTRO";
            // 
            // ctIDArtista
            // 
            this.ctIDArtista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artistasBindingSource, "IDArtista", true));
            this.ctIDArtista.Location = new System.Drawing.Point(32, 150);
            this.ctIDArtista.Multiline = true;
            this.ctIDArtista.Name = "ctIDArtista";
            this.ctIDArtista.Size = new System.Drawing.Size(234, 34);
            this.ctIDArtista.TabIndex = 105;
            // 
            // artistasBindingSource
            // 
            this.artistasBindingSource.DataMember = "Artistas";
            this.artistasBindingSource.DataSource = this.disqueralizardDataSet;
            // 
            // disqueralizardDataSet
            // 
            this.disqueralizardDataSet.DataSetName = "disqueralizardDataSet";
            this.disqueralizardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(36, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 106;
            this.label2.Text = "NOMBRE:";
            // 
            // ctNombre
            // 
            this.ctNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artistasBindingSource, "Nombre", true));
            this.ctNombre.Location = new System.Drawing.Point(40, 242);
            this.ctNombre.Multiline = true;
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(273, 34);
            this.ctNombre.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Plum;
            this.label4.Location = new System.Drawing.Point(311, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 108;
            this.label4.Text = "ARTISTAS";
            // 
            // ctNacionalidad
            // 
            this.ctNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artistasBindingSource, "Nacionalidad", true));
            this.ctNacionalidad.Location = new System.Drawing.Point(40, 338);
            this.ctNacionalidad.Multiline = true;
            this.ctNacionalidad.Name = "ctNacionalidad";
            this.ctNacionalidad.Size = new System.Drawing.Size(201, 34);
            this.ctNacionalidad.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(36, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 109;
            this.label5.Text = "NACIONALIDAD:";
            // 
            // ctFechanac
            // 
            this.ctFechanac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artistasBindingSource, "FechaNacimiento", true));
            this.ctFechanac.Location = new System.Drawing.Point(40, 431);
            this.ctFechanac.Multiline = true;
            this.ctFechanac.Name = "ctFechanac";
            this.ctFechanac.Size = new System.Drawing.Size(201, 34);
            this.ctFechanac.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(36, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 23);
            this.label6.TabIndex = 111;
            this.label6.Text = "FECHA DE NACIMIENTO:";
            // 
            // artistasTableAdapter
            // 
            this.artistasTableAdapter.ClearBeforeFill = true;
            // 
            // FormArtistas
            // 
            this.ClientSize = new System.Drawing.Size(621, 627);
            this.Controls.Add(this.ctFechanac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctNacionalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctIDArtista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormArtistas";
            this.Load += new System.EventHandler(this.FormArtistas_Load);
            this.Controls.SetChildIndex(this.btPrimero, 0);
            this.Controls.SetChildIndex(this.btAnterior, 0);
            this.Controls.SetChildIndex(this.btSiguiente, 0);
            this.Controls.SetChildIndex(this.btUltimo, 0);
            this.Controls.SetChildIndex(this.btañadir, 0);
            this.Controls.SetChildIndex(this.btborrar, 0);
            this.Controls.SetChildIndex(this.btbuscar, 0);
            this.Controls.SetChildIndex(this.ctBuscar, 0);
            this.Controls.SetChildIndex(this.etPosicion, 0);
            this.Controls.SetChildIndex(this.btRegresar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ctIDArtista, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ctNombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ctNacionalidad, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.ctFechanac, 0);
            ((System.ComponentModel.ISupportInitialize)(this.artistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctIDArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctNacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctFechanac;
        private System.Windows.Forms.Label label6;
        private disqueralizardDataSet disqueralizardDataSet;
        private System.Windows.Forms.BindingSource artistasBindingSource;
        private disqueralizardDataSetTableAdapters.ArtistasTableAdapter artistasTableAdapter;
    }
}
