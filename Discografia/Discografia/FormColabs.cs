using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Discografia
{
    public partial class FormColabs : Discografia.Formbase
    {
        public FormColabs()
        {
            InitializeComponent();
        }

        private void FormColabs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'disqueralizardDataSet.Colaboraciones' Puede moverla o quitarla según sea necesario.
            this.colaboracionesTableAdapter.Fill(this.disqueralizardDataSet.Colaboraciones);
            bindingSource = colaboracionesBindingSource;
            MostrarPosicion();

        }
    }
}
