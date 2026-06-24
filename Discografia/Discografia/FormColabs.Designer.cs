namespace Discografia
{
    partial class FormColabs
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctNacionalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctIDArtista = new System.Windows.Forms.TextBox();
            this.disqueralizardDataSet = new Discografia.disqueralizardDataSet();
            this.colaboracionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboracionesTableAdapter = new Discografia.disqueralizardDataSetTableAdapters.ColaboracionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctBuscar
            // 
            this.ctBuscar.Location = new System.Drawing.Point(404, 101);
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.Color.LightPink;
            this.btbuscar.Location = new System.Drawing.Point(303, 105);
            // 
            // btborrar
            // 
            this.btborrar.BackColor = System.Drawing.Color.LightPink;
            this.btborrar.Location = new System.Drawing.Point(433, 276);
            // 
            // btañadir
            // 
            this.btañadir.BackColor = System.Drawing.Color.LightPink;
            this.btañadir.Location = new System.Drawing.Point(433, 195);
            // 
            // btUltimo
            // 
            this.btUltimo.Location = new System.Drawing.Point(483, 426);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(361, 426);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(116, 427);
            // 
            // btPrimero
            // 
            this.btPrimero.Location = new System.Drawing.Point(18, 427);
            // 
            // etPosicion
            // 
            this.etPosicion.Location = new System.Drawing.Point(215, 426);
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(196, 481);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(252, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 32);
            this.label4.TabIndex = 132;
            this.label4.Text = "COLABORACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 131;
            this.label1.Text = "REGISTRO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(44, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 139;
            this.label6.Text = "ID CANCION:";
            // 
            // ctNacionalidad
            // 
            this.ctNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracionesBindingSource, "Rol", true));
            this.ctNacionalidad.Location = new System.Drawing.Point(48, 347);
            this.ctNacionalidad.Multiline = true;
            this.ctNacionalidad.Name = "ctNacionalidad";
            this.ctNacionalidad.Size = new System.Drawing.Size(224, 34);
            this.ctNacionalidad.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(44, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 137;
            this.label5.Text = "ROL:";
            // 
            // ctNombre
            // 
            this.ctNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracionesBindingSource, "IDArtista", true));
            this.ctNombre.Location = new System.Drawing.Point(48, 251);
            this.ctNombre.Multiline = true;
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(224, 34);
            this.ctNombre.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(44, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 135;
            this.label2.Text = "ID ARTISTA:";
            // 
            // ctIDArtista
            // 
            this.ctIDArtista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracionesBindingSource, "IDCancion", true));
            this.ctIDArtista.Location = new System.Drawing.Point(40, 159);
            this.ctIDArtista.Multiline = true;
            this.ctIDArtista.Name = "ctIDArtista";
            this.ctIDArtista.Size = new System.Drawing.Size(232, 34);
            this.ctIDArtista.TabIndex = 134;
            // 
            // disqueralizardDataSet
            // 
            this.disqueralizardDataSet.DataSetName = "disqueralizardDataSet";
            this.disqueralizardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboracionesBindingSource
            // 
            this.colaboracionesBindingSource.DataMember = "Colaboraciones";
            this.colaboracionesBindingSource.DataSource = this.disqueralizardDataSet;
            // 
            // colaboracionesTableAdapter
            // 
            this.colaboracionesTableAdapter.ClearBeforeFill = true;
            // 
            // FormColabs
            // 
            this.ClientSize = new System.Drawing.Size(621, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctNacionalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctIDArtista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormColabs";
            this.Load += new System.EventHandler(this.FormColabs_Load);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ctIDArtista, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ctNombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ctNacionalidad, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctNacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctIDArtista;
        private disqueralizardDataSet disqueralizardDataSet;
        private System.Windows.Forms.BindingSource colaboracionesBindingSource;
        private disqueralizardDataSetTableAdapters.ColaboracionesTableAdapter colaboracionesTableAdapter;
    }
}
