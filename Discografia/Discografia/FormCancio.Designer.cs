namespace Discografia
{
    partial class FormCancio
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctNacionalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctIDArtista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disqueralizardDataSet = new Discografia.disqueralizardDataSet();
            this.cancionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancionesTableAdapter = new Discografia.disqueralizardDataSetTableAdapters.CancionesTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btUltimo
            // 
            this.btUltimo.BackColor = System.Drawing.Color.MediumPurple;
            // 
            // btSiguiente
            // 
            this.btSiguiente.BackColor = System.Drawing.Color.MediumPurple;
            // 
            // btAnterior
            // 
            this.btAnterior.BackColor = System.Drawing.Color.MediumPurple;
            // 
            // btPrimero
            // 
            this.btPrimero.BackColor = System.Drawing.Color.MediumPurple;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancionesBindingSource, "IDAlbum", true));
            this.textBox1.Location = new System.Drawing.Point(32, 432);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 34);
            this.textBox1.TabIndex = 128;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(28, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 127;
            this.label6.Text = "ID CANCION:";
            // 
            // ctNacionalidad
            // 
            this.ctNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancionesBindingSource, "Duracion", true));
            this.ctNacionalidad.Location = new System.Drawing.Point(32, 342);
            this.ctNacionalidad.Multiline = true;
            this.ctNacionalidad.Name = "ctNacionalidad";
            this.ctNacionalidad.Size = new System.Drawing.Size(224, 34);
            this.ctNacionalidad.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(28, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 125;
            this.label5.Text = "DURACION:";
            // 
            // ctNombre
            // 
            this.ctNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancionesBindingSource, "Titulo", true));
            this.ctNombre.Location = new System.Drawing.Point(32, 246);
            this.ctNombre.Multiline = true;
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(369, 34);
            this.ctNombre.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(28, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 123;
            this.label2.Text = "TITULO:";
            // 
            // ctIDArtista
            // 
            this.ctIDArtista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancionesBindingSource, "IDCancion", true));
            this.ctIDArtista.Location = new System.Drawing.Point(24, 154);
            this.ctIDArtista.Multiline = true;
            this.ctIDArtista.Name = "ctIDArtista";
            this.ctIDArtista.Size = new System.Drawing.Size(232, 34);
            this.ctIDArtista.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(28, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 121;
            this.label3.Text = "ID ALBÙM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(321, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 130;
            this.label4.Text = "CANCIÒN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(152, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 129;
            this.label1.Text = "REGISTRO";
            // 
            // disqueralizardDataSet
            // 
            this.disqueralizardDataSet.DataSetName = "disqueralizardDataSet";
            this.disqueralizardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancionesBindingSource
            // 
            this.cancionesBindingSource.DataMember = "Canciones";
            this.cancionesBindingSource.DataSource = this.disqueralizardDataSet;
            // 
            // cancionesTableAdapter
            // 
            this.cancionesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancionesBindingSource, "IDProductor", true));
            this.textBox2.Location = new System.Drawing.Point(327, 432);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 34);
            this.textBox2.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(323, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 131;
            this.label7.Text = "ID PRODUCTOR:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cancionesBindingSource, "IDArtista", true));
            this.textBox3.Location = new System.Drawing.Point(327, 342);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 34);
            this.textBox3.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepPink;
            this.label8.Location = new System.Drawing.Point(323, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 133;
            this.label8.Text = "ID ARTISTA:";
            // 
            // FormCancio
            // 
            this.ClientSize = new System.Drawing.Size(621, 627);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctNacionalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctIDArtista);
            this.Controls.Add(this.label3);
            this.Name = "FormCancio";
            this.Load += new System.EventHandler(this.FormCancio_Load);
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
            this.Controls.SetChildIndex(this.ctIDArtista, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ctNombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ctNacionalidad, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctNacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctIDArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private disqueralizardDataSet disqueralizardDataSet;
        private System.Windows.Forms.BindingSource cancionesBindingSource;
        private disqueralizardDataSetTableAdapters.CancionesTableAdapter cancionesTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
    }
}
