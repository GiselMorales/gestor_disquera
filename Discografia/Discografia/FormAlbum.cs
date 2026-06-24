using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Discografia
{
    public partial class FormAlbum : Discografia.Formbase
    {
        public FormAlbum()
        {
            InitializeComponent();
        }

        private void FormAlbum_Load(object sender, EventArgs e)

        {
            // TODO: esta línea de código carga datos en la tabla 'disqueralizardDataSet.Albumes' Puede moverla o quitarla según sea necesario.
            this.albumesTableAdapter.Fill(this.disqueralizardDataSet.Albumes);
            bindingSource = albumesBindingSource;
            MostrarPosicion();
        }
    }
}
