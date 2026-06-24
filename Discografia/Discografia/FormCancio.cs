using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Discografia
{
    public partial class FormCancio : Discografia.Formbase
    {
        public FormCancio()
        {
            InitializeComponent();
        }

        private void FormCancio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'disqueralizardDataSet.Canciones' Puede moverla o quitarla según sea necesario.
            this.cancionesTableAdapter.Fill(this.disqueralizardDataSet.Canciones);
            bindingSource = cancionesBindingSource;
            MostrarPosicion();

        }
    }
}
