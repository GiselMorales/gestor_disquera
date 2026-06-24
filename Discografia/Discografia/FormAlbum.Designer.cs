namespace Discografia
{
    partial class FormAlbum
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
            this.ctNacionalidad = new System.Windows.Forms.TextBox();
            this.albumesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disqueralizardDataSet = new Discografia.disqueralizardDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctIDArtista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.albumesTableAdapter = new Discografia.disqueralizardDataSetTableAdapters.AlbumesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ctNacionalidad
            // 
            this.ctNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumesBindingSource, "FechaLanzamiento", true));
            this.ctNacionalidad.Location = new System.Drawing.Point(40, 340);
            this.ctNacionalidad.Multiline = true;
            this.ctNacionalidad.Name = "ctNacionalidad";
            this.ctNacionalidad.Size = new System.Drawing.Size(224, 34);
            this.ctNacionalidad.TabIndex = 118;
            // 
            // albumesBindingSource
            // 
            this.albumesBindingSource.DataMember = "Albumes";
            this.albumesBindingSource.DataSource = this.disqueralizardDataSet;
            // 
            // disqueralizardDataSet
            // 
            this.disqueralizardDataSet.DataSetName = "disqueralizardDataSet";
            this.disqueralizardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(36, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 23);
            this.label5.TabIndex = 117;
            this.label5.Text = "FECHA DE LANZAMIENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(311, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 116;
            this.label4.Text = "ALBUM";
            // 
            // ctNombre
            // 
            this.ctNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumesBindingSource, "Titulo", true));
            this.ctNombre.Location = new System.Drawing.Point(40, 244);
            this.ctNombre.Multiline = true;
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(369, 34);
            this.ctNombre.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(36, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 114;
            this.label2.Text = "TITULO:";
            // 
            // ctIDArtista
            // 
            this.ctIDArtista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumesBindingSource, "IDAlbum", true));
            this.ctIDArtista.Location = new System.Drawing.Point(32, 152);
            this.ctIDArtista.Multiline = true;
            this.ctIDArtista.Name = "ctIDArtista";
            this.ctIDArtista.Size = new System.Drawing.Size(232, 34);
            this.ctIDArtista.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(142, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 112;
            this.label1.Text = "REGISTRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 111;
            this.label3.Text = "ID ALBÙM:";
            // 
            // albumesTableAdapter
            // 
            this.albumesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumesBindingSource, "IDSello", true));
            this.textBox1.Location = new System.Drawing.Point(40, 430);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 34);
            this.textBox1.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(36, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 119;
            this.label6.Text = "ID SELLO:";
            // 
            // FormAlbum
            // 
            this.ClientSize = new System.Drawing.Size(621, 627);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctNacionalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctIDArtista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormAlbum";
            this.Load += new System.EventHandler(this.FormAlbum_Load);
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
            this.Controls.SetChildIndex(this.textBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.albumesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctNacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctIDArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private disqueralizardDataSet disqueralizardDataSet;
        private System.Windows.Forms.BindingSource albumesBindingSource;
        private disqueralizardDataSetTableAdapters.AlbumesTableAdapter albumesTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}
