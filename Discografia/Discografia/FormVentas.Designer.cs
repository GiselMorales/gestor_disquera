namespace Discografia
{
    partial class FormVentas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctNacionalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctIDArtista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disqueralizardDataSet = new Discografia.disqueralizardDataSet();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Discografia.disqueralizardDataSetTableAdapters.VentasTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Cantidad", true));
            this.textBox1.Location = new System.Drawing.Point(51, 446);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 34);
            this.textBox1.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(47, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 160;
            this.label3.Text = "CANTIDAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(47, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 159;
            this.label6.Text = "ID VENTA:";
            // 
            // ctNacionalidad
            // 
            this.ctNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "FechaVenta", true));
            this.ctNacionalidad.Location = new System.Drawing.Point(51, 351);
            this.ctNacionalidad.Multiline = true;
            this.ctNacionalidad.Name = "ctNacionalidad";
            this.ctNacionalidad.Size = new System.Drawing.Size(224, 34);
            this.ctNacionalidad.TabIndex = 158;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(47, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 157;
            this.label5.Text = "FECHA DE VENTA:";
            // 
            // ctNombre
            // 
            this.ctNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "IDAlbum", true));
            this.ctNombre.Location = new System.Drawing.Point(51, 255);
            this.ctNombre.Multiline = true;
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(224, 34);
            this.ctNombre.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(47, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 155;
            this.label2.Text = "ID ALBUM:";
            // 
            // ctIDArtista
            // 
            this.ctIDArtista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "IDVenta", true));
            this.ctIDArtista.Location = new System.Drawing.Point(43, 163);
            this.ctIDArtista.Multiline = true;
            this.ctIDArtista.Name = "ctIDArtista";
            this.ctIDArtista.Size = new System.Drawing.Size(232, 34);
            this.ctIDArtista.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(297, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 163;
            this.label4.Text = "VENTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(128, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 162;
            this.label1.Text = "REGISTRO";
            // 
            // disqueralizardDataSet
            // 
            this.disqueralizardDataSet.DataSetName = "disqueralizardDataSet";
            this.disqueralizardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.disqueralizardDataSet;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "PrecioTotal", true));
            this.textBox2.Location = new System.Drawing.Point(332, 409);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 34);
            this.textBox2.TabIndex = 165;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(328, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 164;
            this.label7.Text = "PRECIO TOTAL:";
            // 
            // FormVentas
            // 
            this.ClientSize = new System.Drawing.Size(621, 627);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctNacionalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctIDArtista);
            this.Name = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
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
            this.Controls.SetChildIndex(this.ctIDArtista, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ctNombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ctNacionalidad, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.disqueralizardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctNacionalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctIDArtista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private disqueralizardDataSet disqueralizardDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private disqueralizardDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}
