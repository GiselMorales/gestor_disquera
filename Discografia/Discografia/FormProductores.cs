using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Discografia
{
    public partial class FormProductores : Discografia.Formbase
    {
        public FormProductores()
        {
            InitializeComponent();
        }

        private void FormProductores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'disqueralizardDataSet.Productores' Puede moverla o quitarla según sea necesario.
            this.productoresTableAdapter.Fill(this.disqueralizardDataSet.Productores);
            bindingSource = productoresBindingSource;
            MostrarPosicion();

        }
    }
}
