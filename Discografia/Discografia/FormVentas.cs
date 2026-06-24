using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Discografia
{
    public partial class FormVentas : Discografia.Formbase
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'disqueralizardDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.disqueralizardDataSet.Ventas);
            bindingSource = ventasBindingSource;
            MostrarPosicion();

        }
    }
}
